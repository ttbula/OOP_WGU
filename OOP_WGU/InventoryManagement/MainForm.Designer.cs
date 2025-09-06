namespace InventoryManagement
{
   partial class MainForm
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
         this.btnAddParts = new System.Windows.Forms.Button();
         this.btnModifyParts = new System.Windows.Forms.Button();
         this.btnDeleteParts = new System.Windows.Forms.Button();
         this.btnAddProducts = new System.Windows.Forms.Button();
         this.btnModifyProducts = new System.Windows.Forms.Button();
         this.btnDeleteProducts = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.btnSearchParts = new System.Windows.Forms.Button();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.dgvParts = new System.Windows.Forms.DataGridView();
         this.btnSearchProducts = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.dgvProducts = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
         this.SuspendLayout();
         // 
         // btnAddParts
         // 
         this.btnAddParts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnAddParts.Location = new System.Drawing.Point(321, 356);
         this.btnAddParts.Name = "btnAddParts";
         this.btnAddParts.Size = new System.Drawing.Size(55, 27);
         this.btnAddParts.TabIndex = 3;
         this.btnAddParts.Text = "Add";
         this.btnAddParts.UseVisualStyleBackColor = false;
         this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
         // 
         // btnModifyParts
         // 
         this.btnModifyParts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnModifyParts.Location = new System.Drawing.Point(382, 356);
         this.btnModifyParts.Name = "btnModifyParts";
         this.btnModifyParts.Size = new System.Drawing.Size(55, 27);
         this.btnModifyParts.TabIndex = 4;
         this.btnModifyParts.Text = "Modify";
         this.btnModifyParts.UseVisualStyleBackColor = false;
         this.btnModifyParts.Click += new System.EventHandler(this.btnModifyParts_Click);
         // 
         // btnDeleteParts
         // 
         this.btnDeleteParts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnDeleteParts.Location = new System.Drawing.Point(443, 356);
         this.btnDeleteParts.Name = "btnDeleteParts";
         this.btnDeleteParts.Size = new System.Drawing.Size(55, 27);
         this.btnDeleteParts.TabIndex = 5;
         this.btnDeleteParts.Text = "Delete";
         this.btnDeleteParts.UseVisualStyleBackColor = false;
         this.btnDeleteParts.Click += new System.EventHandler(this.btnDeleteParts_Click);
         // 
         // btnAddProducts
         // 
         this.btnAddProducts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnAddProducts.Location = new System.Drawing.Point(892, 356);
         this.btnAddProducts.Name = "btnAddProducts";
         this.btnAddProducts.Size = new System.Drawing.Size(55, 27);
         this.btnAddProducts.TabIndex = 6;
         this.btnAddProducts.Text = "Add";
         this.btnAddProducts.UseVisualStyleBackColor = false;
         this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
         // 
         // btnModifyProducts
         // 
         this.btnModifyProducts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnModifyProducts.Location = new System.Drawing.Point(953, 356);
         this.btnModifyProducts.Name = "btnModifyProducts";
         this.btnModifyProducts.Size = new System.Drawing.Size(55, 27);
         this.btnModifyProducts.TabIndex = 7;
         this.btnModifyProducts.Text = "Modify";
         this.btnModifyProducts.UseVisualStyleBackColor = false;
         this.btnModifyProducts.Click += new System.EventHandler(this.btnModifyProducts_Click);
         // 
         // btnDeleteProducts
         // 
         this.btnDeleteProducts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnDeleteProducts.Location = new System.Drawing.Point(1014, 356);
         this.btnDeleteProducts.Name = "btnDeleteProducts";
         this.btnDeleteProducts.Size = new System.Drawing.Size(55, 27);
         this.btnDeleteProducts.TabIndex = 8;
         this.btnDeleteProducts.Text = "Delete";
         this.btnDeleteProducts.UseVisualStyleBackColor = false;
         this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
         // 
         // btnExit
         // 
         this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnExit.Location = new System.Drawing.Point(1014, 470);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(55, 27);
         this.btnExit.TabIndex = 9;
         this.btnExit.Text = "Exit";
         this.btnExit.UseVisualStyleBackColor = false;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // btnSearchParts
         // 
         this.btnSearchParts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnSearchParts.Location = new System.Drawing.Point(285, 79);
         this.btnSearchParts.Name = "btnSearchParts";
         this.btnSearchParts.Size = new System.Drawing.Size(75, 20);
         this.btnSearchParts.TabIndex = 13;
         this.btnSearchParts.Text = "Search";
         this.btnSearchParts.UseVisualStyleBackColor = false;
         this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(366, 79);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(132, 20);
         this.textBox3.TabIndex = 14;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(202, 17);
         this.label1.TabIndex = 15;
         this.label1.Text = "Inventory Management System";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 85);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(41, 17);
         this.label2.TabIndex = 16;
         this.label2.Text = "Parts";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(547, 85);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 17);
         this.label3.TabIndex = 17;
         this.label3.Text = "Products";
         // 
         // dgvParts
         // 
         this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvParts.Location = new System.Drawing.Point(12, 105);
         this.dgvParts.Name = "dgvParts";
         this.dgvParts.Size = new System.Drawing.Size(486, 245);
         this.dgvParts.TabIndex = 18;
         // 
         // btnSearchProducts
         // 
         this.btnSearchProducts.BackColor = System.Drawing.SystemColors.ControlLight;
         this.btnSearchProducts.Location = new System.Drawing.Point(856, 78);
         this.btnSearchProducts.Name = "btnSearchProducts";
         this.btnSearchProducts.Size = new System.Drawing.Size(75, 20);
         this.btnSearchProducts.TabIndex = 19;
         this.btnSearchProducts.Text = "Search";
         this.btnSearchProducts.UseVisualStyleBackColor = false;
         this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(937, 79);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(132, 20);
         this.textBox1.TabIndex = 20;
         // 
         // dgvProducts
         // 
         this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvProducts.Location = new System.Drawing.Point(550, 105);
         this.dgvProducts.Name = "dgvProducts";
         this.dgvProducts.Size = new System.Drawing.Size(519, 245);
         this.dgvProducts.TabIndex = 21;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(1081, 541);
         this.Controls.Add(this.dgvProducts);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.btnSearchProducts);
         this.Controls.Add(this.dgvParts);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.btnSearchParts);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnDeleteProducts);
         this.Controls.Add(this.btnModifyProducts);
         this.Controls.Add(this.btnAddProducts);
         this.Controls.Add(this.btnDeleteParts);
         this.Controls.Add(this.btnModifyParts);
         this.Controls.Add(this.btnAddParts);
         this.Name = "MainForm";
         this.Text = "Main Form";
         this.Load += new System.EventHandler(this.MainForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnAddParts;
      private System.Windows.Forms.Button btnModifyParts;
      private System.Windows.Forms.Button btnDeleteParts;
      private System.Windows.Forms.Button btnAddProducts;
      private System.Windows.Forms.Button btnModifyProducts;
      private System.Windows.Forms.Button btnDeleteProducts;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnSearchParts;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DataGridView dgvParts;
      private System.Windows.Forms.Button btnSearchProducts;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.DataGridView dgvProducts;
   }
}

