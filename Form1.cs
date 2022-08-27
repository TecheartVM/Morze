using System;
using System.Drawing;
using System.Windows.Forms;

namespace Morze
{
    public partial class Form1 : Form
    {
        private bool keyPressed = false;

        public Form1()
        {
            InitializeComponent();
            outputDisplay.ForeColor = Color.DarkGreen;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            processInput(e.KeyChar);
        }

        public void setQuestion(string question, string answ)
        {
            keyPressed = false;
            questionDisplay.Text = question;
            inputDisplay.Text = "";
            inputDisplay.ForeColor = Color.Black;
            outputDisplay.Visible = false;
            outputDisplay.Text = answ;
        }

        private void processInput(char input)
        {
            if (keyPressed) return;
            if (Char.IsLetter(input))
            {
                keyPressed = true;
                inputDisplay.Text = input.ToString();
                if(Program.IsCorrectAnswer(input))
                {
                    inputDisplay.ForeColor = Color.DarkGreen;
                }
                else
                {
                    inputDisplay.ForeColor = Color.DarkRed;
                    outputDisplay.Visible = true;
                }
                Program.RunTimer();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.SetQuestion();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.OnExit();
        }
    }
}
