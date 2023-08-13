import React, { Component } from 'react';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';

export class CreateNewHouse extends Component {
    static displayName = CreateNewHouse.name;

    render() {
        return (
            <Form>
                <Form.Group className="mb-3">
                    <Form.Label>Number</Form.Label>
                    <Form.Control type="number" placeholder="Number" />
                    <Form.Text className="text-muted">
                        This is the number of cabin
                    </Form.Text>
                </Form.Group>
                <Form.Group className="mb-3">
                    <Form.Label>Price</Form.Label>
                    <Form.Control type="number" placeholder="Enter price in USD" />
                    <Form.Text className="text-muted">
                        This is the price for a daily rental cabin
                    </Form.Text>
                </Form.Group>
                <Form.Group className="mb-3">
                    <Form.Label>Chouse Family Pet</Form.Label>
                    <Form.Select aria-label="FamilyPet">
                        <option value="0">Dog</option>
                        <option value="1">Cat</option>
                        <option value="2">Hamster</option>
                        <option value="3">Parrot</option>
                        <option value="4">Spider</option>
                        <option value="5">Lizard</option>
                    </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3">
                    <Form.Label>SizeLength</Form.Label>
                    <Form.Control type="number" placeholder="SizeLength" />
                    <Form.Text className="text-muted">
                        This is the size length of cabin
                    </Form.Text>
                </Form.Group>
                <Form.Group className="mb-3">
                    <Form.Label>SizeHeight</Form.Label>
                    <Form.Control type="number" placeholder="SizeHeight" />
                    <Form.Text className="text-muted">
                        This is the size height of cabin
                    </Form.Text>
                </Form.Group>
                <Form.Group >
                    <Form.Label>Chouse House Status</Form.Label>
                    <Form.Select aria-label="Status" >
                        <option value="0">Free</option>
                        <option value="1">Occupied</option>
                     </Form.Select>
                </Form.Group>
                <Form.Group className="mb-3 mt-3">
                    <Form.Label>Photo of House</Form.Label>
                    <Form.Control type="file" />
                </Form.Group>
               

                <Button variant="primary" type="submit" className="mt-2">
                    Submit
                </Button>
            </Form>
        );
    }
}