
namespace Store_management.Forms
{
    partial class FormStock
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnReduceStock = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cboxOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "所選商品庫存變更";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStock.Location = new System.Drawing.Point(134, 215);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(63, 35);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "增加";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnReduceStock
            // 
            this.btnReduceStock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduceStock.Location = new System.Drawing.Point(33, 215);
            this.btnReduceStock.Name = "btnReduceStock";
            this.btnReduceStock.Size = new System.Drawing.Size(63, 35);
            this.btnReduceStock.TabIndex = 8;
            this.btnReduceStock.Text = "減少";
            this.btnReduceStock.UseVisualStyleBackColor = true;
            this.btnReduceStock.Click += new System.EventHandler(this.btnReduceStock_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(260, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 322);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "選項";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStock.Location = new System.Drawing.Point(33, 165);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(164, 29);
            this.txtStock.TabIndex = 28;
            // 
            // cboxOptions
            // 
            this.cboxOptions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxOptions.FormattingEnabled = true;
            this.cboxOptions.Location = new System.Drawing.Point(33, 51);
            this.cboxOptions.Name = "cboxOptions";
            this.cboxOptions.Size = new System.Drawing.Size(164, 29);
            this.cboxOptions.TabIndex = 27;
            this.cboxOptions.SelectedIndexChanged += new System.EventHandler(this.cboxOptions_SelectedIndexChanged);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 322);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cboxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReduceStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnReduceStock;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cboxOptions;
    }
}