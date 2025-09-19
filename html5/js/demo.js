

// function add (a){//currying in javascript
//     return function(b){
//         return function(c){
//             return a+b+c
//         }
//     }
// }
// function sum(a,d){//currying in javascript
//     return function(b){
//         return function(c){
//             return a+b+c+d
//         }
//     }
// }
// // var one=add(1);
// // var two=one(2);
// // var three=two(3);

// const { captureOwnerStack } = require("react");

// // console.log(two(20));

// console.log(add(1)(20)(30),sum(10,10)(10)(20))


//closure scope in scope where varable in side funtion is accesible inside multiple funtions
// var a=10;

// function outer(){
//     console.log(a)
//     var a=20;
//     function inner(){
//         var a=10;
//         console.log(a)
//     }
//     function secondinner(){
//         function inner(){
//             console.log("full inner")
//         }
//         inner();
//     }
//     inner();
//     console.log(a)
//    secondinner();
// }
// outer();
// console.log(a);




var a=10;

function funca(){
   var b=30;
   console.log(a);
    return function(){
        console.log(a);
        console.log(b)

    }
}

funca()();
// console.log(funca(1)(2));
// console.log(a)