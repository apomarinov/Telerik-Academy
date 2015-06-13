function solve(args) {
	var nums = args[0].split(' ').map(function(el){
		return parseInt(el);
	});
	var result = 0, currentResult = 0, firstPeak, secondPeak, valley;
	for(var i = 0, len = nums.length; i < len; i++){
		if(firstPeak) {
			currentResult++;
		}

		// get first peak
		if(!firstPeak) {
			firstPeak = nums[i];
		}
		// get the valley
		else if(!valley || valley > nums[i]) {
			valley = nums[i];
		}
		// get the second peak
		else if(!secondPeak || secondPeak < nums[i]) {
			secondPeak = nums[i];
		}
		// get result
		if(secondPeak > nums[i] || i == nums.length - 1) {
			if(i < nums.length - 1) {
				currentResult--;
			}
			if(result < currentResult) {
				result = currentResult;
			}
			if(i == nums.length - 1) {
				break;
			}
			currentResult = 0;
			firstPeak = secondPeak;
			secondPeak = null;
			valley = null;
			i--;
		}
	}

	return result;
}


var tests = [
	["5 1 7 6 3 6 4 2 3 8"]
	,
	["5 1 7 4 8"],
	["10 1 2 3 4 5 4 3 2 1 10"]
];


for(var i = 0, len = tests.length; i < len; i++){
	console.log(solve(tests[i]));
}