# Hw1
## 實作loadash函數，用傳統作法、BDD、TDD的方式進行實作
### 聲明
* 程式和測試不會的有去詢問徐仁鴻同學後由自己寫上
### 傳統做法:sumby
* 先寫程式再寫測試
* [sumby.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/sumby.js)
```
export function sumBy(Array, iteratee) {
    var sum=0;
    for (var i=0; i<Array.length; i++){
        sum += Array[i][iteratee];
    } 
    return sum;
}
```
* [test1.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/test/test1.js)
```
 import * as _ from '../sumby.js'

//import _ from "https://dev.jspm.io/lodash";
var objects = [{ 'n': 4 }, { 'n': 2 }, { 'n': 8 }, { 'n': 6 }];
 
var a = _.sumBy(objects, function(o) { return o.n; });
console.log(a)
// => 20
// The `_.property` iteratee shorthand.
var b =  _.sumBy(objects, 'n');
console.log(b)
// => 20
```
* 執行結果

![pic](https://github.com/www-abcdefg/sa110a/blob/master/pic/hw1/test1.png)

## BDD:sortedLastIndexOf
* 先寫規格，再寫測試，最後再寫程式
* 規格
```
// _.sortedLastIndexOf([4, 5, 5, 5, 6], 5);
// => 3
```
* [test2.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/test/test2.js)
```
import * as _ from "../sortedLastIndexOf.js";
import{assert} from "https://deno.land/std@0.108.0/testing/asserts.ts"

// _.sortedLastIndexOf([4, 5, 5, 5, 6], 5);
// => 3

Deno.test("sortedLastIndexOf", () => {
    assertEquals(_.sortedLastIndexOf([4, 5, 5, 5, 6], 5), 3)
  })

```
* [sortedLastIndexOf.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/sortedLastIndexOf.js)
```
export function sortedLastIndexOf(Array, value) {
  for(var i = Array.length-1; i>=0; i--){
      if(Array[i] == value){
          return i;
      }
  }
  return -1;
}
```
* 執行結果

![pic](https://github.com/www-abcdefg/sa110a/blob/master/pic/hw1/test2.png)

### TDD:size
* 先寫測試再寫程式
* [test3.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/test/test3.js)
```

import * as _ from '../size.js';
import { assertEquals } from "https://deno.land/std@0.63.0/testing/asserts.ts";

// console.log(_.size([1, 2, 3]))
// => 3
 
// console.log(_.size({ 'a': 1, 'b': 2 }))
// => 2
 
// console.log(_.size("pebbles"))
// => 7
Deno.test("size", () => {
    assertEquals(_.size([1, 2, 3]), 3)
    assertEquals(_.size({ 'a': 1, 'b': 2 }), 2)
    assertEquals(_.size("pebbles"), 7)
  })
```
* [size.js](https://github.com/www-abcdefg/sa110a/blob/master/HW/HW1/size.js)
```
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
```
* 執行結果

![pic](https://github.com/www-abcdefg/sa110a/blob/master/pic/hw1/test3.png)