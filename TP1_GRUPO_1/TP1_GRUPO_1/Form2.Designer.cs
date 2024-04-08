
namespace TP1_GRUPO_1
{
    partial class frmEjercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicio1));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbIzquierdo = new System.Windows.Forms.ListBox();
            this.lbDerecho = new System.Windows.Forms.ListBox();
            this.btnPasar1 = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(71, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(152, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(229, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(490, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbIzquierdo
            // 
            this.lbIzquierdo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIzquierdo.FormattingEnabled = true;
            this.lbIzquierdo.ItemHeight = 16;
            this.lbIzquierdo.Location = new System.Drawing.Point(74, 128);
            this.lbIzquierdo.Name = "lbIzquierdo";
            this.lbIzquierdo.Size = new System.Drawing.Size(200, 244);
            this.lbIzquierdo.TabIndex = 3;
            // 
            // lbDerecho
            // 
            this.lbDerecho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDerecho.FormattingEnabled = true;
            this.lbDerecho.ItemHeight = 16;
            this.lbDerecho.Location = new System.Drawing.Point(391, 128);
            this.lbDerecho.Name = "lbDerecho";
            this.lbDerecho.Size = new System.Drawing.Size(200, 244);
            this.lbDerecho.TabIndex = 4;
            // 
            // btnPasar1
            // 
            this.btnPasar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPasar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasar1.Location = new System.Drawing.Point(310, 178);
            this.btnPasar1.Name = "btnPasar1";
            this.btnPasar1.Size = new System.Drawing.Size(50, 30);
            this.btnPasar1.TabIndex = 5;
            this.btnPasar1.Text = ">";
            this.btnPasar1.UseVisualStyleBackColor = false;
            this.btnPasar1.Click += new System.EventHandler(this.btnPasar1_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPasarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasarTodos.Location = new System.Drawing.Point(310, 278);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(50, 30);
            this.btnPasarTodos.TabIndex = 6;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = false;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasar1);
            this.Controls.Add(this.lbDerecho);
            this.Controls.Add(this.lbIzquierdo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEjercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbIzquierdo;
        private System.Windows.Forms.ListBox lbDerecho;
        private System.Windows.Forms.Button btnPasar1;
        private System.Windows.Forms.Button btnPasarTodos;
    }
}