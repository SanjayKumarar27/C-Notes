var games=['Cricket','Hockey','Polo']

// games.push('chess')

// games.splice()

// games.slice()

// var newgame=games.toSpliced()


// games.fill()
// games[4]='football'
// var num=[1,2,3,4,5]
// var j=games.join("->");
// console.log(j)
// // const newArr = num.flatMap(x => [x, x * 10]);
// const newArr2 = num.flatMap(x => x+1);

// var a=games.slice(1,3)



// const myArr = [[1,2],[3,4],[5,6]];
// const newArr = myArr.flat();
// console.log(a);
// console.log(newArr);




// console.log(games,typeof games)
// console.log(games[0])


// console.log("For loop .......................................")
// for(var i=0;i<games.length;i++){
//     console.log(games[i])
// }

// console.log("While loop .......................................")
// var j=0;
// while(j<games.length){
//     console.log(games[j])
//     j++;
// }

// console.log("do While  loop .......................................")
// var k=0;
// do{
//     console.log(games[k]);
//     k++;
// }while(k<games.length)





// console.log("For IN loop .......................................")
// for(var i in games){
//     console.log(i,games[i])
// }


// var games=['Cricket','Hockey','Polo']
// function print(v,i,arr){
//     console.log(v,i,arr);
// }



// games.forEach(print);

// forEach -> higer order funtions
// print-> the callback fuuntion



//Anonyomous
// print=function (v,i,arr){
//     console.log(v,i,arr);
// }

// games.forEach(print)


games.forEach(function (v,i,arr){
    console.log(v,i,arr);
}
);
