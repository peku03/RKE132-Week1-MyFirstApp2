//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Please enter your name:");
//string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation

Console.WriteLine($"Priviet motherfucker, {userName} !");