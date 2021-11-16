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
            this.TabPage4.Location = new System.Drawing.Point(4, 26);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(505, 200);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Text";
            // 
            // ViewTextButton
            // 
            this.ViewTextButton.Enabled = false;
            this.ViewTextButton.Location = new System.Drawing.Point(420, 146);
            this.ViewTextButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTextButton.Name = "ViewTextButton";
            this.ViewTextButton.Size = new System.Drawing.Size(70, 30);
            this.ViewTextButton.TabIndex = 24;
            this.ViewTextButton.Text = "View";
            this.ViewTextButton.Click += new System.EventHandler(this.ViewTextButton_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 10);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(320, 17);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Filename to generate, or target folder to generate to:";
            // 
            // TextFileTextBox
            // 
            this.TextFileTextBox.Location = new System.Drawing.Point(9, 31);
            this.TextFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextFileTextBox.Multiline = true;
            this.TextFileTextBox.Name = "TextFileTextBox";
            this.TextFileTextBox.Size = new System.Drawing.Size(485, 103);
            this.TextFileTextBox.TabIndex = 22;
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveTextButton.Location = new System.Drawing.Point(345, 146);
            this.SaveTextButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(70, 30);
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
            this.GroupBox1.Location = new System.Drawing.Point(14, 16);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(527, 319);
            this.GroupBox1.TabIndex = 50;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Target URL";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(261, 251);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(149, 42);
            this.Label13.TabIndex = 48;
            this.Label13.Text = "(leave blank to use current user credentials)";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(261, 110);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(149, 42);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "(leave blank to use current user credentials)";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(42, 136);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(75, 21);
            this.Label10.TabIndex = 46;
            this.Label10.Text = "password:";
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(42, 105);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(75, 21);
            this.Label11.TabIndex = 45;
            this.Label11.Text = "user:";
            // 
            // AuthPasswordTextBox
            // 
            this.AuthPasswordTextBox.Location = new System.Drawing.Point(126, 136);
            this.AuthPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthPasswordTextBox.Name = "AuthPasswordTextBox";
            this.AuthPasswordTextBox.Size = new System.Drawing.Size(116, 23);
            this.AuthPasswordTextBox.TabIndex = 44;
            // 
            // AuthUserTextBox
            // 
            this.AuthUserTextBox.Location = new System.Drawing.Point(126, 105);
            this.AuthUserTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthUserTextBox.Name = "AuthUserTextBox";
            this.AuthUserTextBox.Size = new System.Drawing.Size(116, 23);
            this.AuthUserTextBox.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(42, 277);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(75, 21);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "password:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(42, 246);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(75, 21);
            this.Label8.TabIndex = 41;
            this.Label8.Text = "user:";
            // 
            // ProxyPasswordTextBox
            // 
            this.ProxyPasswordTextBox.Location = new System.Drawing.Point(126, 277);
            this.ProxyPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProxyPasswordTextBox.Name = "ProxyPasswordTextBox";
            this.ProxyPasswordTextBox.Size = new System.Drawing.Size(116, 23);
            this.ProxyPasswordTextBox.TabIndex = 40;
            // 
            // ProxyUserTextBox
            // 
            this.ProxyUserTextBox.Location = new System.Drawing.Point(126, 246);
            this.ProxyUserTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProxyUserTextBox.Name = "ProxyUserTextBox";
            this.ProxyUserTextBox.Size = new System.Drawing.Size(116, 23);
            this.ProxyUserTextBox.TabIndex = 39;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(42, 214);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 21);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "proxy URL:";
            // 
            // ProxyUrlTextBox
            // 
            this.ProxyUrlTextBox.Location = new System.Drawing.Point(126, 214);
            this.ProxyUrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProxyUrlTextBox.Name = "ProxyUrlTextBox";
            this.ProxyUrlTextBox.Size = new System.Drawing.Size(387, 23);
            this.ProxyUrlTextBox.TabIndex = 37;
            // 
            // ProxyAuthCheckBox
            // 
            this.ProxyAuthCheckBox.Location = new System.Drawing.Point(19, 178);
            this.ProxyAuthCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProxyAuthCheckBox.Name = "ProxyAuthCheckBox";
            this.ProxyAuthCheckBox.Size = new System.Drawing.Size(313, 31);
            this.ProxyAuthCheckBox.TabIndex = 36;
            this.ProxyAuthCheckBox.Text = "To get to this URL, we must go through a proxy:";
            // 
            // AuthCheckBox
            // 
            this.AuthCheckBox.Location = new System.Drawing.Point(19, 68);
            this.AuthCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthCheckBox.Name = "AuthCheckBox";
            this.AuthCheckBox.Size = new System.Drawing.Size(219, 31);
            this.AuthCheckBox.TabIndex = 35;
            this.AuthCheckBox.Text = "This URL requires authentication";
            // 
            // ViewUrlButton
            // 
            this.ViewUrlButton.Location = new System.Drawing.Point(448, 68);
            this.ViewUrlButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewUrlButton.Name = "ViewUrlButton";
            this.ViewUrlButton.Size = new System.Drawing.Size(70, 30);
            this.ViewUrlButton.TabIndex = 34;
            this.ViewUrlButton.Text = "View";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(9, 31);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(508, 23);
            this.UrlTextBox.TabIndex = 33;
            this.UrlTextBox.Text = "https://www.runoob.com/";
            // 
            // TextEncodingComboBox
            // 
            this.TextEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextEncodingComboBox.Items.AddRange(new object[] {
            "Autodetect",
            "Unicode",
            "Windows-1252",
            "UTF-8"});
            this.TextEncodingComboBox.Location = new System.Drawing.Point(126, 445);
            this.TextEncodingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextEncodingComboBox.Name = "TextEncodingComboBox";
            this.TextEncodingComboBox.Size = new System.Drawing.Size(158, 25);
            this.TextEncodingComboBox.TabIndex = 49;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(23, 450);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 21);
            this.Label7.TabIndex = 48;
            this.Label7.Text = "Text Encoding:";
            // 
            // IFrameCheckBox
            // 
            this.IFrameCheckBox.Location = new System.Drawing.Point(210, 366);
            this.IFrameCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IFrameCheckBox.Name = "IFrameCheckBox";
            this.IFrameCheckBox.Size = new System.Drawing.Size(177, 31);
            this.IFrameCheckBox.TabIndex = 47;
            this.IFrameCheckBox.Text = "Remove <IFRAME> tags";
            // 
            // ScriptCheckBox
            // 
            this.ScriptCheckBox.Location = new System.Drawing.Point(23, 366);
            this.ScriptCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScriptCheckBox.Name = "ScriptCheckBox";
            this.ScriptCheckBox.Size = new System.Drawing.Size(173, 31);
            this.ScriptCheckBox.TabIndex = 46;
            this.ScriptCheckBox.Text = "Remove <SCRIPT> tags";
            // 
            // BrowserIdTextBox
            // 
            this.BrowserIdTextBox.Location = new System.Drawing.Point(126, 413);
            this.BrowserIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BrowserIdTextBox.Name = "BrowserIdTextBox";
            this.BrowserIdTextBox.Size = new System.Drawing.Size(410, 23);
            this.BrowserIdTextBox.TabIndex = 52;
            // 
            // RecursionCheckBox
            // 
            this.RecursionCheckBox.Checked = true;
            this.RecursionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecursionCheckBox.Location = new System.Drawing.Point(23, 340);
            this.RecursionCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecursionCheckBox.Name = "RecursionCheckBox";
            this.RecursionCheckBox.Size = new System.Drawing.Size(378, 26);
            this.RecursionCheckBox.TabIndex = 51;
            this.RecursionCheckBox.Text = "Allow recursive file retrieval (eg, <FRAME> and <IFRAME>)";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(23, 418);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(75, 21);
            this.Label14.TabIndex = 53;
            this.Label14.Text = "Browser ID:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(23, 492);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(513, 230);
            this.TabControl1.TabIndex = 45;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TabControl2);
            this.TabPage1.Location = new System.Drawing.Point(4, 26);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(505, 200);
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
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(505, 200);
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
            this.TabPage5.Location = new System.Drawing.Point(4, 29);
            this.TabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(497, 167);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "On Disk";
            // 
            // ViewMhtButton
            // 
            this.ViewMhtButton.Enabled = false;
            this.ViewMhtButton.Location = new System.Drawing.Point(411, 115);
            this.ViewMhtButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewMhtButton.Name = "ViewMhtButton";
            this.ViewMhtButton.Size = new System.Drawing.Size(70, 30);
            this.ViewMhtButton.TabIndex = 32;
            this.ViewMhtButton.Text = "View";
            this.ViewMhtButton.Click += new System.EventHandler(this.ViewMhtButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(0, 5);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(320, 17);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Filename to generate, or target folder to generate to:";
            // 
            // MhtFileTextBox
            // 
            this.MhtFileTextBox.Location = new System.Drawing.Point(0, 31);
            this.MhtFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MhtFileTextBox.Multiline = true;
            this.MhtFileTextBox.Name = "MhtFileTextBox";
            this.MhtFileTextBox.Size = new System.Drawing.Size(485, 41);
            this.MhtFileTextBox.TabIndex = 30;
            this.MhtFileTextBox.Text = "runoob.mht";
            // 
            // BuildMhtButton
            // 
            this.BuildMhtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuildMhtButton.Location = new System.Drawing.Point(336, 115);
            this.BuildMhtButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildMhtButton.Name = "BuildMhtButton";
            this.BuildMhtButton.Size = new System.Drawing.Size(70, 30);
            this.BuildMhtButton.TabIndex = 29;
            this.BuildMhtButton.Text = "Save";
            this.BuildMhtButton.Click += new System.EventHandler(this.BuildMhtButton_Click);
            // 
            // MemoryRadioButton
            // 
            this.MemoryRadioButton.Location = new System.Drawing.Point(103, 78);
            this.MemoryRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryRadioButton.Name = "MemoryRadioButton";
            this.MemoryRadioButton.Size = new System.Drawing.Size(75, 31);
            this.MemoryRadioButton.TabIndex = 33;
            this.MemoryRadioButton.Text = "Memory";
            // 
            // DiskTempRadioButton
            // 
            this.DiskTempRadioButton.Location = new System.Drawing.Point(177, 78);
            this.DiskTempRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DiskTempRadioButton.Name = "DiskTempRadioButton";
            this.DiskTempRadioButton.Size = new System.Drawing.Size(131, 31);
            this.DiskTempRadioButton.TabIndex = 34;
            this.DiskTempRadioButton.Text = "Disk, Temporary";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(5, 84);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(93, 21);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Temp Storage:";
            // 
            // DiskPermRadioButton
            // 
            this.DiskPermRadioButton.Location = new System.Drawing.Point(308, 78);
            this.DiskPermRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DiskPermRadioButton.Name = "DiskPermRadioButton";
            this.DiskPermRadioButton.Size = new System.Drawing.Size(131, 31);
            this.DiskPermRadioButton.TabIndex = 35;
            this.DiskPermRadioButton.Text = "Disk, Permanent";
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.BuildMhtMemoryButton);
            this.TabPage6.Location = new System.Drawing.Point(4, 29);
            this.TabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new System.Drawing.Size(497, 167);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "In Memory";
            // 
            // BuildMhtMemoryButton
            // 
            this.BuildMhtMemoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuildMhtMemoryButton.Location = new System.Drawing.Point(327, 115);
            this.BuildMhtMemoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildMhtMemoryButton.Name = "BuildMhtMemoryButton";
            this.BuildMhtMemoryButton.Size = new System.Drawing.Size(154, 30);
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
            this.TabPage3.Location = new System.Drawing.Point(4, 26);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(505, 200);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Web Page (html only)";
            // 
            // ViewHtmlButton
            // 
            this.ViewHtmlButton.Enabled = false;
            this.ViewHtmlButton.Location = new System.Drawing.Point(420, 146);
            this.ViewHtmlButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewHtmlButton.Name = "ViewHtmlButton";
            this.ViewHtmlButton.Size = new System.Drawing.Size(70, 30);
            this.ViewHtmlButton.TabIndex = 24;
            this.ViewHtmlButton.Text = "View";
            this.ViewHtmlButton.Click += new System.EventHandler(this.ViewHtmlButton_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 10);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(320, 17);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Filename to generate, or target folder to generate to:";
            // 
            // HtmlFileTextBox
            // 
            this.HtmlFileTextBox.Location = new System.Drawing.Point(9, 31);
            this.HtmlFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HtmlFileTextBox.Multiline = true;
            this.HtmlFileTextBox.Name = "HtmlFileTextBox";
            this.HtmlFileTextBox.Size = new System.Drawing.Size(485, 103);
            this.HtmlFileTextBox.TabIndex = 22;
            // 
            // SaveHtmlButton
            // 
            this.SaveHtmlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveHtmlButton.Location = new System.Drawing.Point(345, 146);
            this.SaveHtmlButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveHtmlButton.Name = "SaveHtmlButton";
            this.SaveHtmlButton.Size = new System.Drawing.Size(70, 30);
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
            this.TabPage2.Location = new System.Drawing.Point(4, 26);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(505, 200);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Web Page (complete)";
            // 
            // ViewCompleteButton
            // 
            this.ViewCompleteButton.Enabled = false;
            this.ViewCompleteButton.Location = new System.Drawing.Point(420, 146);
            this.ViewCompleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCompleteButton.Name = "ViewCompleteButton";
            this.ViewCompleteButton.Size = new System.Drawing.Size(70, 30);
            this.ViewCompleteButton.TabIndex = 22;
            this.ViewCompleteButton.Text = "View";
            this.ViewCompleteButton.Click += new System.EventHandler(this.ViewCompleteButton_Click);
            // 
            // BuildFileButton
            // 
            this.BuildFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuildFileButton.Location = new System.Drawing.Point(345, 146);
            this.BuildFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildFileButton.Name = "BuildFileButton";
            this.BuildFileButton.Size = new System.Drawing.Size(70, 30);
            this.BuildFileButton.TabIndex = 21;
            this.BuildFileButton.Text = "Save";
            this.BuildFileButton.Click += new System.EventHandler(this.BuildFileButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 10);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(320, 17);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Filename to generate, or target folder to generate to:";
            // 
            // CompleteFileTextBox
            // 
            this.CompleteFileTextBox.Location = new System.Drawing.Point(9, 31);
            this.CompleteFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompleteFileTextBox.Multiline = true;
            this.CompleteFileTextBox.Name = "CompleteFileTextBox";
            this.CompleteFileTextBox.Size = new System.Drawing.Size(485, 103);
            this.CompleteFileTextBox.TabIndex = 19;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(261, 654);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 30);
            this.Button1.TabIndex = 44;
            this.Button1.Text = "Button1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 736);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

