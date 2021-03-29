
namespace productsAPIClient
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAqKeyName = new System.Windows.Forms.TextBox();
            this.txtAqKeyValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdMfrBillingInfo = new System.Windows.Forms.Button();
            this.cmdMfrProducts = new System.Windows.Forms.Button();
            this.txtMfrId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(144, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(523, 23);
            this.txtUrl.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(169, 302);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(625, 248);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(698, 30);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(98, 23);
            this.cmdSend.TabIndex = 2;
            this.cmdSend.Text = "Send Request";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // txtAqKeyName
            // 
            this.txtAqKeyName.Location = new System.Drawing.Point(132, 26);
            this.txtAqKeyName.Name = "txtAqKeyName";
            this.txtAqKeyName.Size = new System.Drawing.Size(229, 23);
            this.txtAqKeyName.TabIndex = 5;
            this.txtAqKeyName.Text = "ocp-apim-subscription-key";
            // 
            // txtAqKeyValue
            // 
            this.txtAqKeyValue.Location = new System.Drawing.Point(522, 26);
            this.txtAqKeyValue.Name = "txtAqKeyValue";
            this.txtAqKeyValue.Size = new System.Drawing.Size(229, 23);
            this.txtAqKeyValue.TabIndex = 6;
            this.txtAqKeyValue.Text = "931203a189534d8e849b0666704cf1ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key Value";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAqKeyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAqKeyValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AQ API Key";
            // 
            // cmdMfrBillingInfo
            // 
            this.cmdMfrBillingInfo.Location = new System.Drawing.Point(46, 22);
            this.cmdMfrBillingInfo.Name = "cmdMfrBillingInfo";
            this.cmdMfrBillingInfo.Size = new System.Drawing.Size(215, 23);
            this.cmdMfrBillingInfo.TabIndex = 15;
            this.cmdMfrBillingInfo.Text = "Create Mfr Billing Info Request URI";
            this.cmdMfrBillingInfo.UseVisualStyleBackColor = true;
            this.cmdMfrBillingInfo.Click += new System.EventHandler(this.cmdMfrBillingInfo_Click);
            // 
            // cmdMfrProducts
            // 
            this.cmdMfrProducts.Location = new System.Drawing.Point(46, 51);
            this.cmdMfrProducts.Name = "cmdMfrProducts";
            this.cmdMfrProducts.Size = new System.Drawing.Size(215, 23);
            this.cmdMfrProducts.TabIndex = 16;
            this.cmdMfrProducts.Text = "Create Mfr Products Request URI";
            this.cmdMfrProducts.UseVisualStyleBackColor = true;
            this.cmdMfrProducts.Click += new System.EventHandler(this.cmdMfrProducts_Click);
            // 
            // txtMfrId
            // 
            this.txtMfrId.Location = new System.Drawing.Point(396, 51);
            this.txtMfrId.Name = "txtMfrId";
            this.txtMfrId.Size = new System.Drawing.Size(278, 23);
            this.txtMfrId.TabIndex = 17;
            this.txtMfrId.Text = "a38ad2af-7550-dd11-b5fb-00188bb07921";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mfr ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProdId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdMfrBillingInfo);
            this.groupBox2.Controls.Add(this.txtMfrId);
            this.groupBox2.Controls.Add(this.cmdMfrProducts);
            this.groupBox2.Location = new System.Drawing.Point(16, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "URI creation";
            // 
            // cmdProduct
            // 
            this.cmdProduct.Location = new System.Drawing.Point(46, 81);
            this.cmdProduct.Name = "cmdProduct";
            this.cmdProduct.Size = new System.Drawing.Size(215, 23);
            this.cmdProduct.TabIndex = 21;
            this.cmdProduct.Text = "Create Product Request URI";
            this.cmdProduct.UseVisualStyleBackColor = true;
            this.cmdProduct.Click += new System.EventHandler(this.cmdProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product ID";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(396, 81);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(278, 23);
            this.txtProdId.TabIndex = 19;
            this.txtProdId.Text = "0a646254-e0c1-df11-83ce-00304834ecff";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSend);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "productsAPI rest client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAqKeyName;
        private System.Windows.Forms.TextBox txtAqKeyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdMfrBillingInfo;
        private System.Windows.Forms.Button cmdMfrProducts;
        private System.Windows.Forms.TextBox txtMfrId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdId;
    }
}

