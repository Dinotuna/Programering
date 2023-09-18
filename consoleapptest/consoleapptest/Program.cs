
Console.WriteLine("Vad heter du");
string name = Console.ReadLine().ToLower();


if (name == "micke")
{
    Console.WriteLine("välkommen");
}
else if (name == "typ micke")
{
    Console.WriteLine("Typ välkommen");
}
else
{
    Console.WriteLine("inte välkommen");
}

Console.ReadLine();