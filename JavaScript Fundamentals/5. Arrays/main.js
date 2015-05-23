var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [
	{
		title: "Increase array members",
		body: function(){
			// Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
			// Print the obtained array on the console.
			var arr = new Array(20);

			for(var i = 0, len = arr.length; i < len; i++){
				arr[i] = i * 5;
			}

			console.log(arr);
		}
	},{
		title: "Lexicographically comparison",
		body: function(){
			// Write a script that compares two char arrays lexicographically (letter by letter).
			var arr1 = "telerikrocks".split("");
			var arr2 = "telerikruless".split("");
			var loopLen = arr1.length > arr2.length ? arr1.length : arr2.length;

			for(var i = 0; i < loopLen; i++){
				if(i < arr1.length && i < arr2.length) {
					if(arr1[i] === arr2[i]) {
						console.log(arr1[i] ,"===", arr2[i]);
					} else {
						console.log(arr1[i] ,"!==", arr2[i]);
					}
				}
			}
		}
	},{
		title: "Maximal sequence",
		body: function(){
			// Write a script that finds the maximal sequence of equal elements in an array.
			var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

			console.log(equalSequence(arr));

			function equalSequence (arr)
			{	
				var len = arr.length;
				var testElement = arr [0],
					testCount = 0;
				var foundElement = testElement,
					foundCount = 0;
				
				for (var i = 0; i < len; i++) {
					if (testElement == arr [i]) {
						testCount++;
					} else {
						if (testCount > foundCount) {
							foundCount = testCount;
							foundElement = testElement;
						}
						
						testElement = arr [i];
						testCount = 1;
					}
				}
				
				if (testCount > foundCount) {
					foundCount = testCount;
					foundElement = testElement;
				}
				
				var longestSequence = [];
				for (var i = 0; i < foundCount; i++) {
					longestSequence.push(foundElement);
				}
				
				return longestSequence;
			}
		}
	},{
		title: "Maximal increasing sequence",
		body: function(){
			// Write a script that finds the maximal increasing sequence in an array.
			var arr = [3, 2, 3, 4, 2, 2, 4];

			console.log(increasingSequence(arr));

			function increasingSequence (arr)
			{
				var len = arr.length;
				var testElement = arr [0],
				testCount = 0;
				var foundElement = testElement,
				foundCount = 0, increment = 0;
				
				for (var i = 0; i < len; i++, increment++) {
					if (testElement + increment == arr [i]) {
						testCount++;
					} else {
						if (testCount > foundCount) {
							foundCount = testCount;
							foundElement = testElement;
						}
						
						testElement = arr [i];
						i--;
						increment = -1;
						testCount = 0;
					}
				}
				
				if (testCount > foundCount) {
					foundCount = testCount;
					foundElement = testElement;
				}		
				
				var increasingSequence = [];
				for (var i = 0; i < foundCount; i++) {
					increasingSequence.push(foundElement + i);
				}
				
				return increasingSequence;
			}
		}
	},{
		title: "Selection sort",
		body: function(){
			var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

			console.log(selectionSort(arr));

			function selectionSort (arr)
			{
				var temp, smallest;			
						
				for (var i = 0, len = arr.length; i < len - 1; i++) {
					smallest = i;
					
					for (var j = i + 1; j < len; j++) {
						if (arr [j] < arr [smallest]) {
							smallest = j;						
						}
					}
					
					if (smallest != i) {
						temp = arr [smallest];
						arr [smallest] = arr [i];
						arr [i] = temp;
					}
				}

				return arr;
			}
		}
	},{
		title: "Most frequent number",
		body: function(){
			// Write a script that finds the most frequent number in an array.
			var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

			console.log(arr);
			console.log(mode(arr));

			function mode(array)
			{
			    if(array.length == 0)
			    	return null;
			    var modeMap = {};
			    var maxEl = array[0], maxCount = 1;
			    for(var i = 0; i < array.length; i++)
			    {
			    	var el = array[i];
			    	if(modeMap[el] == null)
			    		modeMap[el] = 1;
			    	else
			    		modeMap[el]++;	
			    	if(modeMap[el] > maxCount)
			    	{
			    		maxEl = el;
			    		maxCount = modeMap[el];
			    	}
			    }
			    return {
			    	element: maxEl,
			    	count: maxCount
			    };
			}
		}
	},{
		title: "Binary search",
		body: function(){
			// Write a script that finds the index of given element in a 
			// sorted array of integers by using the binary search algorithm.
			var arr = [44, 11, 1, 4, 2, 3, 40, 400, 1122, 22, 49, 9, 311];
			arr = arr.sort(function compareNumbers(a, b) {
							  return a - b;
							});

			console.log(arr);
			console.log(binarySearch(11, arr));

			function binarySearch(searchElement, arr) {			 
			    var minIndex = 0;
			    var maxIndex = arr.length - 1;
			    var currentIndex;
			    var currentElement;
			    var operations = 0;
			 
			    while (minIndex <= maxIndex) {
			    	operations++;
			        currentIndex = (minIndex + maxIndex) / 2 | 0;
			        currentElement = arr[currentIndex];
			 
			        if (currentElement < searchElement) {
			            minIndex = currentIndex + 1;
			        }
			        else if (currentElement > searchElement) {
			            maxIndex = currentIndex - 1;
			        }
			        else {
			            return {
			            	index: currentIndex,
			            	operations: operations
			            };
			        }
			    }
			 
			    return {
	            	index: -1,
	            	operations: operations
	            };
			}
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