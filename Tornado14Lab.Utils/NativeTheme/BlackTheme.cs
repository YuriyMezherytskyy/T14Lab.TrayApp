using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Tornado14Lab.Utils.NativeTheme
{
    public class BlackTheme
    {
        public static Color mBlueLight1 = ColorTranslator.FromHtml("#A5C5DA");
        public static Color mBlueLight2 = ColorTranslator.FromHtml("#91B9D3");
        public static Color mBlue1 = ColorTranslator.FromHtml("#008DD7");
        public static Color mBlue2 = ColorTranslator.FromHtml("#0080C0");
        public static Color mBlueDark1 = ColorTranslator.FromHtml("#8999B7");
        public static Color mBlueDark2 = ColorTranslator.FromHtml("#61749E");
        public static Color mViolett1 = ColorTranslator.FromHtml("#CD82A8");
        public static Color mViolett2 = ColorTranslator.FromHtml("#B6477C");
        public static Color mYellow1 = ColorTranslator.FromHtml("#F5D35A");
        public static Color mYellow2 = ColorTranslator.FromHtml("#F2C826");
        public static Color mGreenDark1 = ColorTranslator.FromHtml("#009B49");
        public static Color mGreenDark2 = ColorTranslator.FromHtml("#00803F");
        public static Color mGreenLight1 = ColorTranslator.FromHtml("#A0BB72");
        public static Color mGreenLight2 = ColorTranslator.FromHtml("#8BAC51");
        public static Color mGrayDark1 = ColorTranslator.FromHtml("#535353");
        public static Color mGrayDark2 = ColorTranslator.FromHtml("#3F3F3F");
        public static Color mGrayLight1 = ColorTranslator.FromHtml("#8A8A8A");
        public static Color mGrayLight2 = ColorTranslator.FromHtml("#6A6A6A");
        public static Color mPink1 = ColorTranslator.FromHtml("#FD49FE");
        public static Color mPink2 = ColorTranslator.FromHtml("#FE00FB");
        public static Color mBraun1 = ColorTranslator.FromHtml("#C88569");
        public static Color mBraun2 = ColorTranslator.FromHtml("#BA6443");

        public static Color ColorSplitter = Color.FromArgb(20, 20, 20);
        public static Color ColorDarkGray = Color.FromArgb(30,30,30);
        public static Color ColorDarkGray2 = Color.FromArgb(40,40,40);
        public static Color ColorHeadersText = Color.FromArgb(151,151,135);
        public static Color ColorLightGray = Color.FromArgb(45,45,45);
        public static Color ColorLightGray2 = Color.FromArgb(65,65,65);
        public static Color ColorLightGray4 = Color.FromArgb(104,104,104);
        // #333337 rgb(51,51,55)
        public static Color ColorLightGray3 = Color.FromArgb(51,51,55);
        public static Color ColorBorders = Color.FromArgb(62,62,69);
        public static Color ColorText = Color.FromArgb(241,241,241);
        // #D7AC6A
        public static Color ColorTextNotifyOrange = Color.FromArgb(215,171,105);
        // #7AC1FF
        public static Color ColorTextNotifyBlue = Color.FromArgb(0,122,204);
        // #388A34 rgb(56,138,52)
        public static Color ColorGreen = Color.FromArgb(56,138, 52);
        // #E51400 rgb(229,20,0)
        public static Color ColorRedLight = Color.FromArgb(229,20,0);


        // #1C7BE3 rgb(28,123,227)
        public static Color BlueDark = Color.FromArgb(28,123,222);
        // #1BA1E2 rgb(27,161,226)
        public static Color BlueLight = Color.FromArgb(27,161,226);


        // #339933 rgb(51,153,51)
        public static Color GreenLight = Color.FromArgb(51, 153,51);


        public static void ApplyTheme(Control parentControl)
        {
            ApplyThemeToControl(parentControl);
            foreach (Control control in parentControl.Controls)
            {
                ApplyThemeToControl(control);
                if (control.Controls.Count > 0)
                {
                    ApplyTheme(control);
                }
            }
        }





        private static void ApplyThemeToControl(Control control)
        {
            switch (control.GetType().ToString())
            {
                case "System.Windows.Forms.Button":
                    Button button = (Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.MouseOverBackColor = BlueDark;
                    break;
                case "System.Windows.Forms.CheckBox":
                    control.BackColor = BlackTheme.ColorDarkGray;
                    break;
                case "System.Windows.Forms.ComboBox":
                case "System.Windows.Forms.TabPage":
                    control.BackColor = BlackTheme.ColorDarkGray;
                    control.ForeColor = BlackTheme.ColorText;
                    break;
                case "System.Windows.Forms.TextBox":
                    if (((TextBox)control).BorderStyle != BorderStyle.None)
                    {
                        control.BackColor = BlackTheme.ColorDarkGray;
                        control.ForeColor = BlackTheme.ColorText;
                        ((TextBox)control).BorderStyle = BorderStyle.FixedSingle;
                    }
                    break;
                case "System.Windows.Forms.DataGridView":
                    BlackTheme.ApplyThemeToGrid((DataGridView)control);
                    break;
                case "System.Windows.Forms.Label":
                    Label label = (Label)control;
                    if (label.Font.Size > 11 && label.Font.Size < 13)
                    {
                        label.ForeColor = BlueDark;
                    }
                    else if (label.Font.Size >= 13)
                    {
                        label.ForeColor = GreenLight;
                    }
                    break;
                case "System.Windows.Forms.BindingNavigator":
                case "System.Windows.Forms.ToolStrip":
                    BlackTheme.ApplyThemeToToolStrip((ToolStrip)control);
                    break;
                case "System.Windows.Forms.SplitContainer":
                    BlackTheme.ApplyThemeToSplitContainer((SplitContainer)control);
                    break;
                /*
            case "System.Windows.Forms.Panel":
                control.BackColor = BlackTheme.ColorDarkGray;
                break;
                 */
            }
        }

        public static void ApplyThemeToGrids(List<DataGridView> grids)
        {
            foreach (DataGridView grid in grids)
            {
                ApplyThemeToGrid(grid);
            }
        }

        public static void ApplyThemeToGrid(DataGridView grid)
        {
            grid.BackgroundColor = ColorDarkGray;
            grid.RowTemplate.Height = 35;
            grid.GridColor = ColorBorders;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.ColumnHeadersDefaultCellStyle.BackColor = ColorLightGray;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = ColorHeadersText;
            grid.EnableHeadersVisualStyles = false;
            grid.DefaultCellStyle.BackColor = ColorDarkGray;
            grid.DefaultCellStyle.ForeColor = ColorText;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.RowHeadersVisible = true;
            grid.RowHeadersDefaultCellStyle.BackColor = ColorDarkGray2;
            grid.BorderStyle = BorderStyle.None;
        }

        public static void ApplyThemeToToolStrips(List<ToolStrip> toolStrips)
        {
            foreach (ToolStrip toolStrip in toolStrips)
            {
                ApplyThemeToToolStrip(toolStrip);
            }
        }

        public static void ApplyThemeToToolStrip(ToolStrip toolStrip)
        {
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.BackColor = ColorDarkGray;
            toolStrip.ForeColor = ColorText;
            toolStrip.AutoSize = false;
            toolStrip.Height = 40;
            toolStrip.Renderer = new MySR();
            toolStrip.Padding = new Padding(0, 0, 0, 0);
        }

        public static void ApplyThemeToTabControls(List<TabControl> tabControls)
        {
            foreach (TabControl tabControl in tabControls)
            {
                tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            }
        }

        static void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl1 = (TabControl)sender;
            TabPage CurrentTab = tabControl1.TabPages[e.Index];
            Rectangle ItemRect = tabControl1.GetTabRect(e.Index);
            SolidBrush FillBrush = new SolidBrush(BlackTheme.ColorDarkGray);
            SolidBrush TextBrush = new SolidBrush(BlackTheme.ColorText);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.White;
                TextBrush.Color = Color.Red;
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tabControl1.Alignment == TabAlignment.Left || tabControl1.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tabControl1.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2) - 2, -(ItemRect.Width / 2) - 2, ItemRect.Height + 2, ItemRect.Width + 2);
            }

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();
        }

        public static void ApplyThemeToSplitContainers(List<SplitContainer> splitContainers)
        {
            foreach (SplitContainer splitContainer in splitContainers)
            {
                ApplyThemeToSplitContainer(splitContainer);
            }
        }

        public static void ApplyThemeToSplitContainer(SplitContainer splitContainer)
        {
            splitContainer.Panel1.BackColor = ColorDarkGray;
            splitContainer.Panel2.BackColor = ColorDarkGray;
        }
    }
    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }

}
