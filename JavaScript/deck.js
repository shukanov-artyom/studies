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

// =============== Cards ==============

function Card(suit, rank){
    this.suit = suit;
    this.rank = rank;
}

Card.Suit = enumeration({
    Clubs: 1, 
    Hearts: 2, 
    Diamonds:3, 
    Spades :4});
    
Card.Rank = enumeration({
    Two: 2,
    Three: 3,
    Four: 4,
    Five : 5,
    Six: 6,
    Seven: 7,
    Eight: 8,
    Nine: 9,
    Ten : 10,
    Jack: 11,
    Queen: 12,
    King: 13,
    Ace:14
});

Card.prototype.toString = function(){
    return this.rank.toString() + ' ' + this.suit.toString();
};

Card.prototype.compareTo = function(that){
    if (this.rank < that.rank) return -1;
    if (that.rank < this.rank) return 1;
    return 0;
};

// ...

function Deck(){
    var cards = this.cards = [];
    Card.Suit.foreach(function(s){
        Card.Rank.foreach(function(r){
            cards.push(new Card(s,r));
        })
    });
}

var deck = new Deck();
for (var d in deck.cards){
    console.log(deck.cards[d].toString());
}