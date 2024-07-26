import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './Login.jsx';
import './index.css'


ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
        <App />
  </React.StrictMode>,
)

/*import {
    BrowserRouter as Router,
    Routes,
    Route
} from 'react-router-dom';
import Login from '.src/Login';
//import About from './components/About';

function App() {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Login />} />
                {*//*<Route path="/about" element={<About />} />*//*}
                {*//* Add more routes as needed *//*}
            </Routes>
        </Router>
    );
}

export default App;*/