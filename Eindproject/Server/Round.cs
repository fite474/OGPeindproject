using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Round
    {
        private string player1Choice;
        private string player2Choice;
        private bool roundOver;
        private bool player1Won;
        private bool draw;
        
        public Round()
        {
            
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
            if(player1Choice != "niets" && player2Choice != "niets")
            {
                switch(player1Choice)
                {
                    case "Rock":
                        {
                            if(player2Choice == "Rock")
                            {
                                draw = true;
                            }
                            if (player2Choice == "Spock")
                                player1Won = false;
                            if (player2Choice == "Paper")
                                player1Won = false;
                            if (player2Choice == "Scissors")
                                player1Won = true;
                            if (player2Choice == "Lizard")
                                player1Won = true;
                            break;                                
                        }
                    case "Paper":
                        {
                            if (player2Choice == "Paper")
                            {
                                draw = true;
                            }
                            if (player2Choice == "Spock")
                                player1Won = true;
                            if (player2Choice == "Rock")
                                player1Won = true;
                            if (player2Choice == "Scissors")
                                player1Won = false;
                            if (player2Choice == "Lizard")
                                player1Won = false;
                            break;
                        }

                    case "Scissors":
                        {
                            if (player2Choice == "Scissors")
                            {
                                draw = true;
                            }
                            if (player2Choice == "Spock")
                                player1Won = false;
                            if (player2Choice == "Rock")
                                player1Won = false;
                            if (player2Choice == "Paper")
                                player1Won = true;
                            if (player2Choice == "Lizard")
                                player1Won = true;
                            break;
                        }
                    case "Spock":
                        {
                            if (player2Choice == "Spock")
                            {
                                draw = true;
                            }
                            if (player2Choice == "Scissors")
                                player1Won = true;
                            if (player2Choice == "Rock")
                                player1Won = true;
                            if (player2Choice == "Paper")
                                player1Won = false;
                            if (player2Choice == "Lizard")
                                player1Won = false;
                            break;
                        }
                    case "Lizard":
                        {
                            if (player2Choice == "Lizard")
                            {
                                draw = true;
                            }
                            if (player2Choice == "Spock")
                                player1Won = true;
                            if (player2Choice == "Rock")
                                player1Won = false;
                            if (player2Choice == "Paper")
                                player1Won = true;
                            if (player2Choice == "Scissors")
                                player1Won = false;
                            break;
                        }
                }
                roundOver = true;
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
