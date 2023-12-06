using System.Data.SQLite;
using System.Text.Encodings;
using System.Text.Json;

namespace testWeather2;



class Coord
{
    public double? lat { get; set; }
    public double? lon { get; set; }
}

public class City
{
    public int? id { get; set; }
    public string? name { get; set; }
    //public Coord? coord { get; set; }
    public string? country { get; set; }
    public int? population { get; set; }
    public int? timezone { get; set; }
    public int? sunrise { get; set; }
    public int? sunset { get; set; }
}

public class WeatherInfoMain
{
    public double? temp { get; set; }
    public double? feels_like { get; set; }
    public double? temp_min { get; set; }
    public double? temp_max { get; set; }
    public int? pressure { get; set; }
    public int? sea_level { get; set; }
    public int? grnd_level { get; set; }
    public int? humidity { get; set; }
    public double? temp_kf { get; set; }
}

public class WeatherInfoWeatherItem
{
    public int? id { get; set; }
    public string? main { get; set; }
    public string? description { get; set; }
    public string? icon { get; set; }
}

public class WeatherInfoWind
{
    public double? speed { get; set; }
    public int? deg { get; set; }
    public double? gust { get; set; }
}

public class WeatherInfo
{
    public int? dt { get; set; }
    public WeatherInfoMain? main { get; set; }
    public WeatherInfoWind? wind { get; set; }
    public IList<WeatherInfoWeatherItem>? weather { get; set; }
    public string? dt_txt { get; set; }

}

class WeatherForecast
{
    public string? cod { get; set; }
    public int? message { get; set; }
    public int? cnt { get; set; }
    public City? city { get; set; }
    public IList<WeatherInfo>? list { get; set; }
}

class Program
{

    private static readonly HttpClient client = new HttpClient();
    //private static string url = "http://api.openweathermap.org/data/2.5/forecast?lat=49&lon=32&appid=c78a927e31c9a6024978dac79e5fde2e&units=metric";
    public static string lat = Console.ReadLine().Trim();
    public static string lon = Console.ReadLine().Trim();
    private static SQLiteDataReader sqlite_datareader;
    private static readonly string url = $"http://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid=c78a927e31c9a6024978dac79e5fde2e&units=metric";




    async static Task Main(string[] args)

    {
        SQLiteConnection sqlite_conn;
        sqlite_conn = CreateConnection();
        CreateTable(sqlite_conn);

        //ReadData(sqlite_conn);
        //Console.WriteLine("End!");


        //Create sql Base
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sqlite_conn;
        }

        //Create sql Table
        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS City (id INTEGER PRIMARY KEY AUTOINCREMENT, lat INTEGER, lon INTEGER, country TEXT, citys TEXT)";
            string Createsql1 = "CREATE TABLE IF NOT EXISTS List (id INTEGER PRIMARY KEY ON CONFLICT REPLACE AUTOINCREMENT, data VARCHAR(20), temp INTEGER, wind INTEGER, weather TEXT, id_city INTEGER REFERENCES City (id))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
        }



        //api request
        await getWeather();

        async Task getWeather()
        {

            //string lat = Console.ReadLine().Trim();
            //string lon = Console.ReadLine().Trim();

            Console.WriteLine("Getting JSON...");
            Console.WriteLine("Please entre Lat and Lon");
            var responseString = await client.GetStringAsync(url);
            Console.WriteLine("Parsing JSON...");

            WeatherForecast? weatherForecast =
               JsonSerializer.Deserialize<WeatherForecast>(responseString);
            Console.WriteLine($"cod: {weatherForecast?.cod}");
            Console.WriteLine($"City: {weatherForecast?.city?.name}");
            Console.WriteLine($"list count: {weatherForecast?.list?.Count}");


            InsertData(sqlite_conn, weatherForecast);

            static void InsertData(SQLiteConnection conn, WeatherForecast? weatherForecast)
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT OR REPLACE INTO City (lat, lon, country, citys) VALUES({lat}, {lon}, '{weatherForecast?.city?.country}', '{weatherForecast?.city?.name}')";
                sqlite_cmd.ExecuteNonQuery();



                //string id = "SELECT COUNT(*) FROM City";
                //sqlite_cmd.CommandText = id;
                //sqlite_datareader = sqlite_cmd.ExecuteReader();

                //while (sqlite_datareader.Read())
                //{
                //    string myreader = sqlite_datareader.GetString(0);
                //    Console.WriteLine(myreader);
                //}


                foreach (var weatherInfo in weatherForecast?.list)
                {
                    //Console.WriteLine($"weather temp : {weatherInfo?.main?.temp}");
                    //Console.WriteLine($"weather temp : {weatherInfo?.weather[0]?.main}");
                    //Console.WriteLine($"weather wind speed : {weatherInfo?.wind?.speed}");
                    //Console.WriteLine($"data : {weatherInfo?.dt_txt}");

                    sqlite_cmd.CommandText = $"INSERT OR REPLACE INTO List (data, temp, wind, weather) VALUES('{weatherInfo?.dt_txt}', {weatherInfo?.main?.temp}, {weatherInfo?.wind?.speed}, '{weatherInfo?.weather[0]?.main}')";
                    sqlite_cmd.ExecuteNonQuery();


                    //foreach (var weatherInfoWeather in weatherInfo?.weather)
                    //{
                    //    Console.WriteLine($"  weather main : {weatherInfoWeather?.main}");
                    //    Console.WriteLine($"  weather description : {weatherInfoWeather?.description}");
                    //}
                }
            }

            ReadData(sqlite_conn);

        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM list";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //int id = sqlite_datareader.GetInt32(0);
                string data = sqlite_datareader.GetString(1);
                double temp = sqlite_datareader.GetDouble(2);
                string weather = sqlite_datareader.GetString(4);
                double wind = sqlite_datareader.GetDouble(3);
                //int year = sqlite_datareader.GetInt32(3);
                //int clients_id = sqlite_datareader.GetInt32(3);

                Console.WriteLine($" Data: {data}, Temp: {temp} C, Weather: {weather}, Wind: {wind} km/h");
            }
        }

    }
}
