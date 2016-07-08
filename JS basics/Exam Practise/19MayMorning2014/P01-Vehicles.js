function solve(params){
    var tires = Number(params[0]),
        car = 4,
        truck = 10,
        trike = 3,
        first = 0,
        second = 0,
        third= 0,
        sum = 0,
        count = 0;

    for(first = 0; first< tires/car +1; first+=1){
        for( second = 0; second< tires/truck +1; second+=1){
            for (third = 0; third<tires/trike +1; third+=1){
                sum = (first*car) + (second*truck) + (third*trike);
                if(sum === tires){count+=1;}
            }
        }
    }
    console.log(count);
}


solve([40]);

