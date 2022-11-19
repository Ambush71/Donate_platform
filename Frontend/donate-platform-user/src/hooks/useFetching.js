import {useState} from "react";

export const useFetching = (callBack) => {
    const [isLoading, setIsLoading] = useState(false)
    const [error, setError] = useState('')

    const fetching = async (obj) => {
        try {
            setIsLoading(true)
            await callBack(obj)
        } catch (error) {
            setError(error.message)
        } finally {
            setIsLoading(false)
        }
    }
    return {fetching, isLoading, error}
}

