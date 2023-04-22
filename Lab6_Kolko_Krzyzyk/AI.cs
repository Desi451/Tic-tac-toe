using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Kolko_Krzyzyk
{
    internal class AI
    {
        private string aiMark;
        private string playerMark;
        private List<Button> fields;

        public AI(List<Button> fields, string aiMark, string playerMark)
        {
            this.fields = fields;
            this.aiMark = aiMark;
            this.playerMark = playerMark;
        }

        public void MakeMove()
        {
            Button fieldToMark = GetBestMove();
            fieldToMark.Text = aiMark;
            fieldToMark.Enabled = false;
        }

        private Button GetBestMove()
        {
            Button fieldToMark = null;
            int highestScore = int.MinValue;

            foreach (Button field in fields)
            {
                if (field.Enabled)
                {
                    field.Text = aiMark;
                    int score = Minimax(false);
                    field.Text = "";

                    if (score > highestScore)
                    {
                        highestScore = score;
                        fieldToMark = field;
                    }
                }
            }

            return fieldToMark;
        }

        private int Minimax(bool isMaximizingPlayer)
        {
            if (CheckWin(playerMark))
            {
                return -1;
            }

            if (CheckWin(aiMark))
            {
                return 1;
            }

            if (IsDraw())
            {
                return 0;
            }

            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;

                foreach (Button field in fields)
                {
                    if (field.Enabled)
                    {
                        field.Text = aiMark;
                        bestScore = Math.Max(bestScore, Minimax(false));
                        field.Text = "";
                    }
                }

                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;

                foreach (Button field in fields)
                {
                    if (field.Enabled)
                    {
                        field.Text = playerMark;
                        bestScore = Math.Min(bestScore, Minimax(true));
                        field.Text = "";
                    }
                }

                return bestScore;
            }
        }

        private bool CheckWin(string mark)
        {
            if (fields[0].Text == mark && fields[1].Text == mark && fields[2].Text == mark
               || fields[3].Text == mark && fields[4].Text == mark && fields[5].Text == mark
               || fields[6].Text == mark && fields[8].Text == mark && fields[7].Text == mark
               || fields[0].Text == mark && fields[3].Text == mark && fields[6].Text == mark
               || fields[1].Text == mark && fields[4].Text == mark && fields[7].Text == mark
               || fields[2].Text == mark && fields[5].Text == mark && fields[8].Text == mark
               || fields[0].Text == mark && fields[4].Text == mark && fields[8].Text == mark
               || fields[2].Text == mark && fields[4].Text == mark && fields[6].Text == mark)
            {
                return true;
            }

            return false;
        }

        private bool IsDraw()
        {
            foreach (Button field in fields)
            {
                if (field.Enabled)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
