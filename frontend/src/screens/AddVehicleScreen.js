import React, { useState } from 'react';
import { Form, Button} from 'react-bootstrap';

import FormContainer from '../components/FormContainer';

const AddVehicleScreen = () => {
  const [make, setMake] = useState('');
  const [model, setModel] = useState('');


  const submitHandler = (e) => {
    e.preventDefault();
    console.log(make)
  };

  return (
    <FormContainer>
      <h1>Add Vehicle</h1>
      <Form onSubmit={submitHandler}>
        <Form.Group controlId='make'>
          <Form.Label>Make</Form.Label>
          <Form.Control
            type='make'
            placeholder='Enter Vehicle Make'
            onChange={(e) => setMake(e.target.value)}
          ></Form.Control>
        </Form.Group>

        <Form.Group controlId='model'>
          <Form.Label>Model</Form.Label>
          <Form.Control
            type='text'
            placeholder='Enter Vehicle Model'
            onChange={(e) => setModel(e.target.value)}
          ></Form.Control>
        </Form.Group>

        <Button type='Add' variant='primary'>
          Add Vehicle
        </Button>
      </Form>
    </FormContainer>
  );
};

export default AddVehicleScreen;
