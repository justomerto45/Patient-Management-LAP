namespace MyPatientManager.View
{
    partial class FormHome
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
            buttonAdd = new Button();
            buttonEdit = new Button();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItemDatei = new ToolStripMenuItem();
            helpToolStripMenuItemInfo = new ToolStripMenuItem();
            accountToolStripMenuItemAccount = new ToolStripMenuItem();
            patientenToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button1 = new Button();
            labelWelcome = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxSearch = new TextBox();
            dataGridViewPatients = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9.75F);
            buttonAdd.Location = new Point(1066, 86);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(84, 44);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 9.75F);
            buttonEdit.Location = new Point(1066, 134);
            buttonEdit.Margin = new Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(84, 44);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItemDatei, helpToolStripMenuItemInfo, accountToolStripMenuItemAccount, patientenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1175, 27);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItemDatei
            // 
            dateiToolStripMenuItemDatei.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateiToolStripMenuItemDatei.Name = "dateiToolStripMenuItemDatei";
            dateiToolStripMenuItemDatei.Size = new Size(58, 25);
            dateiToolStripMenuItemDatei.Text = "Datei";
            // 
            // helpToolStripMenuItemInfo
            // 
            helpToolStripMenuItemInfo.Alignment = ToolStripItemAlignment.Right;
            helpToolStripMenuItemInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpToolStripMenuItemInfo.Name = "helpToolStripMenuItemInfo";
            helpToolStripMenuItemInfo.Size = new Size(29, 25);
            helpToolStripMenuItemInfo.Text = "?";
            // 
            // accountToolStripMenuItemAccount
            // 
            accountToolStripMenuItemAccount.Alignment = ToolStripItemAlignment.Right;
            accountToolStripMenuItemAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountToolStripMenuItemAccount.Name = "accountToolStripMenuItemAccount";
            accountToolStripMenuItemAccount.Size = new Size(78, 25);
            accountToolStripMenuItemAccount.Text = "Account";
            // 
            // patientenToolStripMenuItem
            // 
            patientenToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientenToolStripMenuItem.Name = "patientenToolStripMenuItem";
            patientenToolStripMenuItem.Size = new Size(86, 25);
            patientenToolStripMenuItem.Text = "Patienten";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.Location = new Point(1066, 598);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(84, 44);
            button3.TabIndex = 6;
            button3.Text = "Löschen";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(1066, 294);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(84, 44);
            button1.TabIndex = 7;
            button1.Text = "Behandlung";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(381, 25);
            labelWelcome.Margin = new Padding(2, 0, 2, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 51);
            labelWelcome.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Controls.Add(dataGridViewPatients);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1049, 563);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Behandlungen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(666, 25);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 11;
            label1.Text = "Suche (Patienten Name):";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(383, 22);
            textBoxSearch.Margin = new Padding(2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(278, 29);
            textBoxSearch.TabIndex = 10;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged_1;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Location = new Point(5, 55);
            dataGridViewPatients.Margin = new Padding(2);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 62;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(1039, 503);
            dataGridViewPatients.TabIndex = 9;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 654);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(labelWelcome);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private Button buttonEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItemDatei;
        private ToolStripMenuItem helpToolStripMenuItemInfo;
        private ToolStripMenuItem accountToolStripMenuItemAccount;
        private Button button3;
        private Button button1;
        private ToolStripMenuItem patientenToolStripMenuItem;
        private Label labelWelcome;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewPatients;
    }
}