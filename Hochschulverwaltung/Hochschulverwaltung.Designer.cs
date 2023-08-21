namespace Hochschulverwaltung
{
    partial class Hochschulverwaltung
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.layoutNavigationBar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.layoutMainWindow.SuspendLayout();
            this.layoutNavigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMainWindow
            // 
            this.layoutMainWindow.ColumnCount = 2;
            this.layoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutMainWindow.Controls.Add(this.layoutNavigationBar, 1, 0);
            this.layoutMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMainWindow.Location = new System.Drawing.Point(0, 0);
            this.layoutMainWindow.Name = "layoutMainWindow";
            this.layoutMainWindow.RowCount = 1;
            this.layoutMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMainWindow.Size = new System.Drawing.Size(903, 570);
            this.layoutMainWindow.TabIndex = 0;
            // 
            // layoutNavigationBar
            // 
            this.layoutNavigationBar.AutoScroll = true;
            this.layoutNavigationBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.layoutNavigationBar.Controls.Add(this.button1);
            this.layoutNavigationBar.Controls.Add(this.button2);
            this.layoutNavigationBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutNavigationBar.Location = new System.Drawing.Point(806, 3);
            this.layoutNavigationBar.Name = "layoutNavigationBar";
            this.layoutNavigationBar.Size = new System.Drawing.Size(94, 564);
            this.layoutNavigationBar.TabIndex = 0;
            this.layoutNavigationBar.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Hochschulverwaltung.Properties.Resources.plus;
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Hochschulverwaltung.Properties.Resources.datum;
            this.button2.Location = new System.Drawing.Point(14, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hochschulverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.layoutMainWindow);
            this.Name = "Hochschulverwaltung";
            this.Text = "Hochschulverwaltung";
            this.layoutMainWindow.ResumeLayout(false);
            this.layoutNavigationBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMainWindow;
        private System.Windows.Forms.FlowLayoutPanel layoutNavigationBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

