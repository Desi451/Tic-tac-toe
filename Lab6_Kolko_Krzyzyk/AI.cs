using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab6_Kolko_Krzyzyk
{
    public class AI
    {
        private string aiMarker;
        private string playerMarker;

        public AI(string aiMarker, string playerMarker)
        {
            this.aiMarker = aiMarker;
            this.playerMarker = playerMarker;
        }

        public void MakeMove()
        {
            Random random = new Random();
            List<Button> availableFields = Methods.Fields.Where(f => f.Enabled).ToList();
            int index = random.Next(0, availableFields.Count);
            if (availableFields.Count > 0)
            {
                Button selectedField = availableFields[index];
                selectedField.Text = aiMarker;
                selectedField.Enabled = false;
                Methods.Fields[Methods.Fields.IndexOf(selectedField)].Text = aiMarker;
                Methods.Fields[Methods.Fields.IndexOf(selectedField)].Enabled = false;
                Methods.IncrementMove();
                Methods.CheckWin(Methods.Fields);
            }  
        }
    }
}
