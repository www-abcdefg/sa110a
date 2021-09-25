import * as _ from '../some.js'
import{assert} from "https://deno.land/std@0.108.0/testing/asserts.ts";
Deno.test("some",()=>{
    _.some([null, 0, 'yes', false], Boolean);
    // => true
     
    var users = [
      { 'user': 'barney', 'active': true },
      { 'user': 'fred',   'active': false }
    ];
     
    // The `_.matches` iteratee shorthand.
    _.some(users, { 'user': 'barney', 'active': false });
    // => false
     
    // The `_.matchesProperty` iteratee shorthand.
    _.some(users, ['active', false]);
    // => true
     
    // The `_.property` iteratee shorthand.
    _.some(users, 'active');
    // => true
    })