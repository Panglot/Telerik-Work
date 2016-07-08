"use strict";
function solve(params) {
    let result='';
    for(let i = params[0].length-1; i>-1; i-=1){
        result+=params[0][i];
    }
    console.log(result);
}

solve([ 'sample' ]);
