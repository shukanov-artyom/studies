// Declare constructor
var User = function(userId) {
    this.userId = userId;
    this.firstName = 'John';
    this.lastName = 'Smith';
}

User.prototype.GetFullName = function() {
    return this.firstName + ' ' + this.lastName;
};

// must use module.exports here
module.exports = User;
