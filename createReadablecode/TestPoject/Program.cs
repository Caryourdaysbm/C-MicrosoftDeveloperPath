string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array 

char[] charMessage = str.ToCharArray();

// reverse the chars
Array.Reverse(charMessage);
Console.WriteLine(charMessage);

// count o in the chars
// declare a sum to save the count
int sum = 0;
foreach ( char message in charMessage ) {
    // loop through the har array and check if its letter o
    if (message == 'o' ){
        sum ++;
        }
}

Console.Write("the number of o in the text is ");
Console.WriteLine(sum);