using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Kolko_Krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            settingsPanel.Visible = false;
            Fields.Add(Pole0); Fields.Add(Pole1); Fields.Add(Pole2); Fields.Add(Pole3); Fields.Add(Pole4);
            Fields.Add(Pole5); Fields.Add(Pole6); Fields.Add(Pole7); Fields.Add(Pole8);
        }

        int turn = 0; // 0 = kolko 1 = krzyzk
        string znak;
        int ruch = 0;
        List<Button> Fields = new List<Button>();

        private void Pole0_Click(object sender, EventArgs e)
        {
            Click(Pole0);
        }

        private void Pole1_Click(object sender, EventArgs e)
        {
            Click(Pole1);
        }

        private void Pole2_Click(object sender, EventArgs e)
        {
            Click(Pole2);
        }

        private void Pole3_Click(object sender, EventArgs e)
        {
            Click(Pole3);
        }

        private void Pole4_Click(object sender, EventArgs e)
        {
            Click(Pole4);
        }

        private void Pole5_Click(object sender, EventArgs e)
        {
            Click(Pole5);
        }

        private void Pole6_Click(object sender, EventArgs e)
        {
            Click(Pole6);
        }
        private void Pole7_Click(object sender, EventArgs e)
        {
            Click(Pole7);
        }

        private void Pole8_Click(object sender, EventArgs e)
        {
            Click(Pole8);
        }

        private void Click(Button Field)
        {
            ChangeTurn();
            Field.Text = znak;
            Field.Enabled = false;
            CheckWin();
        }

        private void ChangeTurn()
        {      
            if (turn == 0)
            {
                znak = "O";
                turn++;
            }
            else
            {
                znak = "X";
                turn--;
            }
            ruch++;
        }

        private void CheckWin()
        {
            if (
               Pole0.Text == "O" && Pole1.Text == "O" && Pole2.Text == "O"
               || Pole3.Text == "O" && Pole4.Text == "O" && Pole5.Text == "O"
               || Pole6.Text == "O" && Pole8.Text == "O" && Pole7.Text == "O"
               || Pole0.Text == "O" && Pole3.Text == "O" && Pole6.Text == "O"
               || Pole1.Text == "O" && Pole4.Text == "O" && Pole7.Text == "O"
               || Pole2.Text == "O" && Pole5.Text == "O" && Pole8.Text == "O"
               || Pole0.Text == "O" && Pole4.Text == "O" && Pole8.Text == "O"
               || Pole2.Text == "O" && Pole4.Text == "O" && Pole6.Text == "O")
            {
                WhoWon.Text = "Wygrało Kolko";
                MessageBox.Show("Koniec Gry wygrało kółko", "Informacja",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Pole0.Text == "X" && Pole1.Text == "X" && Pole2.Text == "X"
                || Pole3.Text == "X" && Pole4.Text == "X" && Pole5.Text == "X"
                || Pole6.Text == "X" && Pole8.Text == "X" && Pole7.Text == "X"
                || Pole0.Text == "X" && Pole3.Text == "X" && Pole6.Text == "X"
                || Pole1.Text == "X" && Pole4.Text == "X" && Pole7.Text == "X"
                || Pole2.Text == "X" && Pole5.Text == "X" && Pole8.Text == "X"
                || Pole0.Text == "X" && Pole4.Text == "X" && Pole8.Text == "X"
                || Pole2.Text == "X" && Pole4.Text == "X" && Pole6.Text == "X")
             {
                WhoWon.Text = "Wygrał krzyzyk";
                MessageBox.Show("Koniec Gry wygrał krzyżyk", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ruch == 9)
            {
                WhoWon.Text = "Remis";
                MessageBox.Show("Koniec Gry wyik remisowy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void restart()
        {
            WhoWon.Text = "";
            ruch = 0;
            turn = 0;
            znak = "";
            foreach(var button in Fields)
            {
                button.Enabled = true;
                button.Text = znak;
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible == true)
            {
                settingsPanel.Visible = false;
            }
            else { settingsPanel.Visible = true; }
        }

        private void RematchBtn_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
