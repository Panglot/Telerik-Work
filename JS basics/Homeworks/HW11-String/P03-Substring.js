"use strict";
function solve(params) {
    let exp = new RegExp(params[0],"igm");
    let count = (params[1].match(exp) || []).length;
    console.log(count);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);