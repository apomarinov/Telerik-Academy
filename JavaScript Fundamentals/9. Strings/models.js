var Homework = function(){
  var consoleStyle = 'background: #222; color: #bada55';
  var problems = [];
  var helperFunctions = {
  };

  function addProblem (title, body) {
    problems.push({
      title: title,
      body: body
    });
  }

  function addHelperFunction (name, body) {
    helperFunctions[name] = body;
  }

  function executeProblems (){
    for (var i = 0, len = problems.length; i < len; i++) {
      console.log("%c " + (i + 1) + ". " + problems[i].title + " ", consoleStyle);
      problems[i].body(helperFunctions);
    };
  }

  return {
    addProblem: addProblem,
    addHelperFunction: addHelperFunction,
    executeProblems: executeProblems
  };
};

// Pollyfils
if(!Array.prototype.random) {
	Array.prototype.random = function(){
		var randomIndex = Math.floor(Math.random() * (this.length - 1 + 1));
		return this[randomIndex];
	};
}

if(!Math.randomRange) {
	Math.randomRange = function(min, max, isFloat){
		if(isFloat) {
			return Math.random() * (max - min) + min;
		}
	    return Math.floor(Math.random() * (max - min + 1)) + min;
	};
}

if(!Array.prototype.fill) {
	Array.prototype.fill = function(element){
		for(var i = 0, len = this.length; i < len; i++){
			this[i] = element;
		}
		return this;
	};
}

if (!Array.prototype.find) {
  Array.prototype.find = function(predicate) {
    if (this == null) {
      throw new TypeError('Array.prototype.find called on null or undefined');
    }
    if (typeof predicate !== 'function') {
      throw new TypeError('predicate must be a function');
    }
    var list = Object(this);
    var length = list.length >>> 0;
    var thisArg = arguments[1];
    var value;

    for (var i = 0; i < length; i++) {
      value = list[i];
      if (predicate.call(thisArg, value, i, list)) {
        return value;
      }
    }
    return undefined;
  };
}