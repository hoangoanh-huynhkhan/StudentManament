
namespace GUI
{
    partial class frm__alert
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.btn__tool = new System.Windows.Forms.PictureBox();
            this.pic__action = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn__tool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__action)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsg.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMsg.Location = new System.Drawing.Point(45, 25);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(460, 32);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "nap mjoei ku uic mot thoi";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn__tool
            // 
            this.btn__tool.Image = global::GUI.Properties.Resources.icons8_cancel_25px;
            this.btn__tool.Location = new System.Drawing.Point(479, 8);
            this.btn__tool.Name = "btn__tool";
            this.btn__tool.Size = new System.Drawing.Size(26, 30);
            this.btn__tool.TabIndex = 6;
            this.btn__tool.TabStop = false;
            this.btn__tool.Click += new System.EventHandler(this.btnClose__click);
            // 
            // pic__action
            // 
            this.pic__action.Image = global::GUI.Properties.Resources.warning;
            this.pic__action.Location = new System.Drawing.Point(3, 18);
            this.pic__action.Name = "pic__action";
            this.pic__action.Size = new System.Drawing.Size(41, 39);
            this.pic__action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic__action.TabIndex = 5;
            this.pic__action.TabStop = false;
            // 
            // frm__alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(508, 64);
            this.Controls.Add(this.btn__tool);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pic__action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__alert";
            this.Text = "frm__alert";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.btn__tool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox btn__tool;
        private System.Windows.Forms.PictureBox pic__action;
    }
}