using SWCBank;

partial class Program
{
    public static int takeUserNumericalInput()
    {
        int parsedInput;
        while(!Int32.TryParse(ReadLine(), out parsedInput)) {
            WriteLine("You have not entered a valid number." +
                "\nPlease try again.");
        }
        return parsedInput;
    }
}