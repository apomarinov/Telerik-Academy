function solve(args) {
	var css = args.map(function(el){
		return el.trim();
	}).join("\n");

	var selector, content, prop, val;
	var result = '';
	var selectors = ["#", "$", "."];
	var cnt = 0;
	for(var i = 0, len = css.length; i < len; i++){
		selector = getSubString(css, i, '{', -1);
		result += selector + " {\n";

		content = getSubString(css, i + selector.length + 1, '}');

		for(var j = 0, len = content.length; j < len; j++, cnt++){
			if(selectors.indexOf(content[j]) === -1) {
				prop = getSubString(content, j, ':', -1);
				val = getSubString(content, j + prop.length, ';');
				result = result + "  " + prop + ": " + val + ";\n";
				j = content.indexOf(';');
			} else {
				break;
			}
			if(cnt > 50) {
				return;
			}
		}

	}

	function getSubString(text, startIndex, endSymbol, noStart) {
		noStart = noStart || 0;
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == endSymbol) {
				return text.substring(startIndex + 1 + noStart, i).trim();
			}
		}
	}
}


var tests = [
['#the-big-b{',
'color: big-yellow; size: big; .the-little-bs{',
'color: yellow; }',
'} .muppet{',
'skin: fluffy; $.water-spirit{',
'powers:all; }',
'}']
];


for(var i = 0, len = tests.length; i < len; i++){
	console.log(solve(tests[i]));
}