function enumeration(namesToValues){
    
    var enumeration = function(){ // fake constructor
        throw "You cannot instantiate enumeration type";
    }
    
    var proto = enumeration.prototype = {
        constructor : enumeration,
        
        toString: function(){
            return this.name;
        },
        
        valueOf: function(){
            return this.value;
        },
        
        toJSON: function(){
            return this.name;
        }
    };
    
    enumeration.values = []; // "static" collection of all enum members
    
    for (name in namesToValues){ // walk through enumerable props
        var e = inherit(proto); // create new object inherited from proto
        e.name = name; // assign it with properties of an enum member
        e.value = namesToValues[name];
        enumeration[name] = e; // add to statics of fake constructor
        enumeration.values.push(e); // add to collection
    }
    
    enumeration.foreach = function(f,c){ // static foreach for static enum collection
        for (var i=0; i<this.values.length; i++){
            f.call(c, this.values[i]);
        }
    }
    
    return enumeration;
}

// inherit common function
function inherit(p)
{
    if (p === null){
        throw new TypeError('cannot inherit null');
    }
    if (Object.create){
        return Object.create(p);
    }
    var t = typeof p;
        if (t !== 'object' && t !== 'function'){
            throw TypeError();
        }
        function f(){}
        f.prototype = p;
        return new f();
}

// test our enumeration emulation
var Coin = enumeration({Penny: 1, Nickel: 5, Dime: 10, Quarter: 25});
var enumArray = [Coin.Penny, Coin.Dime, Coin.Quarter];
console.log(enumArray[0] instanceof Coin);

var c = new Coin();



