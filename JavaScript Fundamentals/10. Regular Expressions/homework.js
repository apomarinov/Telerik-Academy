console.error("Моля, ако не сте, отворете index.html файлът в браузър и вижте резултата в конзолата.");
var hw = new Homework();

hw.addProblem('Format with placeholders', function(){
	if(!String.prototype.format) {
		String.prototype.format = function(options) {
			var option,
			regex,
			formatted = this;
			for (option in options) {
				regex = new RegExp('#{' + option + '}', 'g');
				formatted = formatted.replace(regex, options[option]);
			}

			return formatted;
		};
	}
	var template1 = 'Hello, there! Are you #{name}?';
	var template2 = 'My name is #{name} and I am #{age}-years-old';

	console.log(template1.format({name: 'John'}));
	console.log(template2.format({name: 'John', age: 13}));
});

hw.addProblem("HTML binding", function(){
	if(!String.prototype.bind) {
		String.prototype.bind = function(output, params) {
			var regexContent,
			regexHref,
			regexClass,
			prop;
			output = this;

			for (prop in params) {
				regexContent = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
				regexHref = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
				regexClass = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');

				output = output.replace(regexContent, function(element, openingTag, content, closingTag) {
					return openingTag + params[prop] + closingTag;
				});

				output = output.replace(regexHref, function (tag, contentBeforeClosing) {
					return contentBeforeClosing + ' href="' + params[prop] + '">';
				});

				output = output.replace(regexClass, function (tag, contentBeforeClosing) {
					return contentBeforeClosing + ' class="' + params[prop] + '">';
				});
			}

			return output;
		};
	}

	var template1 = '<div data-bind-content="name"></div>';
	var template2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>';

	console.log(template1.bind('', {name: 'Steven'}));
	console.log(template2.bind('', {name: 'Elena', link: 'http://telerikacademy.com'}));
});

hw.executeProblems();













