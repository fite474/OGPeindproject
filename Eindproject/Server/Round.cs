using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Round
    {
        public string Player1Choice { get; set; }
        public string Player2Choice { get; set; }
        public bool RoundOver { get; set; }
        public bool Player1Won { get; set; }
        public bool Draw { get; set; }
        
        public Round()
        {
            Player1Choice = "niets";
            Player2Choice = "niets";
            Draw = false;
        }

        /*
         * Rock:
         *   Weaknessess: Spock, Paper
         *   Strengths: Scissors, Lizard
         * 
         * Paper:
         *   Weaknessess: Lizard, Scissors
         *   Strengths: Rock, Spock
         * 
         * Scissors:
         *   Weaknessess: Spock, Rock
         *   Strengths: Paper, Lizard
         * 
         * Spock:
         *   Weaknessess: Lizard, Paper
         *   Strengths: Scissors, Rock
         * 
         * Lizard:
         *   Weaknessess: Scissors, Rock
         *   Strengths: Spock, Paper
         */
        public void CheckWinner()
        {
            if(Player1Choice != "niets" && Player2Choice != "niets")
            {
                switch(Player1Choice)
                {
                    case "Rock":
                        {
                            if(Player2Choice == "Rock")
                            {
                                Draw = true;
                            }
                            if (Player2Choice == "Spock")
                                Player1Won = false;
                            if (Player2Choice == "Paper")
                                Player1Won = false;
                            if (Player2Choice == "Scissors")
                                Player1Won = true;
                            if (Player2Choice == "Lizard")
                                Player1Won = true;
                            break;                                
                        }
                    case "Paper":
                        {
                            if (Player2Choice == "Paper")
                            {
                                Draw = true;
                            }
                            if (Player2Choice == "Spock")
                                Player1Won = true;
                            if (Player2Choice == "Rock")
                                Player1Won = true;
                            if (Player2Choice == "Scissors")
                                Player1Won = false;
                            if (Player2Choice == "Lizard")
                                Player1Won = false;
                            break;
                        }

                    case "Scissors":
                        {
                            if (Player2Choice == "Scissors")
                            {
                                Draw = true;
                            }
                            if (Player2Choice == "Spock")
                                Player1Won = false;
                            if (Player2Choice == "Rock")
                                Player1Won = false;
                            if (Player2Choice == "Paper")
                                Player1Won = true;
                            if (Player2Choice == "Lizard")
                                Player1Won = true;
                            break;
                        }
                    case "Spock":
                        {
                            if (Player2Choice == "Spock")
                            {
                                Draw = true;
                            }
                            if (Player2Choice == "Scissors")
                                Player1Won = true;
                            if (Player2Choice == "Rock")
                                Player1Won = true;
                            if (Player2Choice == "Paper")
                                Player1Won = false;
                            if (Player2Choice == "Lizard")
                                Player1Won = false;
                            break;
                        }
                    case "Lizard":
                        {
                            if (Player2Choice == "Lizard")
                            {
                                Draw = true;
                            }
                            if (Player2Choice == "Spock")
                                Player1Won = true;
                            if (Player2Choice == "Rock")
                                Player1Won = false;
                            if (Player2Choice == "Paper")
                                Player1Won = true;
                            if (Player2Choice == "Scissors")
                                Player1Won = false;
                            break;
                        }
                }
                RoundOver = true;
            }
        }

        public void Reset()
        {
            player1Choice = "niets";
            player2Choice = "niets";
            roundOver = false;
            player1Won = false;
            draw = false;
        }

    }
}
