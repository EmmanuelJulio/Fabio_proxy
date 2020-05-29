namespace UiFabio.Configuraciones.Asignaciones
{
    partial class frmAsignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.Maquinas_sectores = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboSectores = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMaquinas = new System.Windows.Forms.Panel();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.CHK_Modulos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlTodo.SuspendLayout();
            this.PanelTrabajo.SuspendLayout();
            this.PanenlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Maquinas_sectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMaquinas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Location = new System.Drawing.Point(1286, 0);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(1319, 0);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(1352, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1385, 0);
            // 
            // pnlTodo
            // 
            this.pnlTodo.Size = new System.Drawing.Size(1418, 700);
            // 
            // PanelTrabajo
            // 
            this.PanelTrabajo.Controls.Add(this.splitContainer1);
            this.PanelTrabajo.Size = new System.Drawing.Size(1418, 670);
            this.PanelTrabajo.Controls.SetChildIndex(this.splitContainer1, 0);
            // 
            // PanenlControl
            // 
            this.PanenlControl.Size = new System.Drawing.Size(1418, 30);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Maquinas_sectores);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 659);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Asignar Maquinas a sectores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Maquinas_sectores
            // 
            this.Maquinas_sectores.Controls.Add(this.splitContainer2);
            this.Maquinas_sectores.Controls.Add(this.label2);
            this.Maquinas_sectores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maquinas_sectores.Location = new System.Drawing.Point(0, 0);
            this.Maquinas_sectores.Name = "Maquinas_sectores";
            this.Maquinas_sectores.Size = new System.Drawing.Size(1418, 607);
            this.Maquinas_sectores.TabIndex = 0;
            this.Maquinas_sectores.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 98);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlMaquinas);
            this.splitContainer2.Size = new System.Drawing.Size(1418, 509);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ComboSectores);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 509);
            this.panel2.TabIndex = 16;
            // 
            // ComboSectores
            // 
            this.ComboSectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboSectores.FormattingEnabled = true;
            this.ComboSectores.ItemHeight = 23;
            this.ComboSectores.Location = new System.Drawing.Point(0, 49);
            this.ComboSectores.Name = "ComboSectores";
            this.ComboSectores.Size = new System.Drawing.Size(289, 29);
            this.ComboSectores.TabIndex = 31;
            this.ComboSectores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ComboSectores.UseSelectable = true;
            this.ComboSectores.TextChanged += new System.EventHandler(this.ComboSectores_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "¿A que sector desea agregarle maquinas?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMaquinas
            // 
            this.pnlMaquinas.Controls.Add(this.btn_asignar);
            this.pnlMaquinas.Controls.Add(this.CHK_Modulos);
            this.pnlMaquinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaquinas.Location = new System.Drawing.Point(0, 0);
            this.pnlMaquinas.Name = "pnlMaquinas";
            this.pnlMaquinas.Size = new System.Drawing.Size(1125, 509);
            this.pnlMaquinas.TabIndex = 0;
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_asignar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_asignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_asignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_asignar.Location = new System.Drawing.Point(486, 155);
            this.btn_asignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(191, 45);
            this.btn_asignar.TabIndex = 10;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = false;
            // 
            // CHK_Modulos
            // 
            this.CHK_Modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.CHK_Modulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CHK_Modulos.CheckOnClick = true;
            this.CHK_Modulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.CHK_Modulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Modulos.ForeColor = System.Drawing.Color.Silver;
            this.CHK_Modulos.FormattingEnabled = true;
            this.CHK_Modulos.Location = new System.Drawing.Point(0, 0);
            this.CHK_Modulos.Name = "CHK_Modulos";
            this.CHK_Modulos.Size = new System.Drawing.Size(279, 509);
            this.CHK_Modulos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1418, 98);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 700);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmAsignaciones";
            this.Text = "frmAsignaciones";
            this.Load += new System.EventHandler(this.FrmAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlTodo.ResumeLayout(false);
            this.PanelTrabajo.ResumeLayout(false);
            this.PanenlControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Maquinas_sectores.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMaquinas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Maquinas_sectores;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox ComboSectores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMaquinas;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.CheckedListBox CHK_Modulos;
        private System.Windows.Forms.Label label2;
    }
}