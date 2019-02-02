// Started by Alyssa Hove
// 2/1/19
// Board class: deals with validating spaces and checking for wins and losses
using System;

public class Board
{
    // Instance Variables 
    public int width;
    public int height;
    public char[,] board;
   

    // Setter
    public void SetBoard(int wid, int height)
    {
    }
    
    // Getter
    public char[,] GetBoard ()
    {
        
    }
    
    // methods
    public bool ValidateLocation ( int row, int col) // validate that location is free
    {

    }

    public bool CheckHorWin (int row, int col, token t, Board b) // check if can win horizontally check left until nothing on left then start from beginning and go right
    {

    }
    public bool CheckVertWin (int row, int col, token t, Board b) // check if can win vertically
    {

    }

    public bool CheckDiagonalWin(int row, int col, token t, Board b) // check if can win diagonally 
    {

    }

    public void DisplayBoard(int row, int col)
    {
        
    }




}
