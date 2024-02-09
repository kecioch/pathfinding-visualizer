using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pathfinding_Visualizer
{
    public class ControlUI
    {
        // Attribute
        private Button btnStart;
        private Button btnReset;
        private Button btnDelete;
        private Button btnRandom;
        private Button btnExport;
        private Label lbNodes;
        private Label lbTime;
        private Label lbPath;
        private TrackBar tbSize;
        private PictureBox pbGrid;


        // Konstruktor
        public ControlUI(Button btnStart,Button btnReset,Button btnDelete,Button btnRandom,Button btnExport,
                        Label lbNodes, Label lbTime, Label lbPath, PictureBox pbGrid, TrackBar tbSize)
        {
            this.btnStart = btnStart;
            this.btnReset = btnReset;
            this.btnDelete = btnDelete;
            this.btnRandom = btnRandom;
            this.btnExport = btnExport;
            this.lbNodes = lbNodes;
            this.lbPath = lbPath;
            this.lbTime = lbTime;
            this.pbGrid = pbGrid;
            this.tbSize = tbSize;
        }

        // Methoden
        private void buttonEnabled(Button btn, Boolean state)
        {
            btn.Invoke((Action)delegate { btn.Enabled = state; });
        }

        private void labelSetText(Label lbl, string text)
        {
            lbl.Invoke((Action)delegate { lbl.Text = text; });
        }

        public void btnStartEnabled(Boolean state) { buttonEnabled(btnStart, state); }
        public void btnResetEnabled(Boolean state) { buttonEnabled(btnReset, state); }
        public void btnDeleteEnabled(Boolean state) { buttonEnabled(btnDelete, state); }
        public void btnRandomEnabled(Boolean state) { buttonEnabled(btnRandom, state); }
        public void btnExportEnabled(Boolean state) { buttonEnabled(btnExport, state); }
        public void lbNodesSetText(String text) { labelSetText(lbNodes, text); }
        public void lbPathSetText(String text) { labelSetText(lbPath, text); }
        public void lbTimeSetText(String text) { labelSetText(lbTime, text); }
        public void tbSizeEnabled(Boolean state) { this.tbSize.Invoke((Action)delegate { this.tbSize.Enabled = state; }); }
        public void gridRefresh() { pbGrid.Invoke((Action)delegate { this.pbGrid.Refresh(); }); }

        public void allControlElementsEnabled(Boolean state)
        {
            btnStartEnabled(state);
            btnResetEnabled(state);
            btnDeleteEnabled(state);
            btnRandomEnabled(state);
            btnExportEnabled(state);
            tbSizeEnabled(state);
        }

        public void updateLabels(int delay, DateTime timeStart, System.Diagnostics.Stopwatch sw, int nodesCnt)
        {
            TimeSpan timeElapsed = DateTime.Now - timeStart;
            lbTimeSetText("Time: " + sw.Elapsed.TotalSeconds.ToString("00.000000") + " sec");
            lbNodesSetText("Nodes: " + nodesCnt.ToString());
        }
    }
}
