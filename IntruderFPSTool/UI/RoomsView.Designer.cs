namespace IntruderFPSTool.UI
{
    partial class RoomsView
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
            this.components = new System.ComponentModel.Container();
            this.updateRooms = new System.Windows.Forms.Button();
            this.roomsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.setRoomSettings = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // updateRooms
            // 
            this.updateRooms.Location = new System.Drawing.Point(3, 3);
            this.updateRooms.Name = "updateRooms";
            this.updateRooms.Size = new System.Drawing.Size(75, 23);
            this.updateRooms.TabIndex = 0;
            this.updateRooms.Text = "Update";
            this.updateRooms.UseVisualStyleBackColor = true;
            this.updateRooms.Click += new System.EventHandler(this.updateRooms_Click);
            // 
            // roomsList
            // 
            this.roomsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.roomsList.FullRowSelect = true;
            this.roomsList.Location = new System.Drawing.Point(3, 32);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(634, 426);
            this.roomsList.TabIndex = 1;
            this.roomsList.UseCompatibleStateImageBehavior = false;
            this.roomsList.View = System.Windows.Forms.View.Details;
            this.roomsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.roomsList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Map";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mode";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Players";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Region";
            // 
            // setRoomSettings
            // 
            this.setRoomSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setRoomSettings.Location = new System.Drawing.Point(562, 3);
            this.setRoomSettings.Name = "setRoomSettings";
            this.setRoomSettings.Size = new System.Drawing.Size(75, 23);
            this.setRoomSettings.TabIndex = 2;
            this.setRoomSettings.Text = "Settings";
            this.setRoomSettings.UseVisualStyleBackColor = true;
            this.setRoomSettings.Click += new System.EventHandler(this.setRoomSettings_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(84, 7);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(90, 15);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Found 0 rooms.";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 10000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // RoomsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.setRoomSettings);
            this.Controls.Add(this.roomsList);
            this.Controls.Add(this.updateRooms);
            this.Name = "RoomsView";
            this.Size = new System.Drawing.Size(640, 461);
            this.Load += new System.EventHandler(this.RoomsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateRooms;
        private ListView roomsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button setRoomSettings;
        private Label statusLabel;
        private System.Windows.Forms.Timer updateTimer;
    }
}
