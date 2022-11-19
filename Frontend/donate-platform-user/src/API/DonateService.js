import React from 'react';
import axios from 'axios';

const baseUrl = "https://localhost:7089/api"

export const getDonates = async ()=>{
    return await axios.get(`${baseUrl}/Donates`)
}

export const getDonateById = async (id)=>{
    return await axios.get(`${baseUrl}/Donates/${id}`)
}

export const createDonate = async ( donate)=>{
    console.log(typeof donate)
    console.log(donate)
    await axios.post(`${baseUrl}/Donates`,donate, {
        headers:{
            'Content-Type': 'application/json'
        }
    }).then(res=>console.log(res));
}

export const deleteDonate = async (id)=>{
    await axios.delete(`${baseUrl}/Donates`).then(res=>console.log(res));
}

export const updateDonate = async (donate)=>{
    await axios.put(`${baseUrl}/Donates`,donate).then(res=>console.log(res));
}