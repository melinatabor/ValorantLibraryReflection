namespace UI
{
    partial class ValorantReflection
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxConsulta = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPrintSQL = new MaterialSkin.Controls.MaterialButton();
            this.listViewPropiedades = new MaterialSkin.Controls.MaterialListView();
            this.columnPropiedades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewClases = new MaterialSkin.Controls.MaterialListView();
            this.columnClases = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListarClases = new MaterialSkin.Controls.MaterialButton();
            this.lblConsulta = new MaterialSkin.Controls.MaterialLabel();
            this.expansionPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.expansionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.logo_valorant;
            this.pictureBox1.Location = new System.Drawing.Point(29, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxConsulta
            // 
            this.comboBoxConsulta.AutoResize = false;
            this.comboBoxConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxConsulta.Depth = 0;
            this.comboBoxConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxConsulta.DropDownHeight = 174;
            this.comboBoxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsulta.DropDownWidth = 121;
            this.comboBoxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxConsulta.FormattingEnabled = true;
            this.comboBoxConsulta.Hint = "Selecciona el tipo de consulta";
            this.comboBoxConsulta.IntegralHeight = false;
            this.comboBoxConsulta.ItemHeight = 43;
            this.comboBoxConsulta.Items.AddRange(new object[] {
            "Select",
            "Insert",
            "Update",
            "Delete",
            "Create table"});
            this.comboBoxConsulta.Location = new System.Drawing.Point(670, 115);
            this.comboBoxConsulta.MaxDropDownItems = 4;
            this.comboBoxConsulta.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxConsulta.Name = "comboBoxConsulta";
            this.comboBoxConsulta.Size = new System.Drawing.Size(298, 49);
            this.comboBoxConsulta.StartIndex = 0;
            this.comboBoxConsulta.TabIndex = 13;
            // 
            // btnPrintSQL
            // 
            this.btnPrintSQL.AutoSize = false;
            this.btnPrintSQL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintSQL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintSQL.Depth = 0;
            this.btnPrintSQL.HighEmphasis = true;
            this.btnPrintSQL.Icon = null;
            this.btnPrintSQL.Location = new System.Drawing.Point(975, 115);
            this.btnPrintSQL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintSQL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintSQL.Name = "btnPrintSQL";
            this.btnPrintSQL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintSQL.Size = new System.Drawing.Size(205, 49);
            this.btnPrintSQL.TabIndex = 11;
            this.btnPrintSQL.Text = "Generar Consultas SQL";
            this.btnPrintSQL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintSQL.UseAccentColor = false;
            this.btnPrintSQL.UseVisualStyleBackColor = true;
            this.btnPrintSQL.Click += new System.EventHandler(this.btnPrintSQL_Click);
            // 
            // listViewPropiedades
            // 
            this.listViewPropiedades.AutoSizeTable = false;
            this.listViewPropiedades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewPropiedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPropiedades});
            this.listViewPropiedades.Depth = 0;
            this.listViewPropiedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPropiedades.FullRowSelect = true;
            this.listViewPropiedades.HideSelection = false;
            this.listViewPropiedades.Location = new System.Drawing.Point(333, 232);
            this.listViewPropiedades.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewPropiedades.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewPropiedades.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewPropiedades.Name = "listViewPropiedades";
            this.listViewPropiedades.OwnerDraw = true;
            this.listViewPropiedades.Size = new System.Drawing.Size(289, 343);
            this.listViewPropiedades.TabIndex = 10;
            this.listViewPropiedades.UseCompatibleStateImageBehavior = false;
            this.listViewPropiedades.View = System.Windows.Forms.View.Details;
            // 
            // columnPropiedades
            // 
            this.columnPropiedades.Text = "Propiedades";
            this.columnPropiedades.Width = 278;
            // 
            // listViewClases
            // 
            this.listViewClases.AutoSizeTable = false;
            this.listViewClases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewClases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnClases});
            this.listViewClases.Depth = 0;
            this.listViewClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClases.FullRowSelect = true;
            this.listViewClases.HideSelection = false;
            this.listViewClases.Location = new System.Drawing.Point(29, 232);
            this.listViewClases.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewClases.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewClases.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewClases.Name = "listViewClases";
            this.listViewClases.OwnerDraw = true;
            this.listViewClases.Size = new System.Drawing.Size(289, 343);
            this.listViewClases.TabIndex = 9;
            this.listViewClases.UseCompatibleStateImageBehavior = false;
            this.listViewClases.View = System.Windows.Forms.View.Details;
            this.listViewClases.SelectedIndexChanged += new System.EventHandler(this.listViewClases_SelectedIndexChanged);
            // 
            // columnClases
            // 
            this.columnClases.Text = "Listado de Clases";
            this.columnClases.Width = 278;
            // 
            // btnListarClases
            // 
            this.btnListarClases.AutoSize = false;
            this.btnListarClases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarClases.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListarClases.Depth = 0;
            this.btnListarClases.HighEmphasis = true;
            this.btnListarClases.Icon = null;
            this.btnListarClases.Location = new System.Drawing.Point(139, 104);
            this.btnListarClases.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListarClases.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarClases.Name = "btnListarClases";
            this.btnListarClases.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListarClases.Size = new System.Drawing.Size(483, 83);
            this.btnListarClases.TabIndex = 8;
            this.btnListarClases.Text = "Listar Clases";
            this.btnListarClases.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListarClases.UseAccentColor = false;
            this.btnListarClases.UseVisualStyleBackColor = true;
            this.btnListarClases.Click += new System.EventHandler(this.btnListarClases_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Depth = 0;
            this.lblConsulta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConsulta.Location = new System.Drawing.Point(41, 64);
            this.lblConsulta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(411, 126);
            this.lblConsulta.TabIndex = 3;
            // 
            // expansionPanel
            // 
            this.expansionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expansionPanel.CancelButtonText = "";
            this.expansionPanel.CausesValidation = false;
            this.expansionPanel.Controls.Add(this.lblConsulta);
            this.expansionPanel.Depth = 0;
            this.expansionPanel.Description = "Descripción";
            this.expansionPanel.ExpandHeight = 343;
            this.expansionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.expansionPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expansionPanel.Location = new System.Drawing.Point(670, 232);
            this.expansionPanel.Margin = new System.Windows.Forms.Padding(16);
            this.expansionPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.expansionPanel.Name = "expansionPanel";
            this.expansionPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.expansionPanel.Size = new System.Drawing.Size(510, 343);
            this.expansionPanel.TabIndex = 12;
            this.expansionPanel.Title = "Consulta";
            this.expansionPanel.ValidationButtonEnable = true;
            this.expansionPanel.ValidationButtonText = "COPIAR";
            this.expansionPanel.SaveClick += new System.EventHandler(this.expansionPanel_SaveClick);
            // 
            // ValorantReflection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxConsulta);
            this.Controls.Add(this.btnPrintSQL);
            this.Controls.Add(this.listViewPropiedades);
            this.Controls.Add(this.listViewClases);
            this.Controls.Add(this.btnListarClases);
            this.Controls.Add(this.expansionPanel);
            this.Name = "ValorantReflection";
            this.Text = "Valorant Reflection";
            this.Load += new System.EventHandler(this.ReflectionProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.expansionPanel.ResumeLayout(false);
            this.expansionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxConsulta;
        private MaterialSkin.Controls.MaterialButton btnPrintSQL;
        private MaterialSkin.Controls.MaterialListView listViewPropiedades;
        private System.Windows.Forms.ColumnHeader columnPropiedades;
        private MaterialSkin.Controls.MaterialListView listViewClases;
        private System.Windows.Forms.ColumnHeader columnClases;
        private MaterialSkin.Controls.MaterialButton btnListarClases;
        private MaterialSkin.Controls.MaterialLabel lblConsulta;
        private MaterialSkin.Controls.MaterialExpansionPanel expansionPanel;
    }
}

