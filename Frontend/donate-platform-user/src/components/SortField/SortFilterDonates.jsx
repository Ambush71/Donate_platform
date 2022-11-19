import React from "react";
import {Panel} from "rsuite";
import "./SortFilteDonates.css"

const sortFilterDonates = ()=> {
    return (
        <Panel className="SortFilterPanel" shaded>
        <div>Sort by</div>
            <div>Filter by</div>
        </Panel>
    );
}
export default sortFilterDonates;
