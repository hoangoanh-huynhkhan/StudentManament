
namespace GUI.UC
{
    partial class uc__students
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv__students = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grb__info = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl__id = new System.Windows.Forms.Label();
            this.lbl__name = new System.Windows.Forms.Label();
            this.txt__id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt__name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl__faculty = new System.Windows.Forms.Label();
            this.cmb__faculties = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt__score = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl__score = new System.Windows.Forms.Label();
            this.lbl__avatar = new System.Windows.Forms.Label();
            this.pic__avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn__update = new Guna.UI2.WinForms.Guna2Button();
            this.btn__delete = new Guna.UI2.WinForms.Guna2Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk__isMajor = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lbl__gender = new System.Windows.Forms.Label();
            this.rad__male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rad__female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl__birthday = new System.Windows.Forms.Label();
            this.dtp__birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv__students)).BeginInit();
            this.grb__info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic__avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv__students
            // 
            this.dgv__students.AllowUserToAddRows = false;
            this.dgv__students.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv__students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv__students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv__students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv__students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Faculty,
            this.StudentAgv,
            this.Major});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv__students.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv__students.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv__students.Location = new System.Drawing.Point(491, 48);
            this.dgv__students.Name = "dgv__students";
            this.dgv__students.ReadOnly = true;
            this.dgv__students.RowHeadersVisible = false;
            this.dgv__students.RowHeadersWidth = 51;
            this.dgv__students.RowTemplate.Height = 24;
            this.dgv__students.Size = new System.Drawing.Size(673, 603);
            this.dgv__students.TabIndex = 0;
            this.dgv__students.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv__students.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv__students.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv__students.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv__students.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv__students.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv__students.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv__students.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv__students.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv__students.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv__students.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv__students.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv__students.ThemeStyle.HeaderStyle.Height = 54;
            this.dgv__students.ThemeStyle.ReadOnly = true;
            this.dgv__students.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv__students.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv__students.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv__students.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv__students.ThemeStyle.RowsStyle.Height = 24;
            this.dgv__students.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv__students.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grb__info
            // 
            this.grb__info.Controls.Add(this.dtp__birthday);
            this.grb__info.Controls.Add(this.lbl__birthday);
            this.grb__info.Controls.Add(this.rad__female);
            this.grb__info.Controls.Add(this.rad__male);
            this.grb__info.Controls.Add(this.lbl__gender);
            this.grb__info.Controls.Add(this.pic__avatar);
            this.grb__info.Controls.Add(this.lbl__avatar);
            this.grb__info.Controls.Add(this.txt__score);
            this.grb__info.Controls.Add(this.lbl__score);
            this.grb__info.Controls.Add(this.cmb__faculties);
            this.grb__info.Controls.Add(this.lbl__faculty);
            this.grb__info.Controls.Add(this.txt__name);
            this.grb__info.Controls.Add(this.txt__id);
            this.grb__info.Controls.Add(this.lbl__name);
            this.grb__info.Controls.Add(this.lbl__id);
            this.grb__info.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grb__info.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb__info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb__info.Location = new System.Drawing.Point(3, 3);
            this.grb__info.Name = "grb__info";
            this.grb__info.Size = new System.Drawing.Size(482, 568);
            this.grb__info.TabIndex = 1;
            this.grb__info.Text = "Thông tin sinh viên";
            this.grb__info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl__id
            // 
            this.lbl__id.AutoSize = true;
            this.lbl__id.BackColor = System.Drawing.Color.White;
            this.lbl__id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__id.Location = new System.Drawing.Point(6, 67);
            this.lbl__id.Name = "lbl__id";
            this.lbl__id.Size = new System.Drawing.Size(135, 29);
            this.lbl__id.TabIndex = 0;
            this.lbl__id.Text = "Mã sinh viên";
            // 
            // lbl__name
            // 
            this.lbl__name.AutoSize = true;
            this.lbl__name.BackColor = System.Drawing.Color.White;
            this.lbl__name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__name.Location = new System.Drawing.Point(6, 128);
            this.lbl__name.Name = "lbl__name";
            this.lbl__name.Size = new System.Drawing.Size(109, 29);
            this.lbl__name.TabIndex = 1;
            this.lbl__name.Text = "Họ và tên";
            // 
            // txt__id
            // 
            this.txt__id.BackColor = System.Drawing.Color.White;
            this.txt__id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__id.BorderRadius = 15;
            this.txt__id.BorderThickness = 2;
            this.txt__id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__id.DefaultText = "";
            this.txt__id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt__id.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt__id.Location = new System.Drawing.Point(165, 58);
            this.txt__id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__id.Name = "txt__id";
            this.txt__id.PasswordChar = '\0';
            this.txt__id.PlaceholderText = "";
            this.txt__id.SelectedText = "";
            this.txt__id.Size = new System.Drawing.Size(301, 51);
            this.txt__id.TabIndex = 2;
            // 
            // txt__name
            // 
            this.txt__name.BackColor = System.Drawing.Color.White;
            this.txt__name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__name.BorderRadius = 15;
            this.txt__name.BorderThickness = 2;
            this.txt__name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__name.DefaultText = "";
            this.txt__name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt__name.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt__name.Location = new System.Drawing.Point(165, 119);
            this.txt__name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__name.Name = "txt__name";
            this.txt__name.PasswordChar = '\0';
            this.txt__name.PlaceholderText = "";
            this.txt__name.SelectedText = "";
            this.txt__name.Size = new System.Drawing.Size(301, 51);
            this.txt__name.TabIndex = 3;
            // 
            // lbl__faculty
            // 
            this.lbl__faculty.AutoSize = true;
            this.lbl__faculty.BackColor = System.Drawing.Color.White;
            this.lbl__faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__faculty.Location = new System.Drawing.Point(6, 193);
            this.lbl__faculty.Name = "lbl__faculty";
            this.lbl__faculty.Size = new System.Drawing.Size(59, 29);
            this.lbl__faculty.TabIndex = 4;
            this.lbl__faculty.Text = "Khoa";
            // 
            // cmb__faculties
            // 
            this.cmb__faculties.BackColor = System.Drawing.Color.Transparent;
            this.cmb__faculties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb__faculties.BorderRadius = 15;
            this.cmb__faculties.BorderThickness = 2;
            this.cmb__faculties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb__faculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb__faculties.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb__faculties.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb__faculties.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb__faculties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb__faculties.ItemHeight = 30;
            this.cmb__faculties.Location = new System.Drawing.Point(165, 186);
            this.cmb__faculties.Name = "cmb__faculties";
            this.cmb__faculties.Size = new System.Drawing.Size(301, 36);
            this.cmb__faculties.TabIndex = 5;
            // 
            // txt__score
            // 
            this.txt__score.BackColor = System.Drawing.Color.White;
            this.txt__score.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__score.BorderRadius = 15;
            this.txt__score.BorderThickness = 2;
            this.txt__score.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__score.DefaultText = "";
            this.txt__score.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__score.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__score.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__score.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__score.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt__score.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__score.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt__score.Location = new System.Drawing.Point(165, 340);
            this.txt__score.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__score.Name = "txt__score";
            this.txt__score.PasswordChar = '\0';
            this.txt__score.PlaceholderText = "";
            this.txt__score.SelectedText = "";
            this.txt__score.Size = new System.Drawing.Size(301, 51);
            this.txt__score.TabIndex = 7;
            // 
            // lbl__score
            // 
            this.lbl__score.AutoSize = true;
            this.lbl__score.BackColor = System.Drawing.Color.White;
            this.lbl__score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__score.Location = new System.Drawing.Point(6, 351);
            this.lbl__score.Name = "lbl__score";
            this.lbl__score.Size = new System.Drawing.Size(97, 29);
            this.lbl__score.TabIndex = 6;
            this.lbl__score.Text = "Điểm TB";
            // 
            // lbl__avatar
            // 
            this.lbl__avatar.AutoSize = true;
            this.lbl__avatar.BackColor = System.Drawing.Color.White;
            this.lbl__avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__avatar.Location = new System.Drawing.Point(6, 407);
            this.lbl__avatar.Name = "lbl__avatar";
            this.lbl__avatar.Size = new System.Drawing.Size(138, 29);
            this.lbl__avatar.TabIndex = 8;
            this.lbl__avatar.Text = "Ảnh đại diện";
            // 
            // pic__avatar
            // 
            this.pic__avatar.BorderRadius = 15;
            this.pic__avatar.Image = global::GUI.Properties.Resources.add_user;
            this.pic__avatar.ImageRotate = 0F;
            this.pic__avatar.Location = new System.Drawing.Point(165, 419);
            this.pic__avatar.Name = "pic__avatar";
            this.pic__avatar.Size = new System.Drawing.Size(301, 136);
            this.pic__avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__avatar.TabIndex = 9;
            this.pic__avatar.TabStop = false;
            // 
            // btn__update
            // 
            this.btn__update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn__update.BorderRadius = 15;
            this.btn__update.BorderThickness = 2;
            this.btn__update.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn__update.DisabledState.FillColor = System.Drawing.Color.White;
            this.btn__update.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.btn__update.FillColor = System.Drawing.Color.White;
            this.btn__update.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__update.ForeColor = System.Drawing.Color.Purple;
            this.btn__update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn__update.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btn__update.Location = new System.Drawing.Point(66, 577);
            this.btn__update.Name = "btn__update";
            this.btn__update.PressedColor = System.Drawing.Color.White;
            this.btn__update.Size = new System.Drawing.Size(130, 64);
            this.btn__update.TabIndex = 2;
            this.btn__update.Text = "Thêm";
            // 
            // btn__delete
            // 
            this.btn__delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn__delete.BorderRadius = 15;
            this.btn__delete.BorderThickness = 2;
            this.btn__delete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn__delete.DisabledState.FillColor = System.Drawing.Color.White;
            this.btn__delete.DisabledState.ForeColor = System.Drawing.Color.Purple;
            this.btn__delete.FillColor = System.Drawing.Color.White;
            this.btn__delete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__delete.ForeColor = System.Drawing.Color.Purple;
            this.btn__delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn__delete.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.btn__delete.Location = new System.Drawing.Point(288, 577);
            this.btn__delete.Name = "btn__delete";
            this.btn__delete.PressedColor = System.Drawing.Color.White;
            this.btn__delete.Size = new System.Drawing.Size(130, 64);
            this.btn__delete.TabIndex = 3;
            this.btn__delete.Text = "Xóa";
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Mã sinh viên";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Họ tên";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // StudentAgv
            // 
            this.StudentAgv.HeaderText = "Điểm TB";
            this.StudentAgv.MinimumWidth = 6;
            this.StudentAgv.Name = "StudentAgv";
            this.StudentAgv.ReadOnly = true;
            // 
            // Major
            // 
            this.Major.HeaderText = "Chuyên ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            // 
            // chk__isMajor
            // 
            this.chk__isMajor.AutoSize = true;
            this.chk__isMajor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk__isMajor.CheckedState.BorderRadius = 0;
            this.chk__isMajor.CheckedState.BorderThickness = 0;
            this.chk__isMajor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk__isMajor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk__isMajor.Location = new System.Drawing.Point(908, 6);
            this.chk__isMajor.Name = "chk__isMajor";
            this.chk__isMajor.Size = new System.Drawing.Size(246, 28);
            this.chk__isMajor.TabIndex = 4;
            this.chk__isMajor.Text = "Chưa đăng ký chuyên ngành";
            this.chk__isMajor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk__isMajor.UncheckedState.BorderRadius = 0;
            this.chk__isMajor.UncheckedState.BorderThickness = 0;
            this.chk__isMajor.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lbl__gender
            // 
            this.lbl__gender.AutoSize = true;
            this.lbl__gender.BackColor = System.Drawing.Color.White;
            this.lbl__gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__gender.Location = new System.Drawing.Point(6, 245);
            this.lbl__gender.Name = "lbl__gender";
            this.lbl__gender.Size = new System.Drawing.Size(97, 29);
            this.lbl__gender.TabIndex = 10;
            this.lbl__gender.Text = "Giới tính";
            // 
            // rad__male
            // 
            this.rad__male.AutoSize = true;
            this.rad__male.BackColor = System.Drawing.Color.White;
            this.rad__male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad__male.CheckedState.BorderThickness = 0;
            this.rad__male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad__male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad__male.CheckedState.InnerOffset = -4;
            this.rad__male.ForeColor = System.Drawing.Color.Teal;
            this.rad__male.Location = new System.Drawing.Point(165, 241);
            this.rad__male.Name = "rad__male";
            this.rad__male.Size = new System.Drawing.Size(77, 33);
            this.rad__male.TabIndex = 11;
            this.rad__male.Text = "Nam";
            this.rad__male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad__male.UncheckedState.BorderThickness = 2;
            this.rad__male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad__male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rad__male.UseVisualStyleBackColor = false;
            // 
            // rad__female
            // 
            this.rad__female.AutoSize = true;
            this.rad__female.BackColor = System.Drawing.Color.White;
            this.rad__female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad__female.CheckedState.BorderThickness = 0;
            this.rad__female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad__female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad__female.CheckedState.InnerOffset = -4;
            this.rad__female.ForeColor = System.Drawing.Color.Teal;
            this.rad__female.Location = new System.Drawing.Point(272, 241);
            this.rad__female.Name = "rad__female";
            this.rad__female.Size = new System.Drawing.Size(62, 33);
            this.rad__female.TabIndex = 12;
            this.rad__female.Text = "Nữ";
            this.rad__female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad__female.UncheckedState.BorderThickness = 2;
            this.rad__female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad__female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rad__female.UseVisualStyleBackColor = false;
            // 
            // lbl__birthday
            // 
            this.lbl__birthday.AutoSize = true;
            this.lbl__birthday.BackColor = System.Drawing.Color.White;
            this.lbl__birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl__birthday.Location = new System.Drawing.Point(6, 295);
            this.lbl__birthday.Name = "lbl__birthday";
            this.lbl__birthday.Size = new System.Drawing.Size(109, 29);
            this.lbl__birthday.TabIndex = 13;
            this.lbl__birthday.Text = "Ngày sinh";
            // 
            // dtp__birthday
            // 
            this.dtp__birthday.BackColor = System.Drawing.Color.White;
            this.dtp__birthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtp__birthday.BorderRadius = 15;
            this.dtp__birthday.BorderThickness = 2;
            this.dtp__birthday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp__birthday.FillColor = System.Drawing.Color.White;
            this.dtp__birthday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp__birthday.ForeColor = System.Drawing.Color.Teal;
            this.dtp__birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp__birthday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtp__birthday.Location = new System.Drawing.Point(165, 288);
            this.dtp__birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp__birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp__birthday.Name = "dtp__birthday";
            this.dtp__birthday.Size = new System.Drawing.Size(301, 36);
            this.dtp__birthday.TabIndex = 14;
            this.dtp__birthday.Value = new System.DateTime(2023, 12, 10, 0, 58, 1, 980);
            // 
            // uc__students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk__isMajor);
            this.Controls.Add(this.btn__delete);
            this.Controls.Add(this.btn__update);
            this.Controls.Add(this.grb__info);
            this.Controls.Add(this.dgv__students);
            this.Name = "uc__students";
            this.Size = new System.Drawing.Size(1167, 654);
            ((System.ComponentModel.ISupportInitialize)(this.dgv__students)).EndInit();
            this.grb__info.ResumeLayout(false);
            this.grb__info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic__avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv__students;
        private Guna.UI2.WinForms.Guna2GroupBox grb__info;
        private Guna.UI2.WinForms.Guna2TextBox txt__id;
        private System.Windows.Forms.Label lbl__name;
        private System.Windows.Forms.Label lbl__id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private Guna.UI2.WinForms.Guna2PictureBox pic__avatar;
        private System.Windows.Forms.Label lbl__avatar;
        private Guna.UI2.WinForms.Guna2TextBox txt__score;
        private System.Windows.Forms.Label lbl__score;
        private Guna.UI2.WinForms.Guna2ComboBox cmb__faculties;
        private System.Windows.Forms.Label lbl__faculty;
        private Guna.UI2.WinForms.Guna2TextBox txt__name;
        private Guna.UI2.WinForms.Guna2Button btn__update;
        private Guna.UI2.WinForms.Guna2Button btn__delete;
        private Guna.UI2.WinForms.Guna2CheckBox chk__isMajor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp__birthday;
        private System.Windows.Forms.Label lbl__birthday;
        private Guna.UI2.WinForms.Guna2RadioButton rad__female;
        private Guna.UI2.WinForms.Guna2RadioButton rad__male;
        private System.Windows.Forms.Label lbl__gender;
    }
}
