namespace Caro_Game
{
    partial class FormPlayGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayGame));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.btnStartGane = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameTSitem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoTSitem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTSitem = new System.Windows.Forms.ToolStripMenuItem();
            this.winwinTSitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggTSitem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbScoX = new System.Windows.Forms.Label();
            this.lbNamePlayer1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbScoO = new System.Windows.Forms.Label();
            this.lbNamePlayer2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCooldown = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbPlaying = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnGG = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.btnMusic = new System.Windows.Forms.Button();
            this.pnlChessBoard.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlaying)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.AutoSize = true;
            this.pnlChessBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlChessBoard.Controls.Add(this.btnStartGane);
            this.pnlChessBoard.Location = new System.Drawing.Point(354, 131);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(582, 582);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlChessBoard_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlChessBoard_MouseClick);
            // 
            // btnStartGane
            // 
            this.btnStartGane.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStartGane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartGane.FlatAppearance.BorderSize = 2;
            this.btnStartGane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnStartGane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGane.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartGane.Location = new System.Drawing.Point(172, 219);
            this.btnStartGane.Name = "btnStartGane";
            this.btnStartGane.Size = new System.Drawing.Size(252, 73);
            this.btnStartGane.TabIndex = 0;
            this.btnStartGane.Text = "Bắt đầu chơi";
            this.btnStartGane.UseVisualStyleBackColor = false;
            this.btnStartGane.Click += new System.EventHandler(this.BtnStartGame_Click);
            this.btnStartGane.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnStartGane.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlInfo.Controls.Add(this.lbInfo);
            this.pnlInfo.Location = new System.Drawing.Point(730, 44);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(339, 72);
            this.pnlInfo.TabIndex = 4;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbInfo.Location = new System.Drawing.Point(-3, 59);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(41, 13);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.skillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameTSitem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameTSitem
            // 
            this.newGameTSitem.Name = "newGameTSitem";
            this.newGameTSitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameTSitem.Size = new System.Drawing.Size(174, 22);
            this.newGameTSitem.Text = "&New game";
            this.newGameTSitem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // skillToolStripMenuItem
            // 
            this.skillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTSitem,
            this.pauseTSitem,
            this.winwinTSitem,
            this.ggTSitem});
            this.skillToolStripMenuItem.Name = "skillToolStripMenuItem";
            this.skillToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.skillToolStripMenuItem.Text = "&Skill";
            // 
            // undoTSitem
            // 
            this.undoTSitem.Name = "undoTSitem";
            this.undoTSitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoTSitem.Size = new System.Drawing.Size(146, 22);
            this.undoTSitem.Text = "&Undo";
            this.undoTSitem.Click += new System.EventHandler(this.UndoTSitem_Click);
            // 
            // pauseTSitem
            // 
            this.pauseTSitem.Name = "pauseTSitem";
            this.pauseTSitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pauseTSitem.Size = new System.Drawing.Size(146, 22);
            this.pauseTSitem.Text = "&Pause";
            this.pauseTSitem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // winwinTSitem
            // 
            this.winwinTSitem.Name = "winwinTSitem";
            this.winwinTSitem.Size = new System.Drawing.Size(146, 22);
            this.winwinTSitem.Text = "Win-Win!";
            this.winwinTSitem.Click += new System.EventHandler(this.WinwinTSitem_Click);
            // 
            // ggTSitem
            // 
            this.ggTSitem.Name = "ggTSitem";
            this.ggTSitem.Size = new System.Drawing.Size(146, 22);
            this.ggTSitem.Text = "GG!";
            this.ggTSitem.Click += new System.EventHandler(this.GgTSitem_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.TimerPlay_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbScoX);
            this.panel1.Controls.Add(this.lbNamePlayer1);
            this.panel1.Location = new System.Drawing.Point(18, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 103);
            this.panel1.TabIndex = 5;
            // 
            // lbScoX
            // 
            this.lbScoX.AutoSize = true;
            this.lbScoX.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoX.Location = new System.Drawing.Point(75, 35);
            this.lbScoX.Name = "lbScoX";
            this.lbScoX.Size = new System.Drawing.Size(51, 57);
            this.lbScoX.TabIndex = 1;
            this.lbScoX.Text = "0";
            // 
            // lbNamePlayer1
            // 
            this.lbNamePlayer1.AutoSize = true;
            this.lbNamePlayer1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePlayer1.ForeColor = System.Drawing.Color.Red;
            this.lbNamePlayer1.Location = new System.Drawing.Point(66, 10);
            this.lbNamePlayer1.Name = "lbNamePlayer1";
            this.lbNamePlayer1.Size = new System.Drawing.Size(60, 21);
            this.lbNamePlayer1.TabIndex = 0;
            this.lbNamePlayer1.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbScoO);
            this.panel2.Controls.Add(this.lbNamePlayer2);
            this.panel2.Location = new System.Drawing.Point(1075, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 103);
            this.panel2.TabIndex = 6;
            // 
            // lbScoO
            // 
            this.lbScoO.AutoSize = true;
            this.lbScoO.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoO.Location = new System.Drawing.Point(75, 35);
            this.lbScoO.Name = "lbScoO";
            this.lbScoO.Size = new System.Drawing.Size(51, 57);
            this.lbScoO.TabIndex = 2;
            this.lbScoO.Text = "0";
            // 
            // lbNamePlayer2
            // 
            this.lbNamePlayer2.AutoSize = true;
            this.lbNamePlayer2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePlayer2.ForeColor = System.Drawing.Color.Blue;
            this.lbNamePlayer2.Location = new System.Drawing.Point(66, 10);
            this.lbNamePlayer2.Name = "lbNamePlayer2";
            this.lbNamePlayer2.Size = new System.Drawing.Size(60, 21);
            this.lbNamePlayer2.TabIndex = 0;
            this.lbNamePlayer2.Text = "label4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(18, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 396);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox1.BackgroundImage = global::Caro_Game.Properties.Resources.playerX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(1075, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 396);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox2.BackgroundImage = global::Caro_Game.Properties.Resources.playerO;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 360);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(123, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 17);
            this.lbName.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.lbCooldown);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbName);
            this.panel5.Controls.Add(this.ptbPlaying);
            this.panel5.Location = new System.Drawing.Point(228, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 72);
            this.panel5.TabIndex = 0;
            // 
            // lbCooldown
            // 
            this.lbCooldown.AutoSize = true;
            this.lbCooldown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCooldown.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCooldown.Location = new System.Drawing.Point(156, 36);
            this.lbCooldown.Name = "lbCooldown";
            this.lbCooldown.Size = new System.Drawing.Size(54, 17);
            this.lbCooldown.TabIndex = 4;
            this.lbCooldown.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cooldown:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên:";
            // 
            // ptbPlaying
            // 
            this.ptbPlaying.BackColor = System.Drawing.Color.White;
            this.ptbPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPlaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPlaying.Location = new System.Drawing.Point(3, 3);
            this.ptbPlaying.Name = "ptbPlaying";
            this.ptbPlaying.Size = new System.Drawing.Size(63, 66);
            this.ptbPlaying.TabIndex = 1;
            this.ptbPlaying.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lượt chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(638, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Luật chơi";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnNewGame);
            this.panel6.Controls.Add(this.btnPause);
            this.panel6.Controls.Add(this.btnBackMenu);
            this.panel6.Location = new System.Drawing.Point(18, 552);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 138);
            this.panel6.TabIndex = 1;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.BurlyWood;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewGame.Location = new System.Drawing.Point(14, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(175, 38);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Game mới";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click_1);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnNewGame.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.BurlyWood;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPause.Location = new System.Drawing.Point(14, 47);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(175, 38);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            this.btnPause.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnPause.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMenu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackMenu.Location = new System.Drawing.Point(14, 91);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(175, 38);
            this.btnBackMenu.TabIndex = 3;
            this.btnBackMenu.Text = "Menu";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.BtnBackMenu_Click);
            this.btnBackMenu.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnBackMenu.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnHoa);
            this.panel7.Controls.Add(this.btnGG);
            this.panel7.Controls.Add(this.btnUndo);
            this.panel7.Location = new System.Drawing.Point(1079, 552);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 138);
            this.panel7.TabIndex = 2;
            // 
            // btnHoa
            // 
            this.btnHoa.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoa.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHoa.Location = new System.Drawing.Point(14, 47);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(175, 38);
            this.btnHoa.TabIndex = 5;
            this.btnHoa.Text = "Win-win!";
            this.btnHoa.UseVisualStyleBackColor = false;
            this.btnHoa.Click += new System.EventHandler(this.BtnHoa_Click);
            this.btnHoa.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnHoa.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // btnGG
            // 
            this.btnGG.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGG.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGG.Location = new System.Drawing.Point(14, 91);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(175, 38);
            this.btnGG.TabIndex = 6;
            this.btnGG.Text = "GG!";
            this.btnGG.UseVisualStyleBackColor = false;
            this.btnGG.Click += new System.EventHandler(this.BtnGG_Click);
            this.btnGG.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnGG.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUndo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUndo.Location = new System.Drawing.Point(14, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(175, 38);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            this.btnUndo.MouseLeave += new System.EventHandler(this.BtnNewGame_MouseLeave);
            this.btnUndo.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Interval = 950;
            this.timerCoolDown.Tick += new System.EventHandler(this.TimerCoolDown_Tick);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusic.Location = new System.Drawing.Point(641, 44);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(83, 72);
            this.btnMusic.TabIndex = 12;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            this.btnMusic.MouseLeave += new System.EventHandler(this.BtnMusic_MouseLeave);
            this.btnMusic.MouseHover += new System.EventHandler(this.BtnNewGame_MouseHover);
            // 
            // FormPlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1311, 725);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro Edit by Nam Nguyen Hoang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayGame_FormClosing);
            this.pnlChessBoard.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlaying)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameTSitem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoTSitem;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Button btnStartGane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbScoX;
        private System.Windows.Forms.Label lbNamePlayer1;
        private System.Windows.Forms.Label lbNamePlayer2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbPlaying;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnGG;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.Label lbCooldown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbScoO;
        private System.Windows.Forms.ToolStripMenuItem pauseTSitem;
        private System.Windows.Forms.ToolStripMenuItem winwinTSitem;
        private System.Windows.Forms.ToolStripMenuItem ggTSitem;
        private System.Windows.Forms.Button btnMusic;
    }
}

