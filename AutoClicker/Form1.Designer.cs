namespace AutoClicker
{
    partial class Autoclicker
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
            this.components = new System.ComponentModel.Container();
            this.BT_Start = new System.Windows.Forms.Button();
            this.RB_Linksklick = new System.Windows.Forms.RadioButton();
            this.RB_Rechtsklick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NUM_Secs = new System.Windows.Forms.NumericUpDown();
            this.TM_Clicktimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Secs)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(13, 86);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(306, 38);
            this.BT_Start.TabIndex = 0;
            this.BT_Start.Text = "Start";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // RB_Linksklick
            // 
            this.RB_Linksklick.AutoSize = true;
            this.RB_Linksklick.Location = new System.Drawing.Point(13, 13);
            this.RB_Linksklick.Name = "RB_Linksklick";
            this.RB_Linksklick.Size = new System.Drawing.Size(101, 24);
            this.RB_Linksklick.TabIndex = 1;
            this.RB_Linksklick.Text = "Linksklick";
            this.RB_Linksklick.UseVisualStyleBackColor = true;
            // 
            // RB_Rechtsklick
            // 
            this.RB_Rechtsklick.AutoSize = true;
            this.RB_Rechtsklick.Checked = true;
            this.RB_Rechtsklick.Location = new System.Drawing.Point(13, 44);
            this.RB_Rechtsklick.Name = "RB_Rechtsklick";
            this.RB_Rechtsklick.Size = new System.Drawing.Size(115, 24);
            this.RB_Rechtsklick.TabIndex = 2;
            this.RB_Rechtsklick.TabStop = true;
            this.RB_Rechtsklick.Text = "Rechtsklick";
            this.RB_Rechtsklick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alle x Sekunden";
            // 
            // NUM_Secs
            // 
            this.NUM_Secs.Location = new System.Drawing.Point(201, 42);
            this.NUM_Secs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUM_Secs.Name = "NUM_Secs";
            this.NUM_Secs.Size = new System.Drawing.Size(120, 26);
            this.NUM_Secs.TabIndex = 4;
            this.NUM_Secs.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // TM_Clicktimer
            // 
            this.TM_Clicktimer.Tick += new System.EventHandler(this.TM_Clicktimer_Tick);
            // 
            // Autoclicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 145);
            this.Controls.Add(this.NUM_Secs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB_Rechtsklick);
            this.Controls.Add(this.RB_Linksklick);
            this.Controls.Add(this.BT_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Autoclicker";
            this.Text = "Autoclicker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Secs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.RadioButton RB_Linksklick;
        private System.Windows.Forms.RadioButton RB_Rechtsklick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUM_Secs;
        private System.Windows.Forms.Timer TM_Clicktimer;
    }
}

