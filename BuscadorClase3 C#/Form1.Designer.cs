namespace Buscador
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBuscador = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAzul = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Buscá lo que quieras!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBuscador
            // 
            this.tBuscador.Location = new System.Drawing.Point(109, 43);
            this.tBuscador.Name = "tBuscador";
            this.tBuscador.Size = new System.Drawing.Size(408, 20);
            this.tBuscador.TabIndex = 1;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(139, 83);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(149, 20);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bRojo
            // 
            this.bRojo.Location = new System.Drawing.Point(593, 42);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(126, 20);
            this.bRojo.TabIndex = 3;
            this.bRojo.Text = "Rojo";
            this.bRojo.UseVisualStyleBackColor = true;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bVerde
            // 
            this.bVerde.Location = new System.Drawing.Point(593, 68);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(126, 20);
            this.bVerde.TabIndex = 4;
            this.bVerde.Text = "Verde";
            this.bVerde.UseVisualStyleBackColor = true;
            this.bVerde.Click += new System.EventHandler(this.bVerde_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "----->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "<-----";
            // 
            // bAzul
            // 
            this.bAzul.Location = new System.Drawing.Point(593, 94);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(126, 20);
            this.bAzul.TabIndex = 7;
            this.bAzul.Text = "Azul";
            this.bAzul.UseVisualStyleBackColor = true;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(735, 42);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(43, 72);
            this.bVer.TabIndex = 8;
            this.bVer.Text = "ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // bIr
            // 
            this.bIr.Location = new System.Drawing.Point(333, 83);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(149, 20);
            this.bIr.TabIndex = 9;
            this.bIr.Text = "Ir a la URL";
            this.bIr.UseVisualStyleBackColor = true;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(66, 128);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(712, 210);
            this.webBrowser1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "¡Cambiá el color de fondo!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tBuscador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBuscador;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAzul;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
    }
}

