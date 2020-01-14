using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHTMLBuilder;
using MHTMLBuilder.Demo;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MHTMLBuilder.Builder _mht = new Builder();

        public Form1()
        {
            InitializeComponent();
            this.Text = "MhtBuilder Demo Form";
        }

        private void ViewMhtButton_Click(object sender, EventArgs e)
        {
            Process.Start(MhtFileTextBox.Text);
        }

        private void BuildMhtButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            MHTMLBuilder.Builder.FileStorage st = Builder.FileStorage.Memory;

            if (MemoryRadioButton.Checked)
            {
                st = MHTMLBuilder.Builder.FileStorage.Memory;
            }

            if (DiskTempRadioButton.Checked)
            {
                st = MHTMLBuilder.Builder.FileStorage.DiskTemporary;
            }

            if (DiskPermRadioButton.Checked)
            {
                st = MHTMLBuilder.Builder.FileStorage.DiskPermanent;
            }

            MhtFileTextBox.Text = _mht.SavePageArchive(MhtFileTextBox.Text, st, UrlTextBox.Text);
            Cursor.Current = Cursors.Default;
            ViewMhtButton.Enabled = true;
        }

        private void SaveHtmlButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            HtmlFileTextBox.Text = _mht.SavePage(HtmlFileTextBox.Text, UrlTextBox.Text);
            Cursor.Current = Cursors.Default;
            ViewHtmlButton.Enabled = true;
        }

        private void ViewHtmlButton_Click(object sender, EventArgs e)
        {
            Process.Start(HtmlFileTextBox.Text);
        }

        private void BuildFileButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            HtmlFileTextBox.Text = _mht.SavePageComplete(CompleteFileTextBox.Text, UrlTextBox.Text);
            Cursor.Current = Cursors.Default;
            ViewCompleteButton.Enabled = true;
        }

        private void ViewCompleteButton_Click(object sender, EventArgs e)
        {
            Process.Start(CompleteFileTextBox.Text);
        }

        private void SaveTextButton_Click(object sender, EventArgs e)
        {
            _mht.Url = UrlTextBox.Text;

            Cursor.Current = Cursors.WaitCursor;
            TextFileTextBox.Text = _mht.SavePageText(TextFileTextBox.Text);
            Cursor.Current = Cursors.Default;
            ViewTextButton.Enabled = true;
        }

        private void ViewTextButton_Click(object sender, EventArgs e)
        {
            Process.Start(TextFileTextBox.Text);
        }

        private void BuildMhtMemoryButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Form2 f = new Form2();
            f.Data = _mht.GetPageArchive(UrlTextBox.Text);
            f.ShowDialog(this);
            Cursor.Current = Cursors.Default;
        }

        private void BrowserIdTextBox_TextChanged(object sender, System.EventArgs e)
        {
            _mht.BrowserIdString = BrowserIdTextBox.Text;
        }


        private void TextEncodingComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (TextEncodingComboBox.SelectedItem.ToString())
            {
                case "Autodetect": _mht.TextEncoding = null;
                    break;
                case "Unicode":
                    _mht.TextEncoding = System.Text.Encoding.Unicode;
                    break;
                default:
                    _mht.TextEncoding = System.Text.Encoding.UTF8;
                    break;
            }
        }
    }
}
