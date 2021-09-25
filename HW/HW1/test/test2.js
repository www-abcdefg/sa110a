import * as _ from "../before.js";
import{assert} from "https://deno.land/std@0.108.0/testing/asserts.ts"

Deno.test("before",()=>{
jQuery(element).on('click', _.before(5, addContactToList));
// => Allows adding up to 4 contacts to the list.
});
