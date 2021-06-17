namespace pjtVentas
{
    partial class UserMessage
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lbltipoUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(105, 59);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(16, 13);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "...";
            // 
            // lbltipoUsuario
            // 
            this.lbltipoUsuario.AutoSize = true;
            this.lbltipoUsuario.Location = new System.Drawing.Point(88, 121);
            this.lbltipoUsuario.Name = "lbltipoUsuario";
            this.lbltipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbltipoUsuario.TabIndex = 1;
            this.lbltipoUsuario.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltipoUsuario);
            this.Controls.Add(this.lblmensaje);
            this.Name = "UserMessage";
            this.Text = "UserMessage";
            this.Load += new System.EventHandler(this.UserMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lbltipoUsuario;
        private System.Windows.Forms.Button button1;
    }
}