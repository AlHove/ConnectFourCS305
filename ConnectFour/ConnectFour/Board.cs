// Started by Alyssa Hove
// 2/1/19
// Board class: deals with validating spaces and checking for wins and losses
using System;

public class Board
{
    // Instance Variables 
    public int row; 
    public int col; 
    
    public board(char[,] array){
        array = array
    }
    // Setter
    public void SetBoard()
    {
      char[,] board = new char[15,7]{
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
            |_|_|_|_|_|_|_|
    }
    }
	    
    // Getter
    public board GetBoard(){
     return board;
    }
    
    // methods
    public bool ValidateLocation ( board b, int row, int col) // validate that location is free
    {
        if (array[row,col].b = 'X' || 'O'){
            return false;
        }
        if (array[row,col].b = '_'){
            return true;
    }
	    
	    

    public bool CheckHorWin (int row, int col, board b) // check if can win horizontally check left until nothing on left then start from beginning and go right
    {
        )
	
	
        
    public bool CheckVertWin (int row, int col, board b) // check if can win vertically
    {

    }

    public bool CheckDiagonalWin(int row, int col, board b) // check if can win diagonally 
    {

    }
        
  /* public bool CheckWin (board b){ // all encompassing win check
        
    bool win = 0;

	for( int i = 8; i >= 1; --i )
	{
		
		for( int ix = 9; ix >= 1; --ix )
		{
			//Diagonal win /
			if( array[i , ix].b == XO     &&
				array[i-1 , ix-1] == XO &&
				array[i-2 , ix-2] == XO &&
				array[i-3 , ix-3] == XO )
			{
				win = 1;
			}
		    // Horizontal win	-
			if( array[i , ix] == XO   &&
				array[i-1 , ix] == XO &&
				array[i-2 , ix] == XO &&
				array[i-3 , ix] == XO )
			{	
				win = 1;
			}
            //Diagonal win \
            	if( array[i , ix].b == XO     &&
				array[i-1 , ix+1].b == XO &&
				array[i-2 , ix+2].b == XO &&
				array[i-3 , ix+3].b == XO )
			{
				win = 1;
			}
			// Vertical win |
			if ( array[i , ix].b == XO   &&
				 array[i , ix+1].b == XO &&
				 array[i , ix+2].b == XO &&
				 array[i , ix+3].b == XO )
			{
				win = 1;
			}
		}
		return win;
    }
        
        
        */

    public void DisplayBoard(board b) //show current board
    Console.WriteLine(" 1 2 3 4 5 6 7 ");
    {
       for (int i = 0; i < 7; i++)
    {   Console.Write(i);
        for (int j = 0; j < 15; j++)
        {
            Console.WriteLine(array[i,j].b);
        }
      
    }
    }




}
