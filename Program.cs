//Elizabeth Garcia
//8/6/2022
//      Mini Challenge 1: Say Hello
//Create a brand new console project where you are asked your name. YOu will then print out the following: "Hello <name entered>." )Name entered should be 
//the variable the user types in. 
//Reviewed by: Saul
//Comments: Code works great! You're just missing the play again loop.

bool letsPlay = true;

while(letsPlay == true)
{
string yourName;

Console.WriteLine("What is your name?");
yourName = Console.ReadLine();
Console.WriteLine("Hello, " + yourName +".");

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}
