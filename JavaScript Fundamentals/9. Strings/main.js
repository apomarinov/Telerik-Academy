var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [
	{
		title: "Reverse string",
		body: function(){
			// Write a JavaScript function that reverses a string and returns it.
			var samp = "sample";

			console.log(reverseString(samp));

			function reverseString(str) {
				return str.split("").reverse().join('');
			}
		}
	},{
		title: "Correct brackets",
		body: function(){
			var corBrack = "((a+b)/5-d)";
			var wrongBrack = ")(a+b))";

			console.log(corBrack, bracketCheck(corBrack));
			console.log(wrongBrack, bracketCheck(wrongBrack));

			function bracketCheck(exp) {
				var chars = exp.split("");
				var openingBrackets = 0;

				for(var i = 0, len = chars.length; i < len; i++){
					if(chars[i] === '(') {
						openingBrackets++;
					} else if(chars[i] === ')') {
						openingBrackets--;
					}
				}

				return openingBrackets === 0;
			}
		}
	},{
		title: "Sub-string in text",
		body: function(){
			var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
			var searchFor = "in";
			var re = new RegExp('in', 'g');
			var count = (text.match(re) || []).length;

			console.log(count);
		}
	},{
		title: "Parse tags",
		body: function(){
			var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

			console.log(text.match(/<mixcase>(.|\n)*?<\/mixcase>/g));
		}
	}];

	self.helperFunctions = {
	};

	self.executeProblems = function(){
		for (var i = 0, len = self.problems.length; i < len; i++) {
			console.log("%c " + (i + 1) + ". " + self.problems[i].title + " ", consoleStyle);
			self.problems[i].body();
		};
	};
};

Homework.executeProblems();