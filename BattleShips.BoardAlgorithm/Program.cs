public class Board
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

    void PlaceShip(BattleShip ship)
    {

    }
}
