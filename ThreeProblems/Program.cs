Random rnd = new Random(4000);

char diceChoice;

int rolls = 1;
int wins = 1;

System.Console.WriteLine("=== Lab 06 ===");
System.Console.WriteLine("Hello! Please choose from the options below.");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");
System.Console.Write("Please select an option from above: ");

int userChoice = 0;
userChoice=Convert.ToInt32(Console.ReadLine());

while(userChoice <= 0 || userChoice >= 6)
{
    System.Console.Write("Please choose a number from 1 to 5! ");
    
    userChoice = Convert.ToInt32(Console.ReadLine());
}


if(userChoice == 1 || userChoice == 4)
{
    System.Console.WriteLine("=== The Grade Checker ===");
    System.Console.Write("Please enter a score between 0 and 100: ");
    int score = Convert.ToInt32(Console.ReadLine());
    while(score <= -1 || score >= 101)
    {
        System.Console.Write("Please enter a score between 0 and 100: ");
        score = Convert.ToInt32(Console.ReadLine());
    }
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

if(userChoice == 2 || userChoice == 4)
    
    
    do
    {
        int diceOne = rnd.Next(1, 7);
        int diceTwo = rnd.Next(1, 7);

        System.Console.WriteLine($"Roll {rolls}: {diceOne} and {diceTwo}, total {diceOne + diceTwo}");
        
        

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
       
        
        System.Console.Write("Would you like to role again? (y or n)");
        diceChoice = Convert.ToChar(Console.ReadLine());
        diceChoice = char.ToLower(diceChoice);
        
        while(diceChoice != 'y' && diceChoice != 'n')
            {
                System.Console.Write("Please choose y or n!");
                diceChoice = Convert.ToChar(Console.ReadLine());
            }
        
    }while(diceChoice != 'n');
      
     

if(userChoice == 3 || userChoice == 4)
{
    
}


