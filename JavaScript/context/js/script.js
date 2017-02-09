// ************** Experiments with context *****************

function Contexter(){
    console.log("In Constructor Function call this is " + this);
}

Contexter.prototype.thisExposer = function() {
    console.log("In Exposer this equals to " + this);
}

var exp = new Contexter();
exp.thisExposer();

var exposerFunction = exp.thisExposer;
exposerFunction();

// вывод: в классической реализации классов в джс 
// способ вызова влияет на то, чем в методе будет this

// но ситуация немного иная в новых классах ES6