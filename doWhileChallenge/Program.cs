
// ask for user input
string? userInput;
bool validInput = false;
Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    // read user input
    userInput = Console.ReadLine();

    if (userInput != null)
    { 
        // ensure input is a valid integer
        int toInteger = 0;
        bool isInteger = false;

        isInteger = int.TryParse(userInput, out toInteger);

        // ask for user input if integer value isn't between 5 and 10
        if ( toInteger >= 5 && toInteger <= 10 ){
            validInput = true;
        } else {
            Console.WriteLine("Sorry, you entered an invalid number. Enter an integer value between 5 and 10");   
        }
       
    } else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
} while (validInput == false);

Console.WriteLine($"Your input value {userInput} has been accepted.");


