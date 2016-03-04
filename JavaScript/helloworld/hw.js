'use strict'

function clicked() {
    var message = "button clicked."
    alert(message);
    test();
}

function clickedProto() {
    
    // create dog with functions
    function getAnimal(name, age){
        return {
            name: name,
            age: age,
            talk: function(){
                alert(this.name + ' ' + 'makes noise');
            }
        }
    }
    
    var animal = getAnimal('Rex', 2);
    console.log(animal); 
    
    // create dog with prototyping
    function AnotherAnimal(name, age){
        this.name = name,
        this.age = age
    }
    AnotherAnimal.prototype = {
        talk: function(){
            console.log('Another animal is barking because it is a dog!');
        }
    }
    
    var dog = new AnotherAnimal('Pete', 3);
    console.log(dog);
}

function clickedSimpleProto() {
    
}

function test() {
    let a = '3';
    let b = 4;
    let d = a + b;
    console.log(d); 
}
