import {createIconFont} from "@rsuite/icons";
import HomeIcon from "@rsuite/icons/legacy/Home";
import { Navbar, Nav } from 'rsuite';
import React from 'react';
import "../../../styles/Navbar.css"
import {useNavigate} from "react-router-dom";

const IconFont = createIconFont({
    scriptUrl: '//at.alicdn.com/t/font_2144422_r174s9i1orl.js',
    commonProps: { style: { fontSize: 30, color: 'white' } },
    onLoaded: () => {
        console.log('onLoaded');
    }
});

const NavBar = ()=>{
    const navigate = useNavigate();

    return(
        <Navbar>
            <Navbar.Brand href="#">Military donates</Navbar.Brand>
            <Nav>
                <Nav.Item onClick={()=>navigate("/donates")} icon={<HomeIcon />}>Головна</Nav.Item>
                <Nav.Item onClick={()=>navigate("/news")}>Новини</Nav.Item>
                <Nav.Item onClick={()=>navigate("/about")}>Про ресурс</Nav.Item>
            </Nav>
            <Nav pullRight>
                <Nav.Item onClick={()=>navigate("/login")} icon={<IconFont icon="rs-icongear-16" spin/>}>Увійти</Nav.Item>
            </Nav>
        </Navbar>
    )
}
export default NavBar