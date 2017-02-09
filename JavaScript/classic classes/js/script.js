// 1. Incorrect - creating methods each time when 
//  object is instantiated 

function Circle(radius) {
    this.radius = radius;

    this.getPerimeter = function () {
        return 2 * Math.PI * this.radius;
    };

    this.getArea = function() {
        return Math.PI * Math.pow(this.radius, 2);
    };
}

// ******************************
// 2. more correct, but prototype is reinstantiated

function Circle(radius) {
    this.radius = radius;

    this.getPerimeter = function () {
        return 2 * Math.PI * this.radius;
    }

    this.getArea = function() {
        return Math.PI * Math.pow(this.radius, 2);
    }
}

Circle.prototype = {
    getPerimeter: function () {
        return 2 * Math.PI * this.radius;
    },
    getArea: function() {
        return Math.PI * Math.pow(this.radius, 2);
    }
}

// ****************************
// 3. Even more correct, ususally is used in this way.

function Circle(radius) {
    this.radius = radius;

    this.getPerimeter = function () {
        return 2 * Math.PI * this.radius;
    }

    this.getArea = function() {
        return Math.PI * Math.pow(this.radius, 2);
    }
}

Circle.prototype.getPerimeter = function () {
    return 2 * Math.PI * this.radius;
};

Circle.prototype.getArea = function() {
    return Math.PI * Math.pow(this.radius, 2);
};

// ****************************
// 3. the same, but more sophisticated

// ???

// ************** Experiments with context *****************

function Contexter(){
    var self = this;
    console.log("In Constructor Function call this is " + this);
}

Contexter.prototype.thisExposer = function() {
    console.log("In Exposer this equals to " + this);
}

var exp = new Contexter();
exp.thisExposer();
var exposerFunction = exp.thisExposer;
exposerFunction();



