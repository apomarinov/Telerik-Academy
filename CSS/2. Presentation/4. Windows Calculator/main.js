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
					console.log('start');
				}
			});

			$(document).on({
				mousemove: function(event){
					if(!self.isDragged) {
						return false;
					}
					console.log('move');
					self.currentX = event.pageX;
					self.currentY = event.pageY;
					self.deltaX = Math.abs(self.previousX - self.currentX);
					self.deltaY = Math.abs(self.previousY - self.currentY);
					currentWindow.css({
						'margin-left': self.deltaX + "px",
						'margin-top': self.deltaY + "px"
					});
				},
				mouseup: function(){
					self.reset();
				}
			});
		};

		this.reset = function(){
			self.isDragged = false;
		};
	};
});