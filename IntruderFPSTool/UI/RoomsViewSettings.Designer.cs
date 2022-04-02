namespace IntruderFPSTool.UI
{
    partial class RoomsViewSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameFilter = new System.Windows.Forms.TextBox();
            this.versionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regionCombo = new System.Windows.Forms.ComboBox();
            this.hideEmptyCheck = new System.Windows.Forms.CheckBox();
            this.hideFullCheck = new System.Windows.Forms.CheckBox();
            this.hidePasswordedCheck = new System.Windows.Forms.CheckBox();
            this.hideOfficialCheck = new System.Windows.Forms.CheckBox();
            this.hideCustomCheck = new System.Windows.Forms.CheckBox();
            this.hideUnrankedCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Filter";
            // 
            // nameFilter
            // 
            this.nameFilter.Location = new System.Drawing.Point(3, 57);
            this.nameFilter.Name = "nameFilter";
            this.nameFilter.Size = new System.Drawing.Size(217, 23);
            this.nameFilter.TabIndex = 2;
            this.nameFilter.TextChanged += new System.EventHandler(this.nameFilter_TextChanged);
            // 
            // versionInput
            // 
            this.versionInput.Location = new System.Drawing.Point(3, 121);
            this.versionInput.Name = "versionInput";
            this.versionInput.Size = new System.Drawing.Size(75, 23);
            this.versionInput.TabIndex = 4;
            this.versionInput.TextChanged += new System.EventHandler(this.versionInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Region";
            // 
            // regionCombo
            // 
            this.regionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionCombo.FormattingEnabled = true;
            this.regionCombo.Items.AddRange(new object[] {
            "--",
            "EU",
            "US",
            "Asia",
            "JP",
            "AU",
            "USW",
            "SA",
            "CAE",
            "KR",
            "IN",
            "RU"});
            this.regionCombo.Location = new System.Drawing.Point(3, 179);
            this.regionCombo.Name = "regionCombo";
            this.regionCombo.Size = new System.Drawing.Size(75, 23);
            this.regionCombo.TabIndex = 6;
            this.regionCombo.SelectedIndexChanged += new System.EventHandler(this.regionCombo_SelectedIndexChanged);
            // 
            // hideEmptyCheck
            // 
            this.hideEmptyCheck.AutoSize = true;
            this.hideEmptyCheck.Location = new System.Drawing.Point(3, 220);
            this.hideEmptyCheck.Name = "hideEmptyCheck";
            this.hideEmptyCheck.Size = new System.Drawing.Size(88, 19);
            this.hideEmptyCheck.TabIndex = 8;
            this.hideEmptyCheck.Text = "Hide Empty";
            this.hideEmptyCheck.UseVisualStyleBackColor = true;
            this.hideEmptyCheck.CheckedChanged += new System.EventHandler(this.hideEmptyCheck_CheckedChanged);
            // 
            // hideFullCheck
            // 
            this.hideFullCheck.AutoSize = true;
            this.hideFullCheck.Location = new System.Drawing.Point(3, 245);
            this.hideFullCheck.Name = "hideFullCheck";
            this.hideFullCheck.Size = new System.Drawing.Size(73, 19);
            this.hideFullCheck.TabIndex = 9;
            this.hideFullCheck.Text = "Hide Full";
            this.hideFullCheck.UseVisualStyleBackColor = true;
            this.hideFullCheck.CheckedChanged += new System.EventHandler(this.hideFullCheck_CheckedChanged);
            // 
            // hidePasswordedCheck
            // 
            this.hidePasswordedCheck.AutoSize = true;
            this.hidePasswordedCheck.Location = new System.Drawing.Point(3, 270);
            this.hidePasswordedCheck.Name = "hidePasswordedCheck";
            this.hidePasswordedCheck.Size = new System.Drawing.Size(117, 19);
            this.hidePasswordedCheck.TabIndex = 10;
            this.hidePasswordedCheck.Text = "Hide Passworded";
            this.hidePasswordedCheck.UseVisualStyleBackColor = true;
            this.hidePasswordedCheck.CheckedChanged += new System.EventHandler(this.hidePasswordedCheck_CheckedChanged);
            // 
            // hideOfficialCheck
            // 
            this.hideOfficialCheck.AutoSize = true;
            this.hideOfficialCheck.Location = new System.Drawing.Point(3, 295);
            this.hideOfficialCheck.Name = "hideOfficialCheck";
            this.hideOfficialCheck.Size = new System.Drawing.Size(92, 19);
            this.hideOfficialCheck.TabIndex = 11;
            this.hideOfficialCheck.Text = "Hide Official";
            this.hideOfficialCheck.UseVisualStyleBackColor = true;
            this.hideOfficialCheck.CheckedChanged += new System.EventHandler(this.hideOfficialCheck_CheckedChanged);
            // 
            // hideCustomCheck
            // 
            this.hideCustomCheck.AutoSize = true;
            this.hideCustomCheck.Location = new System.Drawing.Point(3, 320);
            this.hideCustomCheck.Name = "hideCustomCheck";
            this.hideCustomCheck.Size = new System.Drawing.Size(96, 19);
            this.hideCustomCheck.TabIndex = 12;
            this.hideCustomCheck.Text = "Hide Custom";
            this.hideCustomCheck.UseVisualStyleBackColor = true;
            this.hideCustomCheck.CheckedChanged += new System.EventHandler(this.hideCustomCheck_CheckedChanged);
            // 
            // hideUnrankedCheck
            // 
            this.hideUnrankedCheck.AutoSize = true;
            this.hideUnrankedCheck.Location = new System.Drawing.Point(3, 345);
            this.hideUnrankedCheck.Name = "hideUnrankedCheck";
            this.hideUnrankedCheck.Size = new System.Drawing.Size(105, 19);
            this.hideUnrankedCheck.TabIndex = 13;
            this.hideUnrankedCheck.Text = "Hide Unranked";
            this.hideUnrankedCheck.UseVisualStyleBackColor = true;
            this.hideUnrankedCheck.CheckedChanged += new System.EventHandler(this.hideUnrankedCheck_CheckedChanged);
            // 
            // RoomsViewSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hideUnrankedCheck);
            this.Controls.Add(this.hideCustomCheck);
            this.Controls.Add(this.hideOfficialCheck);
            this.Controls.Add(this.hidePasswordedCheck);
            this.Controls.Add(this.hideFullCheck);
            this.Controls.Add(this.hideEmptyCheck);
            this.Controls.Add(this.regionCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "RoomsViewSettings";
            this.Size = new System.Drawing.Size(608, 372);
            this.Load += new System.EventHandler(this.RoomsViewSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Label label1;
        private TextBox nameFilter;
        private TextBox versionInput;
        private Label label2;
        private Label label3;
        private ComboBox regionCombo;
        private CheckBox hideEmptyCheck;
        private CheckBox hideFullCheck;
        private CheckBox hidePasswordedCheck;
        private CheckBox hideOfficialCheck;
        private CheckBox hideCustomCheck;
        private CheckBox hideUnrankedCheck;
    }
}
