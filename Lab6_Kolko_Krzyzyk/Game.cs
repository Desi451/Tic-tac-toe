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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            settingsPanel.Visible = false;
            Methods.Fields.Add(Pole0); Methods.Fields.Add(Pole1); Methods.Fields.Add(Pole2); 
            Methods.Fields.Add(Pole3); Methods.Fields.Add(Pole4); Methods.Fields.Add(Pole5); 
            Methods.Fields.Add(Pole6); Methods.Fields.Add(Pole7); Methods.Fields.Add(Pole8);
        }

        AI bot;
        int turn = 0;
        string mark;
        bool isAi=false;
        

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

        private new void Click(Button Field)
        {
            ChangeTurn();
            Field.Text = mark;
            Field.Enabled = false;
            Methods.Fields[Methods.Fields.IndexOf(Field)].Text = mark;
            Methods.Fields[Methods.Fields.IndexOf(Field)].Enabled = false;
            Methods.CheckWin(Methods.Fields);
            TurnAI();
        }

        private void ChangeTurn()
        {      
            if (turn == 0)
            {
                mark = "O";
                turn++;
            }
            else
            {
                mark = "X";
                turn--;
            }
            Methods.IncrementMove();
        }

        private void TurnAI()
        {
            if(isAi == true)
            {
                bot.MakeMove();
                turn--;
            }
        }

        private void restart()
        {
            Methods.SetMove(0);
            turn = 0;
            mark = "";
            foreach (var button in Methods.Fields)
            {
                button.Enabled = true;
                button.Text = mark;
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

        private void btnAI_Click(object sender, EventArgs e)
        {
            restart();
            bot = new AI("X", "0");
            isAi = true;
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            restart();
            isAi = false;
            bot = null;
        }
    }
}
