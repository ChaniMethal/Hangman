namespace Hangman
{
    partial class Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            tblMain = new TableLayoutPanel();
            tblGameBackground = new TableLayoutPanel();
            tblMan = new TableLayoutPanel();
            lblWrongGuesses = new Label();
            tblBoard = new TableLayoutPanel();
            tblABCs = new TableLayoutPanel();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnP = new Button();
            btnQ = new Button();
            btnR = new Button();
            btnS = new Button();
            btnU = new Button();
            btnV = new Button();
            btnW = new Button();
            btnX = new Button();
            btnY = new Button();
            btnZ = new Button();
            btnT = new Button();
            lblWord = new Label();
            tblTopRow = new TableLayoutPanel();
            lblHeader = new Label();
            lblTimer = new Label();
            btnStart = new Button();
            btnGiveUp = new Button();
            tblMain.SuspendLayout();
            tblGameBackground.SuspendLayout();
            tblMan.SuspendLayout();
            tblBoard.SuspendLayout();
            tblABCs.SuspendLayout();
            tblTopRow.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.SteelBlue;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblGameBackground, 0, 1);
            tblMain.Controls.Add(tblTopRow, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblGameBackground
            // 
            tblGameBackground.ColumnCount = 2;
            tblGameBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblGameBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblGameBackground.Controls.Add(tblMan, 0, 0);
            tblGameBackground.Controls.Add(tblBoard, 1, 0);
            tblGameBackground.Dock = DockStyle.Fill;
            tblGameBackground.Location = new Point(3, 70);
            tblGameBackground.Name = "tblGameBackground";
            tblGameBackground.RowCount = 1;
            tblGameBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblGameBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblGameBackground.Size = new Size(794, 377);
            tblGameBackground.TabIndex = 1;
            // 
            // tblMan
            // 
            tblMan.ColumnCount = 1;
            tblMan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMan.Controls.Add(lblWrongGuesses, 0, 1);
            tblMan.Dock = DockStyle.Fill;
            tblMan.Location = new Point(3, 3);
            tblMan.Name = "tblMan";
            tblMan.RowCount = 2;
            tblMan.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tblMan.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMan.Size = new Size(232, 371);
            tblMan.TabIndex = 0;
            // 
            // lblWrongGuesses
            // 
            lblWrongGuesses.AutoSize = true;
            lblWrongGuesses.BackColor = Color.SkyBlue;
            lblWrongGuesses.Dock = DockStyle.Fill;
            lblWrongGuesses.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWrongGuesses.ForeColor = SystemColors.ControlLightLight;
            lblWrongGuesses.Location = new Point(3, 315);
            lblWrongGuesses.Name = "lblWrongGuesses";
            lblWrongGuesses.Size = new Size(226, 56);
            lblWrongGuesses.TabIndex = 0;
            lblWrongGuesses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblBoard
            // 
            tblBoard.ColumnCount = 1;
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBoard.Controls.Add(tblABCs, 0, 1);
            tblBoard.Controls.Add(lblWord, 0, 0);
            tblBoard.Dock = DockStyle.Fill;
            tblBoard.Location = new Point(241, 3);
            tblBoard.Name = "tblBoard";
            tblBoard.RowCount = 2;
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblBoard.Size = new Size(550, 371);
            tblBoard.TabIndex = 1;
            // 
            // tblABCs
            // 
            tblABCs.ColumnCount = 10;
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblABCs.Controls.Add(btnA, 0, 0);
            tblABCs.Controls.Add(btnB, 1, 0);
            tblABCs.Controls.Add(btnC, 2, 0);
            tblABCs.Controls.Add(btnD, 3, 0);
            tblABCs.Controls.Add(btnE, 4, 0);
            tblABCs.Controls.Add(btnF, 5, 0);
            tblABCs.Controls.Add(btnG, 6, 0);
            tblABCs.Controls.Add(btnH, 7, 0);
            tblABCs.Controls.Add(btnI, 8, 0);
            tblABCs.Controls.Add(btnJ, 9, 0);
            tblABCs.Controls.Add(btnK, 0, 1);
            tblABCs.Controls.Add(btnL, 1, 1);
            tblABCs.Controls.Add(btnM, 2, 1);
            tblABCs.Controls.Add(btnN, 3, 1);
            tblABCs.Controls.Add(btnO, 4, 1);
            tblABCs.Controls.Add(btnP, 5, 1);
            tblABCs.Controls.Add(btnQ, 6, 1);
            tblABCs.Controls.Add(btnR, 7, 1);
            tblABCs.Controls.Add(btnS, 8, 1);
            tblABCs.Controls.Add(btnU, 2, 2);
            tblABCs.Controls.Add(btnV, 3, 2);
            tblABCs.Controls.Add(btnW, 4, 2);
            tblABCs.Controls.Add(btnX, 5, 2);
            tblABCs.Controls.Add(btnY, 6, 2);
            tblABCs.Controls.Add(btnZ, 7, 2);
            tblABCs.Controls.Add(btnT, 9, 1);
            tblABCs.Dock = DockStyle.Fill;
            tblABCs.ForeColor = SystemColors.ControlLightLight;
            tblABCs.Location = new Point(3, 151);
            tblABCs.Name = "tblABCs";
            tblABCs.RowCount = 3;
            tblABCs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblABCs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblABCs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblABCs.Size = new Size(544, 217);
            tblABCs.TabIndex = 0;
            // 
            // btnA
            // 
            btnA.BackColor = Color.SkyBlue;
            btnA.Dock = DockStyle.Fill;
            btnA.Font = new Font("Arial Rounded MT Bold", 18F);
            btnA.ForeColor = SystemColors.ControlLightLight;
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(48, 66);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.SkyBlue;
            btnB.Dock = DockStyle.Fill;
            btnB.Font = new Font("Arial Rounded MT Bold", 18F);
            btnB.ForeColor = SystemColors.ControlLightLight;
            btnB.Location = new Point(57, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(48, 66);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.SkyBlue;
            btnC.Dock = DockStyle.Fill;
            btnC.Font = new Font("Arial Rounded MT Bold", 18F);
            btnC.ForeColor = SystemColors.ControlLightLight;
            btnC.Location = new Point(111, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(48, 66);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.SkyBlue;
            btnD.Dock = DockStyle.Fill;
            btnD.Font = new Font("Arial Rounded MT Bold", 18F);
            btnD.ForeColor = SystemColors.ControlLightLight;
            btnD.Location = new Point(165, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(48, 66);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.SkyBlue;
            btnE.Dock = DockStyle.Fill;
            btnE.Font = new Font("Arial Rounded MT Bold", 18F);
            btnE.ForeColor = SystemColors.ControlLightLight;
            btnE.Location = new Point(219, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(48, 66);
            btnE.TabIndex = 4;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.SkyBlue;
            btnF.Dock = DockStyle.Fill;
            btnF.Font = new Font("Arial Rounded MT Bold", 18F);
            btnF.ForeColor = SystemColors.ControlLightLight;
            btnF.Location = new Point(273, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(48, 66);
            btnF.TabIndex = 5;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            btnG.BackColor = Color.SkyBlue;
            btnG.Dock = DockStyle.Fill;
            btnG.Font = new Font("Arial Rounded MT Bold", 18F);
            btnG.ForeColor = SystemColors.ControlLightLight;
            btnG.Location = new Point(327, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(48, 66);
            btnG.TabIndex = 6;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            btnH.BackColor = Color.SkyBlue;
            btnH.Dock = DockStyle.Fill;
            btnH.Font = new Font("Arial Rounded MT Bold", 18F);
            btnH.ForeColor = SystemColors.ControlLightLight;
            btnH.Location = new Point(381, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(48, 66);
            btnH.TabIndex = 7;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            btnI.BackColor = Color.SkyBlue;
            btnI.Dock = DockStyle.Fill;
            btnI.Font = new Font("Arial Rounded MT Bold", 18F);
            btnI.ForeColor = SystemColors.ControlLightLight;
            btnI.Location = new Point(435, 3);
            btnI.Name = "btnI";
            btnI.Size = new Size(48, 66);
            btnI.TabIndex = 8;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.SkyBlue;
            btnJ.Dock = DockStyle.Fill;
            btnJ.Font = new Font("Arial Rounded MT Bold", 18F);
            btnJ.ForeColor = SystemColors.ControlLightLight;
            btnJ.Location = new Point(489, 3);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(52, 66);
            btnJ.TabIndex = 9;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            btnK.BackColor = Color.SkyBlue;
            btnK.Dock = DockStyle.Fill;
            btnK.Font = new Font("Arial Rounded MT Bold", 18F);
            btnK.ForeColor = SystemColors.ControlLightLight;
            btnK.Location = new Point(3, 75);
            btnK.Name = "btnK";
            btnK.Size = new Size(48, 66);
            btnK.TabIndex = 10;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            btnL.BackColor = Color.SkyBlue;
            btnL.Dock = DockStyle.Fill;
            btnL.Font = new Font("Arial Rounded MT Bold", 18F);
            btnL.ForeColor = SystemColors.ControlLightLight;
            btnL.Location = new Point(57, 75);
            btnL.Name = "btnL";
            btnL.Size = new Size(48, 66);
            btnL.TabIndex = 11;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = Color.SkyBlue;
            btnM.Dock = DockStyle.Fill;
            btnM.Font = new Font("Arial Rounded MT Bold", 18F);
            btnM.ForeColor = SystemColors.ControlLightLight;
            btnM.Location = new Point(111, 75);
            btnM.Name = "btnM";
            btnM.Size = new Size(48, 66);
            btnM.TabIndex = 12;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            btnN.BackColor = Color.SkyBlue;
            btnN.Dock = DockStyle.Fill;
            btnN.Font = new Font("Arial Rounded MT Bold", 18F);
            btnN.ForeColor = SystemColors.ControlLightLight;
            btnN.Location = new Point(165, 75);
            btnN.Name = "btnN";
            btnN.Size = new Size(48, 66);
            btnN.TabIndex = 13;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            btnO.BackColor = Color.SkyBlue;
            btnO.Dock = DockStyle.Fill;
            btnO.Font = new Font("Arial Rounded MT Bold", 18F);
            btnO.ForeColor = SystemColors.ControlLightLight;
            btnO.Location = new Point(219, 75);
            btnO.Name = "btnO";
            btnO.Size = new Size(48, 66);
            btnO.TabIndex = 14;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            btnP.BackColor = Color.SkyBlue;
            btnP.Dock = DockStyle.Fill;
            btnP.Font = new Font("Arial Rounded MT Bold", 18F);
            btnP.ForeColor = SystemColors.ControlLightLight;
            btnP.Location = new Point(273, 75);
            btnP.Name = "btnP";
            btnP.Size = new Size(48, 66);
            btnP.TabIndex = 15;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.SkyBlue;
            btnQ.Dock = DockStyle.Fill;
            btnQ.Font = new Font("Arial Rounded MT Bold", 18F);
            btnQ.ForeColor = SystemColors.ControlLightLight;
            btnQ.Location = new Point(327, 75);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(48, 66);
            btnQ.TabIndex = 16;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            btnR.BackColor = Color.SkyBlue;
            btnR.Dock = DockStyle.Fill;
            btnR.Font = new Font("Arial Rounded MT Bold", 18F);
            btnR.ForeColor = SystemColors.ControlLightLight;
            btnR.Location = new Point(381, 75);
            btnR.Name = "btnR";
            btnR.Size = new Size(48, 66);
            btnR.TabIndex = 17;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            btnS.BackColor = Color.SkyBlue;
            btnS.Dock = DockStyle.Fill;
            btnS.Font = new Font("Arial Rounded MT Bold", 18F);
            btnS.ForeColor = SystemColors.ControlLightLight;
            btnS.Location = new Point(435, 75);
            btnS.Name = "btnS";
            btnS.Size = new Size(48, 66);
            btnS.TabIndex = 18;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            btnU.BackColor = Color.SkyBlue;
            btnU.Dock = DockStyle.Fill;
            btnU.Font = new Font("Arial Rounded MT Bold", 18F);
            btnU.ForeColor = SystemColors.ControlLightLight;
            btnU.Location = new Point(111, 147);
            btnU.Name = "btnU";
            btnU.Size = new Size(48, 67);
            btnU.TabIndex = 19;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            btnV.BackColor = Color.SkyBlue;
            btnV.Dock = DockStyle.Fill;
            btnV.Font = new Font("Arial Rounded MT Bold", 18F);
            btnV.ForeColor = SystemColors.ControlLightLight;
            btnV.Location = new Point(165, 147);
            btnV.Name = "btnV";
            btnV.Size = new Size(48, 67);
            btnV.TabIndex = 20;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            btnW.BackColor = Color.SkyBlue;
            btnW.Dock = DockStyle.Fill;
            btnW.Font = new Font("Arial Rounded MT Bold", 18F);
            btnW.ForeColor = SystemColors.ControlLightLight;
            btnW.Location = new Point(219, 147);
            btnW.Name = "btnW";
            btnW.Size = new Size(48, 67);
            btnW.TabIndex = 21;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.SkyBlue;
            btnX.Dock = DockStyle.Fill;
            btnX.Font = new Font("Arial Rounded MT Bold", 18F);
            btnX.ForeColor = SystemColors.ControlLightLight;
            btnX.Location = new Point(273, 147);
            btnX.Name = "btnX";
            btnX.Size = new Size(48, 67);
            btnX.TabIndex = 22;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            btnY.BackColor = Color.SkyBlue;
            btnY.Dock = DockStyle.Fill;
            btnY.Font = new Font("Arial Rounded MT Bold", 18F);
            btnY.ForeColor = SystemColors.ControlLightLight;
            btnY.Location = new Point(327, 147);
            btnY.Name = "btnY";
            btnY.Size = new Size(48, 67);
            btnY.TabIndex = 23;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.SkyBlue;
            btnZ.Dock = DockStyle.Fill;
            btnZ.Font = new Font("Arial Rounded MT Bold", 18F);
            btnZ.ForeColor = SystemColors.ControlLightLight;
            btnZ.Location = new Point(381, 147);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(48, 67);
            btnZ.TabIndex = 24;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            btnT.BackColor = Color.SkyBlue;
            btnT.Dock = DockStyle.Fill;
            btnT.Font = new Font("Arial Rounded MT Bold", 18F);
            btnT.ForeColor = SystemColors.ControlLightLight;
            btnT.Location = new Point(489, 75);
            btnT.Name = "btnT";
            btnT.Size = new Size(52, 66);
            btnT.TabIndex = 25;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.BackColor = Color.SkyBlue;
            lblWord.Dock = DockStyle.Fill;
            lblWord.Font = new Font("Aharoni", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWord.Location = new Point(3, 0);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(544, 148);
            lblWord.TabIndex = 1;
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblTopRow
            // 
            tblTopRow.ColumnCount = 4;
            tblTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblTopRow.Controls.Add(lblHeader, 0, 0);
            tblTopRow.Controls.Add(lblTimer, 1, 0);
            tblTopRow.Controls.Add(btnStart, 2, 0);
            tblTopRow.Controls.Add(btnGiveUp, 3, 0);
            tblTopRow.Dock = DockStyle.Fill;
            tblTopRow.Location = new Point(3, 3);
            tblTopRow.Name = "tblTopRow";
            tblTopRow.RowCount = 1;
            tblTopRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTopRow.Size = new Size(794, 61);
            tblTopRow.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ControlLightLight;
            lblHeader.Location = new Point(3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(470, 61);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "HANGMAN";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.SkyBlue;
            lblTimer.Dock = DockStyle.Fill;
            lblTimer.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = SystemColors.ControlLightLight;
            lblTimer.Location = new Point(400, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(152, 61);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "Time Left: 60s";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SkyBlue;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(558, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 55);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start ";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnGiveUp
            // 
            btnGiveUp.BackColor = Color.SkyBlue;
            btnGiveUp.Dock = DockStyle.Fill;
            btnGiveUp.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiveUp.ForeColor = SystemColors.ControlLightLight;
            btnGiveUp.Location = new Point(677, 3);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(114, 55);
            btnGiveUp.TabIndex = 2;
            btnGiveUp.Text = "GIVE UP";
            btnGiveUp.UseVisualStyleBackColor = false;
            // 
            // Hangman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hangman";
            Text = "Hangman";
            tblMain.ResumeLayout(false);
            tblGameBackground.ResumeLayout(false);
            tblMan.ResumeLayout(false);
            tblMan.PerformLayout();
            tblBoard.ResumeLayout(false);
            tblBoard.PerformLayout();
            tblABCs.ResumeLayout(false);
            tblTopRow.ResumeLayout(false);
            tblTopRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblGameBackground;
        private TableLayoutPanel tblMan;
        private TableLayoutPanel tblBoard;
        private TableLayoutPanel tblABCs;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;
        private Button btnT;
        private TableLayoutPanel tblTopRow;
        private Label lblHeader;
        private Button btnStart;
        private Button btnGiveUp;
        private Label lblWord;
        private Label lblWrongGuesses;
        private Label lblTimer;
    }
}
