namespace PARCIAL_PROGRA_2
{
    partial class PARCIAL1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PARCIAL1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textColumnasM2 = new System.Windows.Forms.TextBox();
            this.textFilasM2 = new System.Windows.Forms.TextBox();
            this.textColumnasM1 = new System.Windows.Forms.TextBox();
            this.textFilasM1 = new System.Windows.Forms.TextBox();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(0, 671);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 41);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnLimpiar);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.textColumnasM2);
            this.panelMenu.Controls.Add(this.textFilasM2);
            this.panelMenu.Controls.Add(this.textColumnasM1);
            this.panelMenu.Controls.Add(this.textFilasM1);
            this.panelMenu.Controls.Add(this.btnMultiplicar);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1166, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 1044);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 577);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 41);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(40, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "COLUMNAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(71, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "FILAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "COLUMNAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILAS";
            // 
            // textColumnasM2
            // 
            this.textColumnasM2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textColumnasM2.Location = new System.Drawing.Point(-2, 335);
            this.textColumnasM2.Name = "textColumnasM2";
            this.textColumnasM2.Size = new System.Drawing.Size(201, 34);
            this.textColumnasM2.TabIndex = 4;
            // 
            // textFilasM2
            // 
            this.textFilasM2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFilasM2.Location = new System.Drawing.Point(-1, 267);
            this.textFilasM2.Name = "textFilasM2";
            this.textFilasM2.Size = new System.Drawing.Size(201, 34);
            this.textFilasM2.TabIndex = 3;
            // 
            // textColumnasM1
            // 
            this.textColumnasM1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textColumnasM1.Location = new System.Drawing.Point(-1, 150);
            this.textColumnasM1.Name = "textColumnasM1";
            this.textColumnasM1.Size = new System.Drawing.Size(201, 34);
            this.textColumnasM1.TabIndex = 1;
            // 
            // textFilasM1
            // 
            this.textFilasM1.BackColor = System.Drawing.Color.White;
            this.textFilasM1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFilasM1.Location = new System.Drawing.Point(-1, 56);
            this.textFilasM1.Name = "textFilasM1";
            this.textFilasM1.Size = new System.Drawing.Size(201, 34);
            this.textFilasM1.TabIndex = 0;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Crimson;
            this.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnMultiplicar.FlatAppearance.BorderSize = 3;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiplicar.Location = new System.Drawing.Point(0, 513);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(200, 41);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Crimson;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Location = new System.Drawing.Point(0, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // PARCIAL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 1044);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PARCIAL1";
            this.Text = "PARCIAL1-MATRICES";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PARCIAL1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSalir;
        private Panel panelMenu;
        private Button btnMultiplicar;
        private Button btnAgregar;
        private TextBox textColumnasM2;
        private TextBox textFilasM2;
        private TextBox textColumnasM1;
        private TextBox textFilasM1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
    }
}