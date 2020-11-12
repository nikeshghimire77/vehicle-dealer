import React from 'react';
import { Container } from 'react-bootstrap';
import { BrowserRouter as Router, Route } from 'react-router-dom';

import Header from './components/Header';
import Footer from './components/Footer';
import AddVehicleScreen  from './screens/AddVehicleScreen';

const App = () => {
  return (
    <Router>
      <Header />
      <main className='py-3'>
        <Container>
        <Route path='/vehicle/new' component={AddVehicleScreen} />
        </Container>
      </main>
      <Footer />
    </Router>
  );
};

export default App;
