import React, {useContext, useState} from 'react';
import '../styles/PostDonate.css';
import {Panel, Form, InputNumber, Button, SelectPicker} from 'rsuite';
import {DonateContext} from "../context";
import {useFetching} from "../hooks/useFetching";
import {createDonate} from "../API/DonateService";
import getKeyEnum from "../hooks/getKeyEnum";
import {getValueEnum} from "../hooks/getValueEnum";


const PostDonate = () => {
    const{supplier, needs} = useContext(DonateContext)
    const [donate, setDonate] = useState({title: '', needs: '',supplier:'',goalSum:''});



    const postDonate = useFetching( async(donate) => {
        await createDonate(donate)
    })

    const addNewDonate = async (e) => {
        e.preventDefault()

        let donateParsed = (
            {title:donate.title,
                needs:parseInt(donate.needs),
                supplier:parseInt(donate.supplier),
                goalSum:parseInt(donate.goalSum)
            })
        await postDonate.fetching(donateParsed)
        setDonate({title: '', needs: '',supplier:'',goalSum:''})
    }


    return( <div className="CreateDonateForm">
        <Panel header="Створення донату" shaded>
            <Form className="AuthForm">
            <Form.Group controlId="name-1">
                <Form.Control formValue={donate.title} placeholder="Заголовок" name="header"
                              onChange={(value) =>
                                  setDonate({...donate, title: value})
                              }/>
            </Form.Group>
            <Form.Group controlId="name-1">
                <SelectPicker formValue={donate.supplier} placeholder="Кому" data={getValueEnum(supplier)} style={{ width: 224 }} searchable={false}
                             onChange={(value) =>
                                 setDonate({...donate, supplier: getKeyEnum(supplier,value)})
                             }/>
            </Form.Group>
            <Form.Group controlId="name-1">
                <SelectPicker formValue={donate.needs} placeholder="На що" data={getValueEnum(needs)} style={{ width: 224 }} searchable={false}
                             onChange={(value) =>
                                 setDonate({...donate, needs: getKeyEnum(needs,value)})}/>
            </Form.Group>
                <Form.Group controlId="name-1">
                    <InputNumber formValue={donate.goalSum} placeholder="Потрібна сума" defaultValue={0} step={1000}
                                 onChange={(value) =>{
                                     setDonate({...donate, goalSum: value})
                                 }
                    }/>

                </Form.Group>
                <Form.Group controlId="name-1">
                    <Button appearance="primary" type="submit" onClick={addNewDonate}>
                        Створити
                    </Button>
                </Form.Group>
            </Form>
            </Panel>
    </div>
    )
}




export default PostDonate
