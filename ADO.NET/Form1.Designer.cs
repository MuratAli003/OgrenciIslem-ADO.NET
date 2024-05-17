namespace ADO.NET
{
    partial class Form1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNoUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNoUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.dgwStudent = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxSurnameUpdate);
            this.groupBox1.Controls.Add(this.tbxNoUpdate);
            this.groupBox1.Controls.Add(this.lblNameUpdate);
            this.groupBox1.Controls.Add(this.lblSurnameUpdate);
            this.groupBox1.Controls.Add(this.tbxNameUpdate);
            this.groupBox1.Controls.Add(this.lblNoUpdate);
            this.groupBox1.Location = new System.Drawing.Point(488, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 191);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a Student";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(137, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(137, 73);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(119, 22);
            this.tbxSurnameUpdate.TabIndex = 5;
            // 
            // tbxNoUpdate
            // 
            this.tbxNoUpdate.Location = new System.Drawing.Point(137, 111);
            this.tbxNoUpdate.Name = "tbxNoUpdate";
            this.tbxNoUpdate.Size = new System.Drawing.Size(119, 22);
            this.tbxNoUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(37, 39);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(44, 16);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(37, 79);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(61, 16);
            this.lblSurnameUpdate.TabIndex = 2;
            this.lblSurnameUpdate.Text = "Surname";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(137, 39);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(119, 22);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // lblNoUpdate
            // 
            this.lblNoUpdate.AutoSize = true;
            this.lblNoUpdate.Location = new System.Drawing.Point(37, 117);
            this.lblNoUpdate.Name = "lblNoUpdate";
            this.lblNoUpdate.Size = new System.Drawing.Size(25, 16);
            this.lblNoUpdate.TabIndex = 3;
            this.lblNoUpdate.Text = "No";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxSurname);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxNo);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblNo);
            this.gbxAdd.Location = new System.Drawing.Point(40, 266);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(264, 191);
            this.gbxAdd.TabIndex = 20;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Student";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(137, 73);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(119, 22);
            this.tbxSurname.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxNo
            // 
            this.tbxNo.Location = new System.Drawing.Point(137, 111);
            this.tbxNo.Name = "tbxNo";
            this.tbxNo.Size = new System.Drawing.Size(119, 22);
            this.tbxNo.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(37, 79);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(137, 33);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(119, 22);
            this.tbxName.TabIndex = 4;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(37, 117);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(25, 16);
            this.lblNo.TabIndex = 3;
            this.lblNo.Text = "No";
            // 
            // dgwStudent
            // 
            this.dgwStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudent.Location = new System.Drawing.Point(40, -6);
            this.dgwStudent.Name = "dgwStudent";
            this.dgwStudent.RowHeadersWidth = 51;
            this.dgwStudent.RowTemplate.Height = 24;
            this.dgwStudent.Size = new System.Drawing.Size(720, 244);
            this.dgwStudent.TabIndex = 19;
            this.dgwStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudent_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.TextBox tbxNoUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNoUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.DataGridView dgwStudent;
    }
}

