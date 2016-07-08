function solve(args){
    var size = +args[0],
        board = args.slice(2,2+size),
        moves = args.slice(3+size);


    function ParsePosition(pos){
        var posReturn = [];

        posReturn[0] = +(pos[0].charCodeAt() - 97);
        posReturn[1] = +pos[1]-1;
        return posReturn;

    }
console.log(ParsePosition("d1"));
}


solve([
    '3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'
])