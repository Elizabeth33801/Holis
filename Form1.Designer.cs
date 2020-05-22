namespace Holis
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPushme = new System.Windows.Forms.Button();
            this.lblCool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Holis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPushme
            // 
            this.btnPushme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPushme.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPushme.Location = new System.Drawing.Point(131, 86);
            this.btnPushme.Name = "btnPushme";
            this.btnPushme.Size = new System.Drawing.Size(170, 47);
            this.btnPushme.TabIndex = 1;
            this.btnPushme.Text = "Push Me";
            this.btnPushme.UseVisualStyleBackColor = false;
            this.btnPushme.Click += new System.EventHandler(this.btnPushme_Click);
            // 
            // lblCool
            // 
            this.lblCool.AutoSize = true;
            this.lblCool.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCool.Location = new System.Drawing.Point(12, 48);
            this.lblCool.Name = "lblCool";
            this.lblCool.Size = new System.Drawing.Size(422, 18);
            this.lblCool.TabIndex = 2;
            this.lblCool.Text = "Espero que tu dia este de lo mas cool CRACK :D";
            this.lblCool.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 247);
            this.Controls.Add(this.lblCool);
            this.Controls.Add(this.btnPushme);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPushme;
        private System.Windows.Forms.Label lblCool;
    }
}

