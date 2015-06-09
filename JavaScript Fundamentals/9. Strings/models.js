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