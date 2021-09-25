import * as _ from '../some.js'
import{assert} from "https://deno.land/std@0.108.0/testing/asserts.ts";
Deno.test("some",()=>{
    console.log("_.inRange(3,2,4) :",_.inRange(3,2,4))
    console.log("_.inRange(4, 8) :",_.inRange(4, 8))
    console.log("_.inRange(4, 2) :",_.inRange(4, 2))
    console.log("_.inRange(2, 2) :",_.inRange(2, 2))
    console.log("_.inRange(1.2, 2) :",_.inRange(1.2, 2))
    console.log("_.inRange(5.2, 4) :",_.inRange(5.2, 4))
    console.log("_.inRange(-3, -2, -6) :",_.inRange(-3, -2, -6))
    })