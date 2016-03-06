function test1() {
    if ('a' in window) { 
        var a = 1;
    }

alert(a);
}

function test2() {
    if ('a' in window ) {
        a = 1;
    }
    alert(a);
}

function test3() {
    if ('a' in window ) {
        a = 1;
    }
    var a;
    alert(a);
}