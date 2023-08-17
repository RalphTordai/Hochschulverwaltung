namespace Hochschulverwaltung
{
    partial class ResourcenAnlegen_Lerngruppe
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
            this.treeViewStudenten = new TreeViewStudenten();
            this.labelName = new System.Windows.Forms.Label();
            this.listViewSelected = new System.Windows.Forms.ListView();
            this.Matrikelnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Studiengang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.ComboBox();
            this.layoutResourcenAnlegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutResourcenAnlegen
            // 
            this.layoutResourcenAnlegen.ColumnCount = 3;
            this.layoutResourcenAnlegen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResourcenAnlegen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutResourcenAnlegen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResourcenAnlegen.Controls.Add(this.treeViewStudenten, 0, 2);
            this.layoutResourcenAnlegen.Controls.Add(this.labelName, 2, 0);
            this.layoutResourcenAnlegen.Controls.Add(this.listViewSelected, 2, 2);
            this.layoutResourcenAnlegen.Controls.Add(this.buttonSelect, 1, 2);
            this.layoutResourcenAnlegen.Controls.Add(this.buttonCreate, 2, 3);
            this.layoutResourcenAnlegen.Controls.Add(this.inputName, 2, 1);
            this.layoutResourcenAnlegen.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutResourcenAnlegen.Location = new System.Drawing.Point(0, 0);
            this.layoutResourcenAnlegen.Name = "layoutResourcenAnlegen";
            this.layoutResourcenAnlegen.Padding = new System.Windows.Forms.Padding(20);
            this.layoutResourcenAnlegen.RowCount = 4;
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutResourcenAnlegen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutResourcenAnlegen.Size = new System.Drawing.Size(701, 435);
            this.layoutResourcenAnlegen.TabIndex = 2;
            // 
            // treeViewStudenten
            // 
            this.treeViewStudenten.CheckBoxes = true;
            this.treeViewStudenten.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewStudenten.Location = new System.Drawing.Point(23, 83);
            this.treeViewStudenten.Name = "treeViewStudenten";
            this.treeViewStudenten.Size = new System.Drawing.Size(304, 299);
            this.treeViewStudenten.TabIndex = 4;
            this.treeViewStudenten.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewStudenten_AfterCheck);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(373, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // listViewSelected
            // 
            this.listViewSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matrikelnummer,
            this.Name,
            this.Studiengang});
            this.listViewSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewSelected.HideSelection = false;
            this.listViewSelected.Location = new System.Drawing.Point(373, 83);
            this.listViewSelected.Name = "listViewSelected";
            this.listViewSelected.Size = new System.Drawing.Size(303, 299);
            this.listViewSelected.TabIndex = 5;
            this.listViewSelected.UseCompatibleStateImageBehavior = false;
            this.listViewSelected.View = System.Windows.Forms.View.Details;
            // 
            // Matrikelnummer
            // 
            this.Matrikelnummer.Text = "Matrikelnummer";
            this.Matrikelnummer.Width = 86;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 106;
            // 
            // Studiengang
            // 
            this.Studiengang.Text = "Studiengang";
            this.Studiengang.Width = 148;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(333, 83);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(34, 34);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "->";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCreate.Location = new System.Drawing.Point(603, 388);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 24);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Erstellen";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // inputName
            // 
            this.inputName.FormattingEnabled = true;
            this.inputName.Location = new System.Drawing.Point(373, 53);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(240, 21);
            this.inputName.TabIndex = 8;
            this.inputName.SelectedIndexChanged += new System.EventHandler(this.inputName_SelectedIndexChanged);
            // 
            // ResourcenAnlegen_Lerngruppe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutResourcenAnlegen);
            this.Size = new System.Drawing.Size(701, 435);
            this.layoutResourcenAnlegen.ResumeLayout(false);
            this.layoutResourcenAnlegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutResourcenAnlegen;
        private System.Windows.Forms.Label labelName;
        private TreeViewStudenten treeViewStudenten;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListView listViewSelected;
        private System.Windows.Forms.ColumnHeader Matrikelnummer;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Studiengang;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox inputName;
    }
}
