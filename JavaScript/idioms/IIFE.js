(function(param){
    // This idiom is called IIFE and is used for setting up 
    //a virtual closed namespace.
    // JS does not have namespaces and we have to use functions.
})(argument);

// IIFE is just an expression and it may return a result.
// And look! WE do not need parentheses around function declaration here!
var a = 3;
var p = function pg() { return 5 * a; }();
console.log(p); // 15 - we used closure here
