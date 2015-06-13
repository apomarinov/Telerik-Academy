function solve(params) {
	var rows = parseInt(params[0]),
		cols = parseInt(params[1]),
		board = [],
		numberOfMoves = parseInt(params[2 + rows]),
		moves = [],
		knightMoves = {'-21':1, '-12':1, '12':1, '21':1, '2-1':1, '1-2':1, '-1-2':1, '-2-1':1};

		// get the board
	for(var i = 2; i < rows + 2; i++){
		if(!board[i]) {
			board.push(params[i].split(''));
		}
	}
	board = board.reverse();
	// get the moves
	var startMove, endMove;
	for(var i = 3 + rows; i <= 3 + rows + numberOfMoves - 1; i++){
		startMove = params[i].split(' ');
		endMove = startMove[1];
		startMove = startMove[0];
		moves.push({
			start: [parseInt(startMove[1]) - 1, startMove.charCodeAt(0) - 97],
			end: [parseInt(endMove[1]) - 1, endMove.charCodeAt(0) - 97]
		});
	}
	// check the moves
	var startPiece, endPiece, startRow, startCol, endRow, endCol, deltaRow, deltaCol, moveCount;
	for(var i = 0, len = moves.length; i < len; i++){
		startRow = moves[i].start[0];
		startCol = moves[i].start[1];
		endRow = moves[i].end[0];
		endCol = moves[i].end[1];
		startPiece = board[startRow][startCol];
		endPiece = board[endRow][endCol];

		// invalid start or end move
		if(startPiece === "-" || startPiece !== "-" && (endPiece === "K" || endPiece === "Q")) {
			console.log("no");
			continue;
		}

		// get direction
		deltaRow = (startRow - endRow);
		deltaCol = (startCol - endCol);

		if(deltaRow < 0) {
			deltaRow = 1;
		} else if(deltaRow > 0) {
			deltaRow = -1;
		}

		if(deltaCol < 0) {
			deltaCol = 1;
		} else if(deltaCol > 0) {
			deltaCol = -1;
		}
		
		// move knight
		if(startPiece === "K") {
			// check if move is valid
			if(!knightMoves.hasOwnProperty((deltaCol * (startCol - endCol)) + "" + (deltaRow * (startRow - endRow)))) {
				console.log("no");
				continue;
			}			
			// move columns
			var didMove = true;
			while(startCol !== endCol) {
				startCol += deltaCol;
				if(board[startRow][startCol] !== "-") {
					console.log("no");
					didMove = false;
					break;
				}
			}
			if(didMove) {
				console.log("yes");
				continue;
			}
			// move rows
			while(startRow !== endRow) {
				startRow += deltaRow;
				if(board[startRow][startCol] !== "-") {
					console.log("no");
					didMove = false;
					break;
				}
			}
			if(didMove) {
				console.log("yes");
			}
		} else if (startPiece === "Q"){
			var didMove = true;
			// move qeen in the direction
			while(startRow !== endRow || startCol !== endCol) {
				startRow += deltaRow;
				startCol += deltaCol;
				if(board[startRow][startCol] !== "-") {
					console.log("no");
					didMove = false;
					break;
				}
			}
			if(didMove) {
				console.log("yes");
			}
		}
	}
}


var tests = [
['3',
'4',
'--K-',
'K--K',
'Q--Q',
'12',
'd1 b3',
'a1 a3',
'c3 b2',
'a1 c1',
'a1 b2',
'a1 c3',
'a2 c1',
'd2 b1',
'b1 b2',
'c3 a3',
'a2 a3',
'd1 d3']
];

var tests2 = [
["5",
"5",
"Q---Q",
"-----",
"-K---",
"--K--",
"Q---Q",
"10",
"a1 a1",
"a1 d4",
"e1 b4",
"a5 d2",
"e5 b2",
"b3 d4",
"b3 c1",
"b3 d1",
"c2 a3",
"c2 b4"]
];


for(var i = 0, len = tests.length; i < len; i++){
	solve(tests2[i]);
}