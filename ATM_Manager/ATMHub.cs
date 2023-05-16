namespace SWCBank;

public class ATM_Hub
{
    public HashSet<ATM> connected_ATMs = new();

    /// <summary>
    /// Initializes the ATM Hub by initializing 3 unique ATMs and
    /// adding them to the Hub's HashSet.
    /// </summary>
    public void startHub()
    {
        ATM atm1 = new(
            id_Num: 1,
            cash_On_Hand: 5000,
            location: "Albuquerque");
        connected_ATMs?.Add(atm1);

        ATM atm2 = new(
            id_Num: 2,
            cash_On_Hand: 5000,
            location: "Las Vegas");
        connected_ATMs?.Add(atm2);

        ATM atm3 = new(
            id_Num: 3,
            cash_On_Hand: 5000,
            location: "San Diego");
        connected_ATMs?.Add(atm3);
    }
}
