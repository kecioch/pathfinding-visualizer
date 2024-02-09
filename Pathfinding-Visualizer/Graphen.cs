using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding_Visualizer
{
    class Graphen
    {
        public static void resetNodes(ref List<Knoten> knotenLi)
        {
            foreach (Knoten k in knotenLi)
            {
                if (k.state == StatesKnoten.DISCOVERED || k.state == StatesKnoten.FINISHED || k.state == StatesKnoten.PATH)
                    k.state = StatesKnoten.EMPTY;
            }
        }

        public static void addKante(ref List<Knoten> knotenli, int u, int v, int cost)
        {
            knotenli[u].kanten.Add(new Kante { indexTarget = v, cost = cost });
            knotenli[v].kanten.Add(new Kante { indexTarget = u, cost = cost });
        }

        public static void createEdges(ref List<Knoten> knotenLi, int anzahlX, int anzahlY)
        {
            // Kanten erzeugen
            int index = 0;
            for (int y = 0; y < anzahlY; y++)
            {
                for (int x = 0; x < anzahlX; x++)
                {
                    // Horizontalen-Rand prüfen
                    if (x < anzahlX - 1)
                    {
                        // Horizontale Knoten verbinden
                        addKante(ref knotenLi, index, index + 1, 10);
                    }

                    // Vertikalen-Rand prüfen
                    if (y < anzahlY - 1)
                    {
                        // Vertikale Knoten verbinden
                        addKante(ref knotenLi, index, index + anzahlX, 10);
                    }

                    // Diagonale Kanten
                    if ((x < (anzahlX - 1)) && (y < (anzahlY - 1)))
                    {
                        // Diagonale Knoten verbinden
                        addKante(ref knotenLi, index, index + anzahlX + 1, 14);
                        if (x != 0)
                        {
                            addKante(ref knotenLi, index, index + anzahlX - 1, 14);
                        }
                    }

                    index++;
                }
            }
        }

        public static void createKnotenListe(ref List<Knoten> knotenLi, ref int startKnoten, ref int endKnoten, int anzahlX, int anzahlY)
        {
            int anzahl = anzahlX * anzahlY;

            startKnoten = -1;
            endKnoten = -1;

            if (knotenLi != null)
                knotenLi.Clear();

            // Knoten erstellen
            for (int i = 0; i < anzahl; i++)
            {
                Knoten knoten = new Knoten()
                {
                    state = StatesKnoten.EMPTY,
                    index = i
                };
                knotenLi.Add(knoten);
            }

            // Kanten erzeugen
            createEdges(ref knotenLi, anzahlX, anzahlY);
        }
    }
}
