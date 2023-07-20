namespace BlazorTrainungJuli229055.Data
{
    public class Weather1
    {
        private WeatherForecastService wfs;
        public Weather1(WeatherForecastService _wfs)
        {
            wfs = _wfs;
        }
    }
}
