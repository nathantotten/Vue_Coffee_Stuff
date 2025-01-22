import axios from "axios";

const httpClient = axios.create({
    baseURL: 'http://localhost:5142/',
    headers: {
      'Content-Type': 'application/json',
    },
});

export default httpClient