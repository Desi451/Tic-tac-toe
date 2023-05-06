using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Kolko_Krzyzyk
{
    public static class Methods
    {

        public static List<Button> Fields = new List<Button>();

        static int move = 0;

        public static int GetMove()
        {
            return move;
        }

        public static int SetMove(int _move) => move = _move;

        public static int IncrementMove() => move++;

        public static int CheckWin(List<Button> Fields)
        {
            if (Fields[0].Text == "O" && Fields[1].Text == "O" && Fields[2].Text == "O"
               || Fields[3].Text == "O" && Fields[4].Text == "O" && Fields[5].Text == "O"
               || Fields[6].Text == "O" && Fields[8].Text == "O" && Fields[7].Text == "O"
               || Fields[0].Text == "O" && Fields[3].Text == "O" && Fields[6].Text == "O"
               || Fields[1].Text == "O" && Fields[4].Text == "O" && Fields[7].Text == "O"
               || Fields[2].Text == "O" && Fields[5].Text == "O" && Fields[8].Text == "O"
               || Fields[0].Text == "O" && Fields[4].Text == "O" && Fields[8].Text == "O"
               || Fields[2].Text == "O" && Fields[4].Text == "O" && Fields[6].Text == "O")
            {
                foreach (var button in Fields)
                {
                    button.Enabled = false;
                }
                MessageBox.Show("Circle wins!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Fields[0].Text == "X" && Fields[1].Text == "X" && Fields[2].Text == "X"
                || Fields[3].Text == "X" && Fields[4].Text == "X" && Fields[5].Text == "X"
                || Fields[6].Text == "X" && Fields[8].Text == "X" && Fields[7].Text == "X"
                || Fields[0].Text == "X" && Fields[3].Text == "X" && Fields[6].Text == "X"
                || Fields[1].Text == "X" && Fields[4].Text == "X" && Fields[7].Text == "X"
                || Fields[2].Text == "X" && Fields[5].Text == "X" && Fields[8].Text == "X"
                || Fields[0].Text == "X" && Fields[4].Text == "X" && Fields[8].Text == "X"
                || Fields[2].Text == "X" && Fields[4].Text == "X" && Fields[6].Text == "X")
            {
                foreach (var button in Fields)
                {
                    button.Enabled = false;
                }
                MessageBox.Show("X wins!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (move == 9)
            {
                MessageBox.Show("Draw", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return 1;
        }
    }
}
