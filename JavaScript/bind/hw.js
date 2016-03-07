'use strict'

// По мотивам урока про контекст, карринг и bind с сайта learn.javascript.ru
function test1() {
    function f(){
        alert(this);
    }
    var user = {
        g: f.bind("Hello")
    }
    user.g(); // binded context still works 
}

function test2() {
    function f(){
        alert(this.name);
    }
    f = f.bind({name: "vasya"}).bind({name: 'petya'});
    f();
}

function test3() {
    var inner = function inn() {
        console.log('inner function');
    }
    inner.count = 0;
    var wrapped = inner.bind({arg: 2});
    alert(wrapped.count); // bind возвращает новый объект функции, поэтому свойства старого не сохраняются.
    alert(inner.count);
}