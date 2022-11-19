import React from 'react';
import DonateItem from "./UI/donateBox/DonateItem";
import "../styles/DonatesList.css"
import sortFilterDonates from "./SortField/SortFilterDonates";

const DonateList = ({donates}) => {
    return (
        <div className="DonatesList">

            {donates.map((d, index) =>{
                    return( <DonateItem key={index} donate={d}/>)
                }
                )}
        </div>
    );
};
export default DonateList