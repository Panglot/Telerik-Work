 function solve(args){
    var imputFrow = args[0].split(' ').map(Number);
        field = [],
        i = 0,
        j = 0,
        counter = 1,
        position = args[1].split(' ').map(Number),
        moves = [],
        points = 0,
        jumps = 0,
        move = 0,
        caught = false;


     for(i = 0; i<imputFrow[0]; i+=1){
         var temparr = [];
         for(j=0;j<imputFrow[1];j+=1){
             temparr.push({num: counter, visited: false});
             counter+=1;
         }
         field[i] = temparr;
     }
     points = field[position[0]][position[1]].num;
     field[position[0]][position[1]].visited = true;
     counter = 0;

     for(i=2; i< args.length; i+=1){
         moves[counter] = args[i].split(' ').map(Number);
         counter+=1;
     }


     for(;;){
         position[0] += moves[move][0];
         position[1] +=moves[move][1];
         move+=1;
         if(move>= moves.length){move = 0};
         jumps +=1;

         if (field[position[0]][position[1]] === undefined){ break; }
         else if(field[position[0]][position[1]].visited === true){
             caught = true;
             break;
         }

         points += (field[position[0]][position[1]]).num;

     }

     if(caught){
         console.log("caught " + jumps);
     }else{
         console.log("escaped " + points);
     }
 }


 solve([
     '6 7 3',
     '0 0',
     '2 2',
     '-2 2',
     '3 -1'
 ])