import React, {useContext, useState} from 'react';
import ProgressBar from "../progressBar/ProgressBar";
import '../../../styles/DonateItem.css';
import { Panel } from 'rsuite';
import DonateExpandModal from "../Modal/Modal";
import {DonateContext} from "../../../context";

const DonateItem = ({donate}) => {
    const[visible, setVisible] = useState(false)
    const{supplier, needs} = useContext(DonateContext)


    const getEnum = (item, ent)=>{

        for (let key in ent) {
            if(item==key){
                return ent[key]
            }
        }
    }

    const getProcentSum=(goal, current)=>{
        if(current>=goal){
            return 100
        }
        return (100*current)/goal
    }
    return(
        <div className="DonateItemBox ShadowPanel">
            <div className="DonateBox" onClick={()=>setVisible(true)}>
                <Panel header={donate.title} shaded>
                    <div className="DonateItem" style={{color:"white"}}>
                        <div className="Supplier">{getEnum(donate.supplier,supplier)}</div>
                        <div className="Needs">{getEnum(donate.needs,needs)}</div>
                        <div className="GoalSum">Потрібна сумна {donate.goalSum}</div>
                        <div className="CurrentSum">Зібрано {donate.currentSum}</div>
                       <div></div>
                    </div>
                    <ProgressBar proc={getProcentSum(donate.goalSum, donate.currentSum)}/>
                    <div style={{color:"white"}} className="Dates">{new Date(donate.createDate).toLocaleDateString()}</div>
                </Panel>
            </div>
            <DonateExpandModal visible={visible} setVisible={setVisible} donate={donate}/>
        </div>
);

}
export default DonateItem