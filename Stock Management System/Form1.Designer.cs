namespace Stock_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prod_txt = new System.Windows.Forms.TextBox();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.selling_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.cat_combobx = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.barcodelb = new System.Windows.Forms.Label();
            this.barcodetxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(967, 99);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(133, 29);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // prod_txt
            // 
            this.prod_txt.Location = new System.Drawing.Point(234, 97);
            this.prod_txt.Name = "prod_txt";
            this.prod_txt.Size = new System.Drawing.Size(151, 27);
            this.prod_txt.TabIndex = 7;
            this.prod_txt.TextChanged += new System.EventHandler(this.prod_txt_TextChanged);
            // 
            // cost_txt
            // 
            this.cost_txt.Location = new System.Drawing.Point(404, 96);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(151, 27);
            this.cost_txt.TabIndex = 8;
            // 
            // selling_txt
            // 
            this.selling_txt.Location = new System.Drawing.Point(579, 96);
            this.selling_txt.Name = "selling_txt";
            this.selling_txt.Size = new System.Drawing.Size(151, 27);
            this.selling_txt.TabIndex = 9;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(753, 96);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(151, 27);
            this.quantity_txt.TabIndex = 10;
            // 
            // cat_combobx
            // 
            this.cat_combobx.FormattingEnabled = true;
            this.cat_combobx.Items.AddRange(new object[] {
            "Toys",
            "Meat",
            "Drinks",
            "Bread",
            "Toiletries",
            "Pasta",
            "Other"});
            this.cat_combobx.Location = new System.Drawing.Point(66, 96);
            this.cat_combobx.Name = "cat_combobx";
            this.cat_combobx.Size = new System.Drawing.Size(151, 28);
            this.cat_combobx.TabIndex = 12;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(967, 394);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 29);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barCode,
            this.productCategory,
            this.productName,
            this.costPrice,
            this.sellingPrice,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(66, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 324);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // barCode
            // 
            this.barCode.HeaderText = "Barcode";
            this.barCode.MinimumWidth = 6;
            this.barCode.Name = "barCode";
            this.barCode.Width = 125;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Product Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.Width = 125;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // costPrice
            // 
            this.costPrice.HeaderText = "Cost Price";
            this.costPrice.MinimumWidth = 6;
            this.costPrice.Name = "costPrice";
            this.costPrice.Width = 125;
            // 
            // sellingPrice
            // 
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.MinimumWidth = 6;
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = " Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(967, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(967, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 29);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(967, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Print Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barcodelb
            // 
            this.barcodelb.AutoSize = true;
            this.barcodelb.Location = new System.Drawing.Point(66, 39);
            this.barcodelb.Name = "barcodelb";
            this.barcodelb.Size = new System.Drawing.Size(64, 20);
            this.barcodelb.TabIndex = 18;
            this.barcodelb.Text = "Barcode";
            // 
            // barcodetxt
            // 
            this.barcodetxt.Location = new System.Drawing.Point(136, 36);
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(180, 27);
            this.barcodetxt.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 136);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barcodetxt);
            this.Controls.Add(this.barcodelb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cat_combobx);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.selling_txt);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.prod_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "Products Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox prod_txt;
        private TextBox cost_txt;
        private TextBox selling_txt;
        private TextBox quantity_txt;
        private ComboBox cat_combobx;
        private Button Exit;
        private DataGridViewTextBoxColumn barCode;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn costPrice;
        private DataGridViewTextBoxColumn sellingPrice;
        private DataGridViewTextBoxColumn Quantity;
        private Button button5;
        private Button button4;
        private Button button1;
        private DataGridView dataGridView1;
        private Label barcodelb;
        private TextBox barcodetxt;
        private PictureBox pictureBox1;
    }
}