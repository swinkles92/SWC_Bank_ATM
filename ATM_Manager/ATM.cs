namespace SW.Shared;

public class ATM
{
    // total amt of cash stored in ATM
    public decimal cash_On_Hand { get; set; }
    // total num of user-selectable options
    public static int numOptions = 3;

    /// <summary>
    /// Prints the welcome message to user.
    /// </summary>
    public void DisplayWelcomeMsg()
    {
        WriteLine("Welcome to SWC Bank!");
    }
    /// <summary>
    /// Prints the list of available options to the user.
    /// </summary>
    public void DisplayOptions()
    {
        WriteLine("Please enter the number of your desired " +
            "transaction from the list below:");
        WriteLine("(1) Deposit cash");
        WriteLine("(2) Withdraw cash");
        WriteLine("(0) End session");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ATM"/> class.
    /// </summary>
    /// <param name="cash_On_Hand">Amount of cash (dollars) currently held
    /// inside the ATM</param>
    public ATM(decimal cash_On_Hand)
    {
        this.cash_On_Hand = cash_On_Hand;
    }

    /// <summary>
    /// Default initialization for an instance of the <see cref="ATM"/> class.
    /// </summary>
    public ATM()
    {
    }
}

