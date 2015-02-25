using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


class Program
{
	static string[] dims = "4 2 4".Split (' ');
	//static string[] dims = Console.ReadLine().Split(' ');
	static int  x = int.Parse (dims [0]) + 1,
		y = int.Parse (dims [1]) + 1,
		z = int.Parse (dims [2]) + 1;
	static int planeX = 2 * (y + z);
	static int planeY = x;
	static char[,] plane = new char[planeY, planeX];
	
	static char[] p1Moves = "MMMM".ToCharArray ();
	static char[] p2Moves = "MMMM".ToCharArray ();
	//static char[] p1Moves = Console.ReadLine().ToCharArray();
	//static char[] p2Moves = Console.ReadLine().ToCharArray();
	// x, y
	static int[] p1Pos = { x / 2, y / 2 };
	static int[] p2Pos = { x / 2, y / 2 * 3 + z - 1};
	static int[] p1Dir = { 0, 1 };
	static int[] p2Dir = { 0, -1 };
	
	static bool p1Crashed = false, p2Crashed = false;
	
	static int[] p1StartPos = {p1Pos [0], p1Pos [1]};
	static int[] p1EndPos = new int[2];
	
	enum directions
	{
		UP,
		DOWN,
		FORWARD,
		BACK
	}
	
	static void Main ()
	{
		for (int i = 0; i < plane.GetLength(0); i++) {
			for (int j = 0; j < plane.GetLength(1); j++) {
				plane [i, j] = '-';
			}
		}
		
		for (int i = 0; i < p1Moves.Length; i++) {
			
			if (!p1Crashed) {
				if (p1Moves [i] != 'M') {
					Turn (1, p1Moves [i]);
				} else {
					MovePlayer (1);
				}
			}
			if (!p2Crashed && i < p2Moves.Length) {
				if (p2Moves [i] != 'M') {
					Turn (2, p2Moves [i]);
				} else {
					MovePlayer (2);
				}
			}

//			Print (plane);
//			Application.DoEvents ();
//			Thread.Sleep (50);
		}
		
		if (p1Crashed && !p2Crashed) {
			Console.WriteLine ("BLUE");
		}
		if (p2Crashed && !p1Crashed) {
			Console.WriteLine ("RED");
		}
		if (p1Crashed && p2Crashed) {
			Console.WriteLine ("DRAW");
		}
		Console.WriteLine (Math.Abs (p1StartPos [0] - p1EndPos [0]) + Math.Abs (p1StartPos [1] - p1EndPos [1]));
	}
	
	static void MovePlayer (int which)
	{
		if (which == 1) {
			plane [p1Pos [0], p1Pos [1]] = 'O';	
			p1EndPos [0] = p1Pos [0] + p1Dir [0];
			p1EndPos [1] = p1Pos [1] + p1Dir [1];
			if (EntersForbiddenWall (p1Pos, p1Dir) || OverlapsPlayer (p1Pos, p1Dir)) {
				p1Crashed = true;
			} else {
				p1Pos [0] += p1Dir [0];
				p1Pos [1] += p1Dir [1];
				if (p1Pos [1] == planeX) {
					p1Pos [1] = 0;
				} else if (p1Pos [1] == -1) {
					p1Pos [1] = planeX - 1;
				}	
			}
		} else {
			plane [p2Pos [0], p2Pos [1]] = 'X';	
			if (EntersForbiddenWall (p2Pos, p2Dir) || OverlapsPlayer (p2Pos, p2Dir)) {
				p2Crashed = true;
			} else {
				p2Pos [0] += p2Dir [0];
				p2Pos [1] += p2Dir [1];
				if (p2Pos [1] == planeX) {
					p2Pos [1] = 0;
				} else if (p2Pos [1] == -1) {
					p2Pos [1] = planeX - 1;
				}	
			}
		}
	}
	
	static bool EntersForbiddenWall (int[] pPos, int[] pDir)
	{
		return pPos [0] + pDir [0] < 0 || pPos [0] + pDir [0] == planeY;
	}
	
	static bool OverlapsPlayer (int[] pPos, int[] pDir)
	{
		if (pPos [0] + pDir [0] < 0 || pPos [0] + pDir [0] == planeY 
			|| pPos [1] + pDir [1] < 0 || pPos [1] + pDir [1] == planeX) {
			return false;
		}
		char nextCellChar = plane [pPos [0] + pDir [0], pPos [1] + pDir [1]];
		return nextCellChar == 'O' || nextCellChar == 'X';
	}
	
	static void Turn (int player, char way)
	{
		if (way == 'L') {
			switch (MovingDir (player)) {
			case directions.UP:
				TurnBack (player);
				break;
			case directions.DOWN:
				TurnForward (player);
				break;
			case directions.FORWARD:
				TurnUp (player);
				break;
			case directions.BACK:
				TurnDown (player);
				break;
			}	
		} else {
			switch (MovingDir (player)) {
			case directions.UP:
				TurnForward (player);
				break;
			case directions.DOWN:
				TurnBack (player);
				break;
			case directions.FORWARD:
				TurnDown (player);
				break;
			case directions.BACK:
				TurnUp (player);
				break;
			}
		}
	}
	
	static void TurnUp (int player)
	{
		if (player == 1) {
			p1Dir [0] = -1;
			p1Dir [1] = 0;
		} else {
			p2Dir [0] = -1;
			p2Dir [1] = 0;			
		}
	}
	
	static void TurnDown (int player)
	{
		if (player == 1) {
			p1Dir [0] = 1;
			p1Dir [1] = 0;
		} else {
			p2Dir [0] = 1;
			p2Dir [1] = 0;			
		}
	}
	
	static void TurnForward (int player)
	{
		if (player == 1) {
			p1Dir [0] = 0;
			p1Dir [1] = 1;
		} else {
			p2Dir [0] = 0;
			p2Dir [1] = 1;			
		}
	}
	
	static void TurnBack (int player)
	{
		if (player == 1) {
			p1Dir [0] = 0;
			p1Dir [1] = -1;
		} else {
			p2Dir [0] = 0;
			p2Dir [1] = -1;			
		}
	}
	
	static directions MovingDir (int player)
	{
		if (player == 1) {
			if (p1Dir [0] == 0 && p1Dir [1] == 1) {
				return directions.FORWARD;
			} else if (p1Dir [0] == -1 && p1Dir [1] == 0) {
				return directions.UP;
			} else if (p1Dir [0] == 0 && p1Dir [1] == -1) {
				return directions.BACK;
			} else if (p1Dir [0] == 1 && p1Dir [1] == 0) {
				return directions.DOWN;
			}
		} else {
			if (p2Dir [0] == 0 && p2Dir [1] == 1) {
				return directions.FORWARD;
			} else if (p2Dir [0] == -1 && p2Dir [1] == 0) {
				return directions.UP;
			} else if (p2Dir [0] == 0 && p2Dir [1] == -1) {
				return directions.BACK;
			} else if (p2Dir [0] == 1 && p2Dir [1] == 0) {
				return directions.DOWN;
			}
		}

		return directions.FORWARD;
	}
	
	static void Print (char[,] m)
	{
		Console.Clear ();
		int rowLength = m.GetLength (0);
		int colLength = m.GetLength (1);
		string elStr;
		
		for (int i = 0; i < rowLength; i++) {
			Console.Write ("{");
			for (int j = 0; j < colLength; j++) {
				elStr = m [i, j].ToString ();
				Console.Write (elStr + (j != colLength - 1 ? "  " : ""));
			}
			Console.Write ("}\n");
		}
	}
}
