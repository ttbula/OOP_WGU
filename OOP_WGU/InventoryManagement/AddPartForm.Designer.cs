namespace InventoryManagement
{
   partial class AddPartForm
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
         this.rbInHouse = new System.Windows.Forms.RadioButton();
         this.rbOutsourced = new System.Windows.Forms.RadioButton();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.lblMachineID = new System.Windows.Forms.Label();
         this.txtboxMin = new System.Windows.Forms.TextBox();
         this.txtboxID = new System.Windows.Forms.TextBox();
         this.txtboxName = new System.Windows.Forms.TextBox();
         this.txtboxInventory = new System.Windows.Forms.TextBox();
         this.txtboxPrice = new System.Windows.Forms.TextBox();
         this.txtboxMax = new System.Windows.Forms.TextBox();
         this.txtboxMachineID = new System.Windows.Forms.TextBox();
         this.txtboxCompanyName = new System.Windows.Forms.TextBox();
         this.lblCompanyName = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // rbInHouse
         // 
         this.rbInHouse.AutoSize = true;
         this.rbInHouse.Location = new System.Drawing.Point(223, 24);
         this.rbInHouse.Name = "rbInHouse";
         this.rbInHouse.Size = new System.Drawing.Size(68, 17);
         this.rbInHouse.TabIndex = 0;
         this.rbInHouse.TabStop = true;
         this.rbInHouse.Text = "In-House";
         this.rbInHouse.UseVisualStyleBackColor = true;
         this.rbInHouse.Click += new System.EventHandler(this.rbInHouse_Click);
         // 
         // rbOutsourced
         // 
         this.rbOutsourced.AutoSize = true;
         this.rbOutsourced.Location = new System.Drawing.Point(390, 24);
         this.rbOutsourced.Name = "rbOutsourced";
         this.rbOutsourced.Size = new System.Drawing.Size(80, 17);
         this.rbOutsourced.TabIndex = 1;
         this.rbOutsourced.TabStop = true;
         this.rbOutsourced.Text = "Outsourced";
         this.rbOutsourced.UseVisualStyleBackColor = true;
         this.rbOutsourced.Click += new System.EventHandler(this.rbOutsourced_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(356, 290);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(24, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Min";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(226, 104);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(18, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "ID";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(208, 151);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(35, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Name";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(181, 243);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(63, 13);
         this.label4.TabIndex = 5;
         this.label4.Text = "Price / Cost";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(193, 199);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(51, 13);
         this.label5.TabIndex = 6;
         this.label5.Text = "Inventory";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(216, 290);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(27, 13);
         this.label6.TabIndex = 7;
         this.label6.Text = "Max";
         // 
         // lblMachineID
         // 
         this.lblMachineID.AutoSize = true;
         this.lblMachineID.Location = new System.Drawing.Point(181, 341);
         this.lblMachineID.Name = "lblMachineID";
         this.lblMachineID.Size = new System.Drawing.Size(62, 13);
         this.lblMachineID.TabIndex = 8;
         this.lblMachineID.Text = "Machine ID";
         // 
         // txtboxMin
         // 
         this.txtboxMin.Location = new System.Drawing.Point(386, 290);
         this.txtboxMin.Name = "txtboxMin";
         this.txtboxMin.Size = new System.Drawing.Size(100, 20);
         this.txtboxMin.TabIndex = 9;
         // 
         // txtboxID
         // 
         this.txtboxID.Location = new System.Drawing.Point(250, 104);
         this.txtboxID.Name = "txtboxID";
         this.txtboxID.Size = new System.Drawing.Size(100, 20);
         this.txtboxID.TabIndex = 10;
         // 
         // txtboxName
         // 
         this.txtboxName.Location = new System.Drawing.Point(250, 151);
         this.txtboxName.Name = "txtboxName";
         this.txtboxName.Size = new System.Drawing.Size(100, 20);
         this.txtboxName.TabIndex = 11;
         // 
         // txtboxInventory
         // 
         this.txtboxInventory.Location = new System.Drawing.Point(250, 199);
         this.txtboxInventory.Name = "txtboxInventory";
         this.txtboxInventory.Size = new System.Drawing.Size(100, 20);
         this.txtboxInventory.TabIndex = 12;
         // 
         // txtboxPrice
         // 
         this.txtboxPrice.Location = new System.Drawing.Point(250, 243);
         this.txtboxPrice.Name = "txtboxPrice";
         this.txtboxPrice.Size = new System.Drawing.Size(100, 20);
         this.txtboxPrice.TabIndex = 13;
         // 
         // txtboxMax
         // 
         this.txtboxMax.Location = new System.Drawing.Point(250, 290);
         this.txtboxMax.Name = "txtboxMax";
         this.txtboxMax.Size = new System.Drawing.Size(100, 20);
         this.txtboxMax.TabIndex = 14;
         // 
         // txtboxMachineID
         // 
         this.txtboxMachineID.Location = new System.Drawing.Point(250, 341);
         this.txtboxMachineID.Name = "txtboxMachineID";
         this.txtboxMachineID.Size = new System.Drawing.Size(100, 20);
         this.txtboxMachineID.TabIndex = 15;
         // 
         // txtboxCompanyName
         // 
         this.txtboxCompanyName.Location = new System.Drawing.Point(250, 341);
         this.txtboxCompanyName.Name = "txtboxCompanyName";
         this.txtboxCompanyName.Size = new System.Drawing.Size(100, 20);
         this.txtboxCompanyName.TabIndex = 16;
         // 
         // lblCompanyName
         // 
         this.lblCompanyName.AutoSize = true;
         this.lblCompanyName.Location = new System.Drawing.Point(162, 341);
         this.lblCompanyName.Name = "lblCompanyName";
         this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
         this.lblCompanyName.TabIndex = 17;
         this.lblCompanyName.Text = "Company Name";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(21, 24);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(63, 17);
         this.label10.TabIndex = 19;
         this.label10.Text = "Add Part";
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(642, 366);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 45);
         this.btnCancel.TabIndex = 21;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(549, 366);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 45);
         this.btnSave.TabIndex = 22;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // AddPartForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.lblCompanyName);
         this.Controls.Add(this.txtboxCompanyName);
         this.Controls.Add(this.txtboxMachineID);
         this.Controls.Add(this.txtboxMax);
         this.Controls.Add(this.txtboxPrice);
         this.Controls.Add(this.txtboxInventory);
         this.Controls.Add(this.txtboxName);
         this.Controls.Add(this.txtboxID);
         this.Controls.Add(this.txtboxMin);
         this.Controls.Add(this.lblMachineID);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.rbOutsourced);
         this.Controls.Add(this.rbInHouse);
         this.Name = "AddPartForm";
         this.Text = "AddPartForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RadioButton rbInHouse;
      private System.Windows.Forms.RadioButton rbOutsourced;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label lblMachineID;
      private System.Windows.Forms.TextBox txtboxMin;
      private System.Windows.Forms.TextBox txtboxID;
      private System.Windows.Forms.TextBox txtboxName;
      private System.Windows.Forms.TextBox txtboxInventory;
      private System.Windows.Forms.TextBox txtboxPrice;
      private System.Windows.Forms.TextBox txtboxMax;
      private System.Windows.Forms.TextBox txtboxMachineID;
      private System.Windows.Forms.TextBox txtboxCompanyName;
      private System.Windows.Forms.Label lblCompanyName;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnSave;
   }
}