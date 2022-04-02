namespace IntruderFPSTool.UI
{
    partial class MatchInfoView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateRoom = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.currentMapLnk = new System.Windows.Forms.LinkLabel();
            this.mapsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agentsInfoBox = new System.Windows.Forms.GroupBox();
            this.agentsList = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.roomCreatorLnk = new System.Windows.Forms.LinkLabel();
            this.scoresList = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.roundsInfoGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.agentsInfoBox.SuspendLayout();
            this.roundsInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateRoom
            // 
            this.updateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRoom.Location = new System.Drawing.Point(718, 3);
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(75, 23);
            this.updateRoom.TabIndex = 4;
            this.updateRoom.Text = "Update";
            this.updateRoom.UseVisualStyleBackColor = true;
            this.updateRoom.Click += new System.EventHandler(this.updateRoom_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // currentMapLnk
            // 
            this.currentMapLnk.AutoSize = true;
            this.currentMapLnk.Location = new System.Drawing.Point(6, 19);
            this.currentMapLnk.Name = "currentMapLnk";
            this.currentMapLnk.Size = new System.Drawing.Size(80, 15);
            this.currentMapLnk.TabIndex = 5;
            this.currentMapLnk.TabStop = true;
            this.currentMapLnk.Text = "Current Map: ";
            this.currentMapLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.currentMap_LinkClicked);
            // 
            // mapsList
            // 
            this.mapsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mapsList.FullRowSelect = true;
            this.mapsList.Location = new System.Drawing.Point(6, 37);
            this.mapsList.Name = "mapsList";
            this.mapsList.Size = new System.Drawing.Size(401, 253);
            this.mapsList.TabIndex = 6;
            this.mapsList.UseCompatibleStateImageBehavior = false;
            this.mapsList.View = System.Windows.Forms.View.Details;
            this.mapsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapsList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Map Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mapsList);
            this.groupBox1.Controls.Add(this.currentMapLnk);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 296);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maps Info";
            // 
            // agentsInfoBox
            // 
            this.agentsInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agentsInfoBox.Controls.Add(this.agentsList);
            this.agentsInfoBox.Controls.Add(this.roomCreatorLnk);
            this.agentsInfoBox.Location = new System.Drawing.Point(422, 32);
            this.agentsInfoBox.Name = "agentsInfoBox";
            this.agentsInfoBox.Size = new System.Drawing.Size(366, 296);
            this.agentsInfoBox.TabIndex = 8;
            this.agentsInfoBox.TabStop = false;
            this.agentsInfoBox.Text = "Agents Info ( 0/0 )";
            // 
            // agentsList
            // 
            this.agentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.agentsList.FullRowSelect = true;
            this.agentsList.Location = new System.Drawing.Point(6, 37);
            this.agentsList.Name = "agentsList";
            this.agentsList.Size = new System.Drawing.Size(354, 253);
            this.agentsList.TabIndex = 1;
            this.agentsList.UseCompatibleStateImageBehavior = false;
            this.agentsList.View = System.Windows.Forms.View.Details;
            this.agentsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.agentsList_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Level";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Exp";
            this.columnHeader5.Width = 100;
            // 
            // roomCreatorLnk
            // 
            this.roomCreatorLnk.AutoSize = true;
            this.roomCreatorLnk.Location = new System.Drawing.Point(6, 19);
            this.roomCreatorLnk.Name = "roomCreatorLnk";
            this.roomCreatorLnk.Size = new System.Drawing.Size(102, 15);
            this.roomCreatorLnk.TabIndex = 0;
            this.roomCreatorLnk.TabStop = true;
            this.roomCreatorLnk.Text = "Room Creator: ---";
            this.roomCreatorLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.roomCreatorLnk_LinkClicked);
            // 
            // scoresList
            // 
            this.scoresList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.scoresList.FullRowSelect = true;
            this.scoresList.Location = new System.Drawing.Point(6, 16);
            this.scoresList.Name = "scoresList";
            this.scoresList.Size = new System.Drawing.Size(258, 161);
            this.scoresList.TabIndex = 9;
            this.scoresList.UseCompatibleStateImageBehavior = false;
            this.scoresList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Round";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Guards";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Intruders";
            // 
            // roundsInfoGroup
            // 
            this.roundsInfoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundsInfoGroup.Controls.Add(this.scoresList);
            this.roundsInfoGroup.Location = new System.Drawing.Point(3, 334);
            this.roundsInfoGroup.Name = "roundsInfoGroup";
            this.roundsInfoGroup.Size = new System.Drawing.Size(270, 183);
            this.roundsInfoGroup.TabIndex = 10;
            this.roundsInfoGroup.TabStop = false;
            this.roundsInfoGroup.Text = "Rounds Info";
            // 
            // MatchInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundsInfoGroup);
            this.Controls.Add(this.agentsInfoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateRoom);
            this.Controls.Add(this.backButton);
            this.Name = "MatchInfoView";
            this.Size = new System.Drawing.Size(796, 524);
            this.Load += new System.EventHandler(this.MatchInfoView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.agentsInfoBox.ResumeLayout(false);
            this.agentsInfoBox.PerformLayout();
            this.roundsInfoGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button updateRoom;
        private Button backButton;
        private LinkLabel currentMapLnk;
        private ListView mapsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private GroupBox agentsInfoBox;
        private LinkLabel roomCreatorLnk;
        private ListView agentsList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView scoresList;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private GroupBox roundsInfoGroup;
    }
}
