import './styles/App.css'
import NavBar from "./components/UI/navbar/Navbar";
import DonateItem from "./components/UI/donateBox/DonateItem";
import {useState} from "react";
import AppRouter from "./components/AppRouter";
import {BrowserRouter, Router} from "react-router-dom";
import sortFilterDonates from "./components/SortField/SortFilterDonates"
import {DonateContext} from "./context";


const supplier = {0:'Армія', 1:'Цивільні'}
const needs = {0:'Транспорт', 1:'Спорядження', 2:'Їжа', 3:'Одяг',4:'Ліки',5:'Інше'}

const docType = {0:'Студентський квиток',1:'Паспорт України',2:'Закордонний паспорт',3:'Водійське посвідчення'}

function App() {
    const [isAuth, setIsAuth] = useState(false);
    const [isLoading, setIsLoading] = useState(true)
  return (
        <DonateContext.Provider value={{
            isAuth,
            setIsAuth,
            isLoading,
            supplier,
            needs,
            docType
        }}>
        <BrowserRouter>
            <NavBar/>
            <AppRouter/>
        </BrowserRouter>
        </DonateContext.Provider>
  );
}

export default App;
