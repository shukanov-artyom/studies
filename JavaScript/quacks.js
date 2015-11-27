function quacks(o /*...*/){
    for (var i =1; i<arguments.length; i++){
        var arg = arguments[i];
        switch (typeof arg){
            case 'string':
                if (typeof(o[arg] !== 'function')){
                    return false;
                }
            case 'function':
                arg = arg.prototype;
            case 'object':
                for (var m in arg){
                    if (typeof m !== 'function'){
                        continue;
                    }
                    if (typeof o[m] !== 'function'){
                        return false;
                    }
                }
        }
        return true;
    }
}
