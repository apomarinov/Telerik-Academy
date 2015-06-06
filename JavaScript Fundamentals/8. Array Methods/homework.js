console.error("Моля, ако не сте, отворете index.html файлът в браузър и вижте резултата в конзолата.");
var hw = new Homework();

hw.addHelperFunction('generatePeople', function(count){
	var namesByGender = {
		male: {
			first: ["A4o", "Go6ko", "Ivan4o", "Preston", "Gan4o"],
			last: ["Minkov", "Strinkov", "Vmirisinkov", "Ajakov", "Boev"]
		},
		female: {
			first: ["Penka", "Eeva", "Mariika", "Danka", "Petkanka"],
			last: ["Miller", "Stoeva", "Ignatova", "Tutrakanskova"]
		}
	};
	var genders = ['male', 'female'];
	var MIN_AGE = 0, MAX_AGE = 130;

	var people = [];
	var fname, lname, age, gender;

	for (var i = 0; i < count; i++) {
		gender = genders[Math.randomRange(0, 1)];
		fname = namesByGender[gender].first.random();
		lname = namesByGender[gender].last.random();
		age = Math.randomRange(MIN_AGE, MAX_AGE);

		people.push(buildPerson(fname, lname, age, gender));
	};

	function buildPerson(fname, lname, age, gender) {
		return { fname: fname, lname: lname, age: age, gender: gender };
	}

	return people;
});


hw.addProblem('Make person', function(helperFunctions){
	// slojil sum zada4kata v helper funkciite 6toto i v drugite zada4i
	// mi e nujno da moga da si generiram hora
	// mojete da vidite koda po gore
	console.table(helperFunctions.generatePeople(10));
});

hw.addProblem('People of age', function(helperFunctions){
	var people = helperFunctions.generatePeople(5);
	var onlyDurtaci = people.every(function(person){
		return person.age >= 18;
	});

	console.table(people);
	console.log("Has only old people? [age >= 18]", onlyDurtaci);
});

hw.addProblem('Underage people', function(helperFunctions){
	var people = helperFunctions.generatePeople(5);
	var onlyGuzar4eta = people.filter(function(person){
		return person.age < 18;
	});

	console.table(people);
	console.log("Now only the young people: ");
	console.table(onlyGuzar4eta);
});

hw.addProblem("Average age of females", function(helperFunctions){
	var people = helperFunctions.generatePeople(10);
	var females = people.filter(function(person){
		return person.gender === 'female';
	});
	var avgFemaleAge = females.reduce(function(sum, person){
		return sum += person.age;
	}, 0) / females.length;

	console.table(people);
	console.table(females);
	console.log("Average age: " + avgFemaleAge);
});

hw.addProblem("Youngest person", function(helperFunctions){
	var people = helperFunctions.generatePeople(10);
	// because the people are random evry time I get the youngest with filter
	// than use find with his/hers age
	var youngestAge = people.sort(function(a, b){
		return a.age - b.age;
	})[0].age;

	var youngest = people.find(function(person){
		return person.age === youngestAge;
	});

	console.table(people);
	console.log("Youngest Person: ", youngest);
});

hw.addProblem("Group people", function(helperFunctions){
	var people = helperFunctions.generatePeople(10);
	var groupedPpl = {};

	groupedPpl = people.reduce(function(grouped, person){
		if(!grouped[person.fname[0]]) {
			grouped[person.fname[0]] = [];
		}
		grouped[person.fname[0]].push(person);
		return grouped;
	}, groupedPpl);

	console.table(people);
	console.log(groupedPpl);
});

hw.executeProblems();













