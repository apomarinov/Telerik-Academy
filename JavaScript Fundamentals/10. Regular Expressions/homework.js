console.error("Моля, ако не сте, отворете index.html файлът в браузър и вижте резултата в конзолата.");
var hw = new Homework();

hw.addProblem('Reverse string', function(){
	var samp = "sample";

	console.log(reverseString(samp));

	function reverseString(str) {
		return str.split("").reverse().join('');
	}
});

hw.executeProblems();













