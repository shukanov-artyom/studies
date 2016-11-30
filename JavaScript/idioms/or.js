var a; // undefined
var b = null;
var c = 2;
var d = a || b || c; // 2

// we can select between different (non-boolean) values
// it's like a C# ?? operator, but with many inputs
// or something like T-SQL COALESCE