// function abc(){
//     console.log("Standard")
// }

// abc();


// a=function (){
//     console.log("Anonymous")
// }

// a();

// //3.IIFE imdealtely invocked funtion expression

// (function (){
//     console.log("IIFE")
// })();


//Higher order funtions
//takes funtion as pararmeter
// if a funtion accepts a funtions as parametr or return a funtion then it called Higger Order funtion

function hof(fx){
    fx();
}

function abc(){
    console.log("Hello");
}

hof(abc);

// hof -> higer order funtions
// abc-> the callback fuuntion