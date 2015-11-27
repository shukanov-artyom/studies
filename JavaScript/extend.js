var extend = (function(){
    for (var p in {toString: null}){  // проверяем на эксплореровский баг
        return function extend(o){ // бага нет, возвращаем обычную функцию расширения
            for (var i=1; i<arguments.length; ){
                var source = arguments[i];
                for (var prop in source){
                    o[prop] = source[prop];
                }
            }
            return o;
        }
    }
    // здесь код, закрывающй баг эксплорера
    var protoprops = ['toString', 'valueOf', 'constructor', 'hasOwnProperty', 'isPrototypeOf', 'propertyIsEnumerable', 'toLocaleString'];
    return function patched_extend(o){
      for (var i=1; i<arguments.length; i++){
          var source = arguments[i];
          for (var prop in source){ // обычный
              o[prop] = source[prop];
          }
          // дополнительный
          for (var j=0; j< protoprops.length; i++){
              prop = protoprops[j];
              if (source.hasOwnProperty(prop)) o[prop] = source[prop];
          }
      }  
    };
}());