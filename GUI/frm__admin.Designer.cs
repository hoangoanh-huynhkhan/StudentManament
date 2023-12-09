
namespace GUI
{
    partial class frm__admin
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn__studentManager = new System.Windows.Forms.ToolStripButton();
            this.btn__facultyManager = new System.Windows.Forms.ToolStripButton();
            this.btn__majorManager = new System.Windows.Forms.ToolStripButton();
            this.btn__maximize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__minimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.uc__students1 = new GUI.UC.uc__students();
            this.guna2Panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btn__maximize);
            this.guna2Panel1.Controls.Add(this.btn__minimize);
            this.guna2Panel1.Controls.Add(this.btn__close);
            this.guna2Panel1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(-15, -13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1238, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn__studentManager,
            this.btn__facultyManager,
            this.btn__majorManager});
            this.toolStrip1.Location = new System.Drawing.Point(9, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(266, 60);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.uc__students1);
            this.guna2Panel2.Location = new System.Drawing.Point(9, 133);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1194, 671);
            this.guna2Panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xin chào Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Huỳnh Văn Chí Khan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(970, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datetime";
            // 
            // btn__studentManager
            // 
            this.btn__studentManager.AutoSize = false;
            this.btn__studentManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn__studentManager.Image = global::GUI.Properties.Resources.add_user;
            this.btn__studentManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__studentManager.Name = "btn__studentManager";
            this.btn__studentManager.Size = new System.Drawing.Size(50, 50);
            this.btn__studentManager.Text = "Quản lý sinh viên";
            // 
            // btn__facultyManager
            // 
            this.btn__facultyManager.AutoSize = false;
            this.btn__facultyManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn__facultyManager.Image = global::GUI.Properties.Resources.graduation;
            this.btn__facultyManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__facultyManager.Name = "btn__facultyManager";
            this.btn__facultyManager.Size = new System.Drawing.Size(50, 50);
            this.btn__facultyManager.Text = "Quản lý khoa";
            // 
            // btn__majorManager
            // 
            this.btn__majorManager.AutoSize = false;
            this.btn__majorManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn__majorManager.Image = global::GUI.Properties.Resources.majority;
            this.btn__majorManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn__majorManager.Name = "btn__majorManager";
            this.btn__majorManager.Size = new System.Drawing.Size(50, 50);
            this.btn__majorManager.Text = "Quản lý chuyên ngành";
            // 
            // btn__maximize
            // 
            this.btn__maximize.Image = global::GUI.Properties.Resources.full_screen;
            this.btn__maximize.ImageRotate = 0F;
            this.btn__maximize.Location = new System.Drawing.Point(113, 25);
            this.btn__maximize.Name = "btn__maximize";
            this.btn__maximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__maximize.Size = new System.Drawing.Size(27, 27);
            this.btn__maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__maximize.TabIndex = 6;
            this.btn__maximize.TabStop = false;
            // 
            // btn__minimize
            // 
            this.btn__minimize.Image = global::GUI.Properties.Resources.minus;
            this.btn__minimize.ImageRotate = 0F;
            this.btn__minimize.Location = new System.Drawing.Point(71, 25);
            this.btn__minimize.Name = "btn__minimize";
            this.btn__minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__minimize.Size = new System.Drawing.Size(27, 27);
            this.btn__minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__minimize.TabIndex = 5;
            this.btn__minimize.TabStop = false;
            // 
            // btn__close
            // 
            this.btn__close.Image = global::GUI.Properties.Resources.close;
            this.btn__close.ImageRotate = 0F;
            this.btn__close.Location = new System.Drawing.Point(29, 25);
            this.btn__close.Name = "btn__close";
            this.btn__close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__close.Size = new System.Drawing.Size(27, 27);
            this.btn__close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__close.TabIndex = 4;
            this.btn__close.TabStop = false;
            this.btn__close.Click += new System.EventHandler(this.btn__close_Click);
            // 
            // uc__students1
            // 
            this.uc__students1.Location = new System.Drawing.Point(15, 8);
            this.uc__students1.Name = "uc__students1";
            this.uc__students1.Size = new System.Drawing.Size(1167, 654);
            this.uc__students1.TabIndex = 1;
            // 
            // frm__admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 816);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm__admin";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__maximize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__minimize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__close;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn__majorManager;
        private System.Windows.Forms.ToolStripButton btn__studentManager;
        private System.Windows.Forms.ToolStripButton btn__facultyManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private UC.uc__students uc__students1;
    }
}