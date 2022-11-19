import React from "react";
import "../../styles/PageContent.css"

function PageContent(props) {
    return (
        <div className="PageContent">
            {props.children}
        </div>
    );
}
export default PageContent;
