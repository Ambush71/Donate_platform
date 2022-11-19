
const getKeyEnum = (obj, val)=>{
    for (const key in obj) {
        if(obj[key]==val){
            console.log(key)
            return key
        }
    }
}
export default getKeyEnum

