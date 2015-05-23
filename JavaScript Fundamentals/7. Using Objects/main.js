var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [{
		title: "Planar coordinates",
		body: function(){
			var line1 = new Line(new Point(0, 0), new Point(5, 0));
			var line2 = new Line(new Point(5, 0), new Point(5, 4));
			var line3 = new Line(new Point(0, 0), new Point(5, 4));

			console.log(line1, "length > ", line1.length());
			console.log(line2, "length > ", line2.length());
			console.log(line3, "length > ", line3.length());
			console.log("Can the lines from a triangle: ", triangleByLines(line1, line2, line3));

			function Point(x, y) {
				this.x = x;
				this.y = y;
			}

			function Line(p1, p2) {
				var self = this;
				self.p1 = p1;
				self.p2 = p2;

				self.length = function() {
					return Math.sqrt(Math.pow((self.p2.x - self.p1.x), 2) + Math.pow((self.p2.y - self.p1.y), 2));
				};
			}

			function triangleByLines(line1, line2, line3) {
				return Math.pow(line1.length(), 2) + Math.pow(line2.length(), 2) === Math.pow(line3.length(), 2);
			}
		}
	},{
		title: "Remove elements",
		body: function(){
			Array.prototype.remove = function(element){
				for(var i = 0, len = this.length; i < len; i++){
					if(this[i] == element) {
						this.splice(i, 1);
					}
				}
			};

			var a = [1, 2, '3', 4];
			console.log(a);
			
			a.remove(2);
			console.log("Remove 2:", a);
			
			a.remove('3');
			console.log("Remove \"3\":", a);
		}
	},{
		title: "Deep copy",
		body: function(){
			var num = 4.4,
				obj = {prop: 123, asd: 'qwe'};

			console.log(clone(num));
			console.log(clone(obj));

			function clone(obj){
			    if(typeof obj !== 'object'){
			        return obj;
			    }

			    var copy = {};
			    for(var prop in obj){
			        copy[prop] = clone(obj[prop]);
			    }

			    return copy;
			};
		}
	},{
		title: "Has property",
		body: function(){
			var obj  = {width: 12};
			console.log(obj, "has prop 'length'?", obj.hasOwnProperty('length'));
			console.log(obj, "has prop 'width'?", obj.hasOwnProperty('width'));
		}
	},{
		title: "Youngest person",
		body: function(){
			var people = [
				{ firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
				{ firstname : 'Bay', lastname: 'Ivan', age: 81},
				{ firstname : 'Bay', lastname: 'Dragan', age: 21},
				{ firstname : 'Bay', lastname: 'Petkan', age: 11}
			];
			console.table(people);

			console.log(getYoungestPerson(people));

			function getYoungestPerson(arr) {
				arr.sort(function(el1, el2){
					return el1.age - el2.age;
				});

				return arr[0].firstname + " " + arr[0].lastname;
			}
		}
	},{
		title: "Group People",
		body: function(){
			var people = [
				{ firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
				{ firstname : 'Bay', lastname: 'Ivan', age: 11},
				{ firstname : 'Bay', lastname: 'Dragan', age: 21},
				{ firstname : 'Petko', lastname: 'Petrov', age: 11}
			];

			console.log("People:");
			console.table(people);
			
			console.log("By firstname:");
			console.log(groupBy(people, 'firstname'));			

			console.log("By lastname:");
			console.log(groupBy(people, 'lastname'));

			console.log("By age:");
			console.log(groupBy(people, 'age'));

			function groupBy(arr, prop) {
				var groupedArr = [];

				for(var i = 0, len = arr.length; i < len; i++){
					if(!groupedArr[arr[i][prop]]) {
						groupedArr[arr[i][prop]] = [];
					}
					groupedArr[arr[i][prop]].push(arr[i]);
				}

				return groupedArr;
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