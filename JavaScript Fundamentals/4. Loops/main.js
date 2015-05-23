var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [
	{
		title: "Numbers",
		body: function(){
			// Write a script that prints all the numbers from 1 to N.
			self.helperFunctions.printNumbersToN(10);
		}
	},{
		title: "Numbers not divisible",
		body: function(){
			// Write a script that prints all the numbers from 1 to N
			// that are not divisible by 3 and 7 at the same time
			self.helperFunctions.printNumbersToN(100, function(num){
				if(num % 3 == 0 && num % 7 == 0) {
					return true;
				}
				return false;
			});
		}
	},{
		title: "Min/Max of sequence",
		body: function(){
			// Write a script that finds the max and min number from a sequence of numbers.
			var nums = [1, 2, 3, 4, 5, 6, 7, 88, 99, 0, 123, 3, 4, -9, 22];
			var min, max;
			min = max = nums[0];

			for(var i = 0, len = nums.length; i < len; i++){
				if(min > nums[i]) {
					min = nums[i];
				}
				if(max < nums[i]) {
					max = nums[i];
				}
			}

			console.log(nums);
			console.log("Min: ", min);
			console.log("Max: ", max);
		}
	},{
		title: "Lexicographically smallest",
		body: function(){
			// Write a script that finds the lexicographically smallest and largest
			// property in document, window and navigator objects.

			console.log("document: ", minMaxProp(document));
			console.log("window: ", minMaxProp(window));
			console.log("navigator: ", minMaxProp(navigator));

			function minMaxProp(obj) {
				var minName = Object.keys(obj)[0], minLength = minName ? minName.length : 9999;
				var maxName = Object.keys(obj)[0], maxLength = maxName ? maxName.length : 0;

				for(var p in obj) {
					if(minLength > p.length) {
						minLength = p.length;
						minName = p.toString();
					}
					if(maxLength < p.length) {
						maxLength = p.length;
						maxName = p.toString();
					}
				}

				return {
					min: minName,
					max: maxName
				}
			}
		}
	}
	];

	self.helperFunctions = {
		printNumbersToN: function(n, condition){
			var output = [];
			for (var i = 1; i <= n; i++) {
				if(!condition) {
					output.push(i);
				} else if(condition(i)) {
					output.push(i);
				}
			};
			console.log(output);
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