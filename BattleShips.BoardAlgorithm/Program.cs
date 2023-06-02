//https://www.c-sharpcorner.com/blogs/battleship-game-in-c-sharp-console-part-1
//https://www.google.com/search?q=c%23+battleship+console+application&client=firefox-b-d&biw=1280&bih=587&sxsrf=APwXEdc9hSharYpAcOAdoUj_EVzp5niN6g%3A1685613381095&ei=RWt4ZNCxBf6Rxc8Piei20AM&oq=battleships+10x10+board+algorithm+C%23&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgBMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADMgoIABBHENYEELADSgQIQRgAUABYAGDXNGgBcAF4AIABAIgBAJIBAJgBAMABAcgBCA&sclient=gws-wiz-serp


using System.Diagnostics.CodeAnalysis;

class Board
{
    Cell[,] cells;
    
    public Board()
    {
        cells = new Cell[10, 10];
    }
    void Initialize()
    {
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells[i,j] = new Cell();
            }
        }
    }

    void PlaceShip(Ship ship)
    {

    }
}
class Cell
{
    Ship ship;
    bool isHit;

    public Cell()
    {
        ship = null;
        isHit = false;
    }
    public Ship GetShip()
    {
        return ship;
    }
    public void SetShip(Ship _ship)
    {
        ship = new Ship(_ship/*,ship type and all that stuff from Ship class*/);
    }
    public bool GetIsHit()
    {
        return isHit;
    }
    public void SetIsHit(bool value)
    {
        isHit = value;
    }
}

class Ship
{
    /*
    "has ship type (No.)"
    "is rotated?/direction"
    "No. Class of ship  Size"
    "1 	Carrier 	    5"
    "2 	Battleship 	    4"
    "3 	Cruiser 	    3"
    "4 	Submarine 	    3"
    "5 	Destroyer 	    2"
    */
    public Ship(Ship ship)
    {
        //copy porpetys
    }
}
