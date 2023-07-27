

Console.WriteLine("Please provide a list of names seperated by commas and no spaces between the names");
string data  = Console.ReadLine();

string[] names = data.Split(',');

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Welcome {names[i]}");
}
