import axios from "axios";

const client = axios.create({
    baseURL: 'https://localhost:7249'
});

export default client;