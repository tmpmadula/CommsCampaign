import axios from 'axios';

const API_BASE_URL = 'http://localhost:5000/api'; // Update with your API base URL

export const createCampaign = (campaignData) => {
  return axios.post(`${API_BASE_URL}/campaign`, campaignData);
};

export const createMessage = (messageData) => {
  return axios.post(`${API_BASE_URL}/message`, messageData);
};
