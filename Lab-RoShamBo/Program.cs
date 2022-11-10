using System;
using Lab_RoShamBo;

string opponentSelection = "";
string opponentThrow = "";
string randomPlayer = "Random Ryan";
string rockPlayer = "Predictable Pete";
bool keepPlaying = true;

Console.WriteLine("Time To Play Rock Paper Scissors!");
Console.WriteLine();



HumanPlayer humanPlayer = new HumanPlayer();
humanPlayer.Name = GetUserName();

while (keepPlaying)
{
    opponentSelection = ChooseAnOpponent(randomPlayer, rockPlayer);
    

    Console.WriteLine();

    Console.WriteLine("Please select rock, paper, or scissors (r/p/s):");
    humanPlayer.RoshamboValue = humanPlayer.GenerateRoshambo();
    Console.WriteLine();

    if (opponentSelection == randomPlayer)
    {
        RandomPlayer randomPlayer1 = new RandomPlayer();
        randomPlayer1.Name = opponentSelection;
        randomPlayer1.RoshamboValue = randomPlayer1.GenerateRoshambo();
        opponentThrow = randomPlayer1.RoshamboValue;
    }
    else
    {
        RockPlayer rockPlayer1 = new RockPlayer();
        rockPlayer1.Name = opponentSelection;
        rockPlayer1.RoshamboValue = rockPlayer1.GenerateRoshambo();
        opponentThrow = rockPlayer1.RoshamboValue;
    }

    Console.WriteLine($"{humanPlayer.Name}: {humanPlayer.RoshamboValue}");
    Console.WriteLine($"{opponentSelection}: {opponentThrow}");
    Console.WriteLine($"Result: {DetermineWinner()}");
    Console.WriteLine();
    keepPlaying = TryAgain("play again?");
}


string DetermineWinner()
{
    int humanThrow;

    if(humanPlayer.RoshamboValue == "Rock")
    {
        humanThrow = 1;
    }else if (humanPlayer.RoshamboValue == "Paper")
    {
        humanThrow = 2;
    }
    else
    {
        humanThrow = 3;
    }
    Roshambo userThrow = (Roshambo)humanThrow;

    switch (userThrow)
    {
        case Roshambo.Rock:
            if (opponentThrow == "Rock")
            {
                return "Draw";
            }
            else if (opponentThrow == "Paper")
            {
                return "Lose";
            }
            else
            {
                return "Win";
            }
        case Roshambo.Paper:
            if (opponentThrow == "Rock")
            {
                return "Win";
            }
            else if (opponentThrow == "Paper")
            {
                return "Draw";
            }
            else
            {
                return "Lose";
            }
        case Roshambo.Scissors:
            if (opponentThrow == "Rock")
            {
                return "Lose";
            }
            else if (opponentThrow == "Paper")
            {
                return "Win";
            }
            else
            {
                return "Draw";
            }
    }
    return "scratch";
}


string ChooseAnOpponent(string randomPlayer, string rockPlayer)
{
    bool isValidInput = true;

    while (isValidInput)
    {
        Console.WriteLine($"Please choose an opponent, {randomPlayer} or {rockPlayer} (p/r)");
        string opponentSelectionRaw = Console.ReadLine().ToLower().Trim();
        if (opponentSelectionRaw.Contains("p") || opponentSelectionRaw.Contains("r"))
        {
            if (opponentSelectionRaw.Contains("p"))
            {
                opponentSelection = rockPlayer;
            }
            else
            {
                opponentSelection = randomPlayer;
            }
            isValidInput = false;
        }
        else
        {
            Console.WriteLine("Sorry that was not a valid input, please try again.");
            isValidInput = true;
        }
    }
    return opponentSelection;
}

string GetUserName()
{
    Console.WriteLine("Please Enter Your Name To Continue");
    string userName = Console.ReadLine();
    if (userName == null || userName == "")
    {
        Console.WriteLine("You must enter your name to continue");
        Console.ReadKey();
        Console.Clear();
        GetUserName();
    }
    return userName;
}

bool TryAgain(string typeOfRepeat)
{
    bool goAgain = false;
    bool isValidInput = true;

    while (isValidInput)
    {
        Console.WriteLine($"Would you like to {typeOfRepeat}(y/n)?");
        string input = Console.ReadLine().ToLower().Trim();
        if (input.Contains("y") || input.Contains("n"))
        {
            goAgain = input == "y" || input == "yes";
            isValidInput = true;
            Console.Clear();
            return goAgain;
        }
        else
        {
            Console.WriteLine("Sorry that was not a valid input, please try again.");
            isValidInput = true;
        }
    }
    return true;
}
