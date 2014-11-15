namespace Gol
{
    using System.Collections.Generic;
    using System.Linq;

    public class Cell
    {
        private bool _state;
        private List<Cell> _neighbours;

        public Cell(bool state)
        {
            _state = state;
            _neighbours = new List<Cell>();
        }

        public bool IsAlive()
        {
            return _state;
        }

        public void AddNeighbour(Cell otherCell)
        {
            _neighbours.Add(otherCell);
        }

        public void ComputeState()
        {
            var aliveNeighbours = _neighbours.Count(n => n.IsAlive());
            if (aliveNeighbours < 2)
            {
                _state = false;
            }
            else if (aliveNeighbours <= 3)
            {
                if (aliveNeighbours != 2)
                {
                    _state = true;
                }
            }
        }
    }
}
