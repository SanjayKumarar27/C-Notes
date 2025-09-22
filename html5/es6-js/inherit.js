class parent{
    constructor(){
        console.log("P cons")
    }
    disp(){
        console.log("parent");
    }
    disp(a){
        console.log("parent ",a);
    }
}

class child extends parent{
    constructor(){
        super();//this should be called before creting child constructor

        console.log("C Cons")
    }
    disp(){
        console.log("Child")
    }
}


let c=new child();
c.disp()

let p=new parent();
p.disp(10);