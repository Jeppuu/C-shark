using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moominQuiz
{
    public partial class Form1 : Form
    {
        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 6;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again!"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch (qnum)   //Let's make the questions
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.muumilaakso;

                    labelQuestion.Text = "Where do the moomins live?";

                    button1.Text = "Moominvalley";
                    button2.Text = "Moomin Town";
                    button3.Text = "The Mymble Village";
                    button4.Text = "The Beach";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.nyyti;

                    labelQuestion.Text = "What is the name of this character?";

                    button1.Text = "Tryffle";
                    button2.Text = "Toffle";
                    button3.Text = "Mymble";
                    button4.Text = "Hemulen";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.lautta;

                    labelQuestion.Text = "What do the moomins desire most out of these?";

                    button1.Text = "Money";
                    button2.Text = "Fame";
                    button3.Text = "Be like others";
                    button4.Text = "Freedom";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.muumipappa;

                    labelQuestion.Text = "What is Moominpappa's hobby?";

                    button1.Text = "Collecting stamps";
                    button2.Text = "Photography";
                    button3.Text = "Writing";
                    button4.Text = "Cooking";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.sillalla;

                    labelQuestion.Text = "What instrument does Snufkin play?";

                    button1.Text = "Harmonica";
                    button2.Text = "Ukulele";
                    button3.Text = "Trumpet";
                    button4.Text = "Maracas";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.uimaan;

                    labelQuestion.Text = "Who does NOT live in the moomin house?";

                    button1.Text = "Moomintroll";
                    button2.Text = "Moominmamma";
                    button3.Text = "Stinky";
                    button4.Text = "Ancestor";

                    correctAnswer = 3;

                    break;
            }
        }

      }
 }
