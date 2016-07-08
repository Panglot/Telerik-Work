"use strict";
function solve(args) {
    var arr = args[0].split('\n').map(function(x) {
        return +x;
    });
    var len = arr.splice(0, 1);
    var pos = 0;
    var forReturn = [];
    for (var i = 0; i < len[0]; i += 1) {
        for (var j = 0; j < arr.length; j += 1) {
            if (arr[pos] > arr[j + 1]) {
                pos = j + 1;
            }
        }
        console.log(Number((arr.splice(pos, 1).reduce(function(item) {
            return item;
        }))));
        pos = 0;
    }
}
solve(['6\n3\n4\n1\n5\n2\n6']);
let a = 5;
console.log(a);
