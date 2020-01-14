namespace WindowsFormsApp1
{
    partial class Form1
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
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.ViewTextButton = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextFileTextBox = new System.Windows.Forms.TextBox();
            this.SaveTextButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.AuthPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AuthUserTextBox = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.ProxyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ProxyUserTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ProxyUrlTextBox = new System.Windows.Forms.TextBox();
            this.ProxyAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.AuthCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewUrlButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.TextEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.IFrameCheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptCheckBox = new System.Windows.Forms.CheckBox();
            this.BrowserIdTextBox = new System.Windows.Forms.TextBox();
            this.RecursionCheckBox = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.ViewMhtButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.MhtFileTextBox = new System.Windows.Forms.TextBox();
            this.BuildMhtButton = new System.Windows.Forms.Button();
            this.MemoryRadioButton = new System.Windows.Forms.RadioButton();
            this.DiskTempRadioButton = new System.Windows.Forms.RadioButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.DiskPermRadioButton = new System.Windows.Forms.RadioButton();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.BuildMhtMemoryButton = new System.Windows.Forms.Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.ViewHtmlButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.HtmlFileTextBox = new System.Windows.Forms.TextBox();
            this.SaveHtmlButton = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ViewCompleteButton = new System.Windows.Forms.Button();
            this.BuildFileButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.CompleteFileTextBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TabPage4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.ViewTextButton);
            this.TabPage4.Controls.Add(this.Label5);
            this.TabPage4.Controls.Add(this.TextFileTextBox);
            this.TabPage4.Controls.Add(this.SaveTextButton);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(432, 150);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Text";
            // 
            // ViewTextButton
            // 
            this.ViewTextButton.Enabled = false;
            this.ViewTextButton.Location = new System.Drawing.Point(360, 112);
            this.ViewTextButton.Name = "ViewTextButton";
            this.ViewTextButton.Size = new System.Drawing.Size(60, 23);
            this.ViewTextButton.TabIndex = 24;
            this.ViewTextButton.Text = "View";
            this.ViewTextButton.Click += new System.EventHandler(this.ViewTextButton_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 8);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(252, 13);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Filename to generate, or target folder to generate to:";
            // 
            // TextFileTextBox
            // 
            this.TextFileTextBox.Location = new System.Drawing.Point(8, 24);
            this.TextFileTextBox.Multiline = true;
            this.TextFileTextBox.Name = "TextFileTextBox";
            this.TextFileTextBox.Size = new System.Drawing.Size(416, 80);
            this.TextFileTextBox.TabIndex = 22;
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTextButton.Location = new System.Drawing.Point(296, 112);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(60, 23);
            this.SaveTextButton.TabIndex = 21;
            this.SaveTextButton.Text = "Save";
            this.SaveTextButton.Click += new System.EventHandler(this.SaveTextButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.AuthPasswordTextBox);
            this.GroupBox1.Controls.Add(this.AuthUserTextBox);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.ProxyPasswordTextBox);
            this.GroupBox1.Controls.Add(this.ProxyUserTextBox);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.ProxyUrlTextBox);
            this.GroupBox1.Controls.Add(this.ProxyAuthCheckBox);
            this.GroupBox1.Controls.Add(this.AuthCheckBox);
            this.GroupBox1.Controls.Add(this.ViewUrlButton);
            this.GroupBox1.Controls.Add(this.UrlTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(452, 244);
            this.GroupBox1.TabIndex = 50;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Target URL";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(224, 192);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(128, 32);
            this.Label13.TabIndex = 48;
            this.Label13.Text = "(leave blank to use current user credentials)";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(224, 84);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(128, 32);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "(leave blank to use current user credentials)";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(36, 104);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(64, 16);
            this.Label10.TabIndex = 46;
            this.Label10.Text = "password:";
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(36, 80);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(64, 16);
            this.Label11.TabIndex = 45;
            this.Label11.Text = "user:";
            // 
            // AuthPasswordTextBox
            // 
            this.AuthPasswordTextBox.Location = new System.Drawing.Point(108, 104);
            this.AuthPasswordTextBox.Name = "AuthPasswordTextBox";
            this.AuthPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthPasswordTextBox.TabIndex = 44;
            // 
            // AuthUserTextBox
            // 
            this.AuthUserTextBox.Location = new System.Drawing.Point(108, 80);
            this.AuthUserTextBox.Name = "AuthUserTextBox";
            this.AuthUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthUserTextBox.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(36, 212);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 16);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "password:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(36, 188);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(64, 16);
            this.Label8.TabIndex = 41;
            this.Label8.Text = "user:";
            // 
            // ProxyPasswordTextBox
            // 
            this.ProxyPasswordTextBox.Location = new System.Drawing.Point(108, 212);
            this.ProxyPasswordTextBox.Name = "ProxyPasswordTextBox";
            this.ProxyPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProxyPasswordTextBox.TabIndex = 40;
            // 
            // ProxyUserTextBox
            // 
            this.ProxyUserTextBox.Location = new System.Drawing.Point(108, 188);
            this.ProxyUserTextBox.Name = "ProxyUserTextBox";
            this.ProxyUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProxyUserTextBox.TabIndex = 39;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(36, 164);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "proxy URL:";
            // 
            // ProxyUrlTextBox
            // 
            this.ProxyUrlTextBox.Location = new System.Drawing.Point(108, 164);
            this.ProxyUrlTextBox.Name = "ProxyUrlTextBox";
            this.ProxyUrlTextBox.Size = new System.Drawing.Size(332, 20);
            this.ProxyUrlTextBox.TabIndex = 37;
            // 
            // ProxyAuthCheckBox
            // 
            this.ProxyAuthCheckBox.Location = new System.Drawing.Point(16, 136);
            this.ProxyAuthCheckBox.Name = "ProxyAuthCheckBox";
            this.ProxyAuthCheckBox.Size = new System.Drawing.Size(268, 24);
            this.ProxyAuthCheckBox.TabIndex = 36;
            this.ProxyAuthCheckBox.Text = "To get to this URL, we must go through a proxy:";
            // 
            // AuthCheckBox
            // 
            this.AuthCheckBox.Location = new System.Drawing.Point(16, 52);
            this.AuthCheckBox.Name = "AuthCheckBox";
            this.AuthCheckBox.Size = new System.Drawing.Size(188, 24);
            this.AuthCheckBox.TabIndex = 35;
            this.AuthCheckBox.Text = "This URL requires authentication";
            // 
            // ViewUrlButton
            // 
            this.ViewUrlButton.Location = new System.Drawing.Point(384, 52);
            this.ViewUrlButton.Name = "ViewUrlButton";
            this.ViewUrlButton.Size = new System.Drawing.Size(60, 23);
            this.ViewUrlButton.TabIndex = 34;
            this.ViewUrlButton.Text = "View";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(8, 24);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(436, 20);
            this.UrlTextBox.TabIndex = 33;
            this.UrlTextBox.Text = "http://www.codinghorror.com/blog/";
            // 
            // TextEncodingComboBox
            // 
            this.TextEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextEncodingComboBox.Items.AddRange(new object[] {
            "Autodetect",
            "Unicode",
            "Windows-1252",
            "UTF-8"});
            this.TextEncodingComboBox.Location = new System.Drawing.Point(108, 340);
            this.TextEncodingComboBox.Name = "TextEncodingComboBox";
            this.TextEncodingComboBox.Size = new System.Drawing.Size(136, 21);
            this.TextEncodingComboBox.TabIndex = 49;
            this.TextEncodingComboBox.SelectedIndexChanged += TextEncodingComboBox_SelectedIndexChanged;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(20, 344);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 48;
            this.Label7.Text = "Text Encoding:";
            // 
            // IFrameCheckBox
            // 
            this.IFrameCheckBox.Location = new System.Drawing.Point(180, 280);
            this.IFrameCheckBox.Name = "IFrameCheckBox";
            this.IFrameCheckBox.Size = new System.Drawing.Size(152, 24);
            this.IFrameCheckBox.TabIndex = 47;
            this.IFrameCheckBox.Text = "Remove <IFRAME> tags";
            // 
            // ScriptCheckBox
            // 
            this.ScriptCheckBox.Location = new System.Drawing.Point(20, 280);
            this.ScriptCheckBox.Name = "ScriptCheckBox";
            this.ScriptCheckBox.Size = new System.Drawing.Size(148, 24);
            this.ScriptCheckBox.TabIndex = 46;
            this.ScriptCheckBox.Text = "Remove <SCRIPT> tags";
            // 
            // BrowserIdTextBox
            // 
            this.BrowserIdTextBox.Location = new System.Drawing.Point(108, 316);
            this.BrowserIdTextBox.Name = "BrowserIdTextBox";
            this.BrowserIdTextBox.Size = new System.Drawing.Size(352, 20);
            this.BrowserIdTextBox.TabIndex = 52;
            this.BrowserIdTextBox.TextChanged += BrowserIdTextBox_TextChanged;
            // 
            // RecursionCheckBox
            // 
            this.RecursionCheckBox.Checked = true;
            this.RecursionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecursionCheckBox.Location = new System.Drawing.Point(20, 260);
            this.RecursionCheckBox.Name = "RecursionCheckBox";
            this.RecursionCheckBox.Size = new System.Drawing.Size(324, 20);
            this.RecursionCheckBox.TabIndex = 51;
            this.RecursionCheckBox.Text = "Allow recursive file retrieval (eg, <FRAME> and <IFRAME>)";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(20, 320);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(64, 16);
            this.Label14.TabIndex = 53;
            this.Label14.Text = "Browser ID:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(20, 376);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(440, 176);
            this.TabControl1.TabIndex = 45;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TabControl2);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(432, 150);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Single File Web Archive";
            // 
            // TabControl2
            // 
            this.TabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl2.Controls.Add(this.TabPage5);
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(432, 150);
            this.TabControl2.TabIndex = 30;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.ViewMhtButton);
            this.TabPage5.Controls.Add(this.Label2);
            this.TabPage5.Controls.Add(this.MhtFileTextBox);
            this.TabPage5.Controls.Add(this.BuildMhtButton);
            this.TabPage5.Controls.Add(this.MemoryRadioButton);
            this.TabPage5.Controls.Add(this.DiskTempRadioButton);
            this.TabPage5.Controls.Add(this.Label6);
            this.TabPage5.Controls.Add(this.DiskPermRadioButton);
            this.TabPage5.Location = new System.Drawing.Point(4, 25);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(424, 121);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "On Disk";
            // 
            // ViewMhtButton
            // 
            this.ViewMhtButton.Enabled = false;
            this.ViewMhtButton.Location = new System.Drawing.Point(352, 88);
            this.ViewMhtButton.Name = "ViewMhtButton";
            this.ViewMhtButton.Size = new System.Drawing.Size(60, 23);
            this.ViewMhtButton.TabIndex = 32;
            this.ViewMhtButton.Text = "View";
            this.ViewMhtButton.Click += new System.EventHandler(this.ViewMhtButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(0, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(252, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Filename to generate, or target folder to generate to:";
            // 
            // MhtFileTextBox
            // 
            this.MhtFileTextBox.Location = new System.Drawing.Point(0, 24);
            this.MhtFileTextBox.Multiline = true;
            this.MhtFileTextBox.Name = "MhtFileTextBox";
            this.MhtFileTextBox.Size = new System.Drawing.Size(416, 32);
            this.MhtFileTextBox.TabIndex = 30;
            // 
            // BuildMhtButton
            // 
            this.BuildMhtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildMhtButton.Location = new System.Drawing.Point(288, 88);
            this.BuildMhtButton.Name = "BuildMhtButton";
            this.BuildMhtButton.Size = new System.Drawing.Size(60, 23);
            this.BuildMhtButton.TabIndex = 29;
            this.BuildMhtButton.Text = "Save";
            this.BuildMhtButton.Click += new System.EventHandler(this.BuildMhtButton_Click);
            // 
            // MemoryRadioButton
            // 
            this.MemoryRadioButton.Location = new System.Drawing.Point(88, 60);
            this.MemoryRadioButton.Name = "MemoryRadioButton";
            this.MemoryRadioButton.Size = new System.Drawing.Size(64, 24);
            this.MemoryRadioButton.TabIndex = 33;
            this.MemoryRadioButton.Text = "Memory";
            // 
            // DiskTempRadioButton
            // 
            this.DiskTempRadioButton.Location = new System.Drawing.Point(152, 60);
            this.DiskTempRadioButton.Name = "DiskTempRadioButton";
            this.DiskTempRadioButton.Size = new System.Drawing.Size(112, 24);
            this.DiskTempRadioButton.TabIndex = 34;
            this.DiskTempRadioButton.Text = "Disk, Temporary";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(4, 64);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 16);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Temp Storage:";
            // 
            // DiskPermRadioButton
            // 
            this.DiskPermRadioButton.Location = new System.Drawing.Point(264, 60);
            this.DiskPermRadioButton.Name = "DiskPermRadioButton";
            this.DiskPermRadioButton.Size = new System.Drawing.Size(112, 24);
            this.DiskPermRadioButton.TabIndex = 35;
            this.DiskPermRadioButton.Text = "Disk, Permanent";
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.BuildMhtMemoryButton);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(424, 121);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "In Memory";
            // 
            // BuildMhtMemoryButton
            // 
            this.BuildMhtMemoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildMhtMemoryButton.Location = new System.Drawing.Point(280, 88);
            this.BuildMhtMemoryButton.Name = "BuildMhtMemoryButton";
            this.BuildMhtMemoryButton.Size = new System.Drawing.Size(132, 23);
            this.BuildMhtMemoryButton.TabIndex = 30;
            this.BuildMhtMemoryButton.Text = "Display";
            this.BuildMhtMemoryButton.Click += new System.EventHandler(this.BuildMhtMemoryButton_Click);
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.ViewHtmlButton);
            this.TabPage3.Controls.Add(this.Label4);
            this.TabPage3.Controls.Add(this.HtmlFileTextBox);
            this.TabPage3.Controls.Add(this.SaveHtmlButton);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(432, 150);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Web Page (html only)";
            // 
            // ViewHtmlButton
            // 
            this.ViewHtmlButton.Enabled = false;
            this.ViewHtmlButton.Location = new System.Drawing.Point(360, 112);
            this.ViewHtmlButton.Name = "ViewHtmlButton";
            this.ViewHtmlButton.Size = new System.Drawing.Size(60, 23);
            this.ViewHtmlButton.TabIndex = 24;
            this.ViewHtmlButton.Text = "View";
            this.ViewHtmlButton.Click += new System.EventHandler(this.ViewHtmlButton_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(252, 13);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Filename to generate, or target folder to generate to:";
            // 
            // HtmlFileTextBox
            // 
            this.HtmlFileTextBox.Location = new System.Drawing.Point(8, 24);
            this.HtmlFileTextBox.Multiline = true;
            this.HtmlFileTextBox.Name = "HtmlFileTextBox";
            this.HtmlFileTextBox.Size = new System.Drawing.Size(416, 80);
            this.HtmlFileTextBox.TabIndex = 22;
            // 
            // SaveHtmlButton
            // 
            this.SaveHtmlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveHtmlButton.Location = new System.Drawing.Point(296, 112);
            this.SaveHtmlButton.Name = "SaveHtmlButton";
            this.SaveHtmlButton.Size = new System.Drawing.Size(60, 23);
            this.SaveHtmlButton.TabIndex = 21;
            this.SaveHtmlButton.Text = "Save";
            this.SaveHtmlButton.Click += new System.EventHandler(this.SaveHtmlButton_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.ViewCompleteButton);
            this.TabPage2.Controls.Add(this.BuildFileButton);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.CompleteFileTextBox);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(432, 150);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Web Page (complete)";
            // 
            // ViewCompleteButton
            // 
            this.ViewCompleteButton.Enabled = false;
            this.ViewCompleteButton.Location = new System.Drawing.Point(360, 112);
            this.ViewCompleteButton.Name = "ViewCompleteButton";
            this.ViewCompleteButton.Size = new System.Drawing.Size(60, 23);
            this.ViewCompleteButton.TabIndex = 22;
            this.ViewCompleteButton.Text = "View";
            this.ViewCompleteButton.Click += new System.EventHandler(this.ViewCompleteButton_Click);
            // 
            // BuildFileButton
            // 
            this.BuildFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildFileButton.Location = new System.Drawing.Point(296, 112);
            this.BuildFileButton.Name = "BuildFileButton";
            this.BuildFileButton.Size = new System.Drawing.Size(60, 23);
            this.BuildFileButton.TabIndex = 21;
            this.BuildFileButton.Text = "Save";
            this.BuildFileButton.Click += new System.EventHandler(this.BuildFileButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(252, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Filename to generate, or target folder to generate to:";
            // 
            // CompleteFileTextBox
            // 
            this.CompleteFileTextBox.Location = new System.Drawing.Point(8, 24);
            this.CompleteFileTextBox.Multiline = true;
            this.CompleteFileTextBox.Name = "CompleteFileTextBox";
            this.CompleteFileTextBox.Size = new System.Drawing.Size(416, 80);
            this.CompleteFileTextBox.TabIndex = 19;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(224, 500);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 44;
            this.Button1.Text = "Button1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 563);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextEncodingComboBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.IFrameCheckBox);
            this.Controls.Add(this.ScriptCheckBox);
            this.Controls.Add(this.BrowserIdTextBox);
            this.Controls.Add(this.RecursionCheckBox);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "MhtBuilder Demo Form";
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.Button ViewTextButton;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextFileTextBox;
        internal System.Windows.Forms.Button SaveTextButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox AuthPasswordTextBox;
        internal System.Windows.Forms.TextBox AuthUserTextBox;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox ProxyPasswordTextBox;
        internal System.Windows.Forms.TextBox ProxyUserTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ProxyUrlTextBox;
        internal System.Windows.Forms.CheckBox ProxyAuthCheckBox;
        internal System.Windows.Forms.CheckBox AuthCheckBox;
        internal System.Windows.Forms.Button ViewUrlButton;
        internal System.Windows.Forms.TextBox UrlTextBox;
        internal System.Windows.Forms.ComboBox TextEncodingComboBox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.CheckBox IFrameCheckBox;
        internal System.Windows.Forms.CheckBox ScriptCheckBox;
        internal System.Windows.Forms.TextBox BrowserIdTextBox;
        internal System.Windows.Forms.CheckBox RecursionCheckBox;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.Button ViewMhtButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox MhtFileTextBox;
        internal System.Windows.Forms.Button BuildMhtButton;
        internal System.Windows.Forms.RadioButton MemoryRadioButton;
        internal System.Windows.Forms.RadioButton DiskTempRadioButton;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.RadioButton DiskPermRadioButton;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button BuildMhtMemoryButton;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Button ViewHtmlButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox HtmlFileTextBox;
        internal System.Windows.Forms.Button SaveHtmlButton;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button ViewCompleteButton;
        internal System.Windows.Forms.Button BuildFileButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox CompleteFileTextBox;
        internal System.Windows.Forms.Button Button1;
    }
}

