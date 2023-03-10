using PasswordGenerator;

Console.WriteLine("*********************************************************");
Console.WriteLine("Welcome to the B E S T   P A S S W O R D   G E N E R A T O R");
Console.WriteLine("*********************************************************");

Console.WriteLine("Do you want to include numbers? (Y/N)");
var includeNumbers= Console.ReadLine(); 

Console.WriteLine("Ok! How about lowercase characters? (Y/N)");
var includeLowercaseLetters = Console.ReadLine();

Console.WriteLine("Very nice! How about uppercase characters? (Y/N)");
var includeUpperCaseLetters = Console.ReadLine();

Console.WriteLine("All right! We are almost done. Would you also want to add  special characters? (Y/N)");
var includeSpecialCharacters = Console.ReadLine();

Console.WriteLine("Graet! Lastly, how long do you  want to keep your password length?");
int PasswordLength = Convert.ToInt32(Console.ReadLine());


var randomPasswordGenerator = new RandomPasswordGenerator();


var Password = randomPasswordGenerator.GenerateRandomPassword(includeNumbers, includeLowercaseLetters, includeUpperCaseLetters, includeSpecialCharacters, PasswordLength);
Console.WriteLine($"Your Password  - {Password}");
   