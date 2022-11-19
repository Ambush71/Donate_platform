import React from 'react';
import "../../../styles/ProgressBar.css"

import { Progress, ButtonGroup, Button, Row, Col } from 'rsuite';



const ProgressBar = ({proc})=>{
    const [percent, setPercent] = React.useState(Math.round(proc));

    const increase = () => {
        const value = Math.min(percent + 10, 100);
        setPercent(value);
    };

    const decrease = () => {
        const value = Math.max(percent - 10, 0);
        setPercent(value);
    };

    const status = percent === 100 ? 'success' : null;
    let color;
    switch (true){
        case percent<50:{
            color="red"
            break
        }
        case percent>=50&&percent<80:{
            color="yellow"
            break
        }
        default:{
            color="#52c41a"
            break
        }
    }
    return(
        <Progress.Line percent={percent} strokeColor={color} status={status} />
    );
}
export default ProgressBar