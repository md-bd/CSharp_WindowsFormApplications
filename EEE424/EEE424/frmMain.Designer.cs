namespace EEE424
{
    partial class frmMain
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
            this.Class = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.txtBoxMi = new System.Windows.Forms.TextBox();
            this.txtBoxMa = new System.Windows.Forms.TextBox();
            this.txtBoxNa = new System.Windows.Forms.TextBox();
            this.txtBoxSt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(152, 64);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(42, 17);
            this.Class.TabIndex = 0;
            this.Class.Text = "Class";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(233, 64);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(103, 17);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Level 0 Term 0";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.cmdDelete);
            this.grpBox1.Controls.Add(this.cmdInsert);
            this.grpBox1.Controls.Add(this.cmdUpdate);
            this.grpBox1.Controls.Add(this.cmdBrowse);
            this.grpBox1.Controls.Add(this.txtBoxMi);
            this.grpBox1.Controls.Add(this.txtBoxMa);
            this.grpBox1.Controls.Add(this.txtBoxNa);
            this.grpBox1.Controls.Add(this.txtBoxSt);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Location = new System.Drawing.Point(155, 111);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(400, 200);
            this.grpBox1.TabIndex = 2;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Student Record";
            this.grpBox1.Visible = false;
            this.grpBox1.Enter += new System.EventHandler(this.grpBox1_Enter);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(313, 155);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 11;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(207, 155);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(75, 23);
            this.cmdInsert.TabIndex = 10;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(106, 155);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 9;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(15, 155);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 8;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // txtBoxMi
            // 
            this.txtBoxMi.Location = new System.Drawing.Point(88, 123);
            this.txtBoxMi.Name = "txtBoxMi";
            this.txtBoxMi.Size = new System.Drawing.Size(300, 20);
            this.txtBoxMi.TabIndex = 7;
            // 
            // txtBoxMa
            // 
            this.txtBoxMa.Location = new System.Drawing.Point(88, 90);
            this.txtBoxMa.Name = "txtBoxMa";
            this.txtBoxMa.Size = new System.Drawing.Size(300, 20);
            this.txtBoxMa.TabIndex = 6;
            // 
            // txtBoxNa
            // 
            this.txtBoxNa.Location = new System.Drawing.Point(88, 58);
            this.txtBoxNa.Name = "txtBoxNa";
            this.txtBoxNa.Size = new System.Drawing.Size(300, 20);
            this.txtBoxNa.TabIndex = 5;
            // 
            // txtBoxSt
            // 
            this.txtBoxSt.Location = new System.Drawing.Point(88, 27);
            this.txtBoxSt.Name = "txtBoxSt";
            this.txtBoxSt.Size = new System.Drawing.Size(300, 20);
            this.txtBoxSt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minor Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major Group";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeClassToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeClassToolStripMenuItem
            // 
            this.changeClassToolStripMenuItem.Name = "changeClassToolStripMenuItem";
            this.changeClassToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.changeClassToolStripMenuItem.Text = "Change Class";
            this.changeClassToolStripMenuItem.Click += new System.EventHandler(this.changeClassToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseDatabaseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseDatabaseToolStripMenuItem
            // 
            this.howToUseDatabaseToolStripMenuItem.Name = "howToUseDatabaseToolStripMenuItem";
            this.howToUseDatabaseToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.howToUseDatabaseToolStripMenuItem.Text = "How to use Database";
            this.howToUseDatabaseToolStripMenuItem.Click += new System.EventHandler(this.howToUseDatabaseToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.sname,
            this.major,
            this.minor});
            this.dataGridView1.Location = new System.Drawing.Point(155, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // student_id
            // 
            this.student_id.HeaderText = "Student No.";
            this.student_id.Name = "student_id";
            // 
            // sname
            // 
            this.sname.HeaderText = "Name";
            this.sname.Name = "sname";
            this.sname.Width = 200;
            // 
            // major
            // 
            this.major.HeaderText = "Major Group";
            this.major.Name = "major";
            // 
            // minor
            // 
            this.minor.HeaderText = "Minor Group";
            this.minor.Name = "minor";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Menu, File and Database management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Class;
        protected internal System.Windows.Forms.Label lblClass;
        protected internal System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMi;
        private System.Windows.Forms.TextBox txtBoxMa;
        private System.Windows.Forms.TextBox txtBoxNa;
        private System.Windows.Forms.TextBox txtBoxSt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
    }
}

