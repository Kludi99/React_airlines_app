import { Forecast } from "../Contracts/WeatherForecasts";
import client from "./ApiClient"

export const GetForecasts = async () => {
    const response = await client.get<Forecast[]>('WeatherForecast');
    return response.data;
}