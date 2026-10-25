/*
* Name: Your William Ayscue
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 24, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

//Random object declared totaly outside the loop so the dice rolls don't reset while the program runs
Random rnd = new Random(4000);

//User choice must be declared outside the Do While, otherwise the While won't recognize it
int userChoice = 0;

//The first loop. This is here so the user has the chance to choose more than one option. It reruns the menue at the end of the program until the user exits
do
{
System.Console.WriteLine("=== Lab 06 ===");
System.Console.WriteLine("Hello! Please choose from the options below.");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");
System.Console.Write("Please select an option from above: ");

userChoice=Convert.ToInt32(Console.ReadLine());

//This loop refuses inncorect selections. If the user tries to enter anything outisde the menue, the program refuses to move on
while(userChoice <= 0 || userChoice >= 6)
{
    System.Console.Write("Please choose a number from 1 to 5! ");
    
    userChoice = Convert.ToInt32(Console.ReadLine());
}

//Each of the three if loops checks the userChoice value to see if they should run. Without these the menue is usless
//This is the first exercise, the grade checker. It calcualtes a letter grade based on a percent score
if( userChoice == 1 || userChoice == 4)
{
    System.Console.WriteLine("=== The Grade Checker ===");
    System.Console.Write("Please enter a score between 0 and 100: ");
    int score = Convert.ToInt32(Console.ReadLine());

    //Refuses nonsese again, just like the one in the beginning
    while(score <= -1 || score >= 101)
    {
        System.Console.Write("Please enter a score between 0 and 100: ");
        score = Convert.ToInt32(Console.ReadLine());
    }

    //This chain of loops checks the value of the grade. Whichever is the first to evaluate to true is the one that gets used.
    //Besides an A, if you ran from greatest to least then you would always get a B, because it would always be less than 89
    if(score >= 90)
    {
        System.Console.WriteLine("Your grade is A.");
    }
    else if(score <= 59)
    {
        System.Console.WriteLine("Your grade is F.");
    }
    else if(score <= 69)
    {
        System.Console.WriteLine("Your grade is D.");
    }
    else if(score <= 79)
    {
        System.Console.WriteLine("Your grade is C.");
    }
    else if(score <= 89)
    {
        System.Console.WriteLine("Your grade is B.");
    }
    
    
}

System.Console.WriteLine();

//Another exercise loop: See the description of the first if loop above
//This is the second exersise. It rolls a pair of dice, tells us the result, and counts the number of rolls and wins
if(userChoice == 2 || userChoice == 4)
{
    System.Console.WriteLine("=== The Dice Table ===");
    char diceChoice;
    int rolls = 0;
    int wins = 0;

    //The do while loop continues to run until the breaking condition is met. It then stops running and the program moves to the next line
    do
    {
        int diceOne = rnd.Next(1, 7);
        int diceTwo = rnd.Next(1, 7);

        System.Console.WriteLine($"Roll {rolls + 1}: {diceOne} and {diceTwo}, total {diceOne + diceTwo}");
        
        
            //Another loop chain, this one instructs the program what to say in response to the result of the roles
            if(diceOne == 1 && diceTwo == 1)
                {
                System.Console.WriteLine("Snake Eyes!");
                }
            else if(diceOne == diceTwo)
                {
                System.Console.WriteLine("Doubles!");
                }
            else if(((diceOne + diceTwo) == 7) || ((diceOne + diceTwo) == 11))
                {
                System.Console.WriteLine("A winner!");
                wins++;
                }
        rolls++;
       
        
        System.Console.Write("Would you like to role again? (y or n) ");
        diceChoice = Convert.ToChar(Console.ReadLine());
        diceChoice = char.ToLower(diceChoice);
        

        //Anohter nonsense refusing loop: see the description of the while loop above
        while(diceChoice != 'y' && diceChoice != 'n')
            {
                System.Console.Write("Please choose y or n! ");
                diceChoice = Convert.ToChar(Console.ReadLine());
            }
    //Refuses nonsense    
    }while(diceChoice != 'n');

    System.Console.WriteLine($"You rolled {rolls} times and won {wins}");
      
}    

System.Console.WriteLine();

//Another exercise loop
//This is the third exersise. It takes in an array of scores up to 15, and then claculates various statistics about those scores
if(userChoice == 3 || userChoice == 4)
{
    System.Console.WriteLine("=== The Score Report ===");
    int passingScores = 0; 
    double totalScores = 0;
    double average = 0;
    double highest = 0;
    System.Console.Write("How many scores would you like to enter? (15 score limit) ");
    int scoreLengh = Convert.ToInt32(Console.ReadLine());
    double[] scores = new double[scoreLengh];

    //Another nonsense refusing loop
    while(scoreLengh <= 1 || scoreLengh > 15)
        {
            System.Console.Write("Please enter a number between 2 and 15 ");
            scoreLengh = Convert.ToInt32(Console.ReadLine());
        }
    //This loop forces a maximum lengh for the array. If a number is entered above 15, the program runs this line, and that number is reduced to 15
    //This loop doesen't care about required values. It really isn't necassary since there is a while loop above
    if(scoreLengh > 15)
    {
        scoreLengh = 15;
    }
    
    //This loop runs through the entire array, and unlike foreach, it allows the program to pick from a certain location
    //In this case everything operates by the Ith location, but you could substitute any value for I and that is the location that would be displayed
    for(int i = 0; i < scoreLengh; i++)
    {

        //This is one last chain loop. It jumps down from top to bottom. The first to be true is the one to be used
        if(i == 0)
        {
         System.Console.Write($"Please enter the {i + 1}st score ");
         scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        else if(i == 1)
        {
         System.Console.Write($"Please enter the {i + 1}nd score ");
         scores[i] = Convert.ToInt32(Console.ReadLine()); 
        }
        else if(i == 2)
        {
         System.Console.Write($"Please enter the {i + 1}rd score ");
         scores[i] = Convert.ToInt32(Console.ReadLine());   
        }
        else
        {
         System.Console.Write($"Please enter the {i + 1}th score ");
         scores[i] = Convert.ToInt32(Console.ReadLine()); 
        }      
        
    }

    //Another loop that runs through the whole array based on location
    for(int i = 0; i < scoreLengh; i++)
    {
        System.Console.WriteLine($"Score {i + 1}: {scores[i]}");
    }

    //This runs through the array but does not track location. It splits the scores into a temporary variable called "score" in this case
    //We can use this loop to do various claculations that do not require a location
    foreach (double score in scores)
    {
        totalScores += score;
        average = totalScores / scoreLengh;
        highest = Math.Max(highest, score);     
        
        //This keeps track of the passing score. When true, the program increments the variable inside by one
        if(score > 60)
        {
            passingScores++;
        }
        
    }  

    System.Console.WriteLine($"Total: {totalScores}");  
    System.Console.WriteLine($"Average: {(average).ToString("F1")}");
    System.Console.WriteLine($"Highest: {highest}");
    System.Console.WriteLine($"Passing {passingScores} of {scoreLengh}");
}

//This is the last part of the Do while. This is the breaking condition. Once it evaluates to true, the program moves down to the end.
}while(userChoice != 5);

System.Console.WriteLine();

System.Console.WriteLine("Goodbye!");
