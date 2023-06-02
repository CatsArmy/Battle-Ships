using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips.BoardAlgorithm
{
    public class Cell
    {
        BattleShip ship;
        bool isHit;

        public Cell()
        {
            ship = null;
            isHit = false;
        }
        public BattleShip GetShip()
        {
            return ship;
        }
        public void SetShip(BattleShip _ship)
        {
            ship = new BattleShip(_ship/*,ship type and all that stuff from Ship class*/);
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
}
