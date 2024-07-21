using PhoneBook.Services;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

Console.WriteLine("* Q - exit\r\n* A - add\r\n* GP - Get by phone (display all info)\r\n* GN - Get by name (display only names)\r\n* GA - Get all (display ordered by name)\r\n* D - delete by phone");
while (true)
{
    string ConsoleInput = Console.ReadLine();
    switch (ConsoleInput)
    {
        case "Q":
            Environment.Exit(0);
            break;
        case "A":
            PhoneService.Add();
            break;
        case "GP":
            PhoneService.GetByPhone();
            break;
        case "GN":
            PhoneService.GetByName();
            break;
        case "GA":
            PhoneService.GetAll();
            break;
        case "D":
            PhoneService.DeleteByPhone();
            break;
        default:
            break;
    }
}