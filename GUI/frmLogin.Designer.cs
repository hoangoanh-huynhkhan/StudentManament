
namespace GUI
{
    partial class frmLogin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl__title = new System.Windows.Forms.Label();
            this.btn__maximize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__minimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic__title = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic__username = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txt__username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt__password = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic__password = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__show = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__show)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.lbl__title);
            this.guna2Panel1.Controls.Add(this.btn__maximize);
            this.guna2Panel1.Controls.Add(this.btn__minimize);
            this.guna2Panel1.Controls.Add(this.btn__close);
            this.guna2Panel1.Location = new System.Drawing.Point(-13, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(524, 47);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl__title
            // 
            this.lbl__title.AutoSize = true;
            this.lbl__title.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__title.ForeColor = System.Drawing.Color.Teal;
            this.lbl__title.Location = new System.Drawing.Point(375, 11);
            this.lbl__title.Name = "lbl__title";
            this.lbl__title.Size = new System.Drawing.Size(107, 27);
            this.lbl__title.TabIndex = 4;
            this.lbl__title.Text = "Đăng nhập";
            // 
            // btn__maximize
            // 
            this.btn__maximize.Image = global::GUI.Properties.Resources.full_screen;
            this.btn__maximize.ImageRotate = 0F;
            this.btn__maximize.Location = new System.Drawing.Point(93, 11);
            this.btn__maximize.Name = "btn__maximize";
            this.btn__maximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__maximize.Size = new System.Drawing.Size(27, 27);
            this.btn__maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__maximize.TabIndex = 3;
            this.btn__maximize.TabStop = false;
            // 
            // btn__minimize
            // 
            this.btn__minimize.Image = global::GUI.Properties.Resources.minus;
            this.btn__minimize.ImageRotate = 0F;
            this.btn__minimize.Location = new System.Drawing.Point(60, 11);
            this.btn__minimize.Name = "btn__minimize";
            this.btn__minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__minimize.Size = new System.Drawing.Size(27, 27);
            this.btn__minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__minimize.TabIndex = 2;
            this.btn__minimize.TabStop = false;
            // 
            // btn__close
            // 
            this.btn__close.Image = global::GUI.Properties.Resources.close;
            this.btn__close.ImageRotate = 0F;
            this.btn__close.Location = new System.Drawing.Point(27, 11);
            this.btn__close.Name = "btn__close";
            this.btn__close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__close.Size = new System.Drawing.Size(27, 27);
            this.btn__close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__close.TabIndex = 1;
            this.btn__close.TabStop = false;
            this.btn__close.Click += new System.EventHandler(this.btn__close_Click);
            // 
            // pic__title
            // 
            this.pic__title.Image = global::GUI.Properties.Resources.login_;
            this.pic__title.ImageRotate = 0F;
            this.pic__title.Location = new System.Drawing.Point(115, 50);
            this.pic__title.Name = "pic__title";
            this.pic__title.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__title.Size = new System.Drawing.Size(271, 284);
            this.pic__title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__title.TabIndex = 1;
            this.pic__title.TabStop = false;
            // 
            // pic__username
            // 
            this.pic__username.Image = global::GUI.Properties.Resources.profile;
            this.pic__username.ImageRotate = 0F;
            this.pic__username.Location = new System.Drawing.Point(14, 387);
            this.pic__username.Name = "pic__username";
            this.pic__username.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__username.Size = new System.Drawing.Size(64, 64);
            this.pic__username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__username.TabIndex = 2;
            this.pic__username.TabStop = false;
            // 
            // txt__username
            // 
            this.txt__username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt__username.BorderRadius = 19;
            this.txt__username.BorderThickness = 2;
            this.txt__username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__username.DefaultText = "";
            this.txt__username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__username.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt__username.ForeColor = System.Drawing.Color.Black;
            this.txt__username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt__username.Location = new System.Drawing.Point(107, 383);
            this.txt__username.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt__username.Name = "txt__username";
            this.txt__username.PasswordChar = '\0';
            this.txt__username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt__username.PlaceholderText = "Tên đăng nhập";
            this.txt__username.SelectedText = "";
            this.txt__username.Size = new System.Drawing.Size(362, 77);
            this.txt__username.TabIndex = 3;
            // 
            // txt__password
            // 
            this.txt__password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt__password.BorderRadius = 19;
            this.txt__password.BorderThickness = 2;
            this.txt__password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__password.DefaultText = "";
            this.txt__password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__password.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt__password.ForeColor = System.Drawing.Color.Black;
            this.txt__password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt__password.Location = new System.Drawing.Point(107, 499);
            this.txt__password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt__password.Name = "txt__password";
            this.txt__password.PasswordChar = '*';
            this.txt__password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt__password.PlaceholderText = "Mật khẩu";
            this.txt__password.SelectedText = "";
            this.txt__password.Size = new System.Drawing.Size(362, 77);
            this.txt__password.TabIndex = 5;
            this.txt__password.TextChanged += new System.EventHandler(this.txt__password_TextChanged);
            // 
            // pic__password
            // 
            this.pic__password.Image = global::GUI.Properties.Resources.password;
            this.pic__password.ImageRotate = 0F;
            this.pic__password.Location = new System.Drawing.Point(14, 503);
            this.pic__password.Name = "pic__password";
            this.pic__password.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__password.Size = new System.Drawing.Size(64, 64);
            this.pic__password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__password.TabIndex = 4;
            this.pic__password.TabStop = false;
            // 
            // btn__show
            // 
            this.btn__show.BackColor = System.Drawing.Color.White;
            this.btn__show.Image = global::GUI.Properties.Resources.hide__1_;
            this.btn__show.ImageRotate = 0F;
            this.btn__show.Location = new System.Drawing.Point(426, 526);
            this.btn__show.Name = "btn__show";
            this.btn__show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__show.Size = new System.Drawing.Size(27, 27);
            this.btn__show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__show.TabIndex = 6;
            this.btn__show.TabStop = false;
            this.btn__show.Visible = false;
            this.btn__show.Click += new System.EventHandler(this.btn__show_Click);
            // 
            // btn__login
            // 
            this.btn__login.Animated = true;
            this.btn__login.BackColor = System.Drawing.Color.Transparent;
            this.btn__login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn__login.BorderRadius = 20;
            this.btn__login.BorderThickness = 3;
            this.btn__login.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn__login.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btn__login.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn__login.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn__login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn__login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn__login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn__login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn__login.FillColor = System.Drawing.Color.White;
            this.btn__login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn__login.ForeColor = System.Drawing.Color.Teal;
            this.btn__login.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btn__login.HoverState.FillColor = System.Drawing.Color.White;
            this.btn__login.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btn__login.IndicateFocus = true;
            this.btn__login.Location = new System.Drawing.Point(164, 608);
            this.btn__login.Name = "btn__login";
            this.btn__login.PressedColor = System.Drawing.Color.White;
            this.btn__login.Size = new System.Drawing.Size(180, 84);
            this.btn__login.TabIndex = 7;
            this.btn__login.Text = "Đăng nhập";
            this.btn__login.UseTransparentBackground = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 747);
            this.Controls.Add(this.btn__login);
            this.Controls.Add(this.btn__show);
            this.Controls.Add(this.txt__password);
            this.Controls.Add(this.pic__password);
            this.Controls.Add(this.txt__username);
            this.Controls.Add(this.pic__username);
            this.Controls.Add(this.pic__title);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__close;
        private System.Windows.Forms.Label lbl__title;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__maximize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__minimize;
        private Guna.UI2.WinForms.Guna2TextBox txt__username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__title;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__show;
        private Guna.UI2.WinForms.Guna2TextBox txt__password;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__password;
        private Guna.UI2.WinForms.Guna2Button btn__login;
    }
}