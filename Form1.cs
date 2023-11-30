using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace FindLetters
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        private int gameTime; // ����� � ��������
        private int remainingTime = 0; //
        private int userScore = 0;

        public Form1()
        {
            InitializeComponent();

            // ������������� �������
            game_timer.Interval = 1000; // �������� � ������������� (1 �������)
            letter_timer.Interval = 3000;
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            // ��������� ���������
            if (radioButton_easy.Checked)
            {
                letter_timer.Interval = 5000;
            }
            else if (radioButton_normal.Checked)
            {
                letter_timer.Interval = 3000;
            }
            else if (radioButton_hard.Checked)
            {
                letter_timer.Interval = 1500;
            }

            // ����� ������ ����
            if (radioButton1.Checked) // ���� ����������������
            {
                gameTime = int.Parse(textBox_timer.Text) * 60; // ����� ������� ��� ������ ����� �������
                remainingTime = gameTime;
                progressBar1.Maximum = gameTime;
                progressBar1.Value = remainingTime;

                button_start.Enabled = false;
                textBox_timer.Enabled = false;
                //groupBox1.Enabled = false;
                //groupBox2.Enabled = false;


                if (game_timer.Enabled)
                {
                    game_timer.Start();
                    letter_timer.Start();
                }
                else
                {
                    game_timer.Enabled = true;
                    letter_timer.Enabled = true;
                    button_stop.Visible = true;
                    ShowNextLetter();
                }
            }
            else if (radioButton2.Checked)
            {
                button_start.Enabled = false;
                textBox_timer.Enabled = false;
                button_stop.Visible = true;
                ShowNextLetter();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label_remaining.Text = remainingTime.ToString();
            progressBar1.Value = remainingTime;
            if (remainingTime <= 0)
            {
                End_Game();
            }
        }

        private char GetRandomRussianLetter()
        {
            // ��������� ��������� ����� �������� ��������
            const string russianAlphabet = "��������������������������������";
            int index = random.Next(russianAlphabet.Length);
            return russianAlphabet[index];
        }

        private char GetRandomEnglishLetter()
        {
            // ��������� ��������� ����� ����������� ��������
            const string englishAlphabet = "qwertyuiopasdfghjklzxcvbnm";
            int index = random.Next(englishAlphabet.Length);
            return englishAlphabet[index];
        }

        private void ShowNextLetter()
        {
            char randomLetter = ' ';

            if (radioButton_russian.Checked) { randomLetter = GetRandomRussianLetter(); }
            else if (radioButton_english.Checked) { randomLetter = GetRandomEnglishLetter(); }

            label_letter.Text = randomLetter.ToString().ToUpper();
            if (radioButton1.Checked) { letter_timer.Start(); }
        }

        private void letter_timer_Tick(object sender, EventArgs e)
        {
            ShowNextLetter();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (game_timer.Enabled)
            {
                char pressedKey = e.KeyChar.ToString().ToLower()[0];
                char displayedLetter = label_letter.Text.ToLower()[0];
                if (pressedKey == displayedLetter) // ���� ������� ������
                {
                    userScore++;
                    label_user_score.Text = userScore.ToString();
                    letter_timer.Stop();
                    ShowNextLetter();
                }
            }
            else if (radioButton2.Checked) // ���� ����������, �� ������ ���������� ����� �����
            {
                char pressedKey = e.KeyChar.ToString().ToLower()[0];
                char displayedLetter = label_letter.Text.ToLower()[0];
                if (pressedKey == displayedLetter)
                {
                    ShowNextLetter();
                }
            }

        }

        private void End_Game()
        {
            game_timer.Enabled = false;
            letter_timer.Enabled = false;

            button_start.Enabled = true;
            button_stop.Visible = false;
            textBox_timer.Enabled = true;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

            progressBar1.Value = 0;
            label_letter.Text = "���";
            label_user_score.Text = "0";

            MessageBox.Show("���� ��������!\n" + "���������� ������: " + userScore.ToString());
            userScore = 0;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            End_Game();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
    }
}