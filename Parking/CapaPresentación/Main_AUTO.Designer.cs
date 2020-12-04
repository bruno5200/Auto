
namespace CapaPresentación
{
    partial class formAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAuto));
            this.PnlPlaca = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnActivos = new FontAwesome.Sharp.IconButton();
            this.pibSABSA = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnArchivos = new FontAwesome.Sharp.IconButton();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinmize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblShow = new System.Windows.Forms.Label();
            this.icoform = new FontAwesome.Sharp.IconButton();
            this.PnlPlaca.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSABSA)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPlaca
            // 
            this.PnlPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnlPlaca.CausesValidation = false;
            this.PnlPlaca.Controls.Add(this.pnlContenedor);
            this.PnlPlaca.Controls.Add(this.pnlMenu);
            this.PnlPlaca.Controls.Add(this.pnlSuperior);
            this.PnlPlaca.Location = new System.Drawing.Point(0, 0);
            this.PnlPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPlaca.Name = "PnlPlaca";
            this.PnlPlaca.Size = new System.Drawing.Size(1350, 729);
            this.PnlPlaca.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(120, 60);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1230, 669);
            this.pnlContenedor.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnActivos);
            this.pnlMenu.Controls.Add(this.pibSABSA);
            this.pnlMenu.Controls.Add(this.btnRegistrar);
            this.pnlMenu.Controls.Add(this.btnArchivos);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(120, 669);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnActivos
            // 
            this.btnActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivos.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnActivos.FlatAppearance.BorderSize = 0;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActivos.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.btnActivos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivos.IconSize = 32;
            this.btnActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivos.Location = new System.Drawing.Point(0, 344);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnActivos.Size = new System.Drawing.Size(119, 50);
            this.btnActivos.TabIndex = 3;
            this.btnActivos.Text = "Activo";
            this.btnActivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // pibSABSA
            // 
            this.pibSABSA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pibSABSA.BackColor = System.Drawing.Color.Transparent;
            this.pibSABSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pibSABSA.BackgroundImage")));
            this.pibSABSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibSABSA.ErrorImage = null;
            this.pibSABSA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pibSABSA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pibSABSA.IconColor = System.Drawing.SystemColors.ControlText;
            this.pibSABSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pibSABSA.IconSize = 120;
            this.pibSABSA.ImageLocation = "";
            this.pibSABSA.InitialImage = null;
            this.pibSABSA.Location = new System.Drawing.Point(0, 0);
            this.pibSABSA.Name = "pibSABSA";
            this.pibSABSA.Size = new System.Drawing.Size(120, 120);
            this.pibSABSA.TabIndex = 2;
            this.pibSABSA.TabStop = false;
            this.pibSABSA.Click += new System.EventHandler(this.pibSABSA_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnRegistrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 32;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 246);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRegistrar.Size = new System.Drawing.Size(119, 50);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnArchivos
            // 
            this.btnArchivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArchivos.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnArchivos.FlatAppearance.BorderSize = 0;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArchivos.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnArchivos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnArchivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArchivos.IconSize = 32;
            this.btnArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivos.Location = new System.Drawing.Point(0, 295);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnArchivos.Size = new System.Drawing.Size(119, 50);
            this.btnArchivos.TabIndex = 0;
            this.btnArchivos.Text = "Archivo";
            this.btnArchivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlSuperior.Controls.Add(this.btnMinmize);
            this.pnlSuperior.Controls.Add(this.btnMaximize);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Controls.Add(this.lblShow);
            this.pnlSuperior.Controls.Add(this.icoform);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(1);
            this.pnlSuperior.MaximumSize = new System.Drawing.Size(3860, 60);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1350, 60);
            this.pnlSuperior.TabIndex = 1;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // btnMinmize
            // 
            this.btnMinmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinmize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(68)))));
            this.btnMinmize.FlatAppearance.BorderSize = 0;
            this.btnMinmize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinmize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinmize.IconColor = System.Drawing.Color.DimGray;
            this.btnMinmize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinmize.IconSize = 32;
            this.btnMinmize.Location = new System.Drawing.Point(1281, 3);
            this.btnMinmize.Name = "btnMinmize";
            this.btnMinmize.Size = new System.Drawing.Size(20, 20);
            this.btnMinmize.TabIndex = 7;
            this.btnMinmize.UseVisualStyleBackColor = false;
            this.btnMinmize.Click += new System.EventHandler(this.btnMinmize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(68)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.DimGray;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 32;
            this.btnMaximize.Location = new System.Drawing.Point(1304, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(68)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1327, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblShow.Location = new System.Drawing.Point(161, 23);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(32, 13);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "Inicio";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icoform
            // 
            this.icoform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icoform.CausesValidation = false;
            this.icoform.FlatAppearance.BorderSize = 0;
            this.icoform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icoform.IconColor = System.Drawing.Color.Gainsboro;
            this.icoform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoform.Location = new System.Drawing.Point(120, 12);
            this.icoform.Name = "icoform";
            this.icoform.Size = new System.Drawing.Size(35, 35);
            this.icoform.TabIndex = 0;
            this.icoform.UseVisualStyleBackColor = false;
            // 
            // formAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.PnlPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "formAuto";
            this.Opacity = 0.95D;
            this.Text = "Parqueo Sabsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlPlaca.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibSABSA)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPlaca;
        private FontAwesome.Sharp.IconButton btnArchivos;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconPictureBox pibSABSA;
        private FontAwesome.Sharp.IconButton icoform;
        private System.Windows.Forms.Label lblShow;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinmize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnActivos;
    }
}

