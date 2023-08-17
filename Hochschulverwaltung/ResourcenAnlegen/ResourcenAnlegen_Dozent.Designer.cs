namespace Hochschulverwaltung
{
    partial class ResourcenAnlegen_Dozent
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutResourcenAnlegen = new System.Windows.Forms.TableLayoutPanel();
            this.labelMatrikelnr = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.layoutResourcenAnlegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutResourcenAnlegen
            // 
            this.layoutResourcenAnlegen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.layoutResourcenAnlegen.ColumnCount = 1;
            this.layoutResourcenAnlegen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutResourcenAnlegen.Controls.Add(this.labelMatrikelnr, 0, 2);
            this.layoutResourcenAnlegen.Controls.Add(this.labelName, 0, 0);
            this.layoutResourcenAnlegen.Controls.Add(this.inputName, 0, 1);
            this.layoutResourcenAnlegen.Controls.Add(this.comboBox1, 0, 3);
            this.layoutResourcenAnlegen.Location = new System.Drawing.Point(0, 0);
            this.layoutResourcenAnlegen.Name = "layoutResourcenAnlegen";
            this.layoutResourcenAnlegen.Padding = new System.Windows.Forms.Padding(20);
            this.layoutResourcenAnlegen.RowCount = 4;
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutResourcenAnlegen.Size = new System.Drawing.Size(340, 200);
            this.layoutResourcenAnlegen.TabIndex = 2;
            // 
            // labelMatrikelnr
            // 
            this.labelMatrikelnr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMatrikelnr.AutoSize = true;
            this.labelMatrikelnr.Location = new System.Drawing.Point(23, 67);
            this.labelMatrikelnr.Name = "labelMatrikelnr";
            this.labelMatrikelnr.Size = new System.Drawing.Size(72, 13);
            this.labelMatrikelnr.TabIndex = 4;
            this.labelMatrikelnr.Text = "Festangestellt";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(23, 43);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(274, 20);
            this.inputName.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ja",
            "Nein"});
            this.comboBox1.Location = new System.Drawing.Point(23, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // ResourcenAnlegen_Dozent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutResourcenAnlegen);
            this.Name = "ResourcenAnlegen_Dozent";
            this.Size = new System.Drawing.Size(350, 210);
            this.layoutResourcenAnlegen.ResumeLayout(false);
            this.layoutResourcenAnlegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutResourcenAnlegen;
        private System.Windows.Forms.Label labelMatrikelnr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
