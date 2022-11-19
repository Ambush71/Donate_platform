import React, {useEffect, useState} from "react";
import {useFetching} from "../hooks/useFetching";
import {createDonate, getDonates} from "../API/DonateService"
import DonateList from "../components/DonateList"
import PageContent from "../components/UI/PageContent";
import sortFilterDonates from "../components/SortField/SortFilterDonates";

  function Donates() {
    const [donates, setDonates] = useState([]);
    const fetchDonates = useFetching( async(param) => {
        const response = await getDonates()
        setDonates([...donates, ...response.data.donates])
    })


    useEffect(() => {
        fetchDonates.fetching()
    },[])

    return (
        <>
        <sortFilterDonates/>
            <></>
        <PageContent><DonateList donates={donates}/></PageContent>
        </>
    );
}
export default Donates;
