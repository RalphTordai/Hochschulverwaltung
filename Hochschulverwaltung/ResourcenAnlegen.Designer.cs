namespace Hochschulverwaltung
{
    partial class ResourcenAnlegen
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
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.labelDropDown = new System.Windows.Forms.Label();
            this.layoutResourcenAnlegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutResourcenAnlegen
            // 
            this.layoutResourcenAnlegen.ColumnCount = 1;
            this.layoutResourcenAnlegen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutResourcenAnlegen.Controls.Add(this.dropDown, 0, 1);
            this.layoutResourcenAnlegen.Controls.Add(this.labelDropDown, 0, 0);
            this.layoutResourcenAnlegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutResourcenAnlegen.Location = new System.Drawing.Point(0, 0);
            this.layoutResourcenAnlegen.Name = "layoutResourcenAnlegen";
            this.layoutResourcenAnlegen.Padding = new System.Windows.Forms.Padding(20);
            this.layoutResourcenAnlegen.RowCount = 3;
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutResourcenAnlegen.Size = new System.Drawing.Size(700, 450);
            this.layoutResourcenAnlegen.TabIndex = 0;
            // 
            // dropDown
            // 
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Items.AddRange(new object[] {
            "Dozent",
            "Kurs",
            "Lerngruppe",
            "Student"});
            this.dropDown.Location = new System.Drawing.Point(23, 53);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(121, 21);
            this.dropDown.TabIndex = 0;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // labelDropDown
            // 
            this.labelDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDropDown.AutoSize = true;
            this.labelDropDown.Location = new System.Drawing.Point(23, 37);
            this.labelDropDown.Name = "labelDropDown";
            this.labelDropDown.Size = new System.Drawing.Size(53, 13);
            this.labelDropDown.TabIndex = 1;
            this.labelDropDown.Text = "Resource";
            // 
            // ResourcenAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.layoutResourcenAnlegen);
            this.Name = "ResourcenAnlegen";
            this.Size = new System.Drawing.Size(700, 450);
            this.layoutResourcenAnlegen.ResumeLayout(false);
            this.layoutResourcenAnlegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutResourcenAnlegen;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.Label labelDropDown;
    }
}
