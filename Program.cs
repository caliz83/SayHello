//Elizabeth Garcia
//8/6/2022
//      Mini Challenge 1: Say Hello
//Create a brand new console project where you are asked your name. YOu will then print out the following: "Hello <name entered>." )Name entered should be 
//the variable the user types in. 
//Reviewed by: Saul
//Comments: Code works great! You're just missing the play again loop.

string yourName;

Console.WriteLine("What is your name?");
yourName = Console.ReadLine();
Console.WriteLine("Hello, " + yourName +".");