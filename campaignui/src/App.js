import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import CampaignForm from './components/CampaignForm';
import MessageForm from './components/MessageForm';

const App = () => {
  return (
    <Router>
      <nav>
        <ul>
          <li>
            <Link to="/campaign">Create Campaign</Link>
          </li>
          <li>
            <Link to="/message">Create Message</Link>
          </li>
        </ul>
      </nav>

      <Routes>
        <Route path="/campaign" element={<CampaignForm />} />
        <Route path="/message" element={<MessageForm />} />
      </Routes>
    </Router>
  );
};

export default App;
