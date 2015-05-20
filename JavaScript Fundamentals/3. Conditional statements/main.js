var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [
	{
		title: "Exchange if greater",
		body: function(){
			// Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
			// As a result print the values a and b, separated by a space.
			var x = 7, y = 4;

			console.log(x, y);

			if(x > y) {
				var temp = x;
				x = y;
				y = temp;
			}

			console.log(x, y);
		}
	},{
		title: "Multiplication Sign",
		body: function(){
			// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
			// Use a sequence of if operators.
			var testNums1 = {a: 5, b: 2, c: 2},
			testNums2 = {a: -2, b: -2, c: 1},
			testNums3 = {a: -2, b: 4, c: 3},
			testNums4 = {a: 0, b: 1, c: 1};

			console.log(testNums1, getMultiplicationSign(testNums1));
			console.log(testNums2, getMultiplicationSign(testNums2));
			console.log(testNums3, getMultiplicationSign(testNums3));
			console.log(testNums4, getMultiplicationSign(testNums4));

			function getMultiplicationSign(nums){
				var result = nums.a * nums.b * nums.c;
				if(result > 0) {
					return "+";
				} else if(result < 0) {
					return "-";
				} else {
					return "0";
				}
			}
		}
	},{
		title: "The biggest of Three",
		body: function(){
			// Write a script that finds the biggest of three numbers.
			// Use nested if statements.
			var testNums1 = {a: 5, b: 2, c: 2},
			testNums2 = {a: -2, b: -2, c: 1},
			testNums3 = {a: -2, b: 4, c: 3},
			testNums4 = {a: 0, b: 1, c: 5};

			console.log(testNums1, biggestOfThree(testNums1));
			console.log(testNums2, biggestOfThree(testNums2));
			console.log(testNums3, biggestOfThree(testNums3));
			console.log(testNums4, biggestOfThree(testNums4));

			function biggestOfThree(nums){
				// 4ak puk nested ifs...
				var biggestOfTwo = nums.a > nums.b ? nums.a : nums.b;
				return biggestOfTwo > nums.c ? biggestOfTwo : nums.c;
			}
		}
	},
	{
		title: "Sort 3 numbers",
		body: function(){
			// Sort 3 real values in descending order.
			// Use nested if statements.
			// Note: Don’t use arrays and the built-in sorting functionality.
			var testNums = {a: 9, b: 20, c: 2};
			var a = testNums.a, b = testNums.b, c = testNums.c;
			var temp;

			console.log(testNums);

			if(a >= b){
				if(c > a){
					testNums.a = c;
					testNums.b = a;
					testNums.c = b;
				} else {
					testNums.a = a;
					testNums.b = c;
					testNums.c = b;
				}
			} else {
				if(b >= c){
					if(c >= a){
						testNums.a = b;
						testNums.b = c;
						testNums.c = a;
					} else {
						testNums.a = b;
						testNums.b = a;
						testNums.c = c;
					}
				} else {
					testNums.a = c;
					testNums.b = b;
					testNums.c = a;
				}
			}

			console.log(testNums);
		}
	},
	{
		title: "Digit as word",
		body: function(){
			// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
			// Print “not a digit” in case of invalid input.
			// Use a switch statement.
			var x = 5, y = 0, z = "Asd";

			console.log(x, self.helperFunctions.digitAsWord(x));
			console.log(y, self.helperFunctions.digitAsWord(y));
			console.log(z, self.helperFunctions.digitAsWord(z));
		}
	},{
		title: "Quadratic equation",
		body: function(){
			// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
			// Calculates and prints its real roots.
			// Note: Quadratic equations may have 0, 1 or 2 real roots.

			var twoRoots = {a: 2, b: 5, c: -3},
			sameRoots = {a: -0.5, b: 4, c: -8},
			noRoots = {a: 5, b: 2, c: 8};

			console.log(twoRoots, solve(twoRoots));
			console.log(sameRoots, solve(sameRoots));
			console.log(noRoots, solve(noRoots));

			function solve(equation){
				var D = equation.b * equation.b - 4 * equation.a * equation.c;
				if(D < 0){
					return "no real roots";
				}
				else if(D == 0){
					return getRoot(-1, D, equation.b, equation.a);
				}
				else{
					return [getRoot(1, D, equation.b, equation.a), getRoot(-1, D, equation.b, equation.a)];
				}
			}

			function getRoot(sign, D, b, a){
				return (-b + Math.sqrt(D) * sign) / (2 * a);
			}
		}
	},{
		title: "The biggest of five numbers",
		body: function(){
			// Write a script that finds the greatest of given 5 variables.
			// Use nested if statements - ne mislA
			
			var nums = [1, 50, 9, 0, 166];
			var max = nums[0];

			for(var i = 1; i < nums.length; i++){
				if(nums[i] > max){
					max = nums[i];
				}
			}

			console.log(nums);
			console.log(max);
		}
	},{
		title: "Number as words",
		body: function(){
			// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
			var a = -1, b = 4, c = 22, d = 101, e = 999;

			function numberAsWord(num){
				if(num)
				var digits = ("" + num).split("");
			}
		}
	}];

	self.helperFunctions = {
		digitAsWord: function(digit){
			switch(digit){
				case 0: return 'zero';
				case 1: return 'one';
				case 2: return 'two';
				case 3: return 'three';
				case 4: return 'four';
				case 5: return 'five';
				case 6: return 'six';
				case 7: return 'seven';
				case 8: return 'eight';
				case 9: return 'nine';
				default: return 'Invalid digit';
			}
		}
	};

	self.executeProblems = function(){
		for (var i = 0, len = self.problems.length; i < len; i++) {
			console.log("%c " + (i + 1) + ". " + self.problems[i].title + " ", consoleStyle);
			self.problems[i].body();
		};
	};
};

Homework.executeProblems();