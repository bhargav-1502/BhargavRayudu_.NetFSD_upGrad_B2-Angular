const WeatherURL = "https://api.open-meteo.com/v1/forecast?latitude=17.3850&longitude=78.4867&current_weather=true";

const fetchWeatherPromise = () => {
    fetch(WeatherURL)
        .then(response => {
            if (!response.ok) {
                throw new Error("Network response was not OK");
            }
            return response.json();
        })
        .then(data => {
            const weather = data.current_weather;

            console.log(`
Weather Report
---------------------------------
Temperature: ${weather.temperature}°C
Wind Speed: ${weather.windspeed} km/h
Wind Direction: ${weather.winddirection}°
`);
        })
        .catch(error => {
            console.error(`Error: ${error.message}`);
        });
};

fetchWeatherPromise();