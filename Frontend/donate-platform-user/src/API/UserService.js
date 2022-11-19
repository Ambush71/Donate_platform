import React from 'react';
import axios from 'axios';

const baseUrl = "https://localhost:7089/api"


export const loginUser = async (user)=>{
    return await axios.get(`${baseUrl}/Login`,user,{
        headers:{
            'Content-Type': 'application/json'
        }
    }).then(res=>console.log(res));
}

export const registerUser = async ( user)=>{
    await axios.post(`${baseUrl}/Resister`,user, {
        headers:{
            'Content-Type': 'application/json'
        }
    }).then(res=>console.log(res));
}


export const updateUser = async (user)=>{
    await axios.put(`${baseUrl}/Donates`,user).then(res=>console.log(res));
}