



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

if(userChoice == 1 || userChoice == 4)
{
    
}

if(userChoice == 2 || userChoice == 4)
{
    
}

if(userChoice == 3 || userChoice == 4)
{
    
}

if(userChoice <= 0 || userChoice >= 6)
{
    System.Console.WriteLine("Please choose a number from 1 to 5!");
}