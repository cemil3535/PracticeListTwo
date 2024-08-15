// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

// List of identify
List<string> coffeeNames = new List<string>();

 
// user get coffe names. that appointment list
for(int i = 0; i < 5; i++)
{
    string userInput;
    Console.Write($"Lutfen {i + 1}'inci Kahve Ismini Giriniz: ");
    userInput = Console.ReadLine();
    coffeeNames.Add(userInput);
}

// coffe name console write
int counter = 1;
foreach (string coffeeNameItem in coffeeNames)
{
    Console.WriteLine($"Kahve {counter}: {coffeeNameItem}");
    counter++;
}



