﻿namespace UiFabio
{
    partial class Principal
    {

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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Panelbot = new System.Windows.Forms.Panel();
            this.lbl_informacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblhora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Dia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_sector = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_usuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Botones = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.Button();
            this.PnlSubMenus = new System.Windows.Forms.Panel();
            this.SubModulos = new System.Windows.Forms.Button();
            this.PnlModulos = new System.Windows.Forms.Panel();
            this.Modulos = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.Fabiogif = new System.Windows.Forms.PictureBox();
            this.Btn_volveropciones = new System.Windows.Forms.PictureBox();
            this.Btn_volvermodulos = new System.Windows.Forms.PictureBox();
            this.lbl_texto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogoFabio = new System.Windows.Forms.PictureBox();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelAnimador = new BunifuAnimatorNS.Animator(this.components);
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            this.Panelbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Botones.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.PnlSubMenus.SuspendLayout();
            this.PnlModulos.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabiogif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volveropciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volvermodulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoFabio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.PanelAnimador.SetDecoration(this.BtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.BtnMinimize, BunifuAnimatorNS.DecorationType.None);
            // 
            // BtnNormal
            // 
            this.PanelAnimador.SetDecoration(this.BtnNormal, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.BtnNormal, BunifuAnimatorNS.DecorationType.None);
            // 
            // btnMaximize
            // 
            this.PanelAnimador.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            // 
            // btnCerrar
            // 
            this.PanelAnimador.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pnlTodo
            // 
            this.animator1.SetDecoration(this.pnlTodo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.pnlTodo, BunifuAnimatorNS.DecorationType.None);
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Controls.Add(this.PanelContenedor);
            this.PanelTrabajo.Controls.Add(this.Botones);
            this.PanelTrabajo.Controls.Add(this.Panelbot);
            this.animator1.SetDecoration(this.PanelTrabajo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PanelTrabajo, BunifuAnimatorNS.DecorationType.None);
            // 
            // PanenlControl
            // 
            this.animator1.SetDecoration(this.PanenlControl, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PanenlControl, BunifuAnimatorNS.DecorationType.None);
            // 
            // Panelbot
            // 
            this.Panelbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.Panelbot.Controls.Add(this.lbl_informacion);
            this.Panelbot.Controls.Add(this.pictureBox2);
            this.Panelbot.Controls.Add(this.lblhora);
            this.Panelbot.Controls.Add(this.Dia);
            this.Panelbot.Controls.Add(this.Txt_sector);
            this.Panelbot.Controls.Add(this.txt_usuario);
            this.Panelbot.Controls.Add(this.pictureBox1);
            this.animator1.SetDecoration(this.Panelbot, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.Panelbot, BunifuAnimatorNS.DecorationType.None);
            this.Panelbot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelbot.Location = new System.Drawing.Point(0, 478);
            this.Panelbot.Name = "Panelbot";
            this.Panelbot.Size = new System.Drawing.Size(1067, 80);
            this.Panelbot.TabIndex = 0;
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.lbl_informacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimador.SetDecoration(this.lbl_informacion, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.lbl_informacion, BunifuAnimatorNS.DecorationType.None);
            this.lbl_informacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion.ForeColor = System.Drawing.Color.Silver;
            this.lbl_informacion.Location = new System.Drawing.Point(215, 6);
            this.lbl_informacion.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(641, 73);
            this.lbl_informacion.TabIndex = 11;
            this.lbl_informacion.Text = "Sabado 22 de junio del 2019";
            this.lbl_informacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_informacion.Visible = false;
            this.lbl_informacion.Click += new System.EventHandler(this.lbl_informacion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimador.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1035, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.PanelAnimador.SetDecoration(this.lblhora, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.lblhora, BunifuAnimatorNS.DecorationType.None);
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Silver;
            this.lblhora.Location = new System.Drawing.Point(989, 26);
            this.lblhora.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(64, 18);
            this.lblhora.TabIndex = 9;
            this.lblhora.Text = "21:38:48";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dia
            // 
            this.Dia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dia.AutoSize = true;
            this.PanelAnimador.SetDecoration(this.Dia, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Dia, BunifuAnimatorNS.DecorationType.None);
            this.Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.Silver;
            this.Dia.Location = new System.Drawing.Point(862, 6);
            this.Dia.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(193, 18);
            this.Dia.TabIndex = 8;
            this.Dia.Text = "Sabado 22 de junio del 2019";
            this.Dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_sector
            // 
            this.Txt_sector.AutoSize = true;
            this.PanelAnimador.SetDecoration(this.Txt_sector, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Txt_sector, BunifuAnimatorNS.DecorationType.None);
            this.Txt_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sector.ForeColor = System.Drawing.Color.Silver;
            this.Txt_sector.Location = new System.Drawing.Point(89, 26);
            this.Txt_sector.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Txt_sector.Name = "Txt_sector";
            this.Txt_sector.Size = new System.Drawing.Size(110, 18);
            this.Txt_sector.TabIndex = 7;
            this.Txt_sector.Text = "Oficina Tecnica";
            this.Txt_sector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.PanelAnimador.SetDecoration(this.txt_usuario, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.txt_usuario, BunifuAnimatorNS.DecorationType.None);
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Silver;
            this.txt_usuario.Location = new System.Drawing.Point(89, 6);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(114, 18);
            this.txt_usuario.TabIndex = 6;
            this.txt_usuario.Text = "Emmanuel Julio";
            this.txt_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.PanelAnimador.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.PanelForm);
            this.Botones.Controls.Add(this.PnlSubMenus);
            this.Botones.Controls.Add(this.PnlModulos);
            this.Botones.Controls.Add(this.pnlLogo);
            this.animator1.SetDecoration(this.Botones, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.Botones, BunifuAnimatorNS.DecorationType.None);
            this.Botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.Botones.Location = new System.Drawing.Point(0, 0);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(462, 478);
            this.Botones.TabIndex = 1;
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.PanelForm.Controls.Add(this.SubMenu);
            this.animator1.SetDecoration(this.PanelForm, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PanelForm, BunifuAnimatorNS.DecorationType.None);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelForm.Location = new System.Drawing.Point(272, 98);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(136, 380);
            this.PanelForm.TabIndex = 3;
            // 
            // SubMenu
            // 
            this.PanelAnimador.SetDecoration(this.SubMenu, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.SubMenu, BunifuAnimatorNS.DecorationType.None);
            this.SubMenu.Location = new System.Drawing.Point(19, 42);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(75, 23);
            this.SubMenu.TabIndex = 2;
            this.SubMenu.Text = "button3";
            this.SubMenu.UseVisualStyleBackColor = true;
            this.SubMenu.Visible = false;
            this.SubMenu.Click += new System.EventHandler(this.SubMenu_Click);
            // 
            // PnlSubMenus
            // 
            this.PnlSubMenus.Controls.Add(this.SubModulos);
            this.animator1.SetDecoration(this.PnlSubMenus, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PnlSubMenus, BunifuAnimatorNS.DecorationType.None);
            this.PnlSubMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSubMenus.Location = new System.Drawing.Point(136, 98);
            this.PnlSubMenus.Name = "PnlSubMenus";
            this.PnlSubMenus.Size = new System.Drawing.Size(136, 380);
            this.PnlSubMenus.TabIndex = 2;
            // 
            // SubModulos
            // 
            this.PanelAnimador.SetDecoration(this.SubModulos, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.SubModulos, BunifuAnimatorNS.DecorationType.None);
            this.SubModulos.Location = new System.Drawing.Point(26, 42);
            this.SubModulos.Name = "SubModulos";
            this.SubModulos.Size = new System.Drawing.Size(75, 23);
            this.SubModulos.TabIndex = 1;
            this.SubModulos.Text = "button2";
            this.SubModulos.UseVisualStyleBackColor = true;
            this.SubModulos.Visible = false;
            this.SubModulos.Click += new System.EventHandler(this.SubModulos_Click);
            // 
            // PnlModulos
            // 
            this.PnlModulos.Controls.Add(this.Modulos);
            this.animator1.SetDecoration(this.PnlModulos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PnlModulos, BunifuAnimatorNS.DecorationType.None);
            this.PnlModulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlModulos.Location = new System.Drawing.Point(0, 98);
            this.PnlModulos.Name = "PnlModulos";
            this.PnlModulos.Size = new System.Drawing.Size(136, 380);
            this.PnlModulos.TabIndex = 1;
            // 
            // Modulos
            // 
            this.PanelAnimador.SetDecoration(this.Modulos, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Modulos, BunifuAnimatorNS.DecorationType.None);
            this.Modulos.Location = new System.Drawing.Point(26, 42);
            this.Modulos.Name = "Modulos";
            this.Modulos.Size = new System.Drawing.Size(75, 23);
            this.Modulos.TabIndex = 0;
            this.Modulos.Text = "button1";
            this.Modulos.UseVisualStyleBackColor = true;
            this.Modulos.Visible = false;
            this.Modulos.Click += new System.EventHandler(this.Modulos_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.Fabiogif);
            this.pnlLogo.Controls.Add(this.Btn_volveropciones);
            this.pnlLogo.Controls.Add(this.Btn_volvermodulos);
            this.pnlLogo.Controls.Add(this.lbl_texto);
            this.pnlLogo.Controls.Add(this.LogoFabio);
            this.animator1.SetDecoration(this.pnlLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.pnlLogo, BunifuAnimatorNS.DecorationType.None);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(462, 98);
            this.pnlLogo.TabIndex = 0;
            // 
            // Fabiogif
            // 
            this.PanelAnimador.SetDecoration(this.Fabiogif, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Fabiogif, BunifuAnimatorNS.DecorationType.None);
            this.Fabiogif.Image = global::UiFabio.Properties.Resources.NUEVO_GIF;
            this.Fabiogif.Location = new System.Drawing.Point(0, 6);
            this.Fabiogif.Name = "Fabiogif";
            this.Fabiogif.Size = new System.Drawing.Size(69, 61);
            this.Fabiogif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fabiogif.TabIndex = 8;
            this.Fabiogif.TabStop = false;
            this.Fabiogif.Visible = false;
            // 
            // Btn_volveropciones
            // 
            this.PanelAnimador.SetDecoration(this.Btn_volveropciones, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Btn_volveropciones, BunifuAnimatorNS.DecorationType.None);
            this.Btn_volveropciones.Image = ((System.Drawing.Image)(resources.GetObject("Btn_volveropciones.Image")));
            this.Btn_volveropciones.Location = new System.Drawing.Point(12, 71);
            this.Btn_volveropciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_volveropciones.Name = "Btn_volveropciones";
            this.Btn_volveropciones.Size = new System.Drawing.Size(24, 18);
            this.Btn_volveropciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_volveropciones.TabIndex = 7;
            this.Btn_volveropciones.TabStop = false;
            this.Btn_volveropciones.Visible = false;
            this.Btn_volveropciones.Click += new System.EventHandler(this.Btn_volveropciones_Click);
            // 
            // Btn_volvermodulos
            // 
            this.PanelAnimador.SetDecoration(this.Btn_volvermodulos, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Btn_volvermodulos, BunifuAnimatorNS.DecorationType.None);
            this.Btn_volvermodulos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_volvermodulos.Image")));
            this.Btn_volvermodulos.Location = new System.Drawing.Point(5, 71);
            this.Btn_volvermodulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_volvermodulos.Name = "Btn_volvermodulos";
            this.Btn_volvermodulos.Size = new System.Drawing.Size(24, 18);
            this.Btn_volvermodulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_volvermodulos.TabIndex = 6;
            this.Btn_volvermodulos.TabStop = false;
            this.Btn_volvermodulos.Visible = false;
            this.Btn_volvermodulos.Click += new System.EventHandler(this.Btn_volvermodulos_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.PanelAnimador.SetDecoration(this.lbl_texto, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.lbl_texto, BunifuAnimatorNS.DecorationType.None);
            this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.ForeColor = System.Drawing.Color.Silver;
            this.lbl_texto.Location = new System.Drawing.Point(35, 71);
            this.lbl_texto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(66, 18);
            this.lbl_texto.TabIndex = 5;
            this.lbl_texto.Text = "Modulos";
            this.lbl_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoFabio
            // 
            this.PanelAnimador.SetDecoration(this.LogoFabio, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.LogoFabio, BunifuAnimatorNS.DecorationType.None);
            this.LogoFabio.Image = ((System.Drawing.Image)(resources.GetObject("LogoFabio.Image")));
            this.LogoFabio.Location = new System.Drawing.Point(5, 6);
            this.LogoFabio.Name = "LogoFabio";
            this.LogoFabio.Size = new System.Drawing.Size(187, 61);
            this.LogoFabio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoFabio.TabIndex = 0;
            this.LogoFabio.TabStop = false;
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // PanelContenedor
            // 
            this.animator1.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(462, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(605, 478);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // PanelAnimador
            // 
            this.PanelAnimador.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimador.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimador.DefaultAnimation = animation1;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimador.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            this.Panelbot.ResumeLayout(false);
            this.Panelbot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Botones.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PnlSubMenus.ResumeLayout(false);
            this.PnlModulos.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fabiogif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volveropciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volvermodulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoFabio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Botones;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Button SubMenu;
        private System.Windows.Forms.Panel PnlSubMenus;
        private System.Windows.Forms.Button SubModulos;
        private System.Windows.Forms.Panel PnlModulos;
        private System.Windows.Forms.Button Modulos;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox Btn_volveropciones;
        private System.Windows.Forms.PictureBox Btn_volvermodulos;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_texto;
        private System.Windows.Forms.PictureBox LogoFabio;
        private System.Windows.Forms.Panel Panelbot;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblhora;
        public Bunifu.Framework.UI.BunifuCustomLabel Dia;
        public Bunifu.Framework.UI.BunifuCustomLabel Txt_sector;
        public Bunifu.Framework.UI.BunifuCustomLabel txt_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer Hora;
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private System.ComponentModel.IContainer components;
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private System.Windows.Forms.Panel PanelContenedor;
        private BunifuAnimatorNS.Animator PanelAnimador;
        private BunifuAnimatorNS.Animator animator1;
        private System.Windows.Forms.PictureBox Fabiogif;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_informacion;
    }
}