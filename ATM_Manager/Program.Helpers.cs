using SWCBank;
using Newtonsoft.Json;

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
    public async static void connectToWeatherAPI()
    {
        var client = new HttpClient();

        var request = new HttpRequestMessage(HttpMethod.Get, " https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/Paris?key=<YOUR_API_KEY>");

        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode(); // Throw an exception if error

        var body = await response.ReadAsStringAsync();
    }
}