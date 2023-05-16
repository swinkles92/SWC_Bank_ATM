namespace SWCBank;

public class ATM
{
    public int id_Num { get; set; }
    public decimal cash_On_Hand { get; set; }
    public string? location { get; set; }

    public void DisplayOptions()
    {
        WriteLine("Welcome to SWC Bank!");
        WriteLine("Please enter the number of your desired " +
            "transaction from the list below:");
        WriteLine("(1) Deposit cash");
        WriteLine("(2) Withdraw cash");
        WriteLine("(0) End session");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ATM"/> class.
    /// </summary>
    /// <param name="id_Num">Identification number of the ATM</param>
    /// <param name="cash_On_Hand">Amount of cash (dollars) currently held
    /// inside the ATM</param>
    /// <param name="location">Physical location (city) of the ATM</param>
    public ATM(int id_Num, decimal cash_On_Hand, string location)
    {
        this.id_Num = id_Num;
        this.cash_On_Hand = cash_On_Hand;
        this.location = location;
    }

    /// <summary>
    /// Default initialization for an instance of the <see cref="ATM"/> class.
    /// </summary>
    public ATM()
    {
    }
}
