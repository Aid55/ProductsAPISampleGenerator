
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
            this.cmdGetCustomProdIds = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomProdIds = new System.Windows.Forms.TextBox();
            this.cmdJsonExport = new System.Windows.Forms.Button();
            this.cmdChooseMfr = new System.Windows.Forms.Button();
            this.cmdChooseProds = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.cmdGetSelectedProducts = new System.Windows.Forms.Button();
            this.rdoUkKey = new System.Windows.Forms.RadioButton();
            this.rdoUsKey = new System.Windows.Forms.RadioButton();
            this.txtAqKeyValue = new System.Windows.Forms.TextBox();
            this.rdoCustomKey = new System.Windows.Forms.RadioButton();
            this.groupBoxApiKeyType = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdUncheckMfrs = new System.Windows.Forms.Button();
            this.cmdUncheckProducts = new System.Windows.Forms.Button();
            this.bgw_getMfrs = new System.ComponentModel.BackgroundWorker();
            this.bgw_getProds = new System.ComponentModel.BackgroundWorker();
            this.bgw_createJson = new System.ComponentModel.BackgroundWorker();
            this.bgw_getCustom = new System.ComponentModel.BackgroundWorker();
            this.groupBoxApiKeyType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(497, 182);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(270, 312);
            this.txtResponse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "Response:";
            // 
            // cmdGetCustomProdIds
            // 
            this.cmdGetCustomProdIds.Location = new System.Drawing.Point(299, 23);
            this.cmdGetCustomProdIds.Name = "cmdGetCustomProdIds";
            this.cmdGetCustomProdIds.Size = new System.Drawing.Size(82, 77);
            this.cmdGetCustomProdIds.TabIndex = 15;
            this.cmdGetCustomProdIds.Text = "GET data for custom Ids";
            this.cmdGetCustomProdIds.UseVisualStyleBackColor = true;
            this.cmdGetCustomProdIds.Click += new System.EventHandler(this.CmdGetCustomProdIds_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(25, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Add 1 GUID per line. No comma\'s or spaces";
            // 
            // txtCustomProdIds
            // 
            this.txtCustomProdIds.Location = new System.Drawing.Point(11, 22);
            this.txtCustomProdIds.Multiline = true;
            this.txtCustomProdIds.Name = "txtCustomProdIds";
            this.txtCustomProdIds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomProdIds.Size = new System.Drawing.Size(282, 74);
            this.txtCustomProdIds.TabIndex = 15;
            this.txtCustomProdIds.Text = "0a646254-e0c1-df11-83ce-00304834ecff\r\n0d646254-e0c1-df11-83ce-00304834ecff";
            // 
            // cmdJsonExport
            // 
            this.cmdJsonExport.Location = new System.Drawing.Point(497, 500);
            this.cmdJsonExport.Name = "cmdJsonExport";
            this.cmdJsonExport.Size = new System.Drawing.Size(270, 42);
            this.cmdJsonExport.TabIndex = 14;
            this.cmdJsonExport.Text = "Export response to json file";
            this.cmdJsonExport.UseVisualStyleBackColor = true;
            this.cmdJsonExport.Click += new System.EventHandler(this.CmdJsonExport_Click);
            // 
            // cmdChooseMfr
            // 
            this.cmdChooseMfr.Location = new System.Drawing.Point(12, 133);
            this.cmdChooseMfr.Name = "cmdChooseMfr";
            this.cmdChooseMfr.Size = new System.Drawing.Size(204, 28);
            this.cmdChooseMfr.TabIndex = 15;
            this.cmdChooseMfr.Text = "2. GET manufacturer list";
            this.cmdChooseMfr.UseVisualStyleBackColor = true;
            this.cmdChooseMfr.Click += new System.EventHandler(this.cmdChooseMfr_Click);
            // 
            // cmdChooseProds
            // 
            this.cmdChooseProds.Location = new System.Drawing.Point(221, 132);
            this.cmdChooseProds.Name = "cmdChooseProds";
            this.cmdChooseProds.Size = new System.Drawing.Size(269, 28);
            this.cmdChooseProds.TabIndex = 16;
            this.cmdChooseProds.Text = "3. GET prods for selected mfr";
            this.cmdChooseProds.UseVisualStyleBackColor = true;
            this.cmdChooseProds.Click += new System.EventHandler(this.cmdChooseProds_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 167);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(204, 346);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.HorizontalScrollbar = true;
            this.checkedListBox2.Location = new System.Drawing.Point(222, 167);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(269, 346);
            this.checkedListBox2.TabIndex = 18;
            // 
            // cmdGetSelectedProducts
            // 
            this.cmdGetSelectedProducts.Location = new System.Drawing.Point(491, 133);
            this.cmdGetSelectedProducts.Name = "cmdGetSelectedProducts";
            this.cmdGetSelectedProducts.Size = new System.Drawing.Size(270, 28);
            this.cmdGetSelectedProducts.TabIndex = 19;
            this.cmdGetSelectedProducts.Text = "4. GET sample data from selected products";
            this.cmdGetSelectedProducts.UseVisualStyleBackColor = true;
            this.cmdGetSelectedProducts.Click += new System.EventHandler(this.cmdGetSelectedProducts_Click);
            // 
            // rdoUkKey
            // 
            this.rdoUkKey.AutoSize = true;
            this.rdoUkKey.Checked = true;
            this.rdoUkKey.Location = new System.Drawing.Point(15, 24);
            this.rdoUkKey.Name = "rdoUkKey";
            this.rdoUkKey.Size = new System.Drawing.Size(102, 19);
            this.rdoUkKey.TabIndex = 0;
            this.rdoUkKey.TabStop = true;
            this.rdoUkKey.Text = "Default UK key";
            this.rdoUkKey.UseVisualStyleBackColor = true;
            // 
            // rdoUsKey
            // 
            this.rdoUsKey.AutoSize = true;
            this.rdoUsKey.Location = new System.Drawing.Point(15, 49);
            this.rdoUsKey.Name = "rdoUsKey";
            this.rdoUsKey.Size = new System.Drawing.Size(101, 19);
            this.rdoUsKey.TabIndex = 1;
            this.rdoUsKey.Text = "Default US key";
            this.rdoUsKey.UseVisualStyleBackColor = true;
            // 
            // txtAqKeyValue
            // 
            this.txtAqKeyValue.Location = new System.Drawing.Point(109, 73);
            this.txtAqKeyValue.Name = "txtAqKeyValue";
            this.txtAqKeyValue.Size = new System.Drawing.Size(225, 23);
            this.txtAqKeyValue.TabIndex = 6;
            // 
            // rdoCustomKey
            // 
            this.rdoCustomKey.AutoSize = true;
            this.rdoCustomKey.Location = new System.Drawing.Point(15, 74);
            this.rdoCustomKey.Name = "rdoCustomKey";
            this.rdoCustomKey.Size = new System.Drawing.Size(88, 19);
            this.rdoCustomKey.TabIndex = 2;
            this.rdoCustomKey.Text = "Custom key";
            this.rdoCustomKey.UseVisualStyleBackColor = true;
            // 
            // groupBoxApiKeyType
            // 
            this.groupBoxApiKeyType.Controls.Add(this.txtAqKeyValue);
            this.groupBoxApiKeyType.Controls.Add(this.rdoCustomKey);
            this.groupBoxApiKeyType.Controls.Add(this.rdoUkKey);
            this.groupBoxApiKeyType.Controls.Add(this.rdoUsKey);
            this.groupBoxApiKeyType.Location = new System.Drawing.Point(16, 12);
            this.groupBoxApiKeyType.Name = "groupBoxApiKeyType";
            this.groupBoxApiKeyType.Size = new System.Drawing.Size(358, 114);
            this.groupBoxApiKeyType.TabIndex = 13;
            this.groupBoxApiKeyType.TabStop = false;
            this.groupBoxApiKeyType.Text = "1. Choose the API key to use";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomProdIds);
            this.groupBox1.Controls.Add(this.cmdGetCustomProdIds);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(380, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 114);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternate: Build response from product Id List";
            // 
            // cmdUncheckMfrs
            // 
            this.cmdUncheckMfrs.Location = new System.Drawing.Point(12, 520);
            this.cmdUncheckMfrs.Name = "cmdUncheckMfrs";
            this.cmdUncheckMfrs.Size = new System.Drawing.Size(204, 22);
            this.cmdUncheckMfrs.TabIndex = 26;
            this.cmdUncheckMfrs.Text = "Uncheck all mfrs";
            this.cmdUncheckMfrs.UseVisualStyleBackColor = true;
            this.cmdUncheckMfrs.Click += new System.EventHandler(this.cmdUncheckMfrs_Click);
            // 
            // cmdUncheckProducts
            // 
            this.cmdUncheckProducts.Location = new System.Drawing.Point(222, 520);
            this.cmdUncheckProducts.Name = "cmdUncheckProducts";
            this.cmdUncheckProducts.Size = new System.Drawing.Size(269, 22);
            this.cmdUncheckProducts.TabIndex = 27;
            this.cmdUncheckProducts.Text = "Uncheck all products";
            this.cmdUncheckProducts.UseVisualStyleBackColor = true;
            this.cmdUncheckProducts.Click += new System.EventHandler(this.cmdUncheckProducts_Click);
            // 
            // bgw_getMfrs
            // 
            this.bgw_getMfrs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_getMfrs_DoWork);
            this.bgw_getMfrs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_getMfrs_RunWorkerCompleted);
            // 
            // bgw_getProds
            // 
            this.bgw_getProds.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_getProds_DoWork);
            this.bgw_getProds.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_getProds_RunWorkerCompleted);
            // 
            // bgw_createJson
            // 
            this.bgw_createJson.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_createJson_DoWork);
            this.bgw_createJson.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_createJson_RunWorkerCompleted);
            // 
            // bgw_getCustom
            // 
            this.bgw_getCustom.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_getCustom_DoWork);
            this.bgw_getCustom.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_getCustom_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 554);
            this.Controls.Add(this.cmdUncheckProducts);
            this.Controls.Add(this.cmdUncheckMfrs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdGetSelectedProducts);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cmdChooseProds);
            this.Controls.Add(this.cmdChooseMfr);
            this.Controls.Add(this.cmdJsonExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.groupBoxApiKeyType);
            this.Name = "MainForm";
            this.Text = "productsAPI rest client";
            this.groupBoxApiKeyType.ResumeLayout(false);
            this.groupBoxApiKeyType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdJsonExport;
        private System.Windows.Forms.TextBox txtCustomProdIds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdGetCustomProdIds;
        private System.Windows.Forms.Button cmdChooseMfr;
        private System.Windows.Forms.Button cmdChooseProds;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button cmdGetSelectedProducts;
        private System.Windows.Forms.RadioButton rdoUkKey;
        private System.Windows.Forms.RadioButton rdoUsKey;
        private System.Windows.Forms.TextBox txtAqKeyValue;
        private System.Windows.Forms.RadioButton rdoCustomKey;
        private System.Windows.Forms.GroupBox groupBoxApiKeyType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdUncheckMfrs;
        private System.Windows.Forms.Button cmdUncheckProducts;
        private System.ComponentModel.BackgroundWorker bgw_getMfrs;
        private System.ComponentModel.BackgroundWorker bgw_getProds;
        private System.ComponentModel.BackgroundWorker bgw_createJson;
        private System.ComponentModel.BackgroundWorker bgw_getCustom;
    }
}

