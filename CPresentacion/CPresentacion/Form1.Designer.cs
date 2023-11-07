namespace CPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.actualizar = new C1.Win.C1Input.C1Button();
            this.crear = new C1.Win.C1Input.C1Button();
            this.leer = new C1.Win.C1Input.C1Button();
            this.c1Button3 = new C1.Win.C1Input.C1Button();
            this.series = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.series)).BeginInit();
            this.SuspendLayout();
            // 
            // actualizar
            // 
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.Image = ((System.Drawing.Image)(resources.GetObject("actualizar.Image")));
            this.actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizar.Location = new System.Drawing.Point(23, 223);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(139, 39);
            this.actualizar.TabIndex = 0;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // crear
            // 
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Image = ((System.Drawing.Image)(resources.GetObject("crear.Image")));
            this.crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crear.Location = new System.Drawing.Point(23, 91);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(139, 39);
            this.crear.TabIndex = 1;
            this.crear.Text = "CREAR";
            this.crear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // leer
            // 
            this.leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leer.Image = ((System.Drawing.Image)(resources.GetObject("leer.Image")));
            this.leer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leer.Location = new System.Drawing.Point(23, 158);
            this.leer.Name = "leer";
            this.leer.Size = new System.Drawing.Size(139, 39);
            this.leer.TabIndex = 2;
            this.leer.Text = "LEER";
            this.leer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leer.UseVisualStyleBackColor = true;
            this.leer.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Button3
            // 
            this.c1Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Button3.Image = ((System.Drawing.Image)(resources.GetObject("c1Button3.Image")));
            this.c1Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Button3.Location = new System.Drawing.Point(23, 286);
            this.c1Button3.Name = "c1Button3";
            this.c1Button3.Size = new System.Drawing.Size(139, 39);
            this.c1Button3.TabIndex = 3;
            this.c1Button3.Text = "BORRAR";
            this.c1Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Button3.UseVisualStyleBackColor = true;
            // 
            // series
            // 
            this.series.AutoSize = true;
            this.series.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.series.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.series.Location = new System.Drawing.Point(326, 9);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(152, 55);
            this.series.TabIndex = 4;
            this.series.Tag = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.series);
            this.Controls.Add(this.c1Button3);
            this.Controls.Add(this.leer);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.actualizar);
            this.Name = "Form1";
            this.Text = "Cara";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.series)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Button actualizar;
        private C1.Win.C1Input.C1Button crear;
        private C1.Win.C1Input.C1Button leer;
        private C1.Win.C1Input.C1Button c1Button3;
        private C1.Win.C1Input.C1Label series;
    }
}

