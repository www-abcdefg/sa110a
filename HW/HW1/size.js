export function size(collection) {
    if(collection instanceof Object){
        var counts=0;
        for(var co in collection){
            if(Object.prototype.hasOwnProperty.call(collection, co)){
                counts++;
            }
        }
        return counts;
    }
    if(collection instanceof Array){
        return collection.length;
    }
    return collection.length;
}