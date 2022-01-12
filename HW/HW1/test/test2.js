import * as _ from "../sortedLastIndexOf.js";
import{assert} from "https://deno.land/std@0.108.0/testing/asserts.ts"

// _.sortedLastIndexOf([4, 5, 5, 5, 6], 5);
// => 3

Deno.test("sortedLastIndexOf", () => {
    assertEquals(_.sortedLastIndexOf([4, 5, 5, 5, 6], 5), 3)
  })
