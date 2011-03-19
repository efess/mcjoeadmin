using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace McJoeAdmin.Controls
{
    public class LineGraph : Control
    {
        private const int MaxSamples = 500;
        private List<GraphSample> _samples;
        private Color _backgroundColor = Color.White;
        private Color _lineColor = Color.Black;
        private int _padding = 4;
        private Image _cacheCanvas;

        public long MaximumValue { get; set; }
        public long MinimumValue { get; set; }

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }
        public int Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }
        public Color LineColor
        {
            get { return _lineColor; }
            set { _lineColor = value; }
        }
        public bool AdjustRangeToSampleRange
        {
            get;
            set;
        }

        public LineGraph()
        {
            _samples = new List<GraphSample>();
        }

        public void AddSample(GraphSample pSample)
        {
            var maxSamples = Math.Max(this.Width - (_padding * 2), MaxSamples);
            while (_samples.Count >= maxSamples)
                _samples.RemoveAt(0);
            _samples.Add(pSample);
            
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;

            if (_samples.Count > 0)
            {
                var padding = _padding * 2;
                var size = new Size(this.Width - padding, this.Height - padding);
                
                if (size.Height <= 0 || size.Width <= 0) // Nothing to print.
                    return;

                var rangeMax = AdjustRangeToSampleRange
                    ? _samples.Max(sample => sample.YValue)
                    : MaximumValue;

                var rangeMin = AdjustRangeToSampleRange
                    ? _samples.Min(sample => sample.YValue)
                    : MinimumValue;

                if (rangeMax <= rangeMin)
                    rangeMax = rangeMin + 1;



                var bitmap = new Bitmap(size.Width, size.Height, graphics);
                bitmap.MakeTransparent();
                var bitmapGraphic = Graphics.FromImage(bitmap);

                var multiplier = (float)(size.Height- 1) / (float)(rangeMax - rangeMin);
                var enumerator = _samples.OrderByDescending(sample => sample.XValue).GetEnumerator();
                using (var pen = new Pen(new SolidBrush(LineColor), 1))
                {
                    for (int i = size.Width - 1; i >= 0 && enumerator.MoveNext(); i--)
                    {
                        var graphValue = enumerator.Current.YValue * multiplier;
                        bitmapGraphic.DrawLine(pen, new Point(i, (size.Height - (int)graphValue - 1)), new Point(i, size.Height));
                    }
                }
                bitmapGraphic.Flush();

                graphics.Clear(_backgroundColor);
                graphics.DrawImage(bitmap, new Point(_padding, _padding));
            }

            base.OnPaint(e);
        }

    }
}
