console.error("Моля, ако не сте, отворете index.html файлът в браузър и вижте резултата в конзолата.");
var hw = new Homework();

hw.addProblem('Reverse string', function(){
	var samp = "sample";

	console.log(reverseString(samp));

	function reverseString(str) {
		return str.split("").reverse().join('');
	}
});

hw.addProblem("Correct brackets", function(){
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
});

hw.addProblem("Sub-string in text", function(){
	var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
	var searchFor = "in";

	console.log(substringOccurence(text, searchFor));

	function substringOccurence(text, search) {
		var count = 0;
		for (var i = 0, len = text.length; i < len; i++) {
			if(text[i] === search[0] && text.substr(i, search.length) == search) {
				count++;
				i += search.length - 1;
			}
		}
		return count;
	}
});

hw.addProblem("Parse tags", function(){
	var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
	var tagFunctions = {
		mixcase: mixcase,
		upcase: upcase,
		lowcase: lowcase
	};

	console.log("Text: ", text);
	console.log("Parsed Tags: ", parseTags(text, tagFunctions));

	function parseTags (text, tags){
		var tagName, openingTagIndex, closingTagIndex, tagAndContents, tagContents, parsedTagContents;

		for (var i = 0, len = text.length; i < len; i++) {
			if(text[i] === '<') {
				openingTagIndex = i;
				tagName = getTagName(text, openingTagIndex);
				closingTagIndex = getClosingTagIndex(text, openingTagIndex, tagName);
				tagAndContents = text.substring(openingTagIndex, closingTagIndex);
				tagContents = getTagContents(tagAndContents, tagName);
				parsedTagContents = tagFunctions[tagName](tagContents);
				text = text.replace(tagAndContents, parsedTagContents);
				i += parsedTagContents.length;
			}
		}

		return text;
	}

	function getTagName(text, startIndex) {
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == '>') {
				return text.substring(startIndex + 1, i);
			}
		}
	}

	function getClosingTagIndex(text, startIndex, tag) {
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == '/' && text.substr(i + 1, tag.length) === tag) {
				return i + tag.length + 2;
			}
		}
	}

	function getTagContents(tagAndContents, tagName) {
		return tagAndContents.replace('<' + tagName + '>', '').replace('</' + tagName + '>', '');
	}

	function mixcase(str){
		var mixcaseStr = '';
		for(var i = 0, len = str.length; i < len; i++){
			mixcaseStr += Math.random() > 0.5 ? str[i].toUpperCase() : str[i].toLowerCase()
		}
		return mixcaseStr;
	}

	function upcase(str) {
		return str.toUpperCase();
	}

	function lowcase(str) {
		return str.toLowerCase();
	}
});

hw.addProblem("nbsp", function(){
	// How to type a non breaking white space:
	// Windows - Alt+0+1+6+0
	var text = "jashdkjas d kjhkjh kjhkjh kj lkjlkj the_next_space_is_regular> <see_it_didnt_get_changed";

	console.log("Text: ", text);
	console.log("Escaped: ", charEscape(text, " ", "&nbsp;"));

	function charEscape(text, ch, escape) {
		for(var i = 0, len = text.length; i < len; i++){
			if(text[i] === ch) {
				text = text.replace(text[i], escape);
			}
		}
		return text;
	}
});

hw.addProblem("Extract text from HTML" , function(){
	var html = "<html> <head> <title>Sample site</title> </head> <body> <div>text <div>more text</div> and more... </div> in body </body> </html>";

	console.log(getTextFromHTML(html));

	function getTextFromHTML(html) {
		var text = '';
		var tagName;

		for (var i = 0, len = html.length; i < len; i++) {
			if(html[i] == '<') {
				tagName = getTagName(html, i);
				text += getTagText(html, i) || '';
				i += tagName.length + 1;
			}
		}

		return text;
	}

	function getTagName(text, startIndex) {
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == '>') {
				return text.substring(startIndex + 1, i);
			}
		}
	}

	function getTagText(html, startIndex) {
		var text;
		for(var i = startIndex, len = html.length; i > 0; i--){
			if(html[i] == '>') {
				return html.substring(i + 1, startIndex).trim();
			}
		}
	}
});

