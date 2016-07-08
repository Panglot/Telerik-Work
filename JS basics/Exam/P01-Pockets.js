"use strict";
function solve(params) {
   let input = params[0].split(' ').map(Number),
       sum = 0;

    for(let i = 0; i<input.length; i+=1){
        if(
            isPocket(
                input[i-2],
                input[i-1],
                input[i],
                input[i+1],
                input[i+2]))
        {sum+=input[i];}
    }
    console.log(sum);

    function isPocket(twoBehind, oneBehind, zero, one, two) {
       if(
           twoBehind === undefined ||
           oneBehind === undefined ||
           zero === undefined ||
           one === undefined ||
           two === undefined
        ) {return false;}

        if(
            ((oneBehind>twoBehind)&& (oneBehind>zero))
            &&
            ((one>zero)&&(one>two))
        ){return true;}
        else { return false;}
    }

}
solve([
    "53 20 1 30 2 40 3 10 1"
]);


//  regex for removing empty spaces /\s\s+/g