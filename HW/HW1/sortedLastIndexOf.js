export function sortedLastIndexOf(Array, value) {
  for(var i = Array.length-1; i>=0; i--){
      if(Array[i] == value){
          return i;
      }
  }
  return -1;
}