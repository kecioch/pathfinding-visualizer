using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding_Visualizer
{
    public enum StatesKnoten { START, END, WALL, EMPTY, DISCOVERED, FINISHED, PATH };

    public class Knoten
    {
        public StatesKnoten state;
        public int index;
        public int gCost;
        public int hCost;
        public int indexVorgaenger;
        public List<Kante> kanten = new List<Kante>();
    }
}
