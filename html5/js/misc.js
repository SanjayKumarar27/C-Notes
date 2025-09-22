// var a=new Number(10);
// var b=new Number(10);

var b=10;

// console.log(a==b); //this check only value
//                     // this compares refrences of the Number Object so it give false for above

// console.log(a===b);//this checks datatype also 
//                      // this compares refrences of the Number Object so it give false for above


// var s1='str1';
// var s2="str2";
// var s3=`str3 ${b}`;//this ES6
// //to use ' inside ' use \
// //same for "
// //oter char 

// console.log(s1,typeof s1)
// console.log(s2,typeof s2)
// console.log(s3,typeof s3)


// const minute = 1000 * 60;
// const hour = minute * 60;
// const day = hour * 24;
// const year = day * 365;
//Number of years from 1970
// var d=Date.now();
// console.log(d/year)


var d=new Date("2003-04-27")

console.log(d.getDate());
console.log(d.getFullYear());
console.log(d.getTime());
console.log(d.getTimezoneOffset());
console.log(d.getHours());
// console.log();





