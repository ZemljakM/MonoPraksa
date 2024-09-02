// See https://aka.ms/new-console-template for more information

using ConsoleAppPraksa;

Menu<string> menu = new Menu<string>();

while (true)
{
    menu.ShowMenu();
    var input = Console.ReadLine();
    switch(input)
    {
        case "1": 
            menu.AddNewFootballClub();
            break;
        case "2":
            menu.RemoveClub();
            break;
        case "3":
            menu.PrintAllClubs();
            break;  
        case "4":
            menu.WriteAllClubsOlderThen();
            break;
        case "5":
            menu.FilterByCity();
            break;
        case "6":
            menu.SortClubsByDateOfEstablishment();
            break;

    }
}




