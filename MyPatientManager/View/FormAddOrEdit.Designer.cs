namespace MyPatientManager.View
{
    partial class FormAddOrEdit
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
            richTextBoxMemoires = new RichTextBox();
            comboBoxPatients = new ComboBox();
            label1 = new Label();
            dataGridViewMedis = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelDoctor = new Label();
            labelDate = new Label();
            labelMemoires = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            pDFExportienToolStripMenuItem = new ToolStripMenuItem();
            druckenToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedis).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxMemoires
            // 
            richTextBoxMemoires.Location = new Point(8, 186);
            richTextBoxMemoires.Margin = new Padding(2, 2, 2, 2);
            richTextBoxMemoires.Name = "richTextBoxMemoires";
            richTextBoxMemoires.Size = new Size(469, 360);
            richTextBoxMemoires.TabIndex = 1;
            richTextBoxMemoires.Text = "";
            // 
            // comboBoxPatients
            // 
            comboBoxPatients.FormattingEnabled = true;
            comboBoxPatients.Location = new Point(8, 60);
            comboBoxPatients.Margin = new Padding(2, 2, 2, 2);
            comboBoxPatients.Name = "comboBoxPatients";
            comboBoxPatients.Size = new Size(316, 23);
            comboBoxPatients.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Patient:";
            // 
            // dataGridViewMedis
            // 
            dataGridViewMedis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedis.Location = new Point(623, 62);
            dataGridViewMedis.Margin = new Padding(2, 2, 2, 2);
            dataGridViewMedis.Name = "dataGridViewMedis";
            dataGridViewMedis.RowHeadersWidth = 62;
            dataGridViewMedis.Size = new Size(405, 493);
            dataGridViewMedis.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Arzt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 128);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Datum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "Medikamente:";
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDoctor.Location = new Point(8, 100);
            labelDoctor.Margin = new Padding(2, 0, 2, 0);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(47, 15);
            labelDoctor.TabIndex = 8;
            labelDoctor.Text = "Dr. Dre";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(8, 143);
            labelDate.Margin = new Padding(2, 0, 2, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(64, 15);
            labelDate.TabIndex = 9;
            labelDate.Text = "01.07.2024";
            // 
            // labelMemoires
            // 
            labelMemoires.AutoSize = true;
            labelMemoires.Location = new Point(8, 169);
            labelMemoires.Margin = new Padding(2, 0, 2, 0);
            labelMemoires.Name = "labelMemoires";
            labelMemoires.Size = new Size(63, 15);
            labelMemoires.TabIndex = 10;
            labelMemoires.Text = "Memoires:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(8, 550);
            buttonSave.Margin = new Padding(2, 2, 2, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(93, 29);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(106, 550);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(93, 29);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1037, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDFExportienToolStripMenuItem, druckenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(46, 22);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // pDFExportienToolStripMenuItem
            // 
            pDFExportienToolStripMenuItem.Name = "pDFExportienToolStripMenuItem";
            pDFExportienToolStripMenuItem.Size = new Size(148, 22);
            pDFExportienToolStripMenuItem.Text = "PDF exportien";
            // 
            // druckenToolStripMenuItem
            // 
            druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            druckenToolStripMenuItem.Size = new Size(148, 22);
            druckenToolStripMenuItem.Text = "Drucken";
            // 
            // FormAddOrEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 587);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelMemoires);
            Controls.Add(labelDate);
            Controls.Add(labelDoctor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewMedis);
            Controls.Add(label1);
            Controls.Add(comboBoxPatients);
            Controls.Add(richTextBoxMemoires);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAddOrEdit";
            Text = "Behandlung";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedis).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RichTextBox richTextBoxMemoires;
        private ComboBox comboBoxPatients;
        private Label label1;
        private DataGridView dataGridViewMedis;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelDoctor;
        private Label labelDate;
        private Label labelMemoires;
        private Button buttonSave;
        private Button buttonCancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem pDFExportienToolStripMenuItem;
        private ToolStripMenuItem druckenToolStripMenuItem;
    }
}