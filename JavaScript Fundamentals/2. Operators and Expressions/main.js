var consoleStyle = 'background: #222; color: #bada55';
var Homework = new function(){
	var self = this;

	self.problems = [
	{
		title: "Odd or Even",
		body: function(){
			// Write an expression that checks if given integer is odd or even.
			var x = 4, y = 5;

			console.log(x, isEven(x));
			console.log(y, isEven(y));

			function isEven(num){
				return num % 2 == 0;
			}
		}
	},
	{
		title: "Divisible by 7 and 5",
		body: function(){
			// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
			var x = 35, y = 30;

			console.log(x, divisbleBy5And7(x));
			console.log(y, divisbleBy5And7(y));

			function divisbleBy5And7(num){
				return num % 5 == 0 && num % 7 == 0;
			}
		}
	},
	{
		title: "Rectangle area",
		body: function(){
			// Write an expression that calculates rectangle’s area by given width and height.
			var x = 35, y = 30;

			console.log(x + " * " + y + " = " + rectArea(x, y));

			function rectArea(a, b){
				return a * b;
			}
		}
	},
	{
		title: "Third digit",
		body: function(){
			// Write an expression that checks for given integer if its third digit (right-to-left) is 7.
			var num1 = 322744, num2 = 123;

			console.log(num1, thirdDigit7(num1));
			console.log(num2, thirdDigit7(num2));

			function thirdDigit7(num) {
				var numStr = num.toString();
				return numStr[numStr.length - 3] == '7';
			}
		}
	},
	{
		title: "Third bit",
		body: function(){
			// Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
			// The bits are counted from right to left, starting from bit #0.
			// The result of the expression should be either 1 or 0.
			var num1 = 2, num2 = 10;

			console.log(getBitAtPos(num1, 3));
			console.log(getBitAtPos(num2, 3));

			function getBitAtPos(num, pos){
				return (num >> pos) & 1;
			}
		}
	},
	{
		title: "Point in Circle",
		body: function(){
			// Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
			var circle = {
				center_x: 0,
				center_y: 0,
				radius: 5
			};

			var point1 = {
				x: 1,
				y: 2
			};

			var point2 = {
				x: 6,
				y: 2
			};

			console.log("Circle =", circle);
			console.log(point1, self.helperFunctions.isPointInCircle(point1, circle));
			console.log(point2, self.helperFunctions.isPointInCircle(point2, circle));
		}
	},
	{
		title: "Is prime",
		body: function(){
			//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
			var num1 = 12, num2 = 13;

			console.log(num1, isPrime(num1));
			console.log(num2, isPrime(num2));

			function isPrime(num){
				if(num < 2)  {
					return false;
				}

				for(var divisor = 2; divisor <= Math.sqrt(num); divisor++){
					if(!(num % divisor))  {
						return false;
					}
				}

				return true;
			}
		}
	},
	{
		title: "Trapezoid area",
		body: function(){
			// Write an expression that calculates trapezoid's area by given sides a and b and height h.

			var trap = {
				a: 10,
				b: 5,
				h: 12
			};

			console.log("Trap: ", trap, " Area > ", getArea(trap));

			function getArea(trapezoid){
				return ((trapezoid.a + trapezoid.b ) / 2) * trapezoid.h;
			}
		}
	},
	{
		title: "Point in Circle and outside Rectangle",
		body: function(){
			// Write an expression that checks for given point P(x, y) if it is within 
			// the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

			var circle = {
				center_x: 0,
				center_y: 0,
				radius: 5
			};

			var rectangle = {
				top: 1,
				bottom: -1,
				left: -1,
				right: 5
			};

			var point1 = {
				x: 2,
				y: 2
			};

			var point2 = {
				x: 1,
				y: 1
			};

			console.log("Circle =", circle);
			console.log(point1, self.helperFunctions.isPointInCircle(point1, circle) && isOutsideRectangle(point1, rectangle));
			console.log(point2, self.helperFunctions.isPointInCircle(point2, circle) && isOutsideRectangle(point2, rectangle));

			function isOutsideRectangle(point, rect){
				return !(point.x >= rect.left && point.x <= rect.right && point.y <= rect.top && point.y >= rect.bottom);
			}
		}
	}];

	self.helperFunctions = {
		isPointInCircle: function (point, circle){
			return (point.x - circle.center_x) * (point.x - circle.center_x) + (point.y - circle.center_y) * (point.y - circle.center_y) < circle.radius * circle.radius;
		}
	};

	self.executeProblems = function(){
		for (var i = 0, len = self.problems.length; i < len; i++) {
			console.log("%c " + (i + 1) + ". " + self.problems[i].title + " ", consoleStyle);
			self.problems[i].body();
		};
	};
};

Homework.executeProblems();