namespace Hochschulverwaltung
{
    partial class Terminplan
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
            this.tlp_Studenplan = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bttn_WochVor = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtp_beginLesson = new System.Windows.Forms.DateTimePicker();
            this.tbx_durationLesson = new System.Windows.Forms.TextBox();
            this.bttn_addLesson = new System.Windows.Forms.Button();
            this.Bttn_WocheZurueck = new System.Windows.Forms.Button();
            this.tbl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Studenplan
            // 
            this.tlp_Studenplan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlp_Studenplan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Studenplan.ColumnCount = 7;
            this.tbl_Main.SetColumnSpan(this.tlp_Studenplan, 4);
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Studenplan.Location = new System.Drawing.Point(3, 76);
            this.tlp_Studenplan.Name = "tlp_Studenplan";
            this.tlp_Studenplan.RowCount = 8;
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Studenplan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Studenplan.Size = new System.Drawing.Size(818, 518);
            this.tlp_Studenplan.TabIndex = 0;
            // 
            // tbl_Main
            // 
            this.tbl_Main.ColumnCount = 4;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Main.Controls.Add(this.tlp_Studenplan, 0, 2);
            this.tbl_Main.Controls.Add(this.comboBox1, 0, 0);
            this.tbl_Main.Controls.Add(this.Bttn_WocheZurueck, 2, 0);
            this.tbl_Main.Controls.Add(this.Bttn_WochVor, 3, 0);
            this.tbl_Main.Controls.Add(this.comboBox2, 0, 1);
            this.tbl_Main.Controls.Add(this.dtp_beginLesson, 1, 1);
            this.tbl_Main.Controls.Add(this.tbx_durationLesson, 2, 1);
            this.tbl_Main.Controls.Add(this.bttn_addLesson, 3, 1);
            this.tbl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Main.Location = new System.Drawing.Point(0, 0);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 3;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Size = new System.Drawing.Size(824, 597);
            this.tbl_Main.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Bttn_WochVor
            // 
            this.Bttn_WochVor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bttn_WochVor.Image = global::Hochschulverwaltung.Properties.Resources.pfeil_2;
            this.Bttn_WochVor.Location = new System.Drawing.Point(621, 3);
            this.Bttn_WochVor.Name = "Bttn_WochVor";
            this.Bttn_WochVor.Size = new System.Drawing.Size(200, 29);
            this.Bttn_WochVor.TabIndex = 3;
            this.Bttn_WochVor.UseVisualStyleBackColor = true;
            this.Bttn_WochVor.Click += new System.EventHandler(this.Bttn_WochVor_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // dtp_beginLesson
            // 
            this.dtp_beginLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_beginLesson.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_beginLesson.Location = new System.Drawing.Point(209, 38);
            this.dtp_beginLesson.Name = "dtp_beginLesson";
            this.dtp_beginLesson.Size = new System.Drawing.Size(200, 20);
            this.dtp_beginLesson.TabIndex = 5;
            // 
            // tbx_durationLesson
            // 
            this.tbx_durationLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_durationLesson.Location = new System.Drawing.Point(415, 38);
            this.tbx_durationLesson.Name = "tbx_durationLesson";
            this.tbx_durationLesson.Size = new System.Drawing.Size(200, 20);
            this.tbx_durationLesson.TabIndex = 6;
            // 
            // bttn_addLesson
            // 
            this.bttn_addLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttn_addLesson.Location = new System.Drawing.Point(621, 38);
            this.bttn_addLesson.Name = "bttn_addLesson";
            this.bttn_addLesson.Size = new System.Drawing.Size(200, 32);
            this.bttn_addLesson.TabIndex = 7;
            this.bttn_addLesson.Text = "Termin einfügen";
            this.bttn_addLesson.UseVisualStyleBackColor = true;
            this.bttn_addLesson.Click += new System.EventHandler(this.bttn_addLesson_Click);
            // 
            // Bttn_WocheZurueck
            // 
            this.Bttn_WocheZurueck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bttn_WocheZurueck.Image = global::Hochschulverwaltung.Properties.Resources.pfeil_1;
            this.Bttn_WocheZurueck.Location = new System.Drawing.Point(415, 3);
            this.Bttn_WocheZurueck.Name = "Bttn_WocheZurueck";
            this.Bttn_WocheZurueck.Size = new System.Drawing.Size(200, 29);
            this.Bttn_WocheZurueck.TabIndex = 2;
            this.Bttn_WocheZurueck.UseVisualStyleBackColor = true;
            this.Bttn_WocheZurueck.Click += new System.EventHandler(this.Bttn_WocheZurueck_Click);
            // 
            // Terminplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl_Main);
            this.Name = "Terminplan";
            this.Size = new System.Drawing.Size(824, 597);
            this.tbl_Main.ResumeLayout(false);
            this.tbl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Studenplan;
        private System.Windows.Forms.TableLayoutPanel tbl_Main;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Bttn_WocheZurueck;
        private System.Windows.Forms.Button Bttn_WochVor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dtp_beginLesson;
        private System.Windows.Forms.TextBox tbx_durationLesson;
        private System.Windows.Forms.Button bttn_addLesson;
    }
}
