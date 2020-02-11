namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.pickFromTime = new System.Windows.Forms.DateTimePicker();
            this.pickToTime = new System.Windows.Forms.DateTimePicker();
            this.pickFromDate = new System.Windows.Forms.DateTimePicker();
            this.pickToDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ckCashier = new System.Windows.Forms.CheckBox();
            this.dataDetail = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dataExtension = new System.Windows.Forms.DataGridView();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.myDataSet = new System.Data.DataSet();
            this.myDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(71, 6);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(109, 20);
            this.txtExtension.TabIndex = 3;
            this.txtExtension.TextChanged += new System.EventHandler(this.txtExtension_TextChanged);
            // 
            // pickFromTime
            // 
            this.pickFromTime.Location = new System.Drawing.Point(326, 6);
            this.pickFromTime.Name = "pickFromTime";
            this.pickFromTime.ShowUpDown = true;
            this.pickFromTime.Size = new System.Drawing.Size(100, 20);
            this.pickFromTime.TabIndex = 11;
            this.pickFromTime.ValueChanged += new System.EventHandler(this.pickFromTime_ValueChanged);
            // 
            // pickToTime
            // 
            this.pickToTime.Location = new System.Drawing.Point(564, 6);
            this.pickToTime.Name = "pickToTime";
            this.pickToTime.ShowUpDown = true;
            this.pickToTime.Size = new System.Drawing.Size(100, 20);
            this.pickToTime.TabIndex = 12;
            this.pickToTime.ValueChanged += new System.EventHandler(this.pickToTime_ValueChanged);
            // 
            // pickFromDate
            // 
            this.pickFromDate.Location = new System.Drawing.Point(222, 6);
            this.pickFromDate.Name = "pickFromDate";
            this.pickFromDate.Size = new System.Drawing.Size(100, 20);
            this.pickFromDate.TabIndex = 15;
            this.pickFromDate.ValueChanged += new System.EventHandler(this.pickFromDate_ValueChanged);
            // 
            // pickToDate
            // 
            this.pickToDate.Location = new System.Drawing.Point(458, 6);
            this.pickToDate.Name = "pickToDate";
            this.pickToDate.Size = new System.Drawing.Size(100, 20);
            this.pickToDate.TabIndex = 16;
            this.pickToDate.ValueChanged += new System.EventHandler(this.pickToDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ckCashier
            // 
            this.ckCashier.AutoSize = true;
            this.ckCashier.Location = new System.Drawing.Point(467, 42);
            this.ckCashier.Name = "ckCashier";
            this.ckCashier.Size = new System.Drawing.Size(134, 17);
            this.ckCashier.TabIndex = 21;
            this.ckCashier.Text = "Display Cashier\'s name";
            this.ckCashier.UseVisualStyleBackColor = true;
            // 
            // dataDetail
            // 
            this.dataDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetail.Location = new System.Drawing.Point(232, 123);
            this.dataDetail.Name = "dataDetail";
            this.dataDetail.Size = new System.Drawing.Size(434, 189);
            this.dataDetail.TabIndex = 22;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(355, 72);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(106, 23);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "View & Print";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(467, 72);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(70, 23);
            this.btnSum.TabIndex = 24;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(270, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(127, 43);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(89, 23);
            this.btnExcel.TabIndex = 31;
            this.btnExcel.Text = "Get from excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dataExtension
            // 
            this.dataExtension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExtension.Location = new System.Drawing.Point(15, 123);
            this.dataExtension.Name = "dataExtension";
            this.dataExtension.Size = new System.Drawing.Size(211, 189);
            this.dataExtension.TabIndex = 20;
            this.dataExtension.SelectionChanged += new System.EventHandler(this.dataExtension_SelectionChanged);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(127, 72);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveAll.TabIndex = 33;
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(270, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 34;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.Initialized += new System.EventHandler(this.myDataSet_Initialized);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 352);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataDetail);
            this.Controls.Add(this.ckCashier);
            this.Controls.Add(this.dataExtension);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pickToDate);
            this.Controls.Add(this.pickFromDate);
            this.Controls.Add(this.pickToTime);
            this.Controls.Add(this.pickFromTime);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.DateTimePicker pickFromTime;
        private System.Windows.Forms.DateTimePicker pickToTime;
        private System.Windows.Forms.DateTimePicker pickFromDate;
        private System.Windows.Forms.DateTimePicker pickToDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox ckCashier;
        private System.Windows.Forms.DataGridView dataDetail;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dataExtension;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Data.DataSet myDataSet;
        private System.Windows.Forms.BindingSource myDataBindingSource;
    }
}

