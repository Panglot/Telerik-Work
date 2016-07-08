function solve(args) {
    var arr = args[0].split('\n');
    var maxSeq = 1;
    var currSeq = 1;

    for (var i = 1; i < arr.length; i++) {
        if (arr[i] === arr[i+1]) {
          currSeq +=1;
        }
        else {
          if (maxSeq<currSeq) {
            maxSeq = currSeq;
          }
          currSeq=1;
        }

    }
    console.log(maxSeq);
}

solve(['8\n7\n3\n2\n3\n4\n2\n2\n4'])
