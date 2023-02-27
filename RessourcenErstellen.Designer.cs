namespace Hochschulverwaltung
{
    partial class RessourcenErstellen
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
            this.Tbl_RessourcenErstellen = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Tbl_RessourcenErstellen
            // 
            this.Tbl_RessourcenErstellen.ColumnCount = 2;
            this.Tbl_RessourcenErstellen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.Tbl_RessourcenErstellen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.Tbl_RessourcenErstellen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_RessourcenErstellen.Location = new System.Drawing.Point(0, 0);
            this.Tbl_RessourcenErstellen.Name = "Tbl_RessourcenErstellen";
            this.Tbl_RessourcenErstellen.RowCount = 1;
            this.Tbl_RessourcenErstellen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_RessourcenErstellen.Size = new System.Drawing.Size(800, 450);
            this.Tbl_RessourcenErstellen.TabIndex = 1;
            // 
            // RessourcenErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbl_RessourcenErstellen);
            this.Name = "RessourcenErstellen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RessourcenErstellen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_RessourcenErstellen;
    }
}