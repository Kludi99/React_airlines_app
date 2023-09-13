import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { useQuery } from 'react-query'
import { GetForecasts } from './ApiClient/WeatherForecastClient'
import { Forecast } from './Contracts/WeatherForecasts'

const useForecasts = () => {
    return useQuery<Forecast[], any>("getForecasts", async () => await GetForecasts())
}

const renderForecast = (forecast: Forecast) => {
    return (
        <div>
            <li>Date: ${forecast.date}</li>
            <li>TemperatureC: ${forecast.temperatureC}</li>
            <li>TemperatureF: ${forecast.temperatureF}</li>
            <li>Summary: ${forecast.summary}</li>
            <br />
        </div>
    )
}

const Home = () => {
    const [count, setCount] = useState(0)
    const { status, data, error } = useForecasts()
    return (
        <>
            <div>
                <a href="https://vitejs.dev" target="_blank">
                    <img src={viteLogo} className="logo" alt="Vite logo" />
                </a>
                <a href="https://react.dev" target="_blank">
                    <img src={reactLogo} className="logo react" alt="React logo" />
                </a>
            </div>
            <h1>Vite + React</h1>
            <div className="card">
                {status === "loading" && (<p>Loading...</p>)}
                {status === "error" && (<p>{error.message}</p>)}
                {status === "success" && (<div>{data?.map((forecast) => renderForecast(forecast))}</div>)}
            </div>
            <p className="read-the-docs">
                Click on the Vite and React logos to learn more
            </p>
        </>
    )
}

export default Home;