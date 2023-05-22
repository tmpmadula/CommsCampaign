import React, { useState } from 'react';
import { createMessage } from '../services/api';

const MessageForm = () => {
  const [description, setDescription] = useState('');
  const [messageText, setMessageText] = useState('');
  const [active, setActive] = useState(false);

  const handleSubmit = async (e) => {
    e.preventDefault();

    const messageData = {
      description,
      messageText,
      active,
    };

    try {
      const response = await createMessage(messageData);
      console.log(response.data); // Handle success response
    } catch (error) {
      console.error(error); // Handle error response
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Description:
        <input
          type="text"
          value={description}
          onChange={(e) => setDescription(e.target.value)}
        />
      </label>
      <label>
        Message Text:
        <input
          type="text"
          value={messageText}
          onChange={(e) => setMessageText(e.target.value)}
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
      <button type="submit">Create Message</button>
    </form>
  );
};

export default MessageForm;
