using SW.Shared;

partial class Program
{
    public static int TakeUserNumericalInput()
    {
        int parsedInput;
        while(!Int32.TryParse(ReadLine(), out parsedInput)) {
            WriteLine("You have not entered a valid number." +
                "\nPlease try again.");
        }
        return parsedInput;
    }
}