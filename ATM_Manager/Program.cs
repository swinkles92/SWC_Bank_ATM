using Newtonsoft.Json;
using Microsoft.Data.Sqlite;
using SW.Shared;

// Setup HttpClient for later use
var client = new HttpClient();

// Instantiate ATM object with default starting cash amt & display welcome msg
ATM atm = new ATM(1000);
atm.DisplayWelcomeMsg();

// Connect to Visual Crossing's Web API to display today's weather report
var request = new HttpRequestMessage(HttpMethod.Get,
    "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/" +
    "services/timeline/Albuquerque/today?key=BE5A2P7RAMQ7LGKEH8NEZPVTP");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
var body = await response.Content.ReadAsStringAsync();
dynamic weather = JsonConvert.DeserializeObject(body);

// The weather object contains an array of day data objects. Since we only
// requested weather info for today; only one day object exists at pos [0].
var day = weather.days[0];
// The following are various data points gathered from the day object.
// More info on these and more can be found at:
// https://www.visualcrossing.com/resources/documentation/weather-api/timeline-weather-api/
string weather_desc = day.description;
string weather_tmax = day.tempmax;
string weather_tmin = day.tempmin;

WriteLine("Today's Albuquerque forecast is:");
WriteLine(" " + weather_desc);
WriteLine(" With a high of " + weather_tmax + "\u00B0F");
WriteLine(" and a low of " + weather_tmin + "\u00B0F");

SqliteConnection conn = CreateConnection();
ReadData(conn);