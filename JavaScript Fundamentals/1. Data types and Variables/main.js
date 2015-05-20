// Problems 1, 3 and 4
// - Assign all the possible JavaScript literals to different variables.
// - Try typeof on all variables you created.
// - Create null, undefined variables and try typeof on them.

var undefinedLit = undefined;
var nullLit = null;
var intLit = 10;
var floatLit = 3.3;
var string = 'hey there';
var arr = [1, 2, 3];
var obj = {first_name: 'Greatest', last_name: 'Ever'};
var funcLit = function(){return;};

var literals = [undefinedLit, nullLit, intLit, floatLit, string, arr, obj, funcLit];

for(var variable in literals){
    console.log(typeof literals[variable]);
}

// Problem 2. Quoted text

// Create a string variable with quoted text in it.
// For example: `'How you doin'?', Joey said'.
var withEscaping = '\'How you doin\'?\', Joey said.';
var withoutEscaping = "'How you doin'?', Joey said.";

console.log(withEscaping + " <<==>> " + withoutEscaping);