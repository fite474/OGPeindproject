using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Score
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public Score()
        {
            Player1Score = 0;
            Player2Score = 0;
        }

        public void GivePoint(int player)
        {
            if(player == 1)
            {
                Player1Score++;
            }
            else if(player == 2)
            {
                Player2Score++;
            }
        }

        public void Reset()
        {
            Player1Score = 0;
            Player2Score = 0;
        }
    }
}
