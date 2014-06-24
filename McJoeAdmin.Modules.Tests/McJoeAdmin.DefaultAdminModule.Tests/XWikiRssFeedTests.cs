using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TestHelpers;
using System.Xml.Linq;

namespace McJoeAdmin.DefaultAdminModule.Tests
{
    [TestFixture]
    public class XWikiRssFeedTests
    {
        [Test]
        public void TestProcessXml()
        {
            var expectedDate = DateTime.Parse("Sun, 03 Apr 2011 13:07:33 GMT");
            var testObject = new XWikiRssFeed();
            var xml = XDocument.Parse(TestRssXml);

            var result = ReflectionUtility.InvokeNonPublicInstanceMethod(testObject, "ProcessRssFeed", xml);

            Assert.AreEqual("4chan and their lulz", testObject.LastUpdateTitle);
            Assert.AreEqual(expectedDate, testObject.LastUpdate);
        }

        private string TestRssXml
        {
            get
            {
                return @"<?xml version=""1.0"" encoding=""UTF-8""?>
<rss xmlns:content=""http://purl.org/rss/1.0/modules/content/"" xmlns:taxo=""http://purl.org/rss/1.0/modules/taxonomy/"" xmlns:rdf=""http://www.w3.org/1999/02/22-rdf-syntax-ns#"" xmlns:dc=""http://purl.org/dc/elements/1.1/"" version=""2.0"">
  <channel>
    <title>The Wiki Blog</title>
    <link>http://mcdev.myxwiki.org/xwiki/bin/view/Main/WebHome</link>
    <description>Most recent blog posts in the wiki</description>
    <language>en</language>
    <copyright>This wiki is licensed under a &lt;a rel=""license"" href=""http://creativecommons.org/licenses/by/2.0/""&gt;Creative Commons 2.0&lt;/a&gt; license</copyright>
    <dc:creator>Joe L</dc:creator>
    <dc:language>en</dc:language>
    <dc:rights>This wiki is licensed under a &lt;a rel=""license"" href=""http://creativecommons.org/licenses/by/2.0/""&gt;Creative Commons 2.0&lt;/a&gt; license</dc:rights>
    <image>
      <title>XWiki Logo</title>
      <url>http://mcdev.myxwiki.org/xwiki/skins/colibri/logo.png</url>
      <link>http://mcdev.myxwiki.org</link>
      <description>XWiki Logo</description>
    </image>
    <item>
      <title>4chan and their lulz</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/4chan+and+their+lulz?language=en</link>
      <description>&lt;p&gt;More love from /v/, didn't do much damage this time. TNT'd the mob grinder, did a little damage to the castle. The lulz are starting to wear off..&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Sun, 03 Apr 2011 13:07:33 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/4chan+and+their+lulz?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-04-03T13:07:33Z</dc:date>
    </item>
    <item>
      <title>GRIEFED!</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/GRIEFED%21?language=en</link>
      <description>&lt;p&gt;Server got griefed! Somehow the server's address or hostname got into the hands of 4chan's \v\ and decided to have their way with the world, wreak havoc, TNT our stuff, and post as an accomplishment on the \v\ boards. &lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Fri, 25 Mar 2011 17:06:51 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/GRIEFED%21?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-03-25T17:06:51Z</dc:date>
    </item>
    <item>
      <title>Kohls inspired by minecraft?</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Kohls+inspired+by+minecraft%3F?language=en</link>
      <description>&lt;p&gt;Kohls.. built w/ sandstone?&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Wed, 02 Mar 2011 17:43:13 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Kohls+inspired+by+minecraft%3F?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-03-02T17:43:13Z</dc:date>
    </item>
    <item>
      <title>Wooden Roller Coaster</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Wooden+Roller+Coaster?language=en</link>
      <description>&lt;p&gt;Saw this on reddit today, what a great idea:&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Mon, 28 Feb 2011 17:35:00 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Wooden+Roller+Coaster?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-02-28T17:35:00Z</dc:date>
    </item>
    <item>
      <title>Slimes are Definitely Back</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Slimes+are+Definitely+Back?language=</link>
      <description>&lt;p&gt;Uh oh...&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Tue, 22 Feb 2011 21:52:03 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Slimes+are+Definitely+Back?language=</guid>
      <dc:creator>John Farrell</dc:creator>
      <dc:date>2011-02-22T21:52:03Z</dc:date>
    </item>
    <item>
      <title>Nawf died..</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Nawf+died?language=en</link>
      <description>&lt;p&gt;RIP&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Tue, 22 Feb 2011 02:46:57 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Nawf+died?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-02-22T02:46:57Z</dc:date>
    </item>
    <item>
      <title>Nether Church</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Nether+Church?language=en</link>
      <description />
      <category>Blog.News</category>
      <pubDate>Mon, 21 Feb 2011 13:16:39 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/Nether+Church?language=en</guid>
      <dc:creator>Joe L</dc:creator>
      <dc:date>2011-02-21T13:16:39Z</dc:date>
    </item>
    <item>
      <title>First blog post</title>
      <link>http://mcdev.myxwiki.org/xwiki/bin/view/Blog/BlogIntroduction?language=en</link>
      <description>&lt;p&gt;This is your wiki's blog first post. Its goal is to provide a short description of your blog's main features.&lt;/p&gt;</description>
      <category>Blog.News</category>
      <pubDate>Mon, 01 Jun 2009 12:00:00 GMT</pubDate>
      <guid isPermaLink=""false"">http://mcdev.myxwiki.org/xwiki/bin/view/Blog/BlogIntroduction?language=en</guid>
      <dc:creator>Administrator</dc:creator>
      <dc:date>2009-06-01T12:00:00Z</dc:date>
    </item>
  </channel>
</rss>";
            }
        }

    }

}