hw.addProblem("Parse URL", function(){
	var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

	console.log(parseURL(url));

	function parseURL(url) {
		var urlParts = url.split('://');
		var protocol = urlParts[0];
		url = url.replace(protocol + '://', '');
		var server = url.split('/')[0];
		var resource = url.replace(server, '');

		return {
			protocol: protocol,
			server: server,
			resource: resource
		};
	}
});

hw.addProblem('Replace tags', function(){
	var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

	console.log(replaceTags(html));

	function replaceTags(html) {
		var url, text;

		for(var i = 0, len = html.length; i < len; i++){
			if(html.substring(i, i + 9) === '<a href="') {
				url = getURL(html, i + 9);
				text = getText(html, i + 11 + url.length);
				html = html.replace('<a href="' + url + '">' + text + '</a>',
									'[URL=' + url + ']' + text + '[/URL]');
			}
		}

		return html;
	}

	function getURL(text, startIndex) {
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == '"') {
				return text.substring(startIndex, i);
			}
		}
	}

	function getText(text, startIndex) {
		for(var i = startIndex, len = text.length; i < len; i++){
			if(text[i] == '<') {
				return text.substring(startIndex, i);
			}
		}
	}
});

hw.addProblem("Extract Emails", function(){
	var text = text = "ooh hi the some text blah blah programming is kewl asdasd@abv.bg yeah .!sadf#!$#asdfasd % <#$>%  ooh another oneee urgitv_ADFG@asd.co.uk";

	console.log(extractEmails(text));

	function extractEmails(text){
	    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
	}
});

hw.addProblem("Find palindromes", function(){
	var text = "sdf as df as df a sdf asdfadfg sdfg ABBA jhagfg UBUEREUBU hgsdfsdf LAMAL exe";

	console.log(findPalindromes(text));

	function findPalindromes(text) {
		var words = text.split(' ');
		var palindromes = [];

		for(var i = 0, len = words.length; i < len; i++){
			if(words[i].length > 2 && words[i] === words[i].split('').reverse().join('')) {
				palindromes.push(words[i]);
			}
		}

		return palindromes;
	}
});

hw.addProblem("String format", function(){
	var examples = [
		['{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'],
		['Hello {0}!', 'Peter']
	];

	for(var i = 0, len = examples.length; i < len; i++){
		console.log(stringFormat.apply(this, examples[i]));
	}

	function stringFormat(){
		var format = arguments[0];

		for(var i = 0, len = format.length; i < len; i++){
			if(format[i] == '{') {
				format = format.replace(format.substr(i, 3), arguments[parseInt(format[i + 1]) + 1].toString());
			}
		}

		return format;
	}
});

hw.addProblem("Generate list", function(){
	window.addEventListener('load', function(){
		var people = [
			{name: 'Peter', age: 14},
			{name: 'Peter2', age: 11},
			{name: 'Pe6ko', age: 112},
			{name: '6ipko', age: 142},
			{name: 'boiko', age: 12}
		];

		var list = document.getElementById('list-item');
		var temp = list.innerHTML, 
			curTemp, propName;
		list.innerHTML = '';

		for(var i = 0, len = people.length; i < len; i++){
			curTemp = temp;
			for(var j = 0, tempLen = curTemp.length; j < tempLen; j++){
				if(curTemp.substr(j, 2) == '-{') {
					propName = getPropName(curTemp, j + 2);
					curTemp = curTemp.replace('-{' + propName + '}-', people[i][propName]);
				}
			}
			list.innerHTML += curTemp;
		}

		function getPropName(text, startIndex) {
			for(var i = startIndex, len = text.length; i < len; i++){
				if(text.substr(i, 2) == '}-') {
					return text.substring(startIndex, i);
				}
			}
		}

		console.table(people);
		console.log("Look the page");
	});

});

hw.executeProblems();













