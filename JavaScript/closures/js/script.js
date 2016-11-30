
function showHelp(help) {
    console.log(help);
}

var helpText = [
    {id: "email", help: "e-mail address"},
    {id: "name", help: "your full name"},
    {id: "age", help: "your age"}
    ];

var funs = [];

// 1 - incorrect usage of closures

function setupHelpIncorrect() {
    var i = 0;
    for (var item in helpText){
        funs[i++] = function() { showHelp(helpText[item]); };
        i++;
    }
}

// 2. Correct - with function factory (deepen closure)

function functionFactory(obj) {
    return function() {
        showHelp(obj)
    };
}

function setupHelpFunctionFactory() {
    var i = 0;
    for (var item in helpText){
        funs[i++] = functionFactory(helpText[item]);
    }
}

// 3. Correct - with instant function call (function expression)

function setupHelpInstantCall() {
    var i = 0;
    for (var item in helpText) {
        funs[i] = (function() { 
            var local = helpText[item];
            return function() {
                showHelp(local);
            };
        })();
        i++;
    }
}

// 4. Correct - using let keyword (ES6)

function setupHelpLetKeyword() {
    var i = 0;
    for (var itemName in helpText) {
        let item = helpText[itemName];
        funs[i++] = function() {
            showHelp(item);
        };
    }
}

// ******** Executing *************

//setupHelpIncorrect();
//setupHelpFunctionFactory();
//setupHelpInstantCall();
setupHelpLetKeyword();

for (var prop in funs) {
    funs[prop]();
}




