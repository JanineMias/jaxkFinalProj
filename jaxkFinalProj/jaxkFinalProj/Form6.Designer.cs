namespace jaxkFinalProj
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblTInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTFee = new System.Windows.Forms.Label();
            this.lblChng = new System.Windows.Forms.Label();
            this.lvCustomerDetails = new System.Windows.Forms.ListView();
            this.colRefNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBaggage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInsurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader.Location = new System.Drawing.Point(236, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(502, 95);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Astral Express";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCustomerDetails.Location = new System.Drawing.Point(37, 112);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(147, 20);
            this.lblCustomerDetails.TabIndex = 1;
            this.lblCustomerDetails.Text = "Customer Details";
            this.lblCustomerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTInformation
            // 
            this.lblTInformation.BackColor = System.Drawing.Color.Lavender;
            this.lblTInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTInformation.Location = new System.Drawing.Point(494, 141);
            this.lblTInformation.Name = "lblTInformation";
            this.lblTInformation.Size = new System.Drawing.Size(257, 131);
            this.lblTInformation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(491, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Travel Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalFee.Location = new System.Drawing.Point(491, 309);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(79, 20);
            this.lblTotalFee.TabIndex = 5;
            this.lblTotalFee.Text = "Total Fee:";
            this.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPayment.Location = new System.Drawing.Point(491, 340);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(79, 20);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment:";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChange.Location = new System.Drawing.Point(491, 370);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(79, 20);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change: ";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTFee
            // 
            this.lblTFee.BackColor = System.Drawing.Color.Lavender;
            this.lblTFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTFee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTFee.Location = new System.Drawing.Point(576, 309);
            this.lblTFee.Name = "lblTFee";
            this.lblTFee.Size = new System.Drawing.Size(175, 20);
            this.lblTFee.TabIndex = 8;
            this.lblTFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChng
            // 
            this.lblChng.BackColor = System.Drawing.Color.Lavender;
            this.lblChng.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChng.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChng.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChng.Location = new System.Drawing.Point(576, 370);
            this.lblChng.Name = "lblChng";
            this.lblChng.Size = new System.Drawing.Size(175, 20);
            this.lblChng.TabIndex = 10;
            this.lblChng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvCustomerDetails
            // 
            this.lvCustomerDetails.BackColor = System.Drawing.Color.Lavender;
            this.lvCustomerDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRefNum,
            this.colName,
            this.colAge,
            this.colType,
            this.colBaggage,
            this.colInsurance});
            this.lvCustomerDetails.GridLines = true;
            this.lvCustomerDetails.HideSelection = false;
            this.lvCustomerDetails.Location = new System.Drawing.Point(40, 141);
            this.lvCustomerDetails.Name = "lvCustomerDetails";
            this.lvCustomerDetails.Size = new System.Drawing.Size(432, 248);
            this.lvCustomerDetails.TabIndex = 11;
            this.lvCustomerDetails.UseCompatibleStateImageBehavior = false;
            this.lvCustomerDetails.View = System.Windows.Forms.View.Details;
            // 
            // colRefNum
            // 
            this.colRefNum.Text = "Ref. No.";
            this.colRefNum.Width = 61;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 110;
            // 
            // colAge
            // 
            this.colAge.Text = "Age";
            this.colAge.Width = 47;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 70;
            // 
            // colBaggage
            // 
            this.colBaggage.Text = "Baggage Fee";
            this.colBaggage.Width = 76;
            // 
            // colInsurance
            // 
            this.colInsurance.Text = "Insurance";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Thistle;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(40, 395);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(397, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(576, 341);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(175, 20);
            this.txtPayment.TabIndex = 14;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Thistle;
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(657, 395);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "CALCULATE";
            this.btnCalc.UseVisualStyleBackColor = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lvCustomerDetails);
            this.Controls.Add(this.lblChng);
            this.Controls.Add(this.lblTFee);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTInformation);
            this.Controls.Add(this.lblCustomerDetails);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSACTION";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label lblTInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTFee;
        private System.Windows.Forms.Label lblChng;
        private System.Windows.Forms.ListView lvCustomerDetails;
        private System.Windows.Forms.ColumnHeader colRefNum;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colBaggage;
        private System.Windows.Forms.ColumnHeader colInsurance;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnCalc;
    }
}