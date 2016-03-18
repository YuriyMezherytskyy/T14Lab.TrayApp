using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Drawing;

namespace SyntaxHighlighter
{
	public class SyntaxRichTextBox : System.Windows.Forms.RichTextBox
	{
		private SyntaxSettings m_settings = new SyntaxSettings();
		private static bool m_bPaint = true;
		private string m_strLine = "";
		private int m_nContentLength = 0;
		private int m_nLineLength = 0;
		private int m_nLineStart = 0;
		private int m_nLineEnd = 0;
		private string m_strKeywords = "";
        private string m_strKeywords2 = "";
        private int m_nCurSelection = 0;

		/// <summary>
		/// The settings.
		/// </summary>
		public SyntaxSettings Settings
		{
			get { return m_settings; }
		}
		
		/// <summary>
		/// WndProc
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref System.Windows.Forms.Message m)
		{
			if (m.Msg == 0x00f)
			{
				if (m_bPaint)
					base.WndProc(ref m);
				else
					m.Result = IntPtr.Zero;
			}
			else
				base.WndProc(ref m);
		}
		/// <summary>
		/// OnTextChanged
		/// </summary>
		/// <param name="e"></param>
		protected override void OnTextChanged(EventArgs e)
		{
            base.OnTextChanged(e);
			// Calculate shit here.
			m_nContentLength = this.TextLength;

			int nCurrentSelectionStart = SelectionStart;
			int nCurrentSelectionLength = SelectionLength;

			m_bPaint = false;

			// Find the start of the current line.
			m_nLineStart = nCurrentSelectionStart;
			while ((m_nLineStart > 0) && (Text[m_nLineStart - 1] != '\n'))
				m_nLineStart--;
			// Find the end of the current line.
			m_nLineEnd = nCurrentSelectionStart;
			while ((m_nLineEnd < Text.Length) && (Text[m_nLineEnd] != '\n'))
				m_nLineEnd++;
			// Calculate the length of the line.
			m_nLineLength = m_nLineEnd - m_nLineStart;
			// Get the current line.
			m_strLine = Text.Substring(m_nLineStart, m_nLineLength);

            //ProcessComments(Text, Settings.CommentColor);
            // Process this line.
			ProcessLine();

			m_bPaint = true;

		}
		/// <summary>
		/// Process a line.
		/// </summary>
		private void ProcessLine()
		{
			// Save the position and make the whole line black
			int nPosition = SelectionStart;
			SelectionStart = m_nLineStart;
			SelectionLength = m_nLineLength;
			SelectionColor = Color.Bisque;

            // Process comments
            if (Settings.EnableComments && !string.IsNullOrEmpty(Settings.Comment))
                ProcessRegex(Settings.Comment + ".*$", Settings.CommentColor);
            
            // Process commentss
            if (Settings.EnableComments2 && !string.IsNullOrEmpty(Settings.Comment2))
                ProcessRegex(Settings.Comment2 + ".*$", Settings.CommentColor2);
            

            // Process the keywords
			ProcessRegex(m_strKeywords, Settings.KeywordColor);
            
            // Process the keywords
            ProcessRegex(m_strKeywords2, Settings.KeywordColor2);
            
            // Process numbers
			if(Settings.EnableIntegers)
				ProcessRegex("\\b(?:[0-9]*\\.)?[0-9]+\\b", Settings.IntegerColor);
			// Process strings
			if(Settings.EnableStrings)
				ProcessRegex("\"[^\"\\\\\\r\\n]*(?:\\\\.[^\"\\\\\\r\\n]*)*\"", Settings.StringColor);
            
			SelectionStart = nPosition;
			SelectionLength = 0;
			SelectionColor = Color.Black;

			m_nCurSelection = nPosition;
		}
		/// <summary>
		/// Process a regular expression.
		/// </summary>
		/// <param name="strRegex">The regular expression.</param>
		/// <param name="color">The color.</param>
		private void ProcessRegex(string strRegex, Color color)
		{
			Regex regKeywords = new Regex(strRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Match regMatch;

			for (regMatch = regKeywords.Match(m_strLine); regMatch.Success; regMatch = regMatch.NextMatch())
			{
				// Process the words
				int nStart = m_nLineStart + regMatch.Index;
				int nLenght = regMatch.Length;
				SelectionStart = nStart;
				SelectionLength = nLenght;
				SelectionColor = color;
			}
		}
        /// <summary>
        /// Process a regular expression.
        /// </summary>
        /// <param name="strRegex">The regular expression.</param>
        /// <param name="color">The color.</param>
        private void ProcessComments(string strRegex, Color color)
        {

            // Save the position and make the whole line black
            int nPosition = SelectionStart;
            SelectionStart = m_nLineStart;
            SelectionLength = m_nLineLength;
            SelectionColor = Color.Bisque;

            try
            {
                Regex regexObj = new Regex("--.*?(?=--)", RegexOptions.Singleline);
                Match matchResults = regexObj.Match(strRegex);
                while (matchResults.Success)
                {
                    // Process the words
                    int nStart = m_nLineStart + matchResults.Index;
                    int nLenght = matchResults.Length;
                    SelectionStart = nStart;
                    SelectionLength = nLenght;
                    SelectionColor = color;
                    // matched text: matchResults.Value
                    // match start: matchResults.Index
                    // match length: matchResults.Length
                    matchResults = matchResults.NextMatch();
                }
            }
            catch (ArgumentException ex)
            {
                // Syntax error in the regular expression
            }

            SelectionStart = nPosition;
            SelectionLength = 0;
            SelectionColor = Color.Black;

            m_nCurSelection = nPosition;

        }
		/// <summary>
		/// Compiles the keywords as a regular expression.
		/// </summary>
		public void CompileKeywords()
		{
			for (int i = 0; i < Settings.Keywords.Count; i++)
			{
				string strKeyword = Settings.Keywords[i];

				if (i == Settings.Keywords.Count-1)
					m_strKeywords += "\\b" + strKeyword + "\\b";
				else
					m_strKeywords += "\\b" + strKeyword + "\\b|";
			}

            for (int i = 0; i < Settings.Keywords2.Count; i++)
            {
                string strKeyword = Settings.Keywords2[i];

                if (i == Settings.Keywords2.Count - 1)
                    m_strKeywords2 += "\\b" + strKeyword + "\\b";
                else
                    m_strKeywords2 += "\\b" + strKeyword + "\\b|";
            }
		}

		public void ProcessAllLines()
		{
            //ProcessComments(Text, Settings.CommentColor);

			m_bPaint = false;

			int nStartPos = 0;
			int i = 0;
			int nOriginalPos = SelectionStart;
			while (i < Lines.Length)
			{
				m_strLine = Lines[i];
				m_nLineStart = nStartPos;
				m_nLineEnd = m_nLineStart + m_strLine.Length;

				ProcessLine();
				i++;

				nStartPos += m_strLine.Length+1;
			}

			m_bPaint = true;
		}
	}

