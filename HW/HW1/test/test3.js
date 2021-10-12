
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