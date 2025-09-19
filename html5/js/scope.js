

// not defined is  Error 
// undefinded is datatype

//hoisting -> use of the variable before declaration is called hoisted

var a=10;//global
// abc();

function abc(){
    console.log(a);
    // var a=20;//re declaration 
    // console.log(a);
    // if(true){
    //     var a=30;//re defining no re delaration -> there is local scope only 2 scopes 
    //     //global scope
    //     //funtion scope
    // }
    if(false){
        var a=30;//declaration done but not the defination
    }

    console.log(a);
}
// var b;

abc();
console.log(a);
// console.log(b);