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
            settingsPanel.Visible= false;
        }

        int turn = 0; // 0 = kolko 1 = krzyzk
        string znak; // 
        int ruch = 0;
        List<Button> fields = new List<Button>();

        private void Pole0_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole0.Text = znak;
            Pole0.Enabled = false;
            CheckWin();
        }

        private void Pole1_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole1.Text = znak;
            Pole1.Enabled = false;
            CheckWin();
        }

        private void Pole2_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole2.Text = znak;
            Pole2.Enabled = false;
            CheckWin();
        }

        private void Pole3_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole3.Text = znak;
            Pole3.Enabled = false;
            CheckWin();
        }

        private void Pole4_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole4.Text = znak;
            Pole4.Enabled = false;
            CheckWin();
        }

        private void Pole5_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole5.Text = znak;
            Pole5.Enabled = false;
            CheckWin();
        }

        private void Pole6_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole6.Text = znak;
            Pole6.Enabled = false;
            CheckWin();
        }
        private void Pole7_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole7.Text = znak;
            Pole7.Enabled = false;
            CheckWin();
        }

        private void Pole8_Click(object sender, EventArgs e)
        {
            ChangeTurn();
            Pole8.Text = znak;
            Pole8.Enabled = false;
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
                KtoWygral.Text = "Wygrał Kolko";
                MessageBox.Show("Koniec Gry", "Informacja",MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult wynik = MessageBox.Show("Czy chcesz zagrać ponownie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wynik == DialogResult.Yes)
                {
                    restart();
                }
                else if (wynik == DialogResult.No)
                {
                    return;
                }
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
                 KtoWygral.Text = "Wygrał krzyzyk";
                MessageBox.Show("Koniec Gry", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult wynik = MessageBox.Show("Czy chcesz zagrać ponownie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wynik == DialogResult.Yes)
                {
                    restart();
                }
                else if (wynik == DialogResult.No)
                {
                    return;
                }
            }
            else if (ruch == 9)
            {
                KtoWygral.Text = "Remis";
                MessageBox.Show("Koniec Gry", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult wynik= MessageBox.Show("Czy chcesz zagrać ponownie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(wynik == DialogResult.Yes)
                {
                    restart();
                }
                else if(wynik == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void restart()
        {
            KtoWygral.Text = "";
            ruch = 0;
            turn = 0;
            znak = "";
            Pole0.Enabled = true;
            Pole1.Enabled = true;
            Pole2.Enabled = true;
            Pole3.Enabled = true;
            Pole4.Enabled = true;
            Pole5.Enabled = true;
            Pole6.Enabled = true;
            Pole7.Enabled = true;
            Pole8.Enabled = true;
            Pole0.Text = znak;
            Pole1.Text = znak;
            Pole2.Text = znak;
            Pole3.Text = znak;
            Pole4.Text = znak;
            Pole5.Text = znak;
            Pole6.Text = znak;
            Pole7.Text = znak;
            Pole8.Text = znak;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible= true;
        }
    }
}
