export function sumBy(Array, iteratee) {
    var sum=0;
    for (var i=0; i<Array.length; i++){
        sum += Array[i][iteratee];
    } 
    return sum;
}