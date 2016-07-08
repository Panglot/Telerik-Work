function solve(params){
    var arr = params.splice(1,params.length).map(Number),
        i = 0,
        count = 1;

    for(i = 0; i < arr.length; i+=1){
                if((arr[i] > arr[i+1])){ count+=1; }
    }
    console.log(count);
}



solve([
    9,
    2,3,2,12,31,23,1
])


