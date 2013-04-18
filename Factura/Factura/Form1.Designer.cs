namespace Factura
{
    partial class Factura
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.p1 = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.iva = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.fct = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(140, 12);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 20);
            this.p1.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(140, 64);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 20);
            this.p3.TabIndex = 1;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(140, 38);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 20);
            this.p2.TabIndex = 2;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(140, 120);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 20);
            this.sub.TabIndex = 3;
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(140, 166);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 4;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(140, 213);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 5;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(21, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(77, 13);
            this.a.TabIndex = 6;
            this.a.Text = "PRODUCTO 1";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(21, 38);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(77, 13);
            this.b.TabIndex = 7;
            this.b.Text = "PRODUCTO 2";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(21, 64);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(77, 13);
            this.c.TabIndex = 8;
            this.c.Text = "PRODUCTO 3";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(21, 127);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(64, 13);
            this.d.TabIndex = 9;
            this.d.Text = "SUBTOTAL";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(21, 173);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(33, 13);
            this.f.TabIndex = 10;
            this.f.Text = "I.V.A.";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(21, 220);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(42, 13);
            this.g.TabIndex = 11;
            this.g.Text = "TOTAL";
            // 
            // fct
            // 
            this.fct.Location = new System.Drawing.Point(24, 255);
            this.fct.Name = "fct";
            this.fct.Size = new System.Drawing.Size(91, 34);
            this.fct.TabIndex = 12;
            this.fct.Text = "FACTURAR";
            this.fct.UseVisualStyleBackColor = true;
            this.fct.Click += new System.EventHandler(this.fct_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(140, 255);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 34);
            this.limpiar.TabIndex = 13;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.fct);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.total);
            this.Controls.Add(this.iva);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p3;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Button fct;
        private System.Windows.Forms.Button limpiar;
    }
}

