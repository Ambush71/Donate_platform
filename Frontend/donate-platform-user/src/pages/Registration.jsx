import React, {useContext, useState} from 'react';
import '../styles/Registration.css';
import {Form, Button, Schema, Panel, SelectPicker, DatePicker} from 'rsuite';
import {DonateContext} from "../context";
import {registerUser} from "../API/UserService";
import {getValueEnum} from "../hooks/getValueEnum";
import getKeyEnum from "../hooks/getKeyEnum";


function Registration() {
    const nameRule = Schema.Types.StringType().isRequired('This field is required.');
    const emailRule = Schema.Types.StringType().isEmail('Please enter a valid email address.');
    const [user, setUser] = useState({name: '', surname: '',email:'',birth:Date.now(),
    document:'',series:'',number:'',password:''});

    const {docType} = useContext(DonateContext)

    const register = async (e) => {
        e.preventDefault()

        let userParsed = (
            {name:user.name,surname:user.surname,email:user.email,birth:user.birth,document:parseInt(user.document),
                series:user.series,password:user.password})

        await registerUser.fetching(userParsed)
        console.log(userParsed)
        setUser({name: '', surname: '',email:'',birth:'',
            document:'',series:'',number:'',password:''})
    }

    const data = ['Паспорт України', 'Закордонний паспорт', 'Студентський квиток',
        'Водійське посвідчення'].map(
        item => ({ label: item, value: item })
    );
    return (
        <div className="RegisterForm ShadowPanel">
        <Panel header="Registration" shaded>
            <Form className="AuthForm">
                <Form.Group controlId="fName">
                    <Form.Control formValue={user.name} placeholder="Ім'я" name="name" rule={nameRule}
                                  onChange={value=>{
                        setUser({...user, name: value})
                    }}/>
                </Form.Group>
                <Form.Group controlId="lName">
                    <Form.Control formValue={user.surname} placeholder="Прізвище" name="name" rule={nameRule}
                                  onChange={value=>{
                        setUser({...user, surname: value})
                    }}/>
                </Form.Group>
                <Form.Group controlId="email">
                    <Form.Control formValue={user.email} placeholder="Пошта" name="email" rule={emailRule}
                                  onChange={value=>{
                        setUser({...user, email: value})
                    }}/>
                </Form.Group>
                <Form.Group controlId="birth">
                    <DatePicker formValue={user.birth} placeholder="Дата народження" name="birth"
                                  onChange={value=>{
                        setUser({...user, birth: value})
                    }}/>
                </Form.Group>
                <Form.Group controlId="Документ">
                    <SelectPicker formValue={user.document} placeholder="Документ" data={getValueEnum(docType)} style={{ width: 300, height:"37px" }} searchable={false}
                                  onChange={value=>{
                                      setUser({...user, document: getKeyEnum(docType,value)})
                                  }}/>
                    <Form.Control formValue={user.series} placeholder="Cерія" name="series" style={{marginLeft:"20px", width: 60, height:"35px" }}
                                  onChange={value=>{
                                      setUser({...user, series: value})
                                  }}/>
                    <Form.Control formValue={user.number} placeholder="Номер" name="number" style={{marginLeft:"5px", width: 110, height:"35px" }}
                                  onChange={value=>{
                                      setUser({...user, number: value})
                                  }}/>
                </Form.Group>
                <Form.Group controlId="pass">
                    <Form.Control formValue={user.password} placeholder="Пароль" name="name" type="password" rule={nameRule}
                                  onChange={value=>{
                                      setUser({...user, password: value})
                                  }}/>
                </Form.Group>
                <Form.Group controlId="confirmPass">
                    <Form.Control placeholder="Підтвердити пароль" type="password" name="name" rule={nameRule}/>
                </Form.Group>
                <Button appearance="primary" type="submit">
                    Submit
                </Button>
            </Form>
        </Panel>
        </div>
    );
}

export default Registration