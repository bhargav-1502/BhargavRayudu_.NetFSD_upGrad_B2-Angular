const WeatherURL = "https://api.open-meteo.com/v1/forecast?latitude=17.3850&longitude=78.4867&current_weather=true";

const fetchWeatherAsync = async () => {
    try {
        const response = await fetch(WeatherURL);

        if (!response.ok) {
            throw new Error("Failed to fetch weather data");
        }

        const data = await response.json();
        const weather = data.current_weather;

        console.log(`
Weather Report
-------------------------------------
Temperature: ${weather.temperature}°C
Wind Speed: ${weather.windspeed} km/h
Wind Direction: ${weather.winddirection}°
`);
    } catch (error) {
        console.error(`Error: ${error.message}`);
    }
};

fetchWeatherAsync();