// See https://aka.ms/new-console-template for more information

using static System.Console;

var welcomeText = """
Welcome to the Dog Age Calculator!

This program allows you to calculate your age in dog years, based on the commonly held belief that one human year is equivalent to seven dog years.

Simply enter your age in years, and the program will convert it to the equivalent age in dog years.

Whether you're a dog lover or just curious about your canine age, this program is for you! So, let's get started and find out how old you are in dog years!
""";
WriteLine(welcomeText);
Write("Enter your age: ");

var userAge = Convert.ToInt32(Read());

var dogAge = Math.Ceiling(16 * Math.Log(userAge) + 31);

var concludingText = $"""
Thank you for using the Dog Age Calculator! Based on your input, your age in dog years is {dogAge}.

We hope you found this program useful and informative. If you have any feedback or suggestions, please let us know.

Have a great day!
""";

WriteLine(concludingText);