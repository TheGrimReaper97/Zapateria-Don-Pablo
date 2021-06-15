namespace pjtVentas.Formulario
{
    partial class frmHerramientas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHerramientas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_produc = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnVender = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_produc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVender)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Herramientas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 40);
            this.panel1.TabIndex = 1;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(639, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bt_produc
            // 
            this.bt_produc.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_produc.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.bt_produc.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_produc.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_produc.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_produc.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_produc.BorderStyle.EdgeRadius = 20;
            this.bt_produc.BorderStyle.SolidColor = System.Drawing.Color.Gray;
            this.bt_produc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_produc.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_produc.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.bt_produc.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.bt_produc.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_produc.Location = new System.Drawing.Point(344, 104);
            this.bt_produc.Name = "bt_produc";
            this.bt_produc.Size = new System.Drawing.Size(152, 152);
            this.bt_produc.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_produc.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_produc.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Transparent;
            this.bt_produc.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_produc.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_produc.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DodgerBlue;
            this.bt_produc.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produc.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.bt_produc.TabIndex = 60;
            this.bt_produc.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produc.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.bt_produc.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_produc.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_produc.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.bt_produc.Click += new System.EventHandler(this.bt_produc_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnVender.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btnVender.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnVender.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnVender.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnVender.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnVender.BorderStyle.EdgeRadius = 20;
            this.btnVender.BorderStyle.SolidColor = System.Drawing.Color.Gray;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnVender.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnVender.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnVender.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.Location = new System.Drawing.Point(136, 104);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(152, 152);
            this.btnVender.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.btnVender.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.btnVender.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Transparent;
            this.btnVender.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.Transparent;
            this.btnVender.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Transparent;
            this.btnVender.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DodgerBlue;
            this.btnVender.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btnVender.TabIndex = 59;
            this.btnVender.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.btnVender.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVender.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.Controls.Add(this.bt_produc);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHerramientas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_produc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btn_Salir;
        private Klik.Windows.Forms.v1.EntryLib.ELButton bt_produc;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnVender;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}