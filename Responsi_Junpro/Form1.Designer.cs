namespace Responsi_Junpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvData = new DataGridView();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            rbHR = new RadioButton();
            rbENG = new RadioButton();
            rbDev = new RadioButton();
            rbPM = new RadioButton();
            rbFinance = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep.Karyawan";
            // 
            // tbName
            // 
            tbName.Location = new Point(140, 24);
            tbName.Name = "tbName";
            tbName.Size = new Size(127, 23);
            tbName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 20);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "ID Departemen:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 35);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "HR : HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 50);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 5;
            label5.Text = "ENG : Engineer";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 65);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 6;
            label6.Text = "DEV : Developer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 80);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 7;
            label7.Text = "PM : Product Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 95);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 8;
            label8.Text = "FIN : Finance";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(26, 184);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(515, 200);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(26, 142);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(140, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(247, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(352, 142);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rbHR
            // 
            rbHR.AutoSize = true;
            rbHR.Location = new Point(130, 67);
            rbHR.Name = "rbHR";
            rbHR.Size = new Size(41, 19);
            rbHR.TabIndex = 15;
            rbHR.TabStop = true;
            rbHR.Text = "HR";
            rbHR.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            rbENG.AutoSize = true;
            rbENG.Location = new Point(186, 67);
            rbENG.Name = "rbENG";
            rbENG.Size = new Size(71, 19);
            rbENG.TabIndex = 16;
            rbENG.TabStop = true;
            rbENG.Text = "Engineer";
            rbENG.UseVisualStyleBackColor = true;
            // 
            // rbDev
            // 
            rbDev.AutoSize = true;
            rbDev.Location = new Point(263, 67);
            rbDev.Name = "rbDev";
            rbDev.Size = new Size(78, 19);
            rbDev.TabIndex = 17;
            rbDev.TabStop = true;
            rbDev.Text = "Developer";
            rbDev.UseVisualStyleBackColor = true;
            // 
            // rbPM
            // 
            rbPM.AutoSize = true;
            rbPM.Location = new Point(129, 99);
            rbPM.Name = "rbPM";
            rbPM.Size = new Size(117, 19);
            rbPM.TabIndex = 18;
            rbPM.TabStop = true;
            rbPM.Text = "Product Manager";
            rbPM.UseVisualStyleBackColor = true;
            // 
            // rbFinance
            // 
            rbFinance.AutoSize = true;
            rbFinance.Location = new Point(258, 102);
            rbFinance.Name = "rbFinance";
            rbFinance.Size = new Size(66, 19);
            rbFinance.TabIndex = 19;
            rbFinance.TabStop = true;
            rbFinance.Text = "Finance";
            rbFinance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 414);
            Controls.Add(rbFinance);
            Controls.Add(rbPM);
            Controls.Add(rbDev);
            Controls.Add(rbENG);
            Controls.Add(rbHR);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgvData;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private RadioButton rbHR;
        private RadioButton rbENG;
        private RadioButton rbDev;
        private RadioButton rbPM;
        private RadioButton rbFinance;
    }
}