$(document).ready(function(){
	var calculatorWindow = new draggableWindow();
	calculatorWindow.init();


	function draggableWindow(){
		var self = this;
		var currentWindow = $(".draggable").closest('.window');

		var isDragged = false;

		var previousX = 0,
			previousY = 0;
		var currentX = 0,
			currentY = 0;
		var deltaX = 0,
			deltaY = 0;

		this.init = function(){
			$(".draggable").on({
				mousedown: function (event){
					self.previousX = event.pageX;
					self.previousY = event.pageY;
					self.isDragged = true;
				}
			});

			$(document).on({
				mousemove: function(event){
					if(!self.isDragged) {
						return false;
					}
					self.getCurrentMouseCoordinates(event);
					self.moveWindow();
				},
				mouseup: function(){
					self.reset();
				}
			});
		};

		this.getCurrentMouseCoordinates = function (event) {
			self.currentX = event.pageX;
			self.currentY = event.pageY;
			self.deltaX = self.currentX - self.previousX;
			self.deltaY = self.currentY - self.previousY;
			self.previousX = self.currentX;
			self.previousY = self.currentY;
		}

		this.moveWindow = function (){
			var currentLeft = parseInt(currentWindow.css('margin-left'));
			var currentTop = parseInt(currentWindow.css('margin-top'));
			currentWindow.css({
				'margin-left': (currentLeft + self.deltaX) + "px",
				'margin-top': (currentTop + self.deltaY) + "px"
			});			
		};

		this.reset = function(){
			self.isDragged = false;
		};
	};
});