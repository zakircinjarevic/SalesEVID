namespace Main
{
    partial class AddEdit_Firmu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numberofemployees = new System.Windows.Forms.NumericUpDown();
            this.txt_notes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxContract = new System.Windows.Forms.CheckBox();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.checkBoxWaiting = new System.Windows.Forms.CheckBox();
            this.checkBoxCalled = new System.Windows.Forms.CheckBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contactperson = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_workdescription = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.toolTip_Warning = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numberofemployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numberofemployees);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBoxContract);
            this.groupBox1.Controls.Add(this.checkBoxDone);
            this.groupBox1.Controls.Add(this.checkBoxWaiting);
            this.groupBox1.Controls.Add(this.checkBoxCalled);
            this.groupBox1.Controls.Add(this.txt_phonenumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_contactperson);
            this.groupBox1.Controls.Add(this.txt_customername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_workdescription);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer info";
            // 
            // txt_numberofemployees
            // 
            this.txt_numberofemployees.Location = new System.Drawing.Point(103, 82);
            this.txt_numberofemployees.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_numberofemployees.Name = "txt_numberofemployees";
            this.txt_numberofemployees.Size = new System.Drawing.Size(55, 20);
            this.txt_numberofemployees.TabIndex = 17;
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(103, 162);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(187, 65);
            this.txt_notes.TabIndex = 5;
            this.txt_notes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Notes";
            // 
            // checkBoxContract
            // 
            this.checkBoxContract.AutoSize = true;
            this.checkBoxContract.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxContract.Location = new System.Drawing.Point(205, 258);
            this.checkBoxContract.Name = "checkBoxContract";
            this.checkBoxContract.Size = new System.Drawing.Size(66, 17);
            this.checkBoxContract.TabIndex = 9;
            this.checkBoxContract.Text = "Contract";
            this.checkBoxContract.UseVisualStyleBackColor = true;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDone.Location = new System.Drawing.Point(219, 235);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDone.TabIndex = 8;
            this.checkBoxDone.Text = "Done";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // checkBoxWaiting
            // 
            this.checkBoxWaiting.AutoSize = true;
            this.checkBoxWaiting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWaiting.Location = new System.Drawing.Point(103, 258);
            this.checkBoxWaiting.Name = "checkBoxWaiting";
            this.checkBoxWaiting.Size = new System.Drawing.Size(62, 17);
            this.checkBoxWaiting.TabIndex = 7;
            this.checkBoxWaiting.Text = "Waiting";
            this.checkBoxWaiting.UseVisualStyleBackColor = true;
            // 
            // checkBoxCalled
            // 
            this.checkBoxCalled.AutoSize = true;
            this.checkBoxCalled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCalled.Location = new System.Drawing.Point(110, 235);
            this.checkBoxCalled.Name = "checkBoxCalled";
            this.checkBoxCalled.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCalled.TabIndex = 6;
            this.checkBoxCalled.Text = "Called";
            this.checkBoxCalled.UseVisualStyleBackColor = true;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(103, 135);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(187, 20);
            this.txt_phonenumber.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone number";
            // 
            // txt_contactperson
            // 
            this.txt_contactperson.Location = new System.Drawing.Point(103, 108);
            this.txt_contactperson.Name = "txt_contactperson";
            this.txt_contactperson.Size = new System.Drawing.Size(187, 20);
            this.txt_contactperson.TabIndex = 3;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(103, 30);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(187, 20);
            this.txt_customername.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. of employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work description";
            // 
            // txt_workdescription
            // 
            this.txt_workdescription.Location = new System.Drawing.Point(103, 56);
            this.txt_workdescription.Name = "txt_workdescription";
            this.txt_workdescription.Size = new System.Drawing.Size(187, 20);
            this.txt_workdescription.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 301);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(137, 301);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(3, 303);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(29, 20);
            this.textBoxID.TabIndex = 18;
            this.textBoxID.Visible = false;
            // 
            // AddEdit_Firmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(303, 331);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEdit_Firmu";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Customer";
            this.Load += new System.EventHandler(this.AddEdit_Firmu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numberofemployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_workdescription;
        private System.Windows.Forms.TextBox txt_contactperson;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ToolTip toolTip_Warning;
        private System.Windows.Forms.CheckBox checkBoxContract;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.CheckBox checkBoxWaiting;
        private System.Windows.Forms.CheckBox checkBoxCalled;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_numberofemployees;
        private System.Windows.Forms.TextBox textBoxID;
    }
}