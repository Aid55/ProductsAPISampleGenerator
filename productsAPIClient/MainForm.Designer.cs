
namespace ProductsAPISampleGenerator
{
    partial class MainForm
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAqKeyValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxApiKeyType = new System.Windows.Forms.GroupBox();
            this.rdoCustomKey = new System.Windows.Forms.RadioButton();
            this.rdoUsKey = new System.Windows.Forms.RadioButton();
            this.rdoUkKey = new System.Windows.Forms.RadioButton();
            this.cmdGetMfrBillingInfo = new System.Windows.Forms.Button();
            this.cmdGetMfrProducts = new System.Windows.Forms.Button();
            this.txtMfrId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdGetProductList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdIdList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdGetProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.cmdJsonExport = new System.Windows.Forms.Button();
            this.cmdChooseMfr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxApiKeyType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(126, 224);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(672, 325);
            this.txtResponse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // txtAqKeyValue
            // 
            this.txtAqKeyValue.Location = new System.Drawing.Point(15, 100);
            this.txtAqKeyValue.Name = "txtAqKeyValue";
            this.txtAqKeyValue.Size = new System.Drawing.Size(211, 23);
            this.txtAqKeyValue.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxApiKeyType);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 164);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AQ API Key";
            // 
            // groupBoxApiKeyType
            // 
            this.groupBoxApiKeyType.Controls.Add(this.rdoCustomKey);
            this.groupBoxApiKeyType.Controls.Add(this.txtAqKeyValue);
            this.groupBoxApiKeyType.Controls.Add(this.rdoUsKey);
            this.groupBoxApiKeyType.Controls.Add(this.rdoUkKey);
            this.groupBoxApiKeyType.Location = new System.Drawing.Point(6, 22);
            this.groupBoxApiKeyType.Name = "groupBoxApiKeyType";
            this.groupBoxApiKeyType.Size = new System.Drawing.Size(278, 133);
            this.groupBoxApiKeyType.TabIndex = 10;
            this.groupBoxApiKeyType.TabStop = false;
            this.groupBoxApiKeyType.Text = "Choose key to use:";
            // 
            // rdoCustomKey
            // 
            this.rdoCustomKey.AutoSize = true;
            this.rdoCustomKey.Location = new System.Drawing.Point(15, 79);
            this.rdoCustomKey.Name = "rdoCustomKey";
            this.rdoCustomKey.Size = new System.Drawing.Size(88, 19);
            this.rdoCustomKey.TabIndex = 2;
            this.rdoCustomKey.Text = "Custom key";
            this.rdoCustomKey.UseVisualStyleBackColor = true;
            // 
            // rdoUsKey
            // 
            this.rdoUsKey.AutoSize = true;
            this.rdoUsKey.Location = new System.Drawing.Point(15, 54);
            this.rdoUsKey.Name = "rdoUsKey";
            this.rdoUsKey.Size = new System.Drawing.Size(101, 19);
            this.rdoUsKey.TabIndex = 1;
            this.rdoUsKey.Text = "Default US key";
            this.rdoUsKey.UseVisualStyleBackColor = true;
            // 
            // rdoUkKey
            // 
            this.rdoUkKey.AutoSize = true;
            this.rdoUkKey.Checked = true;
            this.rdoUkKey.Location = new System.Drawing.Point(15, 29);
            this.rdoUkKey.Name = "rdoUkKey";
            this.rdoUkKey.Size = new System.Drawing.Size(102, 19);
            this.rdoUkKey.TabIndex = 0;
            this.rdoUkKey.TabStop = true;
            this.rdoUkKey.Text = "Default UK key";
            this.rdoUkKey.UseVisualStyleBackColor = true;
            // 
            // cmdGetMfrBillingInfo
            // 
            this.cmdGetMfrBillingInfo.Location = new System.Drawing.Point(339, 22);
            this.cmdGetMfrBillingInfo.Name = "cmdGetMfrBillingInfo";
            this.cmdGetMfrBillingInfo.Size = new System.Drawing.Size(117, 23);
            this.cmdGetMfrBillingInfo.TabIndex = 15;
            this.cmdGetMfrBillingInfo.Text = "GET Mfr Billing Info";
            this.cmdGetMfrBillingInfo.UseVisualStyleBackColor = true;
            this.cmdGetMfrBillingInfo.Click += new System.EventHandler(this.CmdMfrBillingInfo_Click);
            // 
            // cmdGetMfrProducts
            // 
            this.cmdGetMfrProducts.Location = new System.Drawing.Point(339, 52);
            this.cmdGetMfrProducts.Name = "cmdGetMfrProducts";
            this.cmdGetMfrProducts.Size = new System.Drawing.Size(117, 23);
            this.cmdGetMfrProducts.TabIndex = 16;
            this.cmdGetMfrProducts.Text = "GET Mfr Products";
            this.cmdGetMfrProducts.UseVisualStyleBackColor = true;
            this.cmdGetMfrProducts.Click += new System.EventHandler(this.CmdMfrProducts_Click);
            // 
            // txtMfrId
            // 
            this.txtMfrId.Location = new System.Drawing.Point(62, 51);
            this.txtMfrId.Name = "txtMfrId";
            this.txtMfrId.Size = new System.Drawing.Size(252, 23);
            this.txtMfrId.TabIndex = 17;
            this.txtMfrId.Text = "a38ad2af-7550-dd11-b5fb-00188bb07921";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mfr ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdGetProductList);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProdIdList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmdGetProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProdId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdGetMfrBillingInfo);
            this.groupBox2.Controls.Add(this.txtMfrId);
            this.groupBox2.Controls.Add(this.cmdGetMfrProducts);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 206);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requests";
            // 
            // cmdGetProductList
            // 
            this.cmdGetProductList.Location = new System.Drawing.Point(339, 112);
            this.cmdGetProductList.Name = "cmdGetProductList";
            this.cmdGetProductList.Size = new System.Drawing.Size(117, 23);
            this.cmdGetProductList.TabIndex = 15;
            this.cmdGetProductList.Text = "GET Product List";
            this.cmdGetProductList.UseVisualStyleBackColor = true;
            this.cmdGetProductList.Click += new System.EventHandler(this.CmdGetProductList_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(339, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 45);
            this.label9.TabIndex = 24;
            this.label9.Text = "1 GUID per line\r\nNo comma\'s \r\nor spaces";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prod IDs\r\nlist";
            // 
            // txtProdIdList
            // 
            this.txtProdIdList.Location = new System.Drawing.Point(62, 112);
            this.txtProdIdList.Multiline = true;
            this.txtProdIdList.Name = "txtProdIdList";
            this.txtProdIdList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProdIdList.Size = new System.Drawing.Size(271, 88);
            this.txtProdIdList.TabIndex = 15;
            this.txtProdIdList.Text = "0a646254-e0c1-df11-83ce-00304834ecff\r\n0d646254-e0c1-df11-83ce-00304834ecff";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "No GUID needed for this request";
            // 
            // cmdGetProduct
            // 
            this.cmdGetProduct.Location = new System.Drawing.Point(339, 81);
            this.cmdGetProduct.Name = "cmdGetProduct";
            this.cmdGetProduct.Size = new System.Drawing.Size(117, 23);
            this.cmdGetProduct.TabIndex = 21;
            this.cmdGetProduct.Text = "GET Product";
            this.cmdGetProduct.UseVisualStyleBackColor = true;
            this.cmdGetProduct.Click += new System.EventHandler(this.CmdProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Prod ID";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(62, 80);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(252, 23);
            this.txtProdId.TabIndex = 19;
            this.txtProdId.Text = "0a646254-e0c1-df11-83ce-00304834ecff";
            // 
            // cmdJsonExport
            // 
            this.cmdJsonExport.Location = new System.Drawing.Point(16, 349);
            this.cmdJsonExport.Name = "cmdJsonExport";
            this.cmdJsonExport.Size = new System.Drawing.Size(104, 39);
            this.cmdJsonExport.TabIndex = 14;
            this.cmdJsonExport.Text = "Export response to JSON file";
            this.cmdJsonExport.UseVisualStyleBackColor = true;
            this.cmdJsonExport.Click += new System.EventHandler(this.CmdJsonExport_Click);
            // 
            // cmdChooseMfr
            // 
            this.cmdChooseMfr.Location = new System.Drawing.Point(19, 279);
            this.cmdChooseMfr.Name = "cmdChooseMfr";
            this.cmdChooseMfr.Size = new System.Drawing.Size(88, 36);
            this.cmdChooseMfr.TabIndex = 15;
            this.cmdChooseMfr.Text = "Choose Mfr";
            this.cmdChooseMfr.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.cmdChooseMfr);
            this.Controls.Add(this.cmdJsonExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "productsAPI rest client";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxApiKeyType.ResumeLayout(false);
            this.groupBoxApiKeyType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAqKeyValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGetMfrBillingInfo;
        private System.Windows.Forms.Button cmdGetMfrProducts;
        private System.Windows.Forms.TextBox txtMfrId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdGetProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Button cmdJsonExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdIdList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdGetProductList;
        private System.Windows.Forms.GroupBox groupBoxApiKeyType;
        private System.Windows.Forms.RadioButton rdoCustomKey;
        private System.Windows.Forms.RadioButton rdoUsKey;
        private System.Windows.Forms.RadioButton rdoUkKey;
        private System.Windows.Forms.Button cmdChooseMfr;
    }
}