	/// <summary>
	/// Class to store syntax objects in.
	/// </summary>
	public class SyntaxList
	{
		public List<string> m_rgList = new List<string>();
		public Color m_color = new Color();
	}

	/// <summary>
	/// Settings for the keywords and colors.
	/// </summary>
	public class SyntaxSettings
	{
		SyntaxList m_rgKeywords = new SyntaxList();
        SyntaxList m_rgKeywords2 = new SyntaxList();
        string m_strComment = "";
        string m_strComment2 = "";
        Color m_colorComment2 = Color.Green;
        Color m_colorComment = Color.Green;
		Color m_colorString = Color.Gray;
		Color m_colorInteger = Color.Red;
		bool m_bEnableComments = true;
        bool m_bEnableComments2 = true;
        bool m_bEnableIntegers = true;
		bool m_bEnableStrings = true;

		#region Properties
		/// <summary>
		/// A list containing all keywords.
		/// </summary>
		public List<string> Keywords
		{
			get { return m_rgKeywords.m_rgList; }
		}
        /// <summary>
        /// A list containing all keywords.
        /// </summary>
        public List<string> Keywords2
        {
            get { return m_rgKeywords2.m_rgList; }
        }
		/// <summary>
		/// The color of keywords.
		/// </summary>
		public Color KeywordColor
		{
			get { return m_rgKeywords.m_color; }
			set { m_rgKeywords.m_color = value; }
		}
        /// <summary>
        /// The color of keywords.
        /// </summary>
        public Color KeywordColor2
        {
            get { return m_rgKeywords2.m_color; }
            set { m_rgKeywords2.m_color = value; }
        }
		/// <summary>
		/// A string containing the comment identifier.
		/// </summary>
		public string Comment
		{
			get { return m_strComment; }
			set { m_strComment = value; }
		}
        /// <summary>
        /// A string containing the comment identifier.
        /// </summary>
        public string Comment2
        {
            get { return m_strComment2; }
            set { m_strComment2 = value; }
        }
		/// <summary>
		/// The color of comments.
		/// </summary>
		public Color CommentColor
		{
			get { return m_colorComment; }
			set { m_colorComment = value; }
		}
        /// <summary>
        /// The color of comments.
        /// </summary>
        public Color CommentColor2
        {
            get { return m_colorComment2; }
            set { m_colorComment2 = value; }
        }

        /// <summary>
        /// The color of comments.
        /// </summary>
        public Color Comment2Color
        {
            get { return m_colorComment2; }
            set { m_colorComment2 = value; }
        }
		/// <summary>
		/// Enables processing of comments if set to true.
		/// </summary>
		public bool EnableComments
		{
			get { return m_bEnableComments; }
			set { m_bEnableComments = value; }
		}

        /// <summary>
        /// Enables processing of comments if set to true.
        /// </summary>
        public bool EnableComments2
        {
            get { return m_bEnableComments2; }
            set { m_bEnableComments2 = value; }
        }

		/// <summary>
		/// Enables processing of integers if set to true.
		/// </summary>
		public bool EnableIntegers
		{
			get { return m_bEnableIntegers; }
			set { m_bEnableIntegers = value; }
		}
		/// <summary>
		/// Enables processing of strings if set to true.
		/// </summary>
		public bool EnableStrings
		{
			get { return m_bEnableStrings; }
			set { m_bEnableStrings = value; }
		}
		/// <summary>
		/// The color of strings.
		/// </summary>
		public Color StringColor
		{
			get { return m_colorString; }
			set { m_colorString = value; }
		}
		/// <summary>
		/// The color of integers.
		/// </summary>
		public Color IntegerColor
		{
			get { return m_colorInteger; }
			set { m_colorInteger = value; }
		}
		#endregion
	}
}
