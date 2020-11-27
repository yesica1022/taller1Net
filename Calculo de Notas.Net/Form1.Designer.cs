namespace Calculo_de_Notas.Net
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuIconos = new System.Windows.Forms.ToolStrip();
            this.tsOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsSearchUser = new System.Windows.Forms.ToolStripButton();
            this.tsEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.tsSaverFile = new System.Windows.Forms.ToolStripButton();
            this.tsExitApp = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigoin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombrein = new System.Windows.Forms.TextBox();
            this.txtcorreoin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnota1in = new System.Windows.Forms.TextBox();
            this.txtnota2in = new System.Windows.Forms.TextBox();
            this.txtnota3in = new System.Windows.Forms.TextBox();
            this.txtnota4in = new System.Windows.Forms.TextBox();
            this.dgTablaDatos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorm = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuIconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorm)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuIconos
            // 
            this.MenuIconos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuIconos.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.MenuIconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.tsAddUser,
            this.tsSearchUser,
            this.tsEditUser,
            this.tsDeleteUser,
            this.tsSaverFile,
            this.tsExitApp});
            this.MenuIconos.Location = new System.Drawing.Point(0, 0);
            this.MenuIconos.Margin = new System.Windows.Forms.Padding(15);
            this.MenuIconos.Name = "MenuIconos";
            this.MenuIconos.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MenuIconos.Size = new System.Drawing.Size(778, 104);
            this.MenuIconos.TabIndex = 0;
            this.MenuIconos.Text = "toolStrip1";
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenFile.Image")));
            this.tsOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFile.Margin = new System.Windows.Forms.Padding(5);
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Padding = new System.Windows.Forms.Padding(5);
            this.tsOpenFile.Size = new System.Drawing.Size(94, 94);
            this.tsOpenFile.Text = "toolStripButton6";
            this.tsOpenFile.ToolTipText = "Abre el archivo XML";
            this.tsOpenFile.Visible = false;
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click_1);
            // 
            // tsAddUser
            // 
            this.tsAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsAddUser.Image")));
            this.tsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.tsAddUser.Name = "tsAddUser";
            this.tsAddUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsAddUser.Size = new System.Drawing.Size(94, 94);
            this.tsAddUser.Text = "toolStripButton5";
            this.tsAddUser.ToolTipText = "Nuevo Estudiante";
            this.tsAddUser.Click += new System.EventHandler(this.tsAddUser_Click);
            // 
            // tsSearchUser
            // 
            this.tsSearchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchUser.Image")));
            this.tsSearchUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchUser.Margin = new System.Windows.Forms.Padding(5);
            this.tsSearchUser.Name = "tsSearchUser";
            this.tsSearchUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsSearchUser.Size = new System.Drawing.Size(94, 94);
            this.tsSearchUser.Text = "toolStripButton4";
            this.tsSearchUser.ToolTipText = "Buscar Estudiante";
            this.tsSearchUser.Click += new System.EventHandler(this.tsSearchUser_Click_1);
            // 
            // tsEditUser
            // 
            this.tsEditUser.AutoSize = false;
            this.tsEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditUser.Enabled = false;
            this.tsEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsEditUser.Image")));
            this.tsEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditUser.Margin = new System.Windows.Forms.Padding(5);
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsEditUser.Size = new System.Drawing.Size(94, 94);
            this.tsEditUser.Text = "toolStripButton3";
            this.tsEditUser.ToolTipText = "Editar Estudiante";
            this.tsEditUser.Click += new System.EventHandler(this.tsEditUser_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Enabled = false;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Margin = new System.Windows.Forms.Padding(5);
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Padding = new System.Windows.Forms.Padding(5);
            this.tsDeleteUser.Size = new System.Drawing.Size(94, 94);
            this.tsDeleteUser.Text = "toolStripButton2";
            this.tsDeleteUser.ToolTipText = "Borrar Datos del Estudiante";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click_1);
            // 
            // tsSaverFile
            // 
            this.tsSaverFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaverFile.Image = ((System.Drawing.Image)(resources.GetObject("tsSaverFile.Image")));
            this.tsSaverFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaverFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaverFile.Margin = new System.Windows.Forms.Padding(5);
            this.tsSaverFile.Name = "tsSaverFile";
            this.tsSaverFile.Padding = new System.Windows.Forms.Padding(5);
            this.tsSaverFile.Size = new System.Drawing.Size(94, 94);
            this.tsSaverFile.Text = "toolStripButton7";
            this.tsSaverFile.ToolTipText = "GuardarArchivos XML";
            this.tsSaverFile.Visible = false;
            // 
            // tsExitApp
            // 
            this.tsExitApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExitApp.Image = ((System.Drawing.Image)(resources.GetObject("tsExitApp.Image")));
            this.tsExitApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExitApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExitApp.Margin = new System.Windows.Forms.Padding(5);
            this.tsExitApp.Name = "tsExitApp";
            this.tsExitApp.Padding = new System.Windows.Forms.Padding(5);
            this.tsExitApp.Size = new System.Drawing.Size(94, 94);
            this.tsExitApp.Text = "toolStripButton7";
            this.tsExitApp.ToolTipText = "Cerrar Aplicación";
            this.tsExitApp.Click += new System.EventHandler(this.tsExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Estudiante";
            // 
            // txtcodigoin
            // 
            this.txtcodigoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoin.Location = new System.Drawing.Point(542, 161);
            this.txtcodigoin.Name = "txtcodigoin";
            this.txtcodigoin.Size = new System.Drawing.Size(139, 22);
            this.txtcodigoin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // txtnombrein
            // 
            this.txtnombrein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrein.Location = new System.Drawing.Point(175, 202);
            this.txtnombrein.Name = "txtnombrein";
            this.txtnombrein.Size = new System.Drawing.Size(506, 22);
            this.txtnombrein.TabIndex = 6;
            // 
            // txtcorreoin
            // 
            this.txtcorreoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreoin.Location = new System.Drawing.Point(175, 230);
            this.txtcorreoin.Name = "txtcorreoin";
            this.txtcorreoin.Size = new System.Drawing.Size(506, 22);
            this.txtcorreoin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nota 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nota 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nota 4";
            // 
            // txtnota1in
            // 
            this.txtnota1in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1in.Location = new System.Drawing.Point(175, 271);
            this.txtnota1in.Name = "txtnota1in";
            this.txtnota1in.Size = new System.Drawing.Size(63, 22);
            this.txtnota1in.TabIndex = 12;
            // 
            // txtnota2in
            // 
            this.txtnota2in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2in.Location = new System.Drawing.Point(320, 271);
            this.txtnota2in.Name = "txtnota2in";
            this.txtnota2in.Size = new System.Drawing.Size(64, 22);
            this.txtnota2in.TabIndex = 13;
            // 
            // txtnota3in
            // 
            this.txtnota3in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota3in.Location = new System.Drawing.Point(469, 271);
            this.txtnota3in.Name = "txtnota3in";
            this.txtnota3in.Size = new System.Drawing.Size(64, 22);
            this.txtnota3in.TabIndex = 14;
            // 
            // txtnota4in
            // 
            this.txtnota4in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota4in.Location = new System.Drawing.Point(621, 271);
            this.txtnota4in.Name = "txtnota4in";
            this.txtnota4in.Size = new System.Drawing.Size(60, 22);
            this.txtnota4in.TabIndex = 15;
            // 
            // dgTablaDatos
            // 
            this.dgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaDatos.Location = new System.Drawing.Point(89, 325);
            this.dgTablaDatos.Name = "dgTablaDatos";
            this.dgTablaDatos.Size = new System.Drawing.Size(592, 127);
            this.dgTablaDatos.TabIndex = 16;
            this.dgTablaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablaDatos_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // errorm
            // 
            this.errorm.ContainerControl = this;
            this.errorm.Icon = ((System.Drawing.Icon)(resources.GetObject("errorm.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.dgTablaDatos);
            this.Controls.Add(this.txtnota4in);
            this.Controls.Add(this.txtnota3in);
            this.Controls.Add(this.txtnota2in);
            this.Controls.Add(this.txtnota1in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcorreoin);
            this.Controls.Add(this.txtnombrein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuIconos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MenuIconos.ResumeLayout(false);
            this.MenuIconos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuIconos;
        private System.Windows.Forms.ToolStripButton tsOpenFile;
        private System.Windows.Forms.ToolStripButton tsAddUser;
        private System.Windows.Forms.ToolStripButton tsSearchUser;
        private System.Windows.Forms.ToolStripButton tsEditUser;
        private System.Windows.Forms.ToolStripButton tsDeleteUser;
        private System.Windows.Forms.ToolStripButton tsSaverFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombrein;
        private System.Windows.Forms.TextBox txtcorreoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsExitApp;
        private System.Windows.Forms.TextBox txtnota1in;
        private System.Windows.Forms.TextBox txtnota2in;
        private System.Windows.Forms.TextBox txtnota3in;
        private System.Windows.Forms.TextBox txtnota4in;
        private System.Windows.Forms.DataGridView dgTablaDatos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorm;
    }
}

