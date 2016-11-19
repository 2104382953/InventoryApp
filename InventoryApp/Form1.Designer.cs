namespace InventoryApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveInventory = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.lstBoxInventory = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Application";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(145, 113);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(251, 20);
            this.inputBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input Item";
            // 
            // btnRemoveInventory
            // 
            this.btnRemoveInventory.Location = new System.Drawing.Point(304, 206);
            this.btnRemoveInventory.Name = "btnRemoveInventory";
            this.btnRemoveInventory.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInventory.TabIndex = 5;
            this.btnRemoveInventory.Text = "Remove";
            this.btnRemoveInventory.UseVisualStyleBackColor = true;
            this.btnRemoveInventory.Click += new System.EventHandler(this.btnRemoveInventory_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(385, 206);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 6;
            this.btnAddInventory.Text = "Add";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // lstBoxInventory
            // 
            this.lstBoxInventory.FormattingEnabled = true;
            this.lstBoxInventory.Location = new System.Drawing.Point(145, 235);
            this.lstBoxInventory.Name = "lstBoxInventory";
            this.lstBoxInventory.Size = new System.Drawing.Size(316, 108);
            this.lstBoxInventory.TabIndex = 7;
            this.lstBoxInventory.SelectedIndexChanged += new System.EventHandler(this.lstBoxInventory_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(145, 139);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(315, 61);
            this.txtDescription.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 442);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstBoxInventory);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.btnRemoveInventory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveInventory;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.ListBox lstBoxInventory;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

