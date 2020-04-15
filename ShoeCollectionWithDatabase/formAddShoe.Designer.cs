namespace ShoeCollectionWithDatabase
{
    partial class formAddShoe
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
            this.buttonAddShoe = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelColorway = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbColorway = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.brandsDataSet = new ShoeCollectionWithDatabase.BrandsDataSet();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter = new ShoeCollectionWithDatabase.BrandsDataSetTableAdapters.BrandsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddShoe
            // 
            this.buttonAddShoe.Location = new System.Drawing.Point(57, 283);
            this.buttonAddShoe.Name = "buttonAddShoe";
            this.buttonAddShoe.Size = new System.Drawing.Size(82, 58);
            this.buttonAddShoe.TabIndex = 5;
            this.buttonAddShoe.Text = "Add Shoe";
            this.buttonAddShoe.UseVisualStyleBackColor = true;
            this.buttonAddShoe.Click += new System.EventHandler(this.buttonAddShoe_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(154, 283);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(82, 58);
            this.buttonFinish.TabIndex = 6;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(63, 77);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 16);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Brand:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(63, 116);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 16);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model:";
            // 
            // labelColorway
            // 
            this.labelColorway.AutoSize = true;
            this.labelColorway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorway.Location = new System.Drawing.Point(63, 154);
            this.labelColorway.Name = "labelColorway";
            this.labelColorway.Size = new System.Drawing.Size(67, 16);
            this.labelColorway.TabIndex = 3;
            this.labelColorway.Text = "Colorway:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(63, 194);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(37, 16);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Size:";
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(136, 113);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 2;
            // 
            // tbColorway
            // 
            this.tbColorway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorway.Location = new System.Drawing.Point(136, 151);
            this.tbColorway.Name = "tbColorway";
            this.tbColorway.Size = new System.Drawing.Size(100, 22);
            this.tbColorway.TabIndex = 3;
            // 
            // cbBrand
            // 
            this.cbBrand.DataSource = this.brandsBindingSource;
            this.cbBrand.DisplayMember = "Brands";
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(136, 72);
            this.cbBrand.MaxLength = 50;
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(100, 21);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.ValueMember = "Brands";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12"});
            this.cbSize.Location = new System.Drawing.Point(136, 193);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 4;
            // 
            // brandsDataSet
            // 
            this.brandsDataSet.DataSetName = "BrandsDataSet";
            this.brandsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.brandsDataSet;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // formAddShoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 400);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.tbColorway);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelColorway);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonAddShoe);
            this.Name = "formAddShoe";
            this.Text = "formAddShoe";
            this.Load += new System.EventHandler(this.formAddShoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddShoe;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColorway;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbColorway;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbSize;
        private BrandsDataSet brandsDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private BrandsDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
    }
}