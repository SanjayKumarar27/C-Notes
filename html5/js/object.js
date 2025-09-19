//JSON
//{key:value}

//{property:value}


var emp = {
    "eid": 101,
    "ename": "Ravi"
}

console.log(emp, typeof emp)
// console.log(emp.eid,emp.ename);
// console.log(emp(eid),emp(ename));
console.log(emp["eid"], emp["ename"])
// emp=[1,2,3]

// console.log("Array is ",Array.isArray(emp))


for (var a in emp) {
    console.log(emp[a])

}

var emp2={
    "eid":101,
    "ename":"Ravi",
    "details":function(){

        var emp3={
            "eid":2,
            "ename":"sanjay",
            "details":function(){
                console.log("hello ",emp2.ename)
            }
        }
        // emp3.details()
        // var ename="Sanjay";
        console.log("hello "+emp2.ename);
        console.log(this.eid);
    }
}

emp2.details();

console.log(emp2)

