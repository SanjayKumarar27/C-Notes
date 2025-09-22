class Demo{
    // a=10;//not supported in older version only in new version


    #a=10;
    b={
        "eid":101,
        "ename":"sanjay"
    }
    constructor(p){ //no class name is used in construtor
        this.a=p;
    }
    disp(){
        console.log("this is a class",this.a)
    }
}
let a=new Demo(10);
console.log(a.a);
a.disp();
console.log(a,typeof a)//class type is object 
