namespace McJoeAdmin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsoleInput = new System.Windows.Forms.TextBox();
            this.btnSendInput = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStartString = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemoryUsage = new System.Windows.Forms.Label();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server Status";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(542, 470);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConsoleOutput);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsoleOutput.Location = new System.Drawing.Point(3, 16);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.ReadOnly = true;
            this.txtConsoleOutput.Size = new System.Drawing.Size(536, 235);
            this.txtConsoleOutput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConsoleInput);
            this.panel1.Controls.Add(this.btnSendInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 32);
            this.panel1.TabIndex = 1;
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Location = new System.Drawing.Point(3, 6);
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(399, 20);
            this.txtConsoleInput.TabIndex = 0;
            // 
            // btnSendInput
            // 
            this.btnSendInput.Location = new System.Drawing.Point(417, 5);
            this.btnSendInput.Name = "btnSendInput";
            this.btnSendInput.Size = new System.Drawing.Size(104, 21);
            this.btnSendInput.TabIndex = 1;
            this.btnSendInput.Text = "Send Input";
            this.btnSendInput.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Players";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCpuUsage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMemoryUsage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMemory);
            this.groupBox2.Controls.Add(this.lblStartString);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Information";
            // 
            // lblStartString
            // 
            this.lblStartString.AutoSize = true;
            this.lblStartString.Location = new System.Drawing.Point(118, 20);
            this.lblStartString.Name = "lblStartString";
            this.lblStartString.Size = new System.Drawing.Size(66, 13);
            this.lblStartString.TabIndex = 0;
            this.lblStartString.Text = "lblStartString";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(219, 84);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(54, 13);
            this.lblMemory.TabIndex = 1;
            this.lblMemory.Text = "lblMemory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Startup Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory Usage";
            // 
            // lblMemoryUsage
            // 
            this.lblMemoryUsage.AutoSize = true;
            this.lblMemoryUsage.Location = new System.Drawing.Point(118, 38);
            this.lblMemoryUsage.Name = "lblMemoryUsage";
            this.lblMemoryUsage.Size = new System.Drawing.Size(85, 13);
            this.lblMemoryUsage.TabIndex = 4;
            this.lblMemoryUsage.Text = "lblMemoryUsage";
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Location = new System.Drawing.Point(118, 57);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(67, 13);
            this.lblCpuUsage.TabIndex = 6;
            this.lblCpuUsage.Text = "lblCpuUsage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cpu Usage";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "McJoeAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConsoleInput;
        private System.Windows.Forms.Button btnSendInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStartString;
        private System.Windows.Forms.Label lblMemoryUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label label4;
    }
}

