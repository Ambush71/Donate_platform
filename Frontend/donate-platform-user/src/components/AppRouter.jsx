import React from 'react';
import {Route, Routes} from "react-router-dom";
import About from "../pages/About";
import News from "../pages/News";
import SelfProfile from "../pages/SelfProfile";
import Donates from "../pages/Donates";
import NotFound from "../pages/NotFound";
import Registration from "../pages/Registration";
import Login from "../pages/Login"
import PostDonate from "../pages/PostDonate";

const AppRouter = () => {

    return (
            <Routes>
                <Route path='/about' element={<About/>}/>
                <Route path='/news' element={<News/>}/>
                <Route path='/register' element={<Registration/>}/>
                <Route path='/login' element={<Login/>}/>
                <Route path='/profile' element={<SelfProfile/>}/>
                <Route path='/donates' element={<Donates/>}/>
                <Route path='*' element={<NotFound/>}/>
                <Route path='/createDonate' element={<PostDonate/>}/>
            </Routes>
    );
};

export default AppRouter;