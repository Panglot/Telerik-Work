"use strict";
function solve(params) {
    let field = params[0].split(' ').map(Number),
        W = {
                row: Number(params[1].split(';')[0].split(' ')[0]),
                col: Number(params[1].split(';')[0].split(' ')[1]),
                cond: "free"
        },
        N = {
            row: Number(params[1].split(';')[1].split(' ')[0]),
            col: Number(params[1].split(';')[1].split(' ')[1]),
            cond: "free"
        },
        L ={
            row: Number(params[1].split(';')[2].split(' ')[0]),
            col: Number(params[1].split(';')[2].split(' ')[1]),
            cond: "free"
        },
        move = [],
        condition = "princessSaved";
    var traps = [];

    for(let i = 2; i< params.length; i+=1){
        move = params[i].split(' ');
        if(move[0] === "mv"){
            if (move[1] === "Wboup") {
                walk(W,move[2],field);
                if (trollPrincess(W,L)) {
                    condition = "princessCaught";
                    break;
                }
                trollTraps(W,traps);
                trollRescue(W,N);
            }
            else if(move[1] === "Nbslbub") {
                walk(N,move[2],field);
                if (trollPrincess(N,L)) {
                    condition = "princessCaught";
                    break;
                }
                trollTraps(N,traps);
                trollRescue(N,W);

            }
            else if(move[1] === "Lsjtujzbo") {
                walk(L,move[2],field);
                if (princessTroll(L,W,N)) {
                    condition = "princessCaught";
                    break;
                }
                if(L[0] === field[0]-1
                    &&
                    L[1] === field[1]-1){
                    condition = "princessSaved";
                    break;
                }
            }
            }
        else{
            traps.push([L.row, L.col]);
        }
        if((W.cond === "trapped")&&(N.cond==="trapped")){
            condition = "princessSaved";
        }

    }

    function trollRescue(unit, secondUnit) {
        if((unit.row === secondUnit.row)&&(unit.col===secondUnit.col) && (secondUnit.cond === "trapped")){
            secondUnit.cond = "free";
        }

    }
    function trollTraps(unit, traps) {
        for(let i = 0; i<traps.length; i+=1) {
            if((unit.row === traps[i][0])&&(unit.col === traps[i][1])) {
                unit.cond = "trapped";
                traps.splice(i,1);
            }
        }

    }
    function trollPrincess(unit, princess) {
        let princessCaught = false;
        for(let i = -1; i<2; i+=1) {
            for(let j = -1; j<2; j+=1) {
                if((unit.col+i === princess.col)&& (unit.row+j===princess.row))
                {
                    princessCaught = true;
                    return princessCaught;
                }
            }
        }
    }
    function princessTroll(princess, unit1, unit2) {
        let princessCaught = false;
        for(let i = -1; i<2; i+=1) {
            for(let j = -1; j<2; j+=1) {
                if(((princess.col+i === unit1.col)&& (princess.row+j === unit1.row))
                ||
                    ((princess.col+i === unit2.col )&& (princess.row+j === unit2.row)))
                {
                    princessCaught = true;
                    return princessCaught;
                }
            }
        }
    }
    function walk(unit, dir, field ) {
        if(unit.cond === "trapped") {return;}

        if(dir === "l"){
            unit.col -=1;
            if (unit.col<0){unit.col+=1;}
        } else if(dir ==="u") {
            unit.row -= 1;
            if (unit.row < 0) { unit.row += 1; }
        }else if(dir ==="r") {
            unit.col += 1;
            if (unit.col > field[1]-1) {unit.col -= 1; }
        } else if(dir ==="d") {
            unit.row += 1;
            if (unit.row > field[0]-1) {  unit.row -= 1; }
        }
    }

    if(condition === "princessSaved"){
        console.log("Lsjtujzbo is saved! " +W.row.toString()
            + " " + W.col.toString()+ " "+N.row.toString()+ " "
        + N.col.toString());
    }
    else {
        console.log("The trolls caught Lsjtujzbo at " +L.row.toString()
    + " "+L.col.toString());
    }
}



solve([
    '7 7',
    '0 1;0 2;3 3',
    'mv Lsjtujzbo l',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup l',
    'mv Wboup l',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub d',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo l',
    'mv Lsjtujzbo l',
    'mv Nbslbub l',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r'
]);
