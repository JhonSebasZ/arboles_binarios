namespace fase4_jhon_sebastian_zuñiga
{
    partial class Menu
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
            this.btbEscenario1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEscenario2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbEscenario1
            // 
            this.btbEscenario1.BackColor = System.Drawing.Color.LimeGreen;
            this.btbEscenario1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbEscenario1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEscenario1.Font = new System.Drawing.Font("Bell MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btbEscenario1.Location = new System.Drawing.Point(52, 83);
            this.btbEscenario1.Name = "btbEscenario1";
            this.btbEscenario1.Size = new System.Drawing.Size(106, 32);
            this.btbEscenario1.TabIndex = 0;
            this.btbEscenario1.Text = "Escenario1";
            this.btbEscenario1.UseVisualStyleBackColor = false;
            this.btbEscenario1.Click += new System.EventHandler(this.btbEscenario1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(205, 158);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEscenario2
            // 
            this.btnEscenario2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEscenario2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscenario2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscenario2.Font = new System.Drawing.Font("Bell MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEscenario2.Location = new System.Drawing.Point(174, 83);
            this.btnEscenario2.Name = "btnEscenario2";
            this.btnEscenario2.Size = new System.Drawing.Size(106, 32);
            this.btnEscenario2.TabIndex = 2;
            this.btnEscenario2.Text = "Escenario2";
            this.btnEscenario2.UseVisualStyleBackColor = false;
            this.btnEscenario2.Click += new System.EventHandler(this.btnEscenario2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btnEscenario2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbEscenario1);
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btbEscenario1;
        private Button btnSalir;
        private Button btnEscenario2;
    }
}