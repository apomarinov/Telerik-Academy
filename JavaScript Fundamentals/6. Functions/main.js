var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [{
		title: "English digit",
		body: function(){

			console.log(512, digitAsWord(512 % 10));
			console.log(1024, digitAsWord(1024 % 10));
			console.log(12309, digitAsWord(12309 % 10));

			function digitAsWord(digit){
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
				}
			}
		}
	},{
		title: "Reverse number",
		body: function(){
			var num1 = 256, num2 = 123.45;

			console.log(num1, reverseNumber(num1));
			console.log(num2, reverseNumber(num2));

			function reverseNumber(num){
				var charArr = num.toString().split('');
				var reversedStr = charArr.reverse().join('');

				if(charArr.indexOf('.') !== -1) {
					return parseFloat(reversedStr);	
				}
				return parseInt(reversedStr);
			}
		}
	},{
		title: "Occurrences of word",
		body: function(){
			var txt = "tel tel TEL";

			console.log(txt);
			console.log('tel: CI', wordOccurence(txt, 'tel'));
			console.log('TEL: CS', wordOccurence(txt, 'TEL', true));

			function wordOccurence(text, word, isCaseSensitive){
			    var replacedPunctuation = text.replace(/\W+/g, ' ');

			    if(!isCaseSensitive){
			        replacedPunctuation = replacedPunctuation.toLowerCase();
			        word = word.toLowerCase();
			    }

			    var words = replacedPunctuation.split(' ');
			    var occurrences = 0;

			    for(var i = 0; i < words.length; i++){
			        if(words[i] === word) {
			        	occurrences++;
			        }
			    }

			    return occurrences;
			}
		}
	},{
		title: "Number of elements",
		body: function(){
			console.log('Result will appear on window load');
			window.addEventListener("load", getDivs, false);

			function getDivs(){
				console.log("%cNumber of DIVs: " + document.getElementsByTagName('div').length, consoleStyle);
			}
		}
	},{
		title: "Appearance count",
		body: function(){
			var arr1 = [1, 2, 3, 4, 4, 5, 5, 5];
			var arr2 = [];

			console.log(arr1, "5(3 times)", test(occurrenceInArray, [5, arr1], 3));
			console.log(arr2, "1(1 times)", test(occurrenceInArray, [1, arr2], 1));

			function occurrenceInArray (num, arr)
			{
				var times = 0;
				for (var i = 0; i < arr.length; i++) {
					if (arr [i] == num) {
						times++;
					}
				}
				return times;
			}

			function test(callback, args, result){
				return callback.apply(this, args) == result;
			}
		}
	},{
		title: "Larger than neighbours",
		body: function(){
			var arr = [1, 2, 3, 4, 5, 10, 2];

			console.log(arr);
			console.log("At index 5", self.helperFunctions.largerThanNeighbours(5, arr));
			console.log("At index 4", self.helperFunctions.largerThanNeighbours(4, arr));
		}
	}, {
		title: "First larger than neighbours",
		body: function(){
			var arr = [1, 2, 3, 4, 5, 10, 2, 20, 1];			

			console.log(arr);
			console.log("First larger is at index: ", firstLargerThanNeighbours(arr));

			function firstLargerThanNeighbours (arr)
			{
				for (var i = 0; i < arr.length; i++) {
					if (self.helperFunctions.largerThanNeighbours (i, arr)) {
						return i;
					}
				}
				return -1;
			}
		}
	}];

	self.helperFunctions = {
		largerThanNeighbours: function (index, arr)
		{
			var largerThanBoth = 0;
			if (index - 1 >= 0 && arr [index] > arr [index - 1]) {
				largerThanBoth++;
			}
			if (index + 1 < arr.length && arr [index] > arr [index + 1]) {
				largerThanBoth++;
			}
			return largerThanBoth == 2;
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