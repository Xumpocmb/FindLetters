namespace FindLetters
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label_game_name = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_game_name
            // 
            label_game_name.AutoSize = true;
            label_game_name.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_game_name.Location = new Point(21, 19);
            label_game_name.Name = "label_game_name";
            label_game_name.Size = new Size(271, 45);
            label_game_name.TabIndex = 0;
            label_game_name.Text = "Игра в Алфавит";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 1;
            label2.Text = "Разработчик: Юреня Андрей";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.Location = new Point(85, 112);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(139, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://t.me/Xumpocmb";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(33, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 136);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 297);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label_game_name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_game_name;
        private Label label2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}