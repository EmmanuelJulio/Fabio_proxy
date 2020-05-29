namespace Interfaz
{
    partial class Frm_Loggin
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
            this.Txt_Usuario = new MetroFramework.Controls.MetroTextBox();
            this.Txt_contraceña = new MetroFramework.Controls.MetroTextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HORA = new MetroFramework.Controls.MetroLabel();
            this.OLVPass = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            // 
            // 
            // 
            this.Txt_Usuario.CustomButton.Image = null;
            this.Txt_Usuario.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.Txt_Usuario.CustomButton.Name = "";
            this.Txt_Usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Usuario.CustomButton.TabIndex = 1;
            this.Txt_Usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Usuario.CustomButton.UseSelectable = true;
            this.Txt_Usuario.CustomButton.Visible = false;
            this.Txt_Usuario.Lines = new string[0];
            this.Txt_Usuario.Location = new System.Drawing.Point(266, 41);
            this.Txt_Usuario.MaxLength = 32767;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.PasswordChar = '\0';
            this.Txt_Usuario.PromptText = "Ingrece su usuario";
            this.Txt_Usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Usuario.SelectedText = "";
            this.Txt_Usuario.SelectionLength = 0;
            this.Txt_Usuario.SelectionStart = 0;
            this.Txt_Usuario.ShortcutsEnabled = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(220, 23);
            this.Txt_Usuario.Style = MetroFramework.MetroColorStyle.Silver;
            this.Txt_Usuario.TabIndex = 1;
            this.Txt_Usuario.UseSelectable = true;
            this.Txt_Usuario.WaterMark = "Ingrece su usuario";
            this.Txt_Usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_contraceña
            // 
            // 
            // 
            // 
            this.Txt_contraceña.CustomButton.Image = null;
            this.Txt_contraceña.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.Txt_contraceña.CustomButton.Name = "";
            this.Txt_contraceña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_contraceña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_contraceña.CustomButton.TabIndex = 1;
            this.Txt_contraceña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_contraceña.CustomButton.UseSelectable = true;
            this.Txt_contraceña.CustomButton.Visible = false;
            this.Txt_contraceña.Lines = new string[0];
            this.Txt_contraceña.Location = new System.Drawing.Point(266, 70);
            this.Txt_contraceña.MaxLength = 32767;
            this.Txt_contraceña.Name = "Txt_contraceña";
            this.Txt_contraceña.PasswordChar = '*';
            this.Txt_contraceña.PromptText = "Ingrese su contraceña";
            this.Txt_contraceña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_contraceña.SelectedText = "";
            this.Txt_contraceña.SelectionLength = 0;
            this.Txt_contraceña.SelectionStart = 0;
            this.Txt_contraceña.ShortcutsEnabled = true;
            this.Txt_contraceña.Size = new System.Drawing.Size(220, 23);
            this.Txt_contraceña.TabIndex = 2;
            this.Txt_contraceña.UseSelectable = true;
            this.Txt_contraceña.WaterMark = "Ingrese su contraceña";
            this.Txt_contraceña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_contraceña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(266, 100);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(220, 32);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.NUEVO_GIF;
            this.pictureBox1.Location = new System.Drawing.Point(9, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "sabado 22 de julio de 2019";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HORA
            // 
            this.HORA.AutoSize = true;
            this.HORA.Location = new System.Drawing.Point(450, 250);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(36, 19);
            this.HORA.TabIndex = 6;
            this.HORA.Text = "11:33";
            // 
            // OLVPass
            // 
            this.OLVPass.Location = new System.Drawing.Point(266, 160);
            this.OLVPass.Name = "OLVPass";
            this.OLVPass.Size = new System.Drawing.Size(220, 23);
            this.OLVPass.TabIndex = 7;
            this.OLVPass.Text = "¿Olvido su contraceña?";
            this.OLVPass.UseSelectable = true;
            // 
            // Frm_Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 277);
            this.Controls.Add(this.OLVPass);
            this.Controls.Add(this.HORA);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.Txt_contraceña);
            this.Controls.Add(this.Txt_Usuario);
            this.Name = "Frm_Loggin";
            this.Opacity = 0D;
            this.Resizable = false;
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.Frm_Loggin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox Txt_Usuario;
        private MetroFramework.Controls.MetroTextBox Txt_contraceña;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel HORA;
        private MetroFramework.Controls.MetroLink OLVPass;
    }
}