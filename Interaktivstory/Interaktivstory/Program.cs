using System;
using System.Runtime.Versioning;

string choice = "";

Console.WriteLine("Du är påväg hem, du är på samma stig du tar varje dag");
Console.WriteLine("Du kommer till en sväng, du brukar alltid gå åt höger");
Console.WriteLine("Väljer du att gå åt vänster och gå på äventyr eller går du åt höger");
Console.WriteLine("Går du höger eller vänster");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
    Console.WriteLine("Du tar den bekanta höger vägen och undviker äventyret");
    Console.WriteLine("Du ser inget ovanligt påväg hem");
    Console.WriteLine("Du är hemma nu och sitter i soffan");

}
else if (choice == "vänster")
{
    Console.WriteLine("Du går åt vänster");
    Console.WriteLine("Efter några minuter känner du dig konstig");
    Console.WriteLine("Går du bak och går hem eller fortsätter du fram");
    Console.WriteLine("Fram eller bak?");

    choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "fram")
    {
        Console.WriteLine("Du fortsätter frammåt och hittar en kista med pengar");
    }

    else if (choice == "bak")
    {
        Console.WriteLine("Du vänder om men dör av en fågel påväg tillbaka");

    }

    choice = Console.ReadLine();
    choice = choice.ToLower();

}

Console.ReadLine();