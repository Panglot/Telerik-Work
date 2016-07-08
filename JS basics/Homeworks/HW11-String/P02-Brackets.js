"use strict";
function solve(params) {
    let counter = 0;

    for (let i = 0; i< params[0].length; i+=1){
        if(params[0][i] === '('){ counter+=1;}
        else if(params[0][i] === ')'){counter-=1;}

        if(counter<0){break;}
    }

    if(counter!=0) {console.log("Incorrect");}
    else {console.log("Correct");}
}

solve([ '((((a+b))' ]);