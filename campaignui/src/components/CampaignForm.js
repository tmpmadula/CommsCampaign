import React, { useState } from 'react';
import { createCampaign } from '../services/api';

const CampaignForm = () => {
  const [name, setName] = useState('');
  const [description, setDescription] = useState('');
  const [active, setActive] = useState(false);

  const handleSubmit = async (e) => {
    e.preventDefault();

    const campaignData = {
      name,
      description,
      active,
    };

    try {
      const response = await createCampaign(campaignData);
      console.log(response.data); // Handle success response
    } catch (error) {
      console.error(error); // Handle error response
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Name:
        <input
          type="text"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
      </label>
      <label>
        Description:
        <input
          type="text"
          value={description}
          onChange={(e) => setDescription(e.target.value)}
        />
      </label>
      <label>
        Active:
        <input
          type="checkbox"
          checked={active}
          onChange={(e) => setActive(e.target.checked)}
        />
      </label>
      <button type="submit">Create Campaign</button>
    </form>
  );
};

export default CampaignForm;
