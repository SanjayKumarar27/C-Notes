let a=10;//global --recommeded
//hositing the 
function abc(){
    let a=20;//this is funtion scope
    console.log(a);
    if(true){
        // let a=40;// this is block scope or the local scope
        console.log(a)
    }
    console.log(a);

    function b(){
        console.log(a);
    }
    b()
}
abc();
console.log(a);
