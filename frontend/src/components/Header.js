import React from 'react';
import { Navbar, Nav, Container, NavDropdown } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';

const Header = () => {

  return (
    <header>
      <Navbar bg='dark' variant='dark' expand='lg' collapseOnSelect>
        <Container>
          <LinkContainer to='/'>
            <Navbar.Brand>Vega</Navbar.Brand>
          </LinkContainer>
          <Navbar.Toggle aria-controls='basic-navbar-nav' />
          <Navbar.Collapse id='basic-navbar-nav'>
          <Nav className='mr-auto'>
                <LinkContainer to='/vehicle/new'>
                  <Nav.Link>
                    <i className='fa fa-plus mr-1'></i>New Vehicle
                  </Nav.Link>
                </LinkContainer>
            </Nav>

            <Nav className='ml-auto'>
                <LinkContainer to='/login'>
                  <Nav.Link>
                    <i className='fas fa-user mr-1'></i>Sign In
                  </Nav.Link>
                </LinkContainer>
                <LinkContainer to='/register'>
                  <Nav.Link>
                    <i className='fas fa-user-plus mr-1'></i>Register
                  </Nav.Link>
                </LinkContainer>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </header>
  );
};

export default Header;
