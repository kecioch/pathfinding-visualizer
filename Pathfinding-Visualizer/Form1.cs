using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinding_Visualizer
{
    public partial class Form1 : Form
    {
        int scaleSize = 2;
        int stdX = 10;
        int stdY = 5;
        int anzahlX;
        int anzahlY;
        int anzahlGesamt;
        int padding = 1;
        int delay = 45;

        float gridWidth;
        float gridHeight;
        float cellWidth;
        float cellHeight;

        Thread threadAlgo;

        List<Knoten> knotenLi = new List<Knoten>();
        int startKnoten = -1;
        int endKnoten = -1;


        // Methoden
        private void resetLabelUI()
        {
            lbNodes.Text = "Nodes: ";
            lbPath.Text = "Path: ";
            lbTime.Text = "Time: ";

            lblExportNodes.Text = "";
            lblExportPath.Text = "";
            lblExportSize.Text = "";
            lblExportTotal.Text = "";
            lblExportTime.Text = "";
            lblExportDelay.Text = "";
            lblExportAlgorithm.Text = "";
        }

        public void initAnzahl()
        {
            anzahlX = stdX * scaleSize;
            anzahlY = stdY * scaleSize;
            anzahlGesamt = anzahlX * anzahlY;
        }

        public void initGrid()
        {
            gridWidth = pbGrid.Width;
            gridHeight = pbGrid.Height;
            cellWidth = (gridWidth - padding - anzahlX * padding) / anzahlX;
            cellHeight = (gridHeight - padding - anzahlY * padding) / anzahlY;
        }

        public Point getRowColumnFromCoord(float x, float y)
        {
            float temp = 0;

            int iX = 0;
            while (temp < x)
            {
                temp = iX * cellWidth + padding * iX + padding;
                iX++;
            }
            iX -= 2;

            temp = 0;
            int iY = 0;
            while (temp < y)
            {
                temp = iY * cellHeight + padding * iY + padding;
                iY++;
            }
            iY -= 2;

            return new Point(iX, iY);
        }

        public int getIDfromRowColumn(Point pt)
        {
            return (pt.Y * anzahlX + pt.X);
        }


        // UI-Methoden
        public Form1()
        {
            InitializeComponent();
            initGrid();
            initAnzahl();
            Graphen.createKnotenListe(ref knotenLi, ref startKnoten, ref endKnoten, anzahlX, anzahlY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Auswahl - Algorithmen
            cbAlgorithmus.Items.Add("A*");
            cbAlgorithmus.Items.Add("Dijkstra");
            cbAlgorithmus.SelectedIndex = 0;

            // Auswahl - ToolBox
            cbToolbox.Items.Add("Start");
            cbToolbox.Items.Add("End");
            cbToolbox.Items.Add("Wall");
            cbToolbox.Items.Add("Eraser");
            cbToolbox.SelectedIndex = 0;

            // Reset
            resetLabelUI();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            System.Diagnostics.Debug.WriteLine(path);

            if (path != "")
            {
                int width = pbGrid.Size.Width;
                int height = pbGrid.Size.Height;
                int heightHeader = pnlExportHeader.Height;
                int heightInfo = pnlExportInfo.Height;

                // Update Information
                lblExportNodes.Text = lbNodes.Text.Replace("Nodes: ", "");
                lblExportPath.Text = lbPath.Text.Replace("Path: ","");
                lblExportSize.Text = lbSize.Text;
                lblExportTotal.Text = anzahlGesamt.ToString();
                lblExportTime.Text = lbTime.Text.Replace("Time: ","");
                lblExportDelay.Text = lbDelay.Text;
                lblExportAlgorithm.Text = cbAlgorithmus.SelectedItem.ToString();

                // Draw
                Bitmap bm = new Bitmap(width, height + heightHeader + heightInfo);
                pbGrid.DrawToBitmap(bm, new Rectangle(0, heightHeader, width, height));
                pnlExportHeader.Visible = true;
                pnlExportHeader.DrawToBitmap(bm, new Rectangle(0, 0, width, heightHeader));
                pnlExportHeader.Visible = false;
                pnlExportInfo.Visible = true;
                pnlExportInfo.DrawToBitmap(bm, new Rectangle(0, heightHeader + height, width, heightInfo));
                pnlExportInfo.Visible = false;

                // ImageFormat
                ImageFormat imgFormat = ImageFormat.Jpeg;
                string userImgFormat = System.IO.Path.GetExtension(path);

                switch(userImgFormat)
                {
                    case ".png":
                        imgFormat = ImageFormat.Png;
                        break;
                    case ".bmp":
                        imgFormat = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        imgFormat = ImageFormat.Gif;
                        break;
                    case ".tiff":
                        imgFormat = ImageFormat.Tiff;
                        break;
                    case ".wmf":
                        imgFormat = ImageFormat.Wmf;
                        break;
                }

                bm.Save(path, imgFormat);
            }
        }

        private void trackBarRandom_ValueChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Random: "+trackBarRandom.Value);
            lbDensity.Text = (trackBarRandom.Value * 10).ToString() + " %";
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            resetLabelUI();
            System.Diagnostics.Debug.WriteLine("Size: "+trackBarSize.Value);
            scaleSize = trackBarSize.Value;
            lbSize.Text = stdX * scaleSize + " x " + stdY * scaleSize;
            initAnzahl();
            initGrid();
            Graphen.createKnotenListe(ref knotenLi, ref startKnoten, ref endKnoten, anzahlX, anzahlY);
            pbGrid.Refresh();
        }

        private void trackBarDelay_ValueChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Delay: "+trackBarDelay.Value);
            switch(trackBarDelay.Value)
            {
                case 0:
                    delay = 0;
                    break;
                case 1:
                    delay = 10;
                    break;
                case 2:
                    delay = 25;
                    break;
                case 3:
                    delay = 45;
                    break;
                case 4:
                    delay = 80;
                    break;
                case 5:
                    delay = 100;
                    break;
                case 6:
                    delay = 150;
                    break;
                case 7:
                    delay = 200;
                    break;
                case 8:
                    delay = 500;
                    break;
                case 9:
                    delay = 1000;
                    break;
                case 10:
                    delay = 2000;
                    break;
            }

            lbDelay.Text = delay.ToString() + " ms";
        }

        private void pbGrid_Paint_1(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("PAINT");
            
            initAnzahl();
            initGrid();

            float posX;
            float posY;
            int index = 0;

            for (int y = 0; y < anzahlY; y++)
            {
                posY = y * cellHeight + padding * y + padding;

                for (int x = 0; x < anzahlX; x++)
                {
                    posX = x * cellWidth + padding * x + padding;
                    Color col = Color.Beige;
                    StatesKnoten state = knotenLi.ElementAt(index).state;

                    switch(state)
                    {
                        case StatesKnoten.EMPTY:
                            col = Color.White;
                            break;
                        case StatesKnoten.DISCOVERED:
                            col = Color.FromArgb(34,242,204);//(121,199,217);
                            break;
                        case StatesKnoten.FINISHED:
                            col = Color.FromArgb(121,199,217);//(20,84,140);
                            break;
                        case StatesKnoten.START:
                            col = Color.Green;
                            break;
                        case StatesKnoten.WALL:
                            col = Color.Black;
                            break;
                        case StatesKnoten.END:
                            col = Color.Red;
                            break;
                        case StatesKnoten.PATH:
                            col = Color.Yellow;
                            break;
                    }

                    e.Graphics.FillRectangle(new SolidBrush(col), posX, posY, cellWidth, cellHeight);
                    // DEBUG
                    //e.Graphics.DrawString("ID: "+index.ToString(), new Font("Arial",10), Brushes.Blue, posX, posY);
                    //e.graphics.drawstring("g: " + knotenli[index].gcost.tostring(), new font("arial", 15), brushes.blue, posx, posy);
                    //e.graphics.drawstring("h: " + knotenli[index].hcost.tostring(), new font("arial", 15), brushes.blue, posx, posy + 60);
                    //e.graphics.drawstring("f: " + (knotenli[index].hcost + knotenli[index].gcost).tostring(), new font("arial", 20), brushes.darkgoldenrod, posx, posy + 120);

                    index++;
                }
            }
        }

        public void updateKnotenCell(MouseEventArgs e)
        {
            if (threadAlgo == null || !threadAlgo.IsAlive)
            {
                Point pt = getRowColumnFromCoord(e.X, e.Y);
                int index = getIDfromRowColumn(pt);
                if (index >= 0 && index < anzahlGesamt)
                {
                    StatesKnoten state = StatesKnoten.EMPTY;
                    string toolAuswahl = cbToolbox.SelectedItem.ToString();

                    if (index == startKnoten)
                        startKnoten = -1;

                    if (index == endKnoten)
                        endKnoten = -1;

                    switch (toolAuswahl)
                    {
                        case "Start":
                            state = StatesKnoten.START;
                            if (startKnoten != -1)
                                knotenLi.ElementAt(startKnoten).state = StatesKnoten.EMPTY;
                            startKnoten = index;
                            break;
                        case "End":
                            state = StatesKnoten.END;
                            if (endKnoten != -1)
                                knotenLi.ElementAt(endKnoten).state = StatesKnoten.EMPTY;
                            endKnoten = index;
                            break;
                        case "Wall":
                            state = StatesKnoten.WALL;
                            break;
                        case "Eraser":
                            state = StatesKnoten.EMPTY;
                            if (index == startKnoten)
                                startKnoten = -1;
                            if (index == endKnoten)
                                endKnoten = -1;
                            break;
                    }

                    string kanten = "";
                    foreach (Kante k in knotenLi[index].kanten)
                    {
                        kanten += k.indexTarget.ToString() + "(" + k.cost.ToString() + "); ";
                    }
                    System.Diagnostics.Debug.WriteLine("INDEX: " + index + " Kanten: " + kanten);

                    knotenLi.ElementAt(index).state = state;
                    pbGrid.Refresh();
                }
            }
        }

        private void pbGrid_MouseDown(object sender, MouseEventArgs e)
        {
            updateKnotenCell(e);
        }

        private void pbGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
            {
                Control control = (Control)sender;

                if (control.Capture)
                    control.Capture = false;

                updateKnotenCell(e);      
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            resetLabelUI();

            startKnoten = -1;
            endKnoten = -1;

            Random rnd = new Random();
            int randomInt;
            int dichte = trackBarRandom.Value;

            foreach(Knoten k in knotenLi)
            {
                randomInt = rnd.Next(1, 11);
                if ((randomInt % 10) < (dichte))
                    k.state = StatesKnoten.WALL;
                else
                    k.state = StatesKnoten.EMPTY;
            }

            pbGrid.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetLabelUI();
            Graphen.resetNodes(ref knotenLi);

            pbGrid.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            resetLabelUI();
            initAnzahl();
            Graphen.createKnotenListe(ref knotenLi, ref startKnoten, ref endKnoten, anzahlX, anzahlY);
            initGrid();
            pbGrid.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(startKnoten != -1 && endKnoten != -1)
            {
                System.Diagnostics.Debug.WriteLine("Starte "+cbAlgorithmus.SelectedItem.ToString()+"Algorithmus");
                resetLabelUI();
                Graphen.resetNodes(ref knotenLi);
                ControlUI controlUI = new ControlUI(btnStart, btnReset, btnDelete, btnRandom, btnExport, 
                                                    lbNodes, lbTime, lbPath, pbGrid, trackBarSize);

                string algorithmus = cbAlgorithmus.SelectedItem.ToString();
                switch(algorithmus)
                {
                    case "Dijkstra":
                        threadAlgo = new Thread(delegate() { Algorithmen.Dijkstra(ref knotenLi, startKnoten, endKnoten, ref delay, controlUI); });
                        threadAlgo.Start();
                        pbGrid.Refresh();
                        break;

                    case "A*":
                        threadAlgo = new Thread(delegate () { Algorithmen.AStar(ref knotenLi, startKnoten, endKnoten, anzahlX, ref delay, controlUI); });
                        threadAlgo.Start();
                        pbGrid.Refresh();
                        break;
                }
            }
        }
    }
}
