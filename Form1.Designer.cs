namespace FindLetters
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_game_name = new Label();
            label_letter = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button_start = new Button();
            label_timer = new Label();
            textBox_timer = new TextBox();
            game_timer = new System.Windows.Forms.Timer(components);
            letter_timer = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            label_remaining = new Label();
            groupBox1 = new GroupBox();
            label_score = new Label();
            label_user_score = new Label();
            button_stop = new Button();
            groupBox2 = new GroupBox();
            radioButton_hard = new RadioButton();
            radioButton_normal = new RadioButton();
            radioButton_easy = new RadioButton();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            играToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_game_name
            // 
            label_game_name.Anchor = AnchorStyles.Top;
            label_game_name.AutoSize = true;
            label_game_name.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label_game_name.Location = new Point(119, 24);
            label_game_name.Name = "label_game_name";
            label_game_name.Size = new Size(362, 59);
            label_game_name.TabIndex = 0;
            label_game_name.Text = "Игра в Алфавит";
            // 
            // label_letter
            // 
            label_letter.Anchor = AnchorStyles.Top;
            label_letter.AutoSize = true;
            label_letter.Font = new Font("Segoe UI", 46F, FontStyle.Regular, GraphicsUnit.Point);
            label_letter.Location = new Point(222, 88);
            label_letter.Name = "label_letter";
            label_letter.Size = new Size(146, 84);
            label_letter.TabIndex = 1;
            label_letter.Text = "АБВ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(19, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 25);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "соревнование";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 25);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "тренировка";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            button_start.Anchor = AnchorStyles.Top;
            button_start.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            button_start.Location = new Point(164, 345);
            button_start.Name = "button_start";
            button_start.Size = new Size(279, 55);
            button_start.TabIndex = 4;
            button_start.Text = "Играть!";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // label_timer
            // 
            label_timer.Anchor = AnchorStyles.Top;
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_timer.Location = new Point(164, 313);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(135, 21);
            label_timer.TabIndex = 5;
            label_timer.Text = "Таймер (минуты):";
            // 
            // textBox_timer
            // 
            textBox_timer.Anchor = AnchorStyles.Top;
            textBox_timer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_timer.Location = new Point(305, 310);
            textBox_timer.MaxLength = 3;
            textBox_timer.Name = "textBox_timer";
            textBox_timer.PlaceholderText = "Время в секундах";
            textBox_timer.Size = new Size(139, 29);
            textBox_timer.TabIndex = 6;
            textBox_timer.Text = "2";
            // 
            // game_timer
            // 
            game_timer.Tick += Timer1_Tick;
            // 
            // letter_timer
            // 
            letter_timer.Interval = 300;
            letter_timer.Tick += letter_timer_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 477);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(594, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 9;
            // 
            // label_remaining
            // 
            label_remaining.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_remaining.AutoSize = true;
            label_remaining.BackColor = Color.Transparent;
            label_remaining.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_remaining.Location = new Point(0, 477);
            label_remaining.Name = "label_remaining";
            label_remaining.Size = new Size(19, 21);
            label_remaining.TabIndex = 10;
            label_remaining.Text = "0";
            label_remaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(164, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 80);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Режим игры";
            // 
            // label_score
            // 
            label_score.Anchor = AnchorStyles.Top;
            label_score.AutoSize = true;
            label_score.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_score.Location = new Point(164, 403);
            label_score.Name = "label_score";
            label_score.Size = new Size(185, 25);
            label_score.TabIndex = 12;
            label_score.Text = "Количество баллов:";
            // 
            // label_user_score
            // 
            label_user_score.Anchor = AnchorStyles.Top;
            label_user_score.AutoSize = true;
            label_user_score.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_user_score.Location = new Point(421, 403);
            label_user_score.Name = "label_user_score";
            label_user_score.Size = new Size(22, 25);
            label_user_score.TabIndex = 13;
            label_user_score.Text = "0";
            // 
            // button_stop
            // 
            button_stop.Anchor = AnchorStyles.Bottom;
            button_stop.Location = new Point(164, 445);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(279, 26);
            button_stop.TabIndex = 14;
            button_stop.Text = "Остановить игру";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Visible = false;
            button_stop.Click += button_stop_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(radioButton_hard);
            groupBox2.Controls.Add(radioButton_normal);
            groupBox2.Controls.Add(radioButton_easy);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(318, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(126, 105);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сложность";
            // 
            // radioButton_hard
            // 
            radioButton_hard.AutoSize = true;
            radioButton_hard.Location = new Point(15, 74);
            radioButton_hard.Name = "radioButton_hard";
            radioButton_hard.Size = new Size(85, 25);
            radioButton_hard.TabIndex = 2;
            radioButton_hard.Text = "Сложно";
            radioButton_hard.UseVisualStyleBackColor = true;
            // 
            // radioButton_normal
            // 
            radioButton_normal.AutoSize = true;
            radioButton_normal.Location = new Point(15, 47);
            radioButton_normal.Name = "radioButton_normal";
            radioButton_normal.Size = new Size(110, 25);
            radioButton_normal.TabIndex = 1;
            radioButton_normal.Text = "Нормально";
            radioButton_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_easy
            // 
            radioButton_easy.AutoSize = true;
            radioButton_easy.Checked = true;
            radioButton_easy.Location = new Point(15, 22);
            radioButton_easy.Name = "radioButton_easy";
            radioButton_easy.Size = new Size(70, 25);
            radioButton_easy.TabIndex = 0;
            radioButton_easy.TabStop = true;
            radioButton_easy.Text = "Легко";
            radioButton_easy.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logo.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(475, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(594, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(46, 20);
            играToolStripMenuItem.Text = "Игра";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 500);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(button_stop);
            Controls.Add(label_user_score);
            Controls.Add(label_score);
            Controls.Add(groupBox1);
            Controls.Add(label_remaining);
            Controls.Add(progressBar1);
            Controls.Add(textBox_timer);
            Controls.Add(label_timer);
            Controls.Add(button_start);
            Controls.Add(label_letter);
            Controls.Add(label_game_name);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра в Алфавит";
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_game_name;
        private Label label_letter;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button_start;
        private Label label_timer;
        private TextBox textBox_timer;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Timer letter_timer;
        private ProgressBar progressBar1;
        private Label label_remaining;
        private GroupBox groupBox1;
        private Label label_score;
        private Label label_user_score;
        private Button button_stop;
        private GroupBox groupBox2;
        private RadioButton radioButton_hard;
        private RadioButton radioButton_normal;
        private RadioButton radioButton_easy;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}