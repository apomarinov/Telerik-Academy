$(document).ready(function(){
	var calculatorWindow = new draggableWindow();
	calculatorWindow.init();


	function draggableWindow(){
		var self = this;
		var startX = 0,
			startY = 0;
		var deltaX = 0,
			deltaY = 0;

		this.init = function(){
			$(".draggable").on({
				mousedown: function (event){
					self.startX = event.pageX;
					self.startY = event.pageY;
				},
				mousemove: function(event){
					
				}
			});
		};
	};
});