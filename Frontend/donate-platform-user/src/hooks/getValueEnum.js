
export const getValueEnum = collection=>
    Object.values(collection).map(item => ({ label: item, value: item }))