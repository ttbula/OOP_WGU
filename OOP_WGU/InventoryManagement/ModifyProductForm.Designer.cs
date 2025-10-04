namespace InventoryManagement
{
   partial class ModifyProductForm
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
         this.txtboxMax = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
         this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
         this.txtboxSearch = new System.Windows.Forms.TextBox();
         this.btnSearch = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label16 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.txtboxMin = new System.Windows.Forms.TextBox();
         this.txtboxID = new System.Windows.Forms.TextBox();
         this.txtboxName = new System.Windows.Forms.TextBox();
         this.txtboxInventory = new System.Windows.Forms.TextBox();
         this.txtboxPrice = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
         this.SuspendLayout();
         // 
         // txtboxMax
         // 
         this.txtboxMax.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxMax.Location = new System.Drawing.Point(131, 363);
         this.txtboxMax.Name = "txtboxMax";
         this.txtboxMax.Size = new System.Drawing.Size(82, 20);
         this.txtboxMax.TabIndex = 49;
         this.txtboxMax.TextChanged += new System.EventHandler(this.txtboxMax_TextChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(16, 27);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(102, 17);
         this.label4.TabIndex = 27;
         this.label4.Text = "Modify Product";
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(804, 420);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(59, 39);
         this.btnDelete.TabIndex = 28;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(708, 465);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(59, 39);
         this.btnSave.TabIndex = 29;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(804, 465);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(59, 39);
         this.btnCancel.TabIndex = 30;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(804, 234);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(59, 39);
         this.btnAdd.TabIndex = 31;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // dgvCandidateParts
         // 
         this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvCandidateParts.Location = new System.Drawing.Point(490, 111);
         this.dgvCandidateParts.Name = "dgvCandidateParts";
         this.dgvCandidateParts.Size = new System.Drawing.Size(420, 97);
         this.dgvCandidateParts.TabIndex = 32;
         // 
         // dgvAssociatedParts
         // 
         this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvAssociatedParts.Location = new System.Drawing.Point(490, 301);
         this.dgvAssociatedParts.Name = "dgvAssociatedParts";
         this.dgvAssociatedParts.Size = new System.Drawing.Size(420, 97);
         this.dgvAssociatedParts.TabIndex = 33;
         // 
         // txtboxSearch
         // 
         this.txtboxSearch.Location = new System.Drawing.Point(708, 59);
         this.txtboxSearch.Multiline = true;
         this.txtboxSearch.Name = "txtboxSearch";
         this.txtboxSearch.Size = new System.Drawing.Size(202, 27);
         this.txtboxSearch.TabIndex = 34;
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(623, 59);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(62, 29);
         this.btnSearch.TabIndex = 35;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(487, 84);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(95, 13);
         this.label5.TabIndex = 36;
         this.label5.Text = "All candidate Parts";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(487, 272);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(167, 13);
         this.label6.TabIndex = 37;
         this.label6.Text = "Parts Associated with this Product";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(233, 366);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(24, 13);
         this.label7.TabIndex = 38;
         this.label7.Text = "Min";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(76, 184);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(18, 13);
         this.label8.TabIndex = 39;
         this.label8.Text = "ID";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(76, 224);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(35, 13);
         this.label9.TabIndex = 40;
         this.label9.Text = "Name";
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(76, 316);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(63, 13);
         this.label16.TabIndex = 41;
         this.label16.Text = "Price / Cost";
         // 
         // label17
         // 
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(76, 272);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(51, 13);
         this.label17.TabIndex = 42;
         this.label17.Text = "Inventory";
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.Location = new System.Drawing.Point(76, 363);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(27, 13);
         this.label18.TabIndex = 43;
         this.label18.Text = "Max";
         // 
         // txtboxMin
         // 
         this.txtboxMin.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxMin.Location = new System.Drawing.Point(285, 363);
         this.txtboxMin.Name = "txtboxMin";
         this.txtboxMin.Size = new System.Drawing.Size(82, 20);
         this.txtboxMin.TabIndex = 44;
         this.txtboxMin.TextChanged += new System.EventHandler(this.txtboxMin_TextChanged);
         // 
         // txtboxID
         // 
         this.txtboxID.BackColor = System.Drawing.Color.LightGray;
         this.txtboxID.Enabled = false;
         this.txtboxID.Location = new System.Drawing.Point(157, 188);
         this.txtboxID.Name = "txtboxID";
         this.txtboxID.ReadOnly = true;
         this.txtboxID.Size = new System.Drawing.Size(148, 20);
         this.txtboxID.TabIndex = 45;
         // 
         // txtboxName
         // 
         this.txtboxName.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxName.Location = new System.Drawing.Point(157, 224);
         this.txtboxName.Name = "txtboxName";
         this.txtboxName.Size = new System.Drawing.Size(148, 20);
         this.txtboxName.TabIndex = 46;
         this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
         // 
         // txtboxInventory
         // 
         this.txtboxInventory.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxInventory.Location = new System.Drawing.Point(157, 272);
         this.txtboxInventory.Name = "txtboxInventory";
         this.txtboxInventory.Size = new System.Drawing.Size(148, 20);
         this.txtboxInventory.TabIndex = 47;
         this.txtboxInventory.TextChanged += new System.EventHandler(this.txtboxInventory_TextChanged);
         // 
         // txtboxPrice
         // 
         this.txtboxPrice.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxPrice.Location = new System.Drawing.Point(157, 316);
         this.txtboxPrice.Name = "txtboxPrice";
         this.txtboxPrice.Size = new System.Drawing.Size(148, 20);
         this.txtboxPrice.TabIndex = 48;
         this.txtboxPrice.TextChanged += new System.EventHandler(this.txtboxPrice_TextChanged);
         // 
         // ModifyProductForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(992, 530);
         this.Controls.Add(this.txtboxMax);
         this.Controls.Add(this.txtboxPrice);
         this.Controls.Add(this.txtboxInventory);
         this.Controls.Add(this.txtboxName);
         this.Controls.Add(this.txtboxID);
         this.Controls.Add(this.txtboxMin);
         this.Controls.Add(this.label18);
         this.Controls.Add(this.label17);
         this.Controls.Add(this.label16);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.txtboxSearch);
         this.Controls.Add(this.dgvAssociatedParts);
         this.Controls.Add(this.dgvCandidateParts);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.label4);
         this.Name = "ModifyProductForm";
         this.Text = "Product";
         ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtboxMax;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.DataGridView dgvCandidateParts;
      private System.Windows.Forms.DataGridView dgvAssociatedParts;
      private System.Windows.Forms.TextBox txtboxSearch;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.TextBox txtboxMin;
      private System.Windows.Forms.TextBox txtboxID;
      private System.Windows.Forms.TextBox txtboxName;
      private System.Windows.Forms.TextBox txtboxInventory;
      private System.Windows.Forms.TextBox txtboxPrice;
   }
}