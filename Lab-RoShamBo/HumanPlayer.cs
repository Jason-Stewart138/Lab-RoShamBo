using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_RoShamBo
{
    public class HumanPlayer : Player
    {
        public override string GenerateRoshambo()
        {
            string userThrowOut = "";
            bool isValidInput = true;

            while (isValidInput)
            {
                string userThrow = Console.ReadLine().Trim().ToLower();
                
                if (userThrow.StartsWith("r") || userThrow.StartsWith("p") || userThrow.StartsWith("s"))
                {
                    if (userThrow == "r" || userThrow == "rock")
                    {
                        userThrowOut = "Rock";
                    }
                    else if(userThrow == "p" || userThrow == "paper")
                    {
                        userThrowOut = "Paper";
                    }
                    else if (userThrow == "s" || userThrow == "scissors")
                    {
                        userThrowOut = "Scissors";
                    }
                    isValidInput = false;
                }
                else
                {
                    Console.WriteLine("Sorry that was not a valid input, please try again.");
                    Console.WriteLine("Please select rock, paper, or scissors (r/p/s):");
                    Console.WriteLine();
                    isValidInput = true;
                }
            }
            return userThrowOut;
                       
        }
    }
}
