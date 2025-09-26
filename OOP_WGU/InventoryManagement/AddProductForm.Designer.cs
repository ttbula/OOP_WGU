namespace InventoryManagement
{
   partial class AddProductForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
         this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
         this.txtboxSearch = new System.Windows.Forms.TextBox();
         this.btnSearch = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.txtboxMin = new System.Windows.Forms.TextBox();
         this.txtboxID = new System.Windows.Forms.TextBox();
         this.txtboxName = new System.Windows.Forms.TextBox();
         this.txtboxInventory = new System.Windows.Forms.TextBox();
         this.txtboxPrice = new System.Windows.Forms.TextBox();
         this.txtboxMax = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(86, 17);
         this.label1.TabIndex = 0;
         this.label1.Text = "Add Product";
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(800, 420);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(59, 39);
         this.btnDelete.TabIndex = 3;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(704, 465);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(59, 39);
         this.btnSave.TabIndex = 4;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(800, 465);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(59, 39);
         this.btnCancel.TabIndex = 5;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(800, 234);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(59, 39);
         this.btnAdd.TabIndex = 6;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // dgvCandidateParts
         // 
         this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvCandidateParts.Location = new System.Drawing.Point(486, 111);
         this.dgvCandidateParts.Name = "dgvCandidateParts";
         this.dgvCandidateParts.Size = new System.Drawing.Size(420, 97);
         this.dgvCandidateParts.TabIndex = 7;
         // 
         // dgvAssociatedParts
         // 
         this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvAssociatedParts.Location = new System.Drawing.Point(486, 301);
         this.dgvAssociatedParts.Name = "dgvAssociatedParts";
         this.dgvAssociatedParts.Size = new System.Drawing.Size(420, 97);
         this.dgvAssociatedParts.TabIndex = 8;
         // 
         // txtboxSearch
         // 
         this.txtboxSearch.Location = new System.Drawing.Point(704, 59);
         this.txtboxSearch.Multiline = true;
         this.txtboxSearch.Name = "txtboxSearch";
         this.txtboxSearch.Size = new System.Drawing.Size(202, 27);
         this.txtboxSearch.TabIndex = 9;
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(619, 59);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(62, 29);
         this.btnSearch.TabIndex = 10;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(483, 84);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(95, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "All candidate Parts";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(483, 272);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(167, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "Parts Associated with this Product";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(229, 366);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(24, 13);
         this.label10.TabIndex = 15;
         this.label10.Text = "Min";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(72, 184);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(18, 13);
         this.label11.TabIndex = 16;
         this.label11.Text = "ID";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(72, 224);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(35, 13);
         this.label12.TabIndex = 17;
         this.label12.Text = "Name";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(72, 316);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(63, 13);
         this.label13.TabIndex = 18;
         this.label13.Text = "Price / Cost";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(72, 272);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(51, 13);
         this.label14.TabIndex = 19;
         this.label14.Text = "Inventory";
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(72, 363);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(27, 13);
         this.label15.TabIndex = 20;
         this.label15.Text = "Max";
         // 
         // txtboxMin
         // 
         this.txtboxMin.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxMin.Location = new System.Drawing.Point(281, 363);
         this.txtboxMin.Name = "txtboxMin";
         this.txtboxMin.Size = new System.Drawing.Size(82, 20);
         this.txtboxMin.TabIndex = 21;
         this.txtboxMin.TextChanged += new System.EventHandler(this.txtboxMin_TextChanged);
         // 
         // txtboxID
         // 
         this.txtboxID.BackColor = System.Drawing.Color.LightGray;
         this.txtboxID.Enabled = false;
         this.txtboxID.Location = new System.Drawing.Point(153, 188);
         this.txtboxID.Name = "txtboxID";
         this.txtboxID.ReadOnly = true;
         this.txtboxID.Size = new System.Drawing.Size(148, 20);
         this.txtboxID.TabIndex = 22;
         // 
         // txtboxName
         // 
         this.txtboxName.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxName.Location = new System.Drawing.Point(153, 224);
         this.txtboxName.Name = "txtboxName";
         this.txtboxName.Size = new System.Drawing.Size(148, 20);
         this.txtboxName.TabIndex = 23;
         this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
         // 
         // txtboxInventory
         // 
         this.txtboxInventory.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxInventory.Location = new System.Drawing.Point(153, 272);
         this.txtboxInventory.Name = "txtboxInventory";
         this.txtboxInventory.Size = new System.Drawing.Size(148, 20);
         this.txtboxInventory.TabIndex = 24;
         this.txtboxInventory.TextChanged += new System.EventHandler(this.txtboxInventory_TextChanged);
         // 
         // txtboxPrice
         // 
         this.txtboxPrice.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxPrice.Location = new System.Drawing.Point(153, 316);
         this.txtboxPrice.Name = "txtboxPrice";
         this.txtboxPrice.Size = new System.Drawing.Size(148, 20);
         this.txtboxPrice.TabIndex = 25;
         this.txtboxPrice.TextChanged += new System.EventHandler(this.txtboxPrice_TextChanged);
         // 
         // txtboxMax
         // 
         this.txtboxMax.BackColor = System.Drawing.Color.LightCoral;
         this.txtboxMax.Location = new System.Drawing.Point(125, 363);
         this.txtboxMax.Name = "txtboxMax";
         this.txtboxMax.Size = new System.Drawing.Size(82, 20);
         this.txtboxMax.TabIndex = 26;
         this.txtboxMax.TextChanged += new System.EventHandler(this.txtboxMax_TextChanged);
         // 
         // AddProductForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(993, 530);
         this.Controls.Add(this.txtboxMax);
         this.Controls.Add(this.txtboxPrice);
         this.Controls.Add(this.txtboxInventory);
         this.Controls.Add(this.txtboxName);
         this.Controls.Add(this.txtboxID);
         this.Controls.Add(this.txtboxMin);
         this.Controls.Add(this.label15);
         this.Controls.Add(this.label14);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.txtboxSearch);
         this.Controls.Add(this.dgvAssociatedParts);
         this.Controls.Add(this.dgvCandidateParts);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.label1);
         this.Name = "AddProductForm";
         this.Text = "Product";
         ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.DataGridView dgvCandidateParts;
      private System.Windows.Forms.DataGridView dgvAssociatedParts;
      private System.Windows.Forms.TextBox txtboxSearch;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.TextBox txtboxMin;
      private System.Windows.Forms.TextBox txtboxID;
      private System.Windows.Forms.TextBox txtboxName;
      private System.Windows.Forms.TextBox txtboxInventory;
      private System.Windows.Forms.TextBox txtboxPrice;
      private System.Windows.Forms.TextBox txtboxMax;
   }
}