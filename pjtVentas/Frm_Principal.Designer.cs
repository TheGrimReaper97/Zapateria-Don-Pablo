﻿namespace pjtVentas
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVender = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_produc = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_consul = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_herramientas = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_produc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_consul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_herramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 47);
            this.panel1.TabIndex = 0;
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(972, 12);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(32, 32);
            this.btn_mini.TabIndex = 13;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(1011, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 5);
            this.panel2.TabIndex = 1;
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
            this.btnVender.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnVender.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.Location = new System.Drawing.Point(166, 169);
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
            this.btnVender.TabIndex = 51;
            this.btnVender.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.btnVender.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVender.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oxygen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 57;
            this.label4.Text = "Carrito de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oxygen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 59;
            this.label1.Text = "Productos";
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
            this.bt_produc.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.bt_produc.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_produc.Location = new System.Drawing.Point(374, 169);
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
            this.bt_produc.TabIndex = 58;
            this.bt_produc.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produc.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.bt_produc.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_produc.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_produc.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.bt_produc.Click += new System.EventHandler(this.bt_produc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oxygen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "Consultas";
            // 
            // bt_consul
            // 
            this.bt_consul.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_consul.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.bt_consul.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_consul.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_consul.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_consul.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_consul.BorderStyle.EdgeRadius = 20;
            this.bt_consul.BorderStyle.SolidColor = System.Drawing.Color.Gray;
            this.bt_consul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consul.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_consul.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.bt_consul.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.bt_consul.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_consul.Location = new System.Drawing.Point(579, 169);
            this.bt_consul.Name = "bt_consul";
            this.bt_consul.Size = new System.Drawing.Size(152, 152);
            this.bt_consul.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_consul.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_consul.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Transparent;
            this.bt_consul.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_consul.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_consul.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DodgerBlue;
            this.bt_consul.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consul.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.bt_consul.TabIndex = 60;
            this.bt_consul.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consul.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.bt_consul.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_consul.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_consul.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.bt_consul.Click += new System.EventHandler(this.bt_consul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oxygen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(789, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Herramientas";
            // 
            // bt_herramientas
            // 
            this.bt_herramientas.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_herramientas.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.bt_herramientas.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_herramientas.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_herramientas.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_herramientas.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.bt_herramientas.BorderStyle.EdgeRadius = 20;
            this.bt_herramientas.BorderStyle.SolidColor = System.Drawing.Color.Gray;
            this.bt_herramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_herramientas.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.bt_herramientas.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.bt_herramientas.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.bt_herramientas.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_herramientas.Location = new System.Drawing.Point(776, 169);
            this.bt_herramientas.Name = "bt_herramientas";
            this.bt_herramientas.Size = new System.Drawing.Size(152, 152);
            this.bt_herramientas.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_herramientas.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_herramientas.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Transparent;
            this.bt_herramientas.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.Transparent;
            this.bt_herramientas.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.Transparent;
            this.bt_herramientas.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DodgerBlue;
            this.bt_herramientas.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_herramientas.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.bt_herramientas.TabIndex = 62;
            this.bt_herramientas.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_herramientas.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.bt_herramientas.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_herramientas.TextStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_herramientas.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.bt_herramientas.Click += new System.EventHandler(this.bt_herramientas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_herramientas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_consul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_produc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_produc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_consul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_herramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_Salir;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnVender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton bt_produc;
        private System.Windows.Forms.Label label2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton bt_consul;
        private System.Windows.Forms.Label label3;
        private Klik.Windows.Forms.v1.EntryLib.ELButton bt_herramientas;
    }
}