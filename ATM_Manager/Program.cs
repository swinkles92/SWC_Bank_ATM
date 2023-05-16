using SWCBank;

ATM_Hub hub = new();
hub.startHub();

WriteLine("Enter the number of the desired ATM location from the list below:");
foreach(ATM atm in hub.connected_ATMs)
{
    WriteLine($"{atm.id_Num}: {atm.location}");
}
int userLocationSelection;
int.TryParse(ReadLine(), out userLocationSelection);
WriteLine($"You have selected {userLocationSelection}");