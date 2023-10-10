// Do-While Challenge 
// author: Richard Kiddle
// date: 2023-10-10

/*
write code that validates integer input from the user

Before the iteration block: your solution must use a Console.WriteLine() statement 
to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement 
to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement 
to inform the user that their input value has been accepted.
*/


int numericValue = 0;
bool validNumber = false;

while (validNumber == false)
{
    Console.WriteLine("Please enter an integer value between 5 and 10");
    string readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (numericValue < 5 || numericValue > 10)
    {
        validNumber = false;
    }
}

Console.WriteLine($"Your input value of {numericValue} has been accepted.");


