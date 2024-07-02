namespace MyPatientManager
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            button1 = new Button();
            textBoxUsername = new TextBox();
            textBoxPasswort = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 51);
            label1.TabIndex = 3;
            label1.Text = "Willkommen";
            // 
            // button1
            // 
            button1.Location = new Point(260, 179);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(248, 134);
            textBoxUsername.Margin = new Padding(2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(106, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(248, 157);
            textBoxPasswort.Margin = new Padding(2);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(106, 23);
            textBoxPasswort.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 136);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Passwort:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 331);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxUsername);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxUsername;
        private TextBox textBoxPasswort;
        private Label label2;
        private Label label3;
    }
}
