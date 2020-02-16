namespace Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.instLabel = new System.Windows.Forms.Label();
            this.groupBoxOne = new System.Windows.Forms.GroupBox();
            this.EnterQuestionPanel = new System.Windows.Forms.Panel();
            this.TFRadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.blankTextBox = new System.Windows.Forms.TextBox();
            this.ARadioButton = new System.Windows.Forms.RadioButton();
            this.CRadioButton = new System.Windows.Forms.RadioButton();
            this.AnswerFalseRadioButton = new System.Windows.Forms.RadioButton();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.AnswerTrueRadioButton = new System.Windows.Forms.RadioButton();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.NumComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionRTextBox = new System.Windows.Forms.RichTextBox();
            this.AverageListBox = new System.Windows.Forms.ListBox();
            this.SubmitAdminButton = new System.Windows.Forms.Button();
            this.CreateAdminButton = new System.Windows.Forms.Button();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.AdminNameTextBox = new System.Windows.Forms.TextBox();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.FillPopUpButton = new System.Windows.Forms.Label();
            this.MCPopUpButton = new System.Windows.Forms.Label();
            this.TFPopUpLabel = new System.Windows.Forms.Label();
            this.FillRadioButton = new System.Windows.Forms.RadioButton();
            this.TFRadioButton = new System.Windows.Forms.RadioButton();
            this.MultipleRadioButton = new System.Windows.Forms.RadioButton();
            this.AnswerListBox = new System.Windows.Forms.ListBox();
            this.StudentLogButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.QuickAverageButton = new System.Windows.Forms.Button();
            this.ViewStudentInfo = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ViewAdminsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AdministerTestButton = new System.Windows.Forms.Button();
            this.TakeTestButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.groupBoxOne.SuspendLayout();
            this.EnterQuestionPanel.SuspendLayout();
            this.TFRadioButtonGroupBox.SuspendLayout();
            this.questionGroupBox.SuspendLayout();
            this.TypeGroupBox.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.instLabel);
            this.MainPanel.Controls.Add(this.groupBoxOne);
            this.MainPanel.Controls.Add(this.buttonPanel);
            this.MainPanel.Controls.Add(this.titlePanel);
            this.MainPanel.Location = new System.Drawing.Point(6, 9);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(791, 590);
            this.MainPanel.TabIndex = 0;
            // 
            // instLabel
            // 
            this.instLabel.BackColor = System.Drawing.Color.Transparent;
            this.instLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instLabel.Location = new System.Drawing.Point(6, 479);
            this.instLabel.Name = "instLabel";
            this.instLabel.Size = new System.Drawing.Size(778, 106);
            this.instLabel.TabIndex = 3;
            this.instLabel.Text = "instructions...";
            this.instLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instLabel.Click += new System.EventHandler(this.instLabel_Click);
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOne.Controls.Add(this.EnterQuestionPanel);
            this.groupBoxOne.Controls.Add(this.SubmitAdminButton);
            this.groupBoxOne.Controls.Add(this.CreateAdminButton);
            this.groupBoxOne.Controls.Add(this.AdminPasswordLabel);
            this.groupBoxOne.Controls.Add(this.AdminPasswordTextBox);
            this.groupBoxOne.Controls.Add(this.AdminNameLabel);
            this.groupBoxOne.Controls.Add(this.AdminNameTextBox);
            this.groupBoxOne.Controls.Add(this.TypeGroupBox);
            this.groupBoxOne.Controls.Add(this.StudentLogButton);
            this.groupBoxOne.Controls.Add(this.IDLabel);
            this.groupBoxOne.Controls.Add(this.IDTextBox);
            this.groupBoxOne.Location = new System.Drawing.Point(6, 137);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(779, 339);
            this.groupBoxOne.TabIndex = 2;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Enter += new System.EventHandler(this.groupBoxOne_Enter);
            // 
            // EnterQuestionPanel
            // 
            this.EnterQuestionPanel.Controls.Add(this.TFRadioButtonGroupBox);
            this.EnterQuestionPanel.Controls.Add(this.questionGroupBox);
            this.EnterQuestionPanel.Location = new System.Drawing.Point(424, 6);
            this.EnterQuestionPanel.Name = "EnterQuestionPanel";
            this.EnterQuestionPanel.Size = new System.Drawing.Size(354, 327);
            this.EnterQuestionPanel.TabIndex = 14;
            this.EnterQuestionPanel.Visible = false;
            // 
            // TFRadioButtonGroupBox
            // 
            this.TFRadioButtonGroupBox.Controls.Add(this.SubmitButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.DoneButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.EnterButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.AnswerLabel);
            this.TFRadioButtonGroupBox.Controls.Add(this.blankTextBox);
            this.TFRadioButtonGroupBox.Controls.Add(this.ARadioButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.CRadioButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.AnswerFalseRadioButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.BRadioButton);
            this.TFRadioButtonGroupBox.Controls.Add(this.AnswerTrueRadioButton);
            this.TFRadioButtonGroupBox.ForeColor = System.Drawing.Color.White;
            this.TFRadioButtonGroupBox.Location = new System.Drawing.Point(0, 108);
            this.TFRadioButtonGroupBox.Name = "TFRadioButtonGroupBox";
            this.TFRadioButtonGroupBox.Size = new System.Drawing.Size(344, 216);
            this.TFRadioButtonGroupBox.TabIndex = 14;
            this.TFRadioButtonGroupBox.TabStop = false;
            this.TFRadioButtonGroupBox.Text = "Answer";
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(204, 161);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 30);
            this.SubmitButton.TabIndex = 20;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(204, 131);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 30);
            this.DoneButton.TabIndex = 19;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(123, 131);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 30);
            this.EnterButton.TabIndex = 18;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(57, 100);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(61, 21);
            this.AnswerLabel.TabIndex = 17;
            this.AnswerLabel.Text = "Answer:";
            // 
            // blankTextBox
            // 
            this.blankTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blankTextBox.Location = new System.Drawing.Point(133, 97);
            this.blankTextBox.Name = "blankTextBox";
            this.blankTextBox.Size = new System.Drawing.Size(144, 28);
            this.blankTextBox.TabIndex = 16;
            // 
            // ARadioButton
            // 
            this.ARadioButton.AutoSize = true;
            this.ARadioButton.Location = new System.Drawing.Point(61, 59);
            this.ARadioButton.Name = "ARadioButton";
            this.ARadioButton.Size = new System.Drawing.Size(38, 21);
            this.ARadioButton.TabIndex = 11;
            this.ARadioButton.TabStop = true;
            this.ARadioButton.Text = "A";
            this.ARadioButton.UseVisualStyleBackColor = true;
            // 
            // CRadioButton
            // 
            this.CRadioButton.AutoSize = true;
            this.CRadioButton.Location = new System.Drawing.Point(228, 59);
            this.CRadioButton.Name = "CRadioButton";
            this.CRadioButton.Size = new System.Drawing.Size(38, 21);
            this.CRadioButton.TabIndex = 13;
            this.CRadioButton.TabStop = true;
            this.CRadioButton.Text = "C";
            this.CRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnswerFalseRadioButton
            // 
            this.AnswerFalseRadioButton.AutoSize = true;
            this.AnswerFalseRadioButton.Location = new System.Drawing.Point(177, 32);
            this.AnswerFalseRadioButton.Name = "AnswerFalseRadioButton";
            this.AnswerFalseRadioButton.Size = new System.Drawing.Size(63, 21);
            this.AnswerFalseRadioButton.TabIndex = 12;
            this.AnswerFalseRadioButton.TabStop = true;
            this.AnswerFalseRadioButton.Text = "False";
            this.AnswerFalseRadioButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(144, 59);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(38, 21);
            this.BRadioButton.TabIndex = 12;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "B";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnswerTrueRadioButton
            // 
            this.AnswerTrueRadioButton.AutoSize = true;
            this.AnswerTrueRadioButton.Location = new System.Drawing.Point(93, 32);
            this.AnswerTrueRadioButton.Name = "AnswerTrueRadioButton";
            this.AnswerTrueRadioButton.Size = new System.Drawing.Size(59, 21);
            this.AnswerTrueRadioButton.TabIndex = 11;
            this.AnswerTrueRadioButton.TabStop = true;
            this.AnswerTrueRadioButton.Text = "True";
            this.AnswerTrueRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.NumComboBox);
            this.questionGroupBox.Controls.Add(this.label2);
            this.questionGroupBox.Controls.Add(this.QuestionRTextBox);
            this.questionGroupBox.Controls.Add(this.AverageListBox);
            this.questionGroupBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionGroupBox.ForeColor = System.Drawing.Color.White;
            this.questionGroupBox.Location = new System.Drawing.Point(0, 12);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(344, 96);
            this.questionGroupBox.TabIndex = 16;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "Question";
            // 
            // NumComboBox
            // 
            this.NumComboBox.DropDownHeight = 300;
            this.NumComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumComboBox.FormattingEnabled = true;
            this.NumComboBox.IntegralHeight = false;
            this.NumComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.NumComboBox.Location = new System.Drawing.Point(6, 27);
            this.NumComboBox.MaxDropDownItems = 30;
            this.NumComboBox.Name = "NumComboBox";
            this.NumComboBox.Size = new System.Drawing.Size(48, 29);
            this.NumComboBox.TabIndex = 15;
            this.NumComboBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "#";
            // 
            // QuestionRTextBox
            // 
            this.QuestionRTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionRTextBox.Location = new System.Drawing.Point(60, 27);
            this.QuestionRTextBox.Name = "QuestionRTextBox";
            this.QuestionRTextBox.Size = new System.Drawing.Size(278, 56);
            this.QuestionRTextBox.TabIndex = 13;
            this.QuestionRTextBox.Text = "";
            // 
            // AverageListBox
            // 
            this.AverageListBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageListBox.FormattingEnabled = true;
            this.AverageListBox.HorizontalScrollbar = true;
            this.AverageListBox.ItemHeight = 21;
            this.AverageListBox.Location = new System.Drawing.Point(6, 31);
            this.AverageListBox.Name = "AverageListBox";
            this.AverageListBox.Size = new System.Drawing.Size(334, 235);
            this.AverageListBox.TabIndex = 10;
            this.AverageListBox.Visible = false;
            // 
            // SubmitAdminButton
            // 
            this.SubmitAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitAdminButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitAdminButton.ForeColor = System.Drawing.Color.White;
            this.SubmitAdminButton.Location = new System.Drawing.Point(360, 178);
            this.SubmitAdminButton.Name = "SubmitAdminButton";
            this.SubmitAdminButton.Size = new System.Drawing.Size(75, 31);
            this.SubmitAdminButton.TabIndex = 5;
            this.SubmitAdminButton.Text = "Submit";
            this.SubmitAdminButton.UseVisualStyleBackColor = true;
            this.SubmitAdminButton.Click += new System.EventHandler(this.SubmitAdminButton_Click_1);
            // 
            // CreateAdminButton
            // 
            this.CreateAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateAdminButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAdminButton.ForeColor = System.Drawing.Color.White;
            this.CreateAdminButton.Location = new System.Drawing.Point(441, 178);
            this.CreateAdminButton.Name = "CreateAdminButton";
            this.CreateAdminButton.Size = new System.Drawing.Size(75, 31);
            this.CreateAdminButton.TabIndex = 4;
            this.CreateAdminButton.Text = "Create ";
            this.CreateAdminButton.UseVisualStyleBackColor = true;
            this.CreateAdminButton.Click += new System.EventHandler(this.submitAdminButton_Click);
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordLabel.Location = new System.Drawing.Point(262, 98);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(90, 24);
            this.AdminPasswordLabel.TabIndex = 3;
            this.AdminPasswordLabel.Text = "Password:";
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(374, 95);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(142, 32);
            this.AdminPasswordTextBox.TabIndex = 2;
            this.AdminPasswordTextBox.Text = "Password1";
            this.AdminPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.AutoSize = true;
            this.AdminNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameLabel.Location = new System.Drawing.Point(262, 60);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(58, 24);
            this.AdminNameLabel.TabIndex = 1;
            this.AdminNameLabel.Text = "Name:";
            // 
            // AdminNameTextBox
            // 
            this.AdminNameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameTextBox.Location = new System.Drawing.Point(374, 57);
            this.AdminNameTextBox.Name = "AdminNameTextBox";
            this.AdminNameTextBox.Size = new System.Drawing.Size(142, 32);
            this.AdminNameTextBox.TabIndex = 0;
            this.AdminNameTextBox.Text = "Admin";
            this.AdminNameTextBox.UseWaitCursor = true;
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.FillPopUpButton);
            this.TypeGroupBox.Controls.Add(this.MCPopUpButton);
            this.TypeGroupBox.Controls.Add(this.TFPopUpLabel);
            this.TypeGroupBox.Controls.Add(this.FillRadioButton);
            this.TypeGroupBox.Controls.Add(this.TFRadioButton);
            this.TypeGroupBox.Controls.Add(this.MultipleRadioButton);
            this.TypeGroupBox.Controls.Add(this.AnswerListBox);
            this.TypeGroupBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeGroupBox.ForeColor = System.Drawing.Color.White;
            this.TypeGroupBox.Location = new System.Drawing.Point(6, 18);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(374, 312);
            this.TypeGroupBox.TabIndex = 9;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Type";
            // 
            // FillPopUpButton
            // 
            this.FillPopUpButton.AutoSize = true;
            this.FillPopUpButton.Location = new System.Drawing.Point(252, 161);
            this.FillPopUpButton.Name = "FillPopUpButton";
            this.FillPopUpButton.Size = new System.Drawing.Size(23, 17);
            this.FillPopUpButton.TabIndex = 12;
            this.FillPopUpButton.Text = "ex.";
            this.FillPopUpButton.Click += new System.EventHandler(this.FillPopUpButton_Click);
            // 
            // MCPopUpButton
            // 
            this.MCPopUpButton.AutoSize = true;
            this.MCPopUpButton.Location = new System.Drawing.Point(251, 123);
            this.MCPopUpButton.Name = "MCPopUpButton";
            this.MCPopUpButton.Size = new System.Drawing.Size(23, 17);
            this.MCPopUpButton.TabIndex = 11;
            this.MCPopUpButton.Text = "ex.";
            this.MCPopUpButton.Click += new System.EventHandler(this.MCPopUpButton_Click_1);
            // 
            // TFPopUpLabel
            // 
            this.TFPopUpLabel.AutoSize = true;
            this.TFPopUpLabel.Location = new System.Drawing.Point(222, 85);
            this.TFPopUpLabel.Name = "TFPopUpLabel";
            this.TFPopUpLabel.Size = new System.Drawing.Size(23, 17);
            this.TFPopUpLabel.TabIndex = 10;
            this.TFPopUpLabel.Text = "ex.";
            this.TFPopUpLabel.Click += new System.EventHandler(this.TFPopUpLabel_Click);
            // 
            // FillRadioButton
            // 
            this.FillRadioButton.AutoSize = true;
            this.FillRadioButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillRadioButton.ForeColor = System.Drawing.Color.Black;
            this.FillRadioButton.Location = new System.Drawing.Point(99, 152);
            this.FillRadioButton.Name = "FillRadioButton";
            this.FillRadioButton.Size = new System.Drawing.Size(147, 28);
            this.FillRadioButton.TabIndex = 8;
            this.FillRadioButton.TabStop = true;
            this.FillRadioButton.Text = "Fill In the Blank";
            this.FillRadioButton.UseVisualStyleBackColor = true;
            this.FillRadioButton.CheckedChanged += new System.EventHandler(this.FillRadioButton_CheckedChanged);
            // 
            // TFRadioButton
            // 
            this.TFRadioButton.AutoSize = true;
            this.TFRadioButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFRadioButton.ForeColor = System.Drawing.Color.Black;
            this.TFRadioButton.Location = new System.Drawing.Point(99, 76);
            this.TFRadioButton.Name = "TFRadioButton";
            this.TFRadioButton.Size = new System.Drawing.Size(117, 28);
            this.TFRadioButton.TabIndex = 6;
            this.TFRadioButton.TabStop = true;
            this.TFRadioButton.Text = "True / False";
            this.TFRadioButton.UseVisualStyleBackColor = true;
            this.TFRadioButton.CheckedChanged += new System.EventHandler(this.TFRadioButton_CheckedChanged);
            // 
            // MultipleRadioButton
            // 
            this.MultipleRadioButton.AutoSize = true;
            this.MultipleRadioButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.MultipleRadioButton.Location = new System.Drawing.Point(99, 114);
            this.MultipleRadioButton.Name = "MultipleRadioButton";
            this.MultipleRadioButton.Size = new System.Drawing.Size(146, 28);
            this.MultipleRadioButton.TabIndex = 7;
            this.MultipleRadioButton.TabStop = true;
            this.MultipleRadioButton.Text = "Multiple Choice";
            this.MultipleRadioButton.UseVisualStyleBackColor = true;
            this.MultipleRadioButton.CheckedChanged += new System.EventHandler(this.MultipleRadioButton_CheckedChanged);
            // 
            // AnswerListBox
            // 
            this.AnswerListBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerListBox.FormattingEnabled = true;
            this.AnswerListBox.HorizontalScrollbar = true;
            this.AnswerListBox.ItemHeight = 18;
            this.AnswerListBox.Location = new System.Drawing.Point(12, 27);
            this.AnswerListBox.Name = "AnswerListBox";
            this.AnswerListBox.Size = new System.Drawing.Size(350, 256);
            this.AnswerListBox.TabIndex = 9;
            this.AnswerListBox.Visible = false;
            this.AnswerListBox.SelectedIndexChanged += new System.EventHandler(this.AnswerListBox_SelectedIndexChanged);
            // 
            // StudentLogButton
            // 
            this.StudentLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentLogButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogButton.ForeColor = System.Drawing.Color.White;
            this.StudentLogButton.Location = new System.Drawing.Point(386, 216);
            this.StudentLogButton.Name = "StudentLogButton";
            this.StudentLogButton.Size = new System.Drawing.Size(130, 31);
            this.StudentLogButton.TabIndex = 15;
            this.StudentLogButton.Text = "Student Login";
            this.StudentLogButton.UseVisualStyleBackColor = true;
            this.StudentLogButton.Visible = false;
            this.StudentLogButton.Click += new System.EventHandler(this.StudentLogButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.Black;
            this.IDLabel.Location = new System.Drawing.Point(262, 137);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(92, 24);
            this.IDLabel.TabIndex = 16;
            this.IDLabel.Text = "Student ID:";
            this.IDLabel.Visible = false;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(374, 134);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(142, 32);
            this.IDTextBox.TabIndex = 16;
            this.IDTextBox.UseWaitCursor = true;
            this.IDTextBox.Visible = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.Controls.Add(this.QuickAverageButton);
            this.buttonPanel.Controls.Add(this.ViewStudentInfo);
            this.buttonPanel.Controls.Add(this.ResultsButton);
            this.buttonPanel.Controls.Add(this.logoutButton);
            this.buttonPanel.Controls.Add(this.ViewAdminsButton);
            this.buttonPanel.Controls.Add(this.ExitButton);
            this.buttonPanel.Controls.Add(this.AdministerTestButton);
            this.buttonPanel.Controls.Add(this.TakeTestButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 75);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(784, 62);
            this.buttonPanel.TabIndex = 1;
            // 
            // QuickAverageButton
            // 
            this.QuickAverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuickAverageButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickAverageButton.ForeColor = System.Drawing.Color.White;
            this.QuickAverageButton.Location = new System.Drawing.Point(127, 12);
            this.QuickAverageButton.Name = "QuickAverageButton";
            this.QuickAverageButton.Size = new System.Drawing.Size(95, 44);
            this.QuickAverageButton.TabIndex = 10;
            this.QuickAverageButton.Text = "Quick Results";
            this.QuickAverageButton.UseVisualStyleBackColor = true;
            this.QuickAverageButton.Click += new System.EventHandler(this.QuickAverageButton_Click);
            // 
            // ViewStudentInfo
            // 
            this.ViewStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewStudentInfo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentInfo.ForeColor = System.Drawing.Color.White;
            this.ViewStudentInfo.Location = new System.Drawing.Point(587, 12);
            this.ViewStudentInfo.Name = "ViewStudentInfo";
            this.ViewStudentInfo.Size = new System.Drawing.Size(86, 44);
            this.ViewStudentInfo.TabIndex = 9;
            this.ViewStudentInfo.Text = "View Student Info";
            this.ViewStudentInfo.UseVisualStyleBackColor = true;
            this.ViewStudentInfo.Click += new System.EventHandler(this.ViewStudentInfo_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsButton.ForeColor = System.Drawing.Color.White;
            this.ResultsButton.Location = new System.Drawing.Point(12, 12);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(95, 44);
            this.ResultsButton.TabIndex = 8;
            this.ResultsButton.Text = "Results";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(583, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(95, 44);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ViewAdminsButton
            // 
            this.ViewAdminsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewAdminsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAdminsButton.ForeColor = System.Drawing.Color.White;
            this.ViewAdminsButton.Location = new System.Drawing.Point(693, 12);
            this.ViewAdminsButton.Name = "ViewAdminsButton";
            this.ViewAdminsButton.Size = new System.Drawing.Size(86, 44);
            this.ViewAdminsButton.TabIndex = 6;
            this.ViewAdminsButton.Text = "View Admins";
            this.ViewAdminsButton.UseVisualStyleBackColor = true;
            this.ViewAdminsButton.Click += new System.EventHandler(this.ViewAdminsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(472, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 44);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdministerTestButton
            // 
            this.AdministerTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdministerTestButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministerTestButton.ForeColor = System.Drawing.Color.White;
            this.AdministerTestButton.Location = new System.Drawing.Point(357, 12);
            this.AdministerTestButton.Name = "AdministerTestButton";
            this.AdministerTestButton.Size = new System.Drawing.Size(95, 44);
            this.AdministerTestButton.TabIndex = 1;
            this.AdministerTestButton.Text = "Administer Test";
            this.AdministerTestButton.UseVisualStyleBackColor = true;
            this.AdministerTestButton.Click += new System.EventHandler(this.AdmisisterTestButton_Click);
            // 
            // TakeTestButton
            // 
            this.TakeTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TakeTestButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeTestButton.ForeColor = System.Drawing.Color.White;
            this.TakeTestButton.Location = new System.Drawing.Point(242, 12);
            this.TakeTestButton.Name = "TakeTestButton";
            this.TakeTestButton.Size = new System.Drawing.Size(95, 44);
            this.TakeTestButton.TabIndex = 0;
            this.TakeTestButton.Text = "Take Test";
            this.TakeTestButton.UseVisualStyleBackColor = true;
            this.TakeTestButton.Click += new System.EventHandler(this.TakeTestButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Transparent;
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(785, 75);
            this.titlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESTING SOFTWARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 603);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.groupBoxOne.ResumeLayout(false);
            this.groupBoxOne.PerformLayout();
            this.EnterQuestionPanel.ResumeLayout(false);
            this.TFRadioButtonGroupBox.ResumeLayout(false);
            this.TFRadioButtonGroupBox.PerformLayout();
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AdministerTestButton;
        private System.Windows.Forms.Button TakeTestButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOne;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.TextBox AdminNameTextBox;
        private System.Windows.Forms.Label instLabel;
        private System.Windows.Forms.Button CreateAdminButton;
        private System.Windows.Forms.Button SubmitAdminButton;
        private System.Windows.Forms.Button ViewAdminsButton;
        private System.Windows.Forms.Panel EnterQuestionPanel;
        private System.Windows.Forms.GroupBox TFRadioButtonGroupBox;
        private System.Windows.Forms.RadioButton AnswerFalseRadioButton;
        private System.Windows.Forms.RadioButton AnswerTrueRadioButton;
        private System.Windows.Forms.RichTextBox QuestionRTextBox;
        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton FillRadioButton;
        private System.Windows.Forms.RadioButton TFRadioButton;
        private System.Windows.Forms.RadioButton MultipleRadioButton;
        private System.Windows.Forms.RadioButton CRadioButton;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton ARadioButton;
        private System.Windows.Forms.TextBox blankTextBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox NumComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.ListBox AnswerListBox;
        private System.Windows.Forms.Button StudentLogButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ListBox AverageListBox;
        private System.Windows.Forms.Button ViewStudentInfo;
        private System.Windows.Forms.Button QuickAverageButton;
        private System.Windows.Forms.Label TFPopUpLabel;
        private System.Windows.Forms.Label MCPopUpButton;
        private System.Windows.Forms.Label FillPopUpButton;
    }
}

