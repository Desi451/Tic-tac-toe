using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        int timeGame = 0;
        int gameScore = 1;
        int gameID = 0;
        public Form1(int tG, int gS, int ID)
        {
            InitializeComponent();
            timeGame = tG;
            gameScore = gS;
            gameID = ID;
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            timeGame++;
            czasGry.Text = "Czas gry: " + timeGame.ToString() + "minut";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //EndGame();
            MessageBox.Show("Wynik gry nr: " + gameID + "\nLiczba punktów: " + gameScore + "\nCzas rozgrywki: " + timeGame,"Statystyki",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public void restartGame()
        {
            timeGame = 0;
            gameTime.Start();
        }

        public void EndGame()
        { 
            gameTime.Stop();
            MessageBox.Show("Koniec gry twój wynik to: " + "tutaj dac trzeba zmienna wyniku" + "\nCzas rozrywki: " + timeGame + " minut/a",
            "Gra", MessageBoxButtons.OK, MessageBoxIcon.Information  );
        }
    }

    public class Statistics : Form1
    {
        public Statistics(int tG, int gS, int ID) : base (tG, gS, ID)
        {
            
        }
    }

}
