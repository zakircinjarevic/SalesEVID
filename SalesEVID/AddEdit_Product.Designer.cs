namespace SalesEVID
{
    partial class AddEdit_Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContractDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.toolTipWarning = new System.Windows.Forms.ToolTip(this.components);
            this.radioBtnSale = new System.Windows.Forms.RadioButton();
            this.radioBtnRent = new System.Windows.Forms.RadioButton();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product name";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(153, 6);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(82, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contract duration (months)";
            // 
            // txtContractDuration
            // 
            this.txtContractDuration.Location = new System.Drawing.Point(153, 111);
            this.txtContractDuration.Name = "txtContractDuration";
            this.txtContractDuration.Size = new System.Drawing.Size(82, 20);
            this.txtContractDuration.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly rent";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(153, 85);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(82, 20);
            this.txtRent.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(-8, 135);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(14, 20);
            this.txtId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sale price";
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(153, 59);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(82, 20);
            this.txtSale.TabIndex = 14;
            // 
            // radioBtnSale
            // 
            this.radioBtnSale.AutoSize = true;
            this.radioBtnSale.Location = new System.Drawing.Point(84, 33);
            this.radioBtnSale.Name = "radioBtnSale";
            this.radioBtnSale.Size = new System.Drawing.Size(46, 17);
            this.radioBtnSale.TabIndex = 17;
            this.radioBtnSale.TabStop = true;
            this.radioBtnSale.Text = "Sale";
            this.radioBtnSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnSale.UseVisualStyleBackColor = true;
            this.radioBtnSale.CheckedChanged += new System.EventHandler(this.radioBtnSale_CheckedChanged);
            // 
            // radioBtnRent
            // 
            this.radioBtnRent.AutoSize = true;
            this.radioBtnRent.Location = new System.Drawing.Point(153, 33);
            this.radioBtnRent.Name = "radioBtnRent";
            this.radioBtnRent.Size = new System.Drawing.Size(48, 17);
            this.radioBtnRent.TabIndex = 18;
            this.radioBtnRent.TabStop = true;
            this.radioBtnRent.Text = "Rent";
            this.radioBtnRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnRent.UseVisualStyleBackColor = true;
            this.radioBtnRent.CheckedChanged += new System.EventHandler(this.radioBtnRent_CheckedChanged);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(53, 137);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(82, 23);
            this.buttoncancel.TabIndex = 19;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // AddEdit_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 173);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.radioBtnRent);
            this.Controls.Add(this.radioBtnSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContractDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEdit_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddEdit_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContractDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.ToolTip toolTipWarning;
        private System.Windows.Forms.RadioButton radioBtnSale;
        private System.Windows.Forms.RadioButton radioBtnRent;
        private System.Windows.Forms.Button buttoncancel;
    }
}