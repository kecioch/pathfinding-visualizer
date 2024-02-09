using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pathfinding_Visualizer
{
    public class Algorithmen
    {
        private static void initNodes(List<Knoten> knotenLi)
        {
            foreach (Knoten k in knotenLi)
            {
                k.gCost = -1;
                k.hCost = -1;
                k.indexVorgaenger = -1;
            }
        }

        private static int findLowestCostIndexG(List<Knoten> knotenLi, List<int> discoveredNodes)
        {
            int index = -1;
            int value = -1;

            if (discoveredNodes.Count != 0)
            {
                index = 0;
                value = knotenLi[discoveredNodes[index]].gCost;

                for (int i = 1; i < discoveredNodes.Count; i++)
                {
                    if (knotenLi[discoveredNodes[i]].gCost < value)
                    {
                        index = i;
                        value = knotenLi[discoveredNodes[i]].gCost;
                    }
                }
            }

            return index;
        }

        private static int findLowestCostIndexF(List<Knoten> knotenLi, List<int> discoveredNodes)
        {
            int index = -1;
            int fCost = -1;
            int hCost = -1;

            if (discoveredNodes.Count != 0)
            {
                index = 0;
                hCost = knotenLi[discoveredNodes[index]].hCost;
                fCost = hCost + knotenLi[discoveredNodes[index]].gCost;

                for (int i = 1; i < discoveredNodes.Count; i++)
                {
                    int fCostDiscoveredNode = (knotenLi[discoveredNodes[i]].hCost + knotenLi[discoveredNodes[i]].gCost);
                    if (fCostDiscoveredNode < fCost || (fCostDiscoveredNode == fCost) && (knotenLi[discoveredNodes[i]].hCost < hCost))
                    {
                        index = i;
                        hCost = knotenLi[discoveredNodes[i]].hCost;
                        fCost = hCost + knotenLi[discoveredNodes[i]].gCost;
                    }
                }
            }

            return index;
        }

        private static void setNewCostG(ref List<Knoten> knotenLi, int index, int vorgaengerIndex, int newCost)
        {
            knotenLi[index].gCost = newCost;
            knotenLi[index].indexVorgaenger = vorgaengerIndex;
        }

        private static void setPath(List<Knoten> knotenLi, int startknoten, int endknoten, ControlUI controlUI)
        {
            if (knotenLi[endknoten].gCost != -1)
            {
                int pathLen = 0;
                int aktKnotenIndex = knotenLi[endknoten].indexVorgaenger;
                while (aktKnotenIndex != startknoten)
                {
                    pathLen++;
                    knotenLi[aktKnotenIndex].state = StatesKnoten.PATH;
                    aktKnotenIndex = knotenLi[aktKnotenIndex].indexVorgaenger;
                    controlUI.gridRefresh();
                    Thread.Sleep(15);
                }

                // Path Label aktualisieren
                controlUI.lbPathSetText("Path: " + pathLen.ToString());
            }
            else
            {
                MessageBox.Show("No path found!", "Information");
            }
        }


        // Wegfindungs-Algorithmen

        // Dijkstra Algorithmus
        public static void Dijkstra(ref List<Knoten> knotenLi, int startknoten, int endknoten, ref int delay, ControlUI controlUI)
        {
            System.Diagnostics.Debug.WriteLine("Startknoten: " + startknoten + ", Endknoten: " + endknoten + ", KnotenListe: " + knotenLi);
            controlUI.allControlElementsEnabled(false);

            DateTime timeStart = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // INIT Knoten
            initNodes(knotenLi);

            knotenLi[startknoten].gCost = 0;

            // INIT Liste
            List<int> discoveredNodes = new List<int>();
            discoveredNodes.Add(startknoten);

            // Algorithmus
            int aktKnoten = startknoten;
            int nodesCnt = 0;

            while ((discoveredNodes.Count != 0) && (aktKnoten != endknoten))
            {
                // Aktullen Knoten bestimmen
                // Knoten mit geringsten Kosten aus WarteListe finden
                int index = findLowestCostIndexG(knotenLi, discoveredNodes);
                aktKnoten = discoveredNodes[index];
                discoveredNodes.RemoveAt(index);

                // Nachbarn prüfen
                foreach (Kante k in knotenLi[aktKnoten].kanten)
                {
                    StatesKnoten kantenState = knotenLi[k.indexTarget].state;
                    if (kantenState != StatesKnoten.FINISHED && kantenState != StatesKnoten.WALL)
                    {
                        // Wenn Nachbarknoten noch nicht initialisiert oder höhere Kosten als neue Verbindung
                        if (knotenLi[k.indexTarget].gCost == -1)
                        {
                            nodesCnt++;
                            discoveredNodes.Add(k.indexTarget);
                            setNewCostG(ref knotenLi, k.indexTarget, aktKnoten, knotenLi[aktKnoten].gCost + k.cost);
                            if (knotenLi[k.indexTarget].state != StatesKnoten.END && knotenLi[k.indexTarget].state != StatesKnoten.START)
                                knotenLi[k.indexTarget].state = StatesKnoten.DISCOVERED;
                        }
                        else if (knotenLi[k.indexTarget].gCost > (knotenLi[aktKnoten].gCost + k.cost))
                        {
                            setNewCostG(ref knotenLi, k.indexTarget, aktKnoten, knotenLi[aktKnoten].gCost + k.cost);
                        }
                    }
                }

                // AktKnoten beenden
                if (knotenLi[aktKnoten].state != StatesKnoten.END && knotenLi[aktKnoten].state != StatesKnoten.START)
                    knotenLi[aktKnoten].state = StatesKnoten.FINISHED;

                if (delay != 0)
                {
                    // Grid aktualisieren
                    controlUI.gridRefresh();

                    // Labels aktualisieren
                    controlUI.updateLabels(delay, timeStart, sw, nodesCnt);

                    Thread.Sleep(delay);
                }
            }

            // Labels aktualisieren
            sw.Stop();
            controlUI.updateLabels(delay, timeStart, sw, nodesCnt);

            // PATH setzen
            setPath(knotenLi, startknoten, endknoten, controlUI);

            controlUI.allControlElementsEnabled(true);

            System.Diagnostics.Debug.WriteLine(sw.Elapsed);
        }


        // A* Algorithmus
        private static int calculateCostH(int startknoten, int endknoten, int anzahlX)
        {
            Point startCoord = new Point(startknoten % anzahlX, startknoten / anzahlX);
            Point endCoord = new Point(endknoten % anzahlX, endknoten / anzahlX);

            int h_diagonal = Math.Min(Math.Abs(endCoord.X - startCoord.X), Math.Abs(endCoord.Y - startCoord.Y));
            int h_straight = Math.Abs(endCoord.X - startCoord.X) + Math.Abs(endCoord.Y - startCoord.Y);
            int h = 14 * h_diagonal + 10 * (h_straight - 2 * h_diagonal);

            return h;
        }

        public static void AStar(ref List<Knoten> knotenLi, int startknoten, int endknoten, int anzahlX, ref int delay, ControlUI controlUI)
        {
            System.Diagnostics.Debug.WriteLine("Startknoten: " + startknoten + ", Endknoten: " + endknoten + ", KnotenListe: " + knotenLi);
            controlUI.allControlElementsEnabled(false);

            DateTime timeStart = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // INIT Knoten
            initNodes(knotenLi);

            knotenLi[startknoten].gCost = 0;
            knotenLi[startknoten].hCost = 0;

            // INIT Liste
            List<int> discoveredNodes = new List<int>();
            discoveredNodes.Add(startknoten);

            // Algorithmus
            int aktKnoten = startknoten;
            int nodesCnt = 0;

            while ((discoveredNodes.Count != 0) && (aktKnoten != endknoten))
            {
                // Aktullen Knoten bestimmen
                // Knoten mit geringsten Kosten aus WarteListe finden
                int index = findLowestCostIndexF(knotenLi, discoveredNodes);

                aktKnoten = discoveredNodes[index];
                discoveredNodes.RemoveAt(index);

                // Nachbarn prüfen
                foreach (Kante k in knotenLi[aktKnoten].kanten)
                {
                    StatesKnoten kantenState = knotenLi[k.indexTarget].state;
                    if (kantenState != StatesKnoten.FINISHED && kantenState != StatesKnoten.WALL)
                    {
                        // Wenn Nachbarknoten noch nicht initialisiert oder höhere Kosten als neue Verbindung
                        if (knotenLi[k.indexTarget].gCost == -1)
                        {
                            nodesCnt++;
                            discoveredNodes.Add(k.indexTarget);

                            // H Kosten berechnen
                            int hCost = calculateCostH(k.indexTarget, endknoten, anzahlX);
                            knotenLi[k.indexTarget].hCost = hCost;

                            // G Kosten berechnen
                            setNewCostG(ref knotenLi, k.indexTarget, aktKnoten, knotenLi[aktKnoten].gCost + k.cost);
                            if (knotenLi[k.indexTarget].state != StatesKnoten.END && knotenLi[k.indexTarget].state != StatesKnoten.START)
                                knotenLi[k.indexTarget].state = StatesKnoten.DISCOVERED;
                        }
                        else if (knotenLi[k.indexTarget].gCost > (knotenLi[aktKnoten].gCost + k.cost))
                        {
                            setNewCostG(ref knotenLi, k.indexTarget, aktKnoten, knotenLi[aktKnoten].gCost + k.cost);
                        }
                    }
                }

                // AktKnoten beenden
                if (knotenLi[aktKnoten].state != StatesKnoten.END && knotenLi[aktKnoten].state != StatesKnoten.START)
                    knotenLi[aktKnoten].state = StatesKnoten.FINISHED;

                if (delay != 0)
                {
                    // Grid aktualisieren
                    controlUI.gridRefresh();

                    // Labels aktualisieren
                    controlUI.updateLabels(delay, timeStart, sw, nodesCnt);

                    Thread.Sleep(delay);
                }
            }

            // Labels aktualisieren
            sw.Stop();
            controlUI.updateLabels(delay, timeStart, sw, nodesCnt);

            // PATH setzen
            setPath(knotenLi, startknoten, endknoten, controlUI);

            controlUI.allControlElementsEnabled(true);

            System.Diagnostics.Debug.WriteLine(sw.Elapsed);
        }
    }
}
