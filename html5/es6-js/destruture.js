// let arr=[67,98,45,88,42]

// let a1=arr[0];
// let b1=arr[1];

// console.log(a1,b1);
// // 
// // let [,,,a,b]=arr;//destuctureing in js
// // let [a,b,...c]=arr;//destuctureing in js
// let [,,...c]=arr;//destuctureing in js
// console.log(c);


const emp={
    "eid":101,
    "ename":"RAvi",
    "sal":55000
}

// let {eid,ename}=emp;
// console.log(eid,ename)

let {eid,...rem}=emp; //destrutring using rest operatore
//rest is when accepting the 
//spread is when we are copying /putting values in to other variable
console.log(eid,rem)