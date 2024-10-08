Random coin = new Random ();

int coinFlip = coin.Next(0, 2);

Console.WriteLine( (coinFlip == 0 ) ? "heads" : "tails");

// challenge Using Booolean ecpressin
string permission = "Admin";
int level = 57;

if (permission.Contains("Admin") && level > 55 ){
    Console.WriteLine("Welcome, Super Admin user.");
} else if (permission.Contains("Admin") && level <= 55){
    Console.WriteLine("Welcome, Admin user.");
} else if (permission.Contains("Manager") && level >= 20){
    Console.WriteLine("Contact an Admin for access.");
} else if (permission.Contains("Manager") && level < 20){
    Console.WriteLine("You do not have sufficient privileges.");
} else  {Console.WriteLine("You do not have sufficient privileges.");
};