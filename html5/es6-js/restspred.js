add=function (...nums){//rest operator take 
    let total=0;
    for( let n of nums){
        total+=n;
    }
    console.log(total);
}   

add(1,1,1,1)
add(9,10)
add(9,9,9)
add("hello"," ","World!")

let arr=[5,5,5];

add(5,5,...arr)

let cop=[...arr];//spred oprator to copy
arr[2]=10;
console.log(cop)



const emp={
    "eid":101,
    "ename":"Ravi"
}

const copyemp={...emp};
emp.ename="Kvita";

console.log(emp);
console.log(copyemp)