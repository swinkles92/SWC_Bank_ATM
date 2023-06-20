using SWCBank;

partial class Program
{
    static ATM SelectATMLocation(ATM_Hub hub)
    {
        int num;
        ATM? chosenATM;
        do
        {
            WriteLine("Enter the number of the desired ATM location from the list below:");
            foreach (ATM atm in hub.connected_ATMs)
            {
                WriteLine($"{atm.id_Num}: {atm.location}");
            }
            while (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("Please enter a valid number!");
            }
        } while (!(num >= 1) && !(num <= hub.connected_ATMs.Count));
        chosenATM = hub.connected_ATMs.Where(x => x.id_Num.Equals(num))
        return chosenATM;
    }
}