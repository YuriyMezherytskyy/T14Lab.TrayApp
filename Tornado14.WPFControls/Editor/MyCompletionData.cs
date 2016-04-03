// Copyright (c) 2009 Daniel Grunwald
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using System.Net;
using System.Xml;
using HtmlAgilityPack;
using System.Text;
using System.IO;
using System.Collections.Generic;
#if NREFACTORY
using ICSharpCode.NRefactory.Editor;
#endif

namespace ICSharpCode.AvalonEdit.Sample
{
	/// <summary>
	/// Implements AvalonEdit ICompletionData interface to provide the entries in the completion drop down.
	/// </summary>
	public class MyCompletionData : ICompletionData
	{
        public string CustomDescription { get; set; }
        public MyCompletionData(string text, string description)
		{
			this.Text = text;
            this.CustomDescription = description;
		}
		
		public System.Windows.Media.ImageSource Image {
			get { return null; }
		}
		
		public string Text { get; private set; }

        // Use this property if you want to show a fancy UIElement in the drop down list.
        public object Content {
			get { return this.Text; }
		}
		
		public object Description {
			get { return CustomDescription; }
		}
		
		public double Priority { get { return 0; } }
		
		public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
		{
            // TODo Do Something with that
            //string url = @"http://google.com/complete/search?output=toolbar&q=" + "wpf avalon edit";
            //WebRequest httpWebRequest = HttpWebRequest.Create(url);
            //var webResponse = httpWebRequest.GetResponse();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(webResponse.GetResponseStream());
            //var result = xmlDoc.SelectNodes("//CompleteSuggestion");
            //textArea.Document.GetText(completionSegment);

            //StringBuilder sb = new StringBuilder();
            //byte[] ResultsBuffer = new byte[8192];
            //string SearchResults = "http://google.com/search?q=" + "avalon edit";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SearchResults);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Stream resStream = response.GetResponseStream();
            //string tempString = null;
            //int count = 0;
            //do
            //{
            //    count = resStream.Read(ResultsBuffer, 0, ResultsBuffer.Length);
            //    if (count != 0)
            //    {
            //        tempString = Encoding.ASCII.GetString(ResultsBuffer, 0, count);
            //        sb.Append(tempString);
            //    }
            //}

            //while (count > 0);
            //string sbb = sb.ToString();

            //HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            //html.OptionOutputAsXml = true;
            //html.LoadHtml(sbb);
            //HtmlNode doc = html.DocumentNode;
            //StringBuilder results = new StringBuilder();
            //foreach (HtmlNode link in doc.SelectNodes("//a[@href]"))
            //{
            //    //HtmlAttribute att = link.Attributes["href"];
            //    string hrefValue = link.GetAttributeValue("href", string.Empty);
            //    if (!hrefValue.ToString().ToUpper().Contains("GOOGLE") && hrefValue.ToString().Contains("/url?q=") && hrefValue.ToString().ToUpper().Contains("HTTP://"))
            //    {
            //        int index = hrefValue.IndexOf("&");
            //        if (index > 0)
            //        {
            //            hrefValue = hrefValue.Substring(0, index);
            //            results.AppendLine(hrefValue.Replace("/url?q=", ""));
            //        }
            //    }
            //}
            //textArea.Document.Replace(completionSegment, results.ToString());

            textArea.Document.Replace(completionSegment, this.Text);
		}
	}
}
