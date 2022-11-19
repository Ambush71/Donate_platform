import {Button, Form, Panel} from "rsuite";
import React from "react";
import "../styles/Login.css"
import {Link} from "react-router-dom";

const Login = ()=>{

    return(
        <div className="ShadowPanel">
            <Panel className="LoginPanel" header="Login" >
                 <Form className="LoginForm">
                     <Form.Group controlId="email">
                        <Form.Control placeholder="Пошта" name="email" />
                     </Form.Group>
                        <Form.Group controlId="pass">
                            <Form.Control placeholder="Пароль" name="name" type="password" />
                        </Form.Group>
                        <Button appearance="subtle" type="submit" style={{border:"2px solid #033485",boxShadow: "0px -3px 20px black"}}>
                            Увійти
                        </Button>

                 </Form>
                <Link to="/Register" className="RegLink">Зареєструватися</Link>
            </Panel>
        </div>
    )
}
export default Login