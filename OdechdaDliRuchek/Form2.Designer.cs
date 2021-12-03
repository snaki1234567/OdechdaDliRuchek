namespace OdechdaDliRuchek
{
    partial class Form2
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label countInPackLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label countInStockLabel;
            System.Windows.Forms.Label minCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label materialTypeIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.odechdaDliRushekDataSet = new OdechdaDliRuchek.OdechdaDliRushekDataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new OdechdaDliRuchek.OdechdaDliRushekDataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new OdechdaDliRuchek.OdechdaDliRushekDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.countInPackTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.countInStockTextBox = new System.Windows.Forms.TextBox();
            this.minCountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            countInPackLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            countInStockLabel = new System.Windows.Forms.Label();
            minCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            materialTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odechdaDliRushekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(328, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернутся назад";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // odechdaDliRushekDataSet
            // 
            this.odechdaDliRushekDataSet.DataSetName = "OdechdaDliRushekDataSet";
            this.odechdaDliRushekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.odechdaDliRushekDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentPriorityHistoryTableAdapter = null;
            this.tableAdapterManager.AgentTableAdapter = null;
            this.tableAdapterManager.AgentTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialCountHistoryTableAdapter = null;
            this.tableAdapterManager.MaterialSupplierTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.ProductCostHistoryTableAdapter = null;
            this.tableAdapterManager.ProductMaterialTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OdechdaDliRuchek.OdechdaDliRushekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(291, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(36, 22);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            iDLabel.Click += new System.EventHandler(this.iDLabel_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(333, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 29);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(192, 183);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(53, 22);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(251, 180);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 29);
            this.titleTextBox.TabIndex = 4;
            // 
            // countInPackLabel
            // 
            countInPackLabel.AutoSize = true;
            countInPackLabel.Location = new System.Drawing.Point(210, 240);
            countInPackLabel.Name = "countInPackLabel";
            countInPackLabel.Size = new System.Drawing.Size(134, 22);
            countInPackLabel.TabIndex = 5;
            countInPackLabel.Text = "Count In Pack:";
            // 
            // countInPackTextBox
            // 
            this.countInPackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CountInPack", true));
            this.countInPackTextBox.Location = new System.Drawing.Point(350, 237);
            this.countInPackTextBox.Name = "countInPackTextBox";
            this.countInPackTextBox.Size = new System.Drawing.Size(100, 29);
            this.countInPackTextBox.TabIndex = 6;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(291, 361);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(49, 22);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "Unit:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(346, 358);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(100, 29);
            this.unitTextBox.TabIndex = 8;
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new System.Drawing.Point(309, 435);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new System.Drawing.Size(139, 22);
            countInStockLabel.TabIndex = 9;
            countInStockLabel.Text = "Count In Stock:";
            // 
            // countInStockTextBox
            // 
            this.countInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CountInStock", true));
            this.countInStockTextBox.Location = new System.Drawing.Point(454, 432);
            this.countInStockTextBox.Name = "countInStockTextBox";
            this.countInStockTextBox.Size = new System.Drawing.Size(100, 29);
            this.countInStockTextBox.TabIndex = 10;
            // 
            // minCountLabel
            // 
            minCountLabel.AutoSize = true;
            minCountLabel.Location = new System.Drawing.Point(424, 315);
            minCountLabel.Name = "minCountLabel";
            minCountLabel.Size = new System.Drawing.Size(103, 22);
            minCountLabel.TabIndex = 11;
            minCountLabel.Text = "Min Count:";
            // 
            // minCountTextBox
            // 
            this.minCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "MinCount", true));
            this.minCountTextBox.Location = new System.Drawing.Point(533, 312);
            this.minCountTextBox.Name = "minCountTextBox";
            this.minCountTextBox.Size = new System.Drawing.Size(100, 29);
            this.minCountTextBox.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(484, 229);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 22);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(599, 226);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 29);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(68, 307);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(53, 22);
            costLabel.TabIndex = 15;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(127, 304);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 29);
            this.costTextBox.TabIndex = 16;
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(19, 113);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(100, 29);
            this.imageTextBox.TabIndex = 18;
            // 
            // materialTypeIDLabel
            // 
            materialTypeIDLabel.AutoSize = true;
            materialTypeIDLabel.Location = new System.Drawing.Point(136, 402);
            materialTypeIDLabel.Name = "materialTypeIDLabel";
            materialTypeIDLabel.Size = new System.Drawing.Size(157, 22);
            materialTypeIDLabel.TabIndex = 19;
            materialTypeIDLabel.Text = "Material Type ID:";
            // 
            // materialTypeIDTextBox
            // 
            this.materialTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "MaterialTypeID", true));
            this.materialTypeIDTextBox.Location = new System.Drawing.Point(299, 399);
            this.materialTypeIDTextBox.Name = "materialTypeIDTextBox";
            this.materialTypeIDTextBox.Size = new System.Drawing.Size(100, 29);
            this.materialTypeIDTextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.imageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 157);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(materialTypeIDLabel);
            this.Controls.Add(this.materialTypeIDTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCountLabel);
            this.Controls.Add(this.minCountTextBox);
            this.Controls.Add(countInStockLabel);
            this.Controls.Add(this.countInStockTextBox);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(countInPackLabel);
            this.Controls.Add(this.countInPackTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Одежда для ручек | Дабовление и редактирование данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odechdaDliRushekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private OdechdaDliRushekDataSet odechdaDliRushekDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private OdechdaDliRushekDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private OdechdaDliRushekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox countInPackTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox countInStockTextBox;
        private System.Windows.Forms.TextBox minCountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox materialTypeIDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList2;
    }
}