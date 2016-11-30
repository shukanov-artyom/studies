// ************* Fake namespace using object ***************

var namespace = {};
namespace.variable1 = "value1";
namespace.functionA = function() {
    console.log("Namespace function called! : " 
        + namespace.variable1);
};

namespace.functionA();

// ************ fake namespaces using IIFEs ****************
(function fun() {
    console.log("i'm called!");
})();

(function fun(parameter) {
    console.log("i'm called with parameter " + parameter);
})("1");

// *************** Recursive Named IIFE ********************

var counter = 0;
(function namedIIFE(ctr) {
    if (ctr++ == 10) {
        console.log("That's enough, let's get out of here.")
        return;
    } else {
        console.log("Recursion is " + ctr + " deep!");
        namedIIFE(ctr);
    }
})(counter);
console.log("Counter state: " + counter);