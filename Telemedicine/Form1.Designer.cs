
namespace Telemedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwPatients = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxFin = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.tbxSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.tbxBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxOclock = new System.Windows.Forms.TextBox();
            this.lblOclock = new System.Windows.Forms.Label();
            this.tbxDiagnoss = new System.Windows.Forms.TextBox();
            this.lblDiagnoss = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxFinUpdate = new System.Windows.Forms.TextBox();
            this.lblFinUpdate = new System.Windows.Forms.Label();
            this.tbxSexUpdate = new System.Windows.Forms.TextBox();
            this.lblSexUpdate = new System.Windows.Forms.Label();
            this.tbxBirthdayUpdate = new System.Windows.Forms.TextBox();
            this.lblBirthdayUpdate = new System.Windows.Forms.Label();
            this.tbxNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblNumberUpdate = new System.Windows.Forms.Label();
            this.tbxAddressUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressUpdate = new System.Windows.Forms.Label();
            this.tbxOclockUpdate = new System.Windows.Forms.TextBox();
            this.lblOclockUpdate = new System.Windows.Forms.Label();
            this.tbxDiagnossUpdate = new System.Windows.Forms.TextBox();
            this.lblDiagnossUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatients)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPatients
            // 
            this.dgwPatients.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgwPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatients.Location = new System.Drawing.Point(34, 51);
            this.dgwPatients.Name = "dgwPatients";
            this.dgwPatients.RowHeadersWidth = 51;
            this.dgwPatients.RowTemplate.Height = 24;
            this.dgwPatients.Size = new System.Drawing.Size(1273, 331);
            this.dgwPatients.TabIndex = 0;
            this.dgwPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPatients_CellClick);
            this.dgwPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPatients_CellContentClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxFin);
            this.gbxAdd.Controls.Add(this.lblFin);
            this.gbxAdd.Controls.Add(this.tbxSex);
            this.gbxAdd.Controls.Add(this.lblSex);
            this.gbxAdd.Controls.Add(this.tbxBirthday);
            this.gbxAdd.Controls.Add(this.lblBirthday);
            this.gbxAdd.Controls.Add(this.tbxNumber);
            this.gbxAdd.Controls.Add(this.lblNumber);
            this.gbxAdd.Controls.Add(this.tbxAddress);
            this.gbxAdd.Controls.Add(this.lblAddress);
            this.gbxAdd.Controls.Add(this.tbxOclock);
            this.gbxAdd.Controls.Add(this.lblOclock);
            this.gbxAdd.Controls.Add(this.tbxDiagnoss);
            this.gbxAdd.Controls.Add(this.lblDiagnoss);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.Location = new System.Drawing.Point(34, 403);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(479, 432);
            this.gbxAdd.TabIndex = 33;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Patient Information";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(219, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 39);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxFin
            // 
            this.tbxFin.Location = new System.Drawing.Point(199, 60);
            this.tbxFin.Name = "tbxFin";
            this.tbxFin.Size = new System.Drawing.Size(159, 30);
            this.tbxFin.TabIndex = 32;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(97, 58);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(43, 23);
            this.lblFin.TabIndex = 31;
            this.lblFin.Text = "Fin:";
            // 
            // tbxSex
            // 
            this.tbxSex.Location = new System.Drawing.Point(199, 106);
            this.tbxSex.Name = "tbxSex";
            this.tbxSex.Size = new System.Drawing.Size(159, 30);
            this.tbxSex.TabIndex = 30;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(97, 104);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(48, 23);
            this.lblSex.TabIndex = 29;
            this.lblSex.Text = "Sex:";
            // 
            // tbxBirthday
            // 
            this.tbxBirthday.Location = new System.Drawing.Point(199, 149);
            this.tbxBirthday.Name = "tbxBirthday";
            this.tbxBirthday.Size = new System.Drawing.Size(159, 30);
            this.tbxBirthday.TabIndex = 28;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(91, 147);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(90, 23);
            this.lblBirthday.TabIndex = 27;
            this.lblBirthday.Text = "Birthday:";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(199, 200);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(159, 30);
            this.tbxNumber.TabIndex = 26;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(97, 199);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 23);
            this.lblNumber.TabIndex = 25;
            this.lblNumber.Text = "Number:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(199, 250);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(159, 30);
            this.tbxAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(96, 250);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 23);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address:";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // tbxOclock
            // 
            this.tbxOclock.Location = new System.Drawing.Point(199, 297);
            this.tbxOclock.Name = "tbxOclock";
            this.tbxOclock.Size = new System.Drawing.Size(159, 30);
            this.tbxOclock.TabIndex = 22;
            // 
            // lblOclock
            // 
            this.lblOclock.AutoSize = true;
            this.lblOclock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOclock.Location = new System.Drawing.Point(97, 297);
            this.lblOclock.Name = "lblOclock";
            this.lblOclock.Size = new System.Drawing.Size(83, 23);
            this.lblOclock.TabIndex = 21;
            this.lblOclock.Text = "O\'clock:";
            this.lblOclock.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxDiagnoss
            // 
            this.tbxDiagnoss.Location = new System.Drawing.Point(199, 343);
            this.tbxDiagnoss.Name = "tbxDiagnoss";
            this.tbxDiagnoss.Size = new System.Drawing.Size(159, 30);
            this.tbxDiagnoss.TabIndex = 20;
            // 
            // lblDiagnoss
            // 
            this.lblDiagnoss.AutoSize = true;
            this.lblDiagnoss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnoss.Location = new System.Drawing.Point(90, 343);
            this.lblDiagnoss.Name = "lblDiagnoss";
            this.lblDiagnoss.Size = new System.Drawing.Size(97, 23);
            this.lblDiagnoss.TabIndex = 19;
            this.lblDiagnoss.Text = "Diagnosis:";
            this.lblDiagnoss.Click += new System.EventHandler(this.lblDiagnoss_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(199, 21);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 30);
            this.tbxName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 23);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFinUpdate);
            this.gbxUpdate.Controls.Add(this.lblFinUpdate);
            this.gbxUpdate.Controls.Add(this.tbxSexUpdate);
            this.gbxUpdate.Controls.Add(this.lblSexUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBirthdayUpdate);
            this.gbxUpdate.Controls.Add(this.lblBirthdayUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAddressUpdate);
            this.gbxUpdate.Controls.Add(this.lblAddressUpdate);
            this.gbxUpdate.Controls.Add(this.tbxOclockUpdate);
            this.gbxUpdate.Controls.Add(this.lblOclockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxDiagnossUpdate);
            this.gbxUpdate.Controls.Add(this.lblDiagnossUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(828, 403);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(479, 432);
            this.gbxUpdate.TabIndex = 34;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Patient Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Location = new System.Drawing.Point(235, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 39);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxFinUpdate
            // 
            this.tbxFinUpdate.Location = new System.Drawing.Point(199, 60);
            this.tbxFinUpdate.Name = "tbxFinUpdate";
            this.tbxFinUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxFinUpdate.TabIndex = 32;
            // 
            // lblFinUpdate
            // 
            this.lblFinUpdate.AutoSize = true;
            this.lblFinUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinUpdate.Location = new System.Drawing.Point(87, 60);
            this.lblFinUpdate.Name = "lblFinUpdate";
            this.lblFinUpdate.Size = new System.Drawing.Size(43, 23);
            this.lblFinUpdate.TabIndex = 31;
            this.lblFinUpdate.Text = "Fin:";
            // 
            // tbxSexUpdate
            // 
            this.tbxSexUpdate.Location = new System.Drawing.Point(199, 106);
            this.tbxSexUpdate.Name = "tbxSexUpdate";
            this.tbxSexUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxSexUpdate.TabIndex = 30;
            // 
            // lblSexUpdate
            // 
            this.lblSexUpdate.AutoSize = true;
            this.lblSexUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexUpdate.Location = new System.Drawing.Point(87, 106);
            this.lblSexUpdate.Name = "lblSexUpdate";
            this.lblSexUpdate.Size = new System.Drawing.Size(48, 23);
            this.lblSexUpdate.TabIndex = 29;
            this.lblSexUpdate.Text = "Sex:";
            // 
            // tbxBirthdayUpdate
            // 
            this.tbxBirthdayUpdate.Location = new System.Drawing.Point(199, 147);
            this.tbxBirthdayUpdate.Name = "tbxBirthdayUpdate";
            this.tbxBirthdayUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxBirthdayUpdate.TabIndex = 28;
            // 
            // lblBirthdayUpdate
            // 
            this.lblBirthdayUpdate.AutoSize = true;
            this.lblBirthdayUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayUpdate.Location = new System.Drawing.Point(87, 147);
            this.lblBirthdayUpdate.Name = "lblBirthdayUpdate";
            this.lblBirthdayUpdate.Size = new System.Drawing.Size(90, 23);
            this.lblBirthdayUpdate.TabIndex = 27;
            this.lblBirthdayUpdate.Text = "Birthday:";
            // 
            // tbxNumberUpdate
            // 
            this.tbxNumberUpdate.Location = new System.Drawing.Point(199, 200);
            this.tbxNumberUpdate.Name = "tbxNumberUpdate";
            this.tbxNumberUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxNumberUpdate.TabIndex = 26;
            // 
            // lblNumberUpdate
            // 
            this.lblNumberUpdate.AutoSize = true;
            this.lblNumberUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberUpdate.Location = new System.Drawing.Point(87, 198);
            this.lblNumberUpdate.Name = "lblNumberUpdate";
            this.lblNumberUpdate.Size = new System.Drawing.Size(84, 23);
            this.lblNumberUpdate.TabIndex = 25;
            this.lblNumberUpdate.Text = "Number:";
            // 
            // tbxAddressUpdate
            // 
            this.tbxAddressUpdate.Location = new System.Drawing.Point(199, 250);
            this.tbxAddressUpdate.Name = "tbxAddressUpdate";
            this.tbxAddressUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxAddressUpdate.TabIndex = 24;
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressUpdate.Location = new System.Drawing.Point(87, 248);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(85, 23);
            this.lblAddressUpdate.TabIndex = 23;
            this.lblAddressUpdate.Text = "Address:";
            // 
            // tbxOclockUpdate
            // 
            this.tbxOclockUpdate.Location = new System.Drawing.Point(199, 297);
            this.tbxOclockUpdate.Name = "tbxOclockUpdate";
            this.tbxOclockUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxOclockUpdate.TabIndex = 22;
            // 
            // lblOclockUpdate
            // 
            this.lblOclockUpdate.AutoSize = true;
            this.lblOclockUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOclockUpdate.Location = new System.Drawing.Point(87, 297);
            this.lblOclockUpdate.Name = "lblOclockUpdate";
            this.lblOclockUpdate.Size = new System.Drawing.Size(83, 23);
            this.lblOclockUpdate.TabIndex = 21;
            this.lblOclockUpdate.Text = "O\'clock:";
            // 
            // tbxDiagnossUpdate
            // 
            this.tbxDiagnossUpdate.Location = new System.Drawing.Point(199, 343);
            this.tbxDiagnossUpdate.Name = "tbxDiagnossUpdate";
            this.tbxDiagnossUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxDiagnossUpdate.TabIndex = 20;
            // 
            // lblDiagnossUpdate
            // 
            this.lblDiagnossUpdate.AutoSize = true;
            this.lblDiagnossUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnossUpdate.Location = new System.Drawing.Point(87, 341);
            this.lblDiagnossUpdate.Name = "lblDiagnossUpdate";
            this.lblDiagnossUpdate.Size = new System.Drawing.Size(97, 23);
            this.lblDiagnossUpdate.TabIndex = 19;
            this.lblDiagnossUpdate.Text = "Diagnosis:";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(199, 21);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(159, 30);
            this.tbxNameUpdate.TabIndex = 18;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUpdate.Location = new System.Drawing.Point(87, 21);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(66, 23);
            this.lblNameUpdate.TabIndex = 17;
            this.lblNameUpdate.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1063, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 862);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwPatients);
            this.Name = "Form1";
            this.Text = "Telemedicine System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatients)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPatients;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox tbxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox tbxBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxOclock;
        private System.Windows.Forms.Label lblOclock;
        private System.Windows.Forms.TextBox tbxDiagnoss;
        private System.Windows.Forms.Label lblDiagnoss;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxFinUpdate;
        private System.Windows.Forms.Label lblFinUpdate;
        private System.Windows.Forms.TextBox tbxSexUpdate;
        private System.Windows.Forms.Label lblSexUpdate;
        private System.Windows.Forms.TextBox tbxBirthdayUpdate;
        private System.Windows.Forms.Label lblBirthdayUpdate;
        private System.Windows.Forms.TextBox tbxNumberUpdate;
        private System.Windows.Forms.Label lblNumberUpdate;
        private System.Windows.Forms.TextBox tbxAddressUpdate;
        private System.Windows.Forms.Label lblAddressUpdate;
        private System.Windows.Forms.TextBox tbxOclockUpdate;
        private System.Windows.Forms.Label lblOclockUpdate;
        private System.Windows.Forms.TextBox tbxDiagnossUpdate;
        private System.Windows.Forms.Label lblDiagnossUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

