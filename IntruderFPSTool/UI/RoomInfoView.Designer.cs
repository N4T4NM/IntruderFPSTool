namespace IntruderFPSTool.UI
{
    partial class RoomInfoView
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
            this.backButton = new System.Windows.Forms.Button();
            this.updateRoom = new System.Windows.Forms.Button();
            this.roomId = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.Label();
            this.roomMotd = new System.Windows.Forms.Label();
            this.roomHasPassword = new System.Windows.Forms.Label();
            this.roomRegion = new System.Windows.Forms.Label();
            this.roomIsOfficial = new System.Windows.Forms.Label();
            this.roomIsRanked = new System.Windows.Forms.Label();
            this.roomStyle = new System.Windows.Forms.Label();
            this.roomJoinableBy = new System.Windows.Forms.Label();
            this.roomMatchInfoLnk = new System.Windows.Forms.LinkLabel();
            this.roomOverview = new System.Windows.Forms.Label();
            this.roomCreator = new System.Windows.Forms.Label();
            this.joinLnk = new System.Windows.Forms.LinkLabel();
            this.roomPasswordHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateRoom
            // 
            this.updateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRoom.Location = new System.Drawing.Point(486, 3);
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(75, 23);
            this.updateRoom.TabIndex = 2;
            this.updateRoom.Text = "Update";
            this.updateRoom.UseVisualStyleBackColor = true;
            this.updateRoom.Click += new System.EventHandler(this.updateRoom_Click);
            // 
            // roomId
            // 
            this.roomId.AutoSize = true;
            this.roomId.Location = new System.Drawing.Point(3, 73);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(24, 15);
            this.roomId.TabIndex = 3;
            this.roomId.Text = "ID: ";
            // 
            // roomName
            // 
            this.roomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomName.Location = new System.Drawing.Point(84, 2);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(396, 24);
            this.roomName.TabIndex = 4;
            this.roomName.Text = "---";
            this.roomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomMotd
            // 
            this.roomMotd.AutoSize = true;
            this.roomMotd.Location = new System.Drawing.Point(3, 98);
            this.roomMotd.Name = "roomMotd";
            this.roomMotd.Size = new System.Drawing.Size(42, 15);
            this.roomMotd.TabIndex = 5;
            this.roomMotd.Text = "Motd: ";
            // 
            // roomHasPassword
            // 
            this.roomHasPassword.AutoSize = true;
            this.roomHasPassword.Location = new System.Drawing.Point(3, 129);
            this.roomHasPassword.Name = "roomHasPassword";
            this.roomHasPassword.Size = new System.Drawing.Size(86, 15);
            this.roomHasPassword.TabIndex = 6;
            this.roomHasPassword.Text = "Has Password: ";
            // 
            // roomRegion
            // 
            this.roomRegion.AutoSize = true;
            this.roomRegion.Location = new System.Drawing.Point(3, 156);
            this.roomRegion.Name = "roomRegion";
            this.roomRegion.Size = new System.Drawing.Size(50, 15);
            this.roomRegion.TabIndex = 7;
            this.roomRegion.Text = "Region: ";
            // 
            // roomIsOfficial
            // 
            this.roomIsOfficial.AutoSize = true;
            this.roomIsOfficial.Location = new System.Drawing.Point(4, 183);
            this.roomIsOfficial.Name = "roomIsOfficial";
            this.roomIsOfficial.Size = new System.Drawing.Size(51, 15);
            this.roomIsOfficial.TabIndex = 8;
            this.roomIsOfficial.Text = "Official: ";
            // 
            // roomIsRanked
            // 
            this.roomIsRanked.AutoSize = true;
            this.roomIsRanked.Location = new System.Drawing.Point(4, 213);
            this.roomIsRanked.Name = "roomIsRanked";
            this.roomIsRanked.Size = new System.Drawing.Size(52, 15);
            this.roomIsRanked.TabIndex = 9;
            this.roomIsRanked.Text = "Ranked: ";
            // 
            // roomStyle
            // 
            this.roomStyle.AutoSize = true;
            this.roomStyle.Location = new System.Drawing.Point(4, 243);
            this.roomStyle.Name = "roomStyle";
            this.roomStyle.Size = new System.Drawing.Size(38, 15);
            this.roomStyle.TabIndex = 10;
            this.roomStyle.Text = "Style: ";
            // 
            // roomJoinableBy
            // 
            this.roomJoinableBy.AutoSize = true;
            this.roomJoinableBy.Location = new System.Drawing.Point(255, 98);
            this.roomJoinableBy.Name = "roomJoinableBy";
            this.roomJoinableBy.Size = new System.Drawing.Size(72, 15);
            this.roomJoinableBy.TabIndex = 15;
            this.roomJoinableBy.Text = "Joinable By: ";
            // 
            // roomMatchInfoLnk
            // 
            this.roomMatchInfoLnk.AutoSize = true;
            this.roomMatchInfoLnk.Location = new System.Drawing.Point(255, 129);
            this.roomMatchInfoLnk.Name = "roomMatchInfoLnk";
            this.roomMatchInfoLnk.Size = new System.Drawing.Size(59, 15);
            this.roomMatchInfoLnk.TabIndex = 11;
            this.roomMatchInfoLnk.TabStop = true;
            this.roomMatchInfoLnk.Text = "More Info";
            this.roomMatchInfoLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.roomMatchInfoLnk_LinkClicked);
            // 
            // roomOverview
            // 
            this.roomOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomOverview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomOverview.Location = new System.Drawing.Point(84, 26);
            this.roomOverview.Name = "roomOverview";
            this.roomOverview.Size = new System.Drawing.Size(396, 24);
            this.roomOverview.TabIndex = 18;
            this.roomOverview.Text = "---";
            this.roomOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomCreator
            // 
            this.roomCreator.AutoSize = true;
            this.roomCreator.Location = new System.Drawing.Point(255, 73);
            this.roomCreator.Name = "roomCreator";
            this.roomCreator.Size = new System.Drawing.Size(52, 15);
            this.roomCreator.TabIndex = 19;
            this.roomCreator.Text = "Creator: ";
            // 
            // joinLnk
            // 
            this.joinLnk.AutoSize = true;
            this.joinLnk.Location = new System.Drawing.Point(255, 156);
            this.joinLnk.Name = "joinLnk";
            this.joinLnk.Size = new System.Drawing.Size(28, 15);
            this.joinLnk.TabIndex = 20;
            this.joinLnk.TabStop = true;
            this.joinLnk.Text = "Join";
            this.joinLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.joinLnk_LinkClicked);
            // 
            // roomPasswordHash
            // 
            this.roomPasswordHash.AutoSize = true;
            this.roomPasswordHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomPasswordHash.Location = new System.Drawing.Point(3, 271);
            this.roomPasswordHash.Name = "roomPasswordHash";
            this.roomPasswordHash.Size = new System.Drawing.Size(93, 15);
            this.roomPasswordHash.TabIndex = 21;
            this.roomPasswordHash.Text = "Password Hash: ";
            this.roomPasswordHash.Click += new System.EventHandler(this.roomPasswordHash_Click);
            // 
            // RoomInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomPasswordHash);
            this.Controls.Add(this.joinLnk);
            this.Controls.Add(this.roomCreator);
            this.Controls.Add(this.roomOverview);
            this.Controls.Add(this.roomJoinableBy);
            this.Controls.Add(this.roomMatchInfoLnk);
            this.Controls.Add(this.roomStyle);
            this.Controls.Add(this.roomIsRanked);
            this.Controls.Add(this.roomIsOfficial);
            this.Controls.Add(this.roomRegion);
            this.Controls.Add(this.roomHasPassword);
            this.Controls.Add(this.roomMotd);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.updateRoom);
            this.Controls.Add(this.backButton);
            this.Name = "RoomInfoView";
            this.Size = new System.Drawing.Size(564, 310);
            this.Load += new System.EventHandler(this.RoomInfoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Button updateRoom;
        private Label roomId;
        private Label roomName;
        private Label roomMotd;
        private Label roomHasPassword;
        private Label roomRegion;
        private Label roomIsOfficial;
        private Label roomIsRanked;
        private Label roomStyle;
        private Label roomJoinableBy;
        private LinkLabel roomMatchInfoLnk;
        private Label roomOverview;
        private Label roomCreator;
        private LinkLabel joinLnk;
        private Label roomPasswordHash;
    }
}
