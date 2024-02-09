
namespace Pathfinding_Visualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbDensity = new System.Windows.Forms.Label();
            this.lbDelay = new System.Windows.Forms.Label();
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.trackBarRandom = new System.Windows.Forms.TrackBar();
            this.lbSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbNodes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbToolbox = new System.Windows.Forms.ComboBox();
            this.cbAlgorithmus = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.pnlExportHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlExportInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblExportAlgorithm = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblExportSize = new System.Windows.Forms.Label();
            this.lblExportTotal = new System.Windows.Forms.Label();
            this.lblExportTime = new System.Windows.Forms.Label();
            this.lblExportDelay = new System.Windows.Forms.Label();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.lblExportNodes = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.pnlExportHeader.SuspendLayout();
            this.pnlExportInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnHeader.Controls.Add(this.lbDensity);
            this.pnHeader.Controls.Add(this.lbDelay);
            this.pnHeader.Controls.Add(this.trackBarDelay);
            this.pnHeader.Controls.Add(this.trackBarRandom);
            this.pnHeader.Controls.Add(this.lbSize);
            this.pnHeader.Controls.Add(this.trackBarSize);
            this.pnHeader.Controls.Add(this.btnDelete);
            this.pnHeader.Controls.Add(this.lbTime);
            this.pnHeader.Controls.Add(this.btnExport);
            this.pnHeader.Controls.Add(this.btnRandom);
            this.pnHeader.Controls.Add(this.label6);
            this.pnHeader.Controls.Add(this.label5);
            this.pnHeader.Controls.Add(this.lbPath);
            this.pnHeader.Controls.Add(this.lbNodes);
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.cbToolbox);
            this.pnHeader.Controls.Add(this.cbAlgorithmus);
            this.pnHeader.Controls.Add(this.btnReset);
            this.pnHeader.Controls.Add(this.btnStart);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1230, 134);
            this.pnHeader.TabIndex = 0;
            // 
            // lbDensity
            // 
            this.lbDensity.BackColor = System.Drawing.Color.Transparent;
            this.lbDensity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDensity.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDensity.Location = new System.Drawing.Point(1064, 107);
            this.lbDensity.Name = "lbDensity";
            this.lbDensity.Size = new System.Drawing.Size(154, 25);
            this.lbDensity.TabIndex = 20;
            this.lbDensity.Text = "40 %";
            this.lbDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDelay
            // 
            this.lbDelay.BackColor = System.Drawing.Color.Transparent;
            this.lbDelay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDelay.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDelay.Location = new System.Drawing.Point(504, 101);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(167, 25);
            this.lbDelay.TabIndex = 15;
            this.lbDelay.Text = "45 ms";
            this.lbDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarDelay
            // 
            this.trackBarDelay.LargeChange = 1;
            this.trackBarDelay.Location = new System.Drawing.Point(493, 76);
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(187, 56);
            this.trackBarDelay.TabIndex = 4;
            this.trackBarDelay.TickFrequency = 0;
            this.trackBarDelay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDelay.Value = 3;
            this.trackBarDelay.ValueChanged += new System.EventHandler(this.trackBarDelay_ValueChanged);
            // 
            // trackBarRandom
            // 
            this.trackBarRandom.LargeChange = 1;
            this.trackBarRandom.Location = new System.Drawing.Point(1064, 82);
            this.trackBarRandom.Maximum = 8;
            this.trackBarRandom.Name = "trackBarRandom";
            this.trackBarRandom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRandom.Size = new System.Drawing.Size(154, 56);
            this.trackBarRandom.TabIndex = 3;
            this.trackBarRandom.TickFrequency = 0;
            this.trackBarRandom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRandom.Value = 4;
            this.trackBarRandom.ValueChanged += new System.EventHandler(this.trackBarRandom_ValueChanged);
            // 
            // lbSize
            // 
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSize.ForeColor = System.Drawing.SystemColors.Window;
            this.lbSize.Location = new System.Drawing.Point(896, 106);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(154, 25);
            this.lbSize.TabIndex = 10;
            this.lbSize.Text = "20 x 10";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(896, 82);
            this.trackBarSize.Maximum = 15;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(154, 56);
            this.trackBarSize.TabIndex = 8;
            this.trackBarSize.TickFrequency = 0;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 2;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(896, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTime.Location = new System.Drawing.Point(66, 95);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(410, 25);
            this.lbTime.TabIndex = 18;
            this.lbTime.Text = "Time: 230ms";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExport.Location = new System.Drawing.Point(12, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExport.Size = new System.Drawing.Size(37, 112);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "E\r\nx\r\np\r\no\r\nr\r\nt";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRandom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRandom.Location = new System.Drawing.Point(1064, 12);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(154, 44);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Randomize";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(702, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Toolbox";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(504, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delay";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPath
            // 
            this.lbPath.BackColor = System.Drawing.Color.Transparent;
            this.lbPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPath.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPath.Location = new System.Drawing.Point(278, 67);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(198, 25);
            this.lbPath.TabIndex = 13;
            this.lbPath.Text = "Path: 156";
            this.lbPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNodes
            // 
            this.lbNodes.BackColor = System.Drawing.Color.Transparent;
            this.lbNodes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNodes.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNodes.Location = new System.Drawing.Point(66, 67);
            this.lbNodes.Name = "lbNodes";
            this.lbNodes.Size = new System.Drawing.Size(198, 25);
            this.lbNodes.TabIndex = 12;
            this.lbNodes.Text = "Nodes: 1054";
            this.lbNodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1064, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Density";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(896, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbToolbox
            // 
            this.cbToolbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbToolbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbToolbox.FormattingEnabled = true;
            this.cbToolbox.Location = new System.Drawing.Point(702, 60);
            this.cbToolbox.Name = "cbToolbox";
            this.cbToolbox.Size = new System.Drawing.Size(167, 29);
            this.cbToolbox.TabIndex = 6;
            // 
            // cbAlgorithmus
            // 
            this.cbAlgorithmus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithmus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlgorithmus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlgorithmus.FormattingEnabled = true;
            this.cbAlgorithmus.Location = new System.Drawing.Point(504, 12);
            this.cbAlgorithmus.Name = "cbAlgorithmus";
            this.cbAlgorithmus.Size = new System.Drawing.Size(167, 29);
            this.cbAlgorithmus.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReset.Location = new System.Drawing.Point(278, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(198, 44);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStart.Location = new System.Drawing.Point(66, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbGrid
            // 
            this.pbGrid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGrid.Location = new System.Drawing.Point(0, 134);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(1230, 573);
            this.pbGrid.TabIndex = 1;
            this.pbGrid.TabStop = false;
            this.pbGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGrid_Paint_1);
            this.pbGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseDown);
            this.pbGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseMove);
            // 
            // pnlExportHeader
            // 
            this.pnlExportHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnlExportHeader.Controls.Add(this.label3);
            this.pnlExportHeader.Location = new System.Drawing.Point(0, 190);
            this.pnlExportHeader.Name = "pnlExportHeader";
            this.pnlExportHeader.Size = new System.Drawing.Size(1230, 90);
            this.pnlExportHeader.TabIndex = 2;
            this.pnlExportHeader.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1203, 90);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pathfinding - Visualizer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlExportInfo
            // 
            this.pnlExportInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlExportInfo.Controls.Add(this.tableLayoutPanel1);
            this.pnlExportInfo.Controls.Add(this.panel1);
            this.pnlExportInfo.Controls.Add(this.label12);
            this.pnlExportInfo.Controls.Add(this.lblExportSize);
            this.pnlExportInfo.Controls.Add(this.lblExportTotal);
            this.pnlExportInfo.Controls.Add(this.lblExportTime);
            this.pnlExportInfo.Controls.Add(this.lblExportDelay);
            this.pnlExportInfo.Controls.Add(this.lblExportPath);
            this.pnlExportInfo.Controls.Add(this.lblExportNodes);
            this.pnlExportInfo.Controls.Add(this.label20);
            this.pnlExportInfo.Controls.Add(this.label11);
            this.pnlExportInfo.Controls.Add(this.label10);
            this.pnlExportInfo.Controls.Add(this.label8);
            this.pnlExportInfo.Controls.Add(this.label4);
            this.pnlExportInfo.Location = new System.Drawing.Point(0, 493);
            this.pnlExportInfo.Name = "pnlExportInfo";
            this.pnlExportInfo.Size = new System.Drawing.Size(1230, 214);
            this.pnlExportInfo.TabIndex = 3;
            this.pnlExportInfo.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1230, 56);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblExportAlgorithm);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(447, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 50);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // lblExportAlgorithm
            // 
            this.lblExportAlgorithm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportAlgorithm.AutoSize = true;
            this.lblExportAlgorithm.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportAlgorithm.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportAlgorithm.Location = new System.Drawing.Point(3, 0);
            this.lblExportAlgorithm.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblExportAlgorithm.Name = "lblExportAlgorithm";
            this.lblExportAlgorithm.Size = new System.Drawing.Size(148, 48);
            this.lblExportAlgorithm.TabIndex = 15;
            this.lblExportAlgorithm.Text = "Dijkstra";
            this.lblExportAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label14.Location = new System.Drawing.Point(151, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 48);
            this.label14.TabIndex = 14;
            this.label14.Text = "Algorithm";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(44, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 3);
            this.panel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(446, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 48);
            this.label12.TabIndex = 12;
            this.label12.Text = "Time:";
            // 
            // lblExportSize
            // 
            this.lblExportSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportSize.AutoSize = true;
            this.lblExportSize.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportSize.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportSize.Location = new System.Drawing.Point(1020, 95);
            this.lblExportSize.Name = "lblExportSize";
            this.lblExportSize.Size = new System.Drawing.Size(123, 45);
            this.lblExportSize.TabIndex = 11;
            this.lblExportSize.Text = "20 x 10";
            this.lblExportSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportTotal
            // 
            this.lblExportTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportTotal.AutoSize = true;
            this.lblExportTotal.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportTotal.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportTotal.Location = new System.Drawing.Point(1020, 155);
            this.lblExportTotal.Name = "lblExportTotal";
            this.lblExportTotal.Size = new System.Drawing.Size(79, 45);
            this.lblExportTotal.TabIndex = 10;
            this.lblExportTotal.Text = "200";
            this.lblExportTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportTime
            // 
            this.lblExportTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportTime.AutoSize = true;
            this.lblExportTime.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportTime.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportTime.Location = new System.Drawing.Point(585, 89);
            this.lblExportTime.Name = "lblExportTime";
            this.lblExportTime.Size = new System.Drawing.Size(247, 45);
            this.lblExportTime.TabIndex = 9;
            this.lblExportTime.Text = "00,000000 sec";
            this.lblExportTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportDelay
            // 
            this.lblExportDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportDelay.AutoSize = true;
            this.lblExportDelay.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportDelay.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportDelay.Location = new System.Drawing.Point(585, 155);
            this.lblExportDelay.Name = "lblExportDelay";
            this.lblExportDelay.Size = new System.Drawing.Size(103, 45);
            this.lblExportDelay.TabIndex = 8;
            this.lblExportDelay.Text = "40ms";
            this.lblExportDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportPath
            // 
            this.lblExportPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportPath.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportPath.Location = new System.Drawing.Point(241, 155);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(74, 45);
            this.lblExportPath.TabIndex = 7;
            this.lblExportPath.Text = "156";
            this.lblExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportNodes
            // 
            this.lblExportNodes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportNodes.AutoSize = true;
            this.lblExportNodes.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportNodes.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblExportNodes.Location = new System.Drawing.Point(241, 95);
            this.lblExportNodes.Name = "lblExportNodes";
            this.lblExportNodes.Size = new System.Drawing.Size(92, 45);
            this.lblExportNodes.TabIndex = 6;
            this.lblExportNodes.Text = "1054";
            this.lblExportNodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label20.Location = new System.Drawing.Point(887, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 48);
            this.label20.TabIndex = 5;
            this.label20.Text = "Total:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label11.Location = new System.Drawing.Point(444, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 48);
            this.label11.TabIndex = 4;
            this.label11.Text = "Delay:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(887, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 48);
            this.label10.TabIndex = 3;
            this.label10.Text = "Size:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(89, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 48);
            this.label8.TabIndex = 1;
            this.label8.Text = "Path:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(89, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 48);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nodes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 707);
            this.Controls.Add(this.pbGrid);
            this.Controls.Add(this.pnlExportInfo);
            this.Controls.Add(this.pnlExportHeader);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathfinding - Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.pnlExportHeader.ResumeLayout(false);
            this.pnlExportInfo.ResumeLayout(false);
            this.pnlExportInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbToolbox;
        private System.Windows.Forms.ComboBox cbAlgorithmus;
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.TrackBar trackBarRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Panel pnlExportHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlExportInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lblExportSize;
        private System.Windows.Forms.Label lblExportTotal;
        private System.Windows.Forms.Label lblExportTime;
        private System.Windows.Forms.Label lblExportDelay;
        private System.Windows.Forms.Label lblExportPath;
        private System.Windows.Forms.Label lblExportNodes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblExportAlgorithm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbDensity;
    }
}

