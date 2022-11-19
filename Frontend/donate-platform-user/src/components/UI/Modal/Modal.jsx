import React from 'react';
import { Modal, Button } from 'rsuite';
import "../../../styles/Modal.css"

const DonateExpandModal = ({visible, setVisible}) => {

    const handleClose = () => setVisible(false);

    return (
        <Modal overflow={true} open={visible} onClose={handleClose}>
                <Modal.Header>
                    <Modal.Title>Modal Title</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                </Modal.Body>
                <Modal.Footer>
                    <Button color="cyan" appearance="subtle">
                        Зробити донат
                    </Button>
                </Modal.Footer>
            </Modal>
    );
};

export default DonateExpandModal