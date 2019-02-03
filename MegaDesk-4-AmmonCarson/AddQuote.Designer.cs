namespace MegaDesk_4_AmmonCarson
{
    partial class AddQuote
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
            this.btnCancelQuote = new System.Windows.Forms.Button();
            this.btnSubmitQuote = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelDesk = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfDrawers = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShipping = new System.Windows.Forms.Label();
            this.labelShippingDays = new System.Windows.Forms.Label();
            this.comboBoxShipping = new System.Windows.Forms.ComboBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelQuote
            // 
            this.btnCancelQuote.Location = new System.Drawing.Point(176, 367);
            this.btnCancelQuote.Name = "btnCancelQuote";
            this.btnCancelQuote.Size = new System.Drawing.Size(163, 45);
            this.btnCancelQuote.TabIndex = 0;
            this.btnCancelQuote.Text = "Cancel Quote";
            this.btnCancelQuote.UseVisualStyleBackColor = true;
            this.btnCancelQuote.Click += new System.EventHandler(this.btnCancelQuote_Click);
            // 
            // btnSubmitQuote
            // 
            this.btnSubmitQuote.Location = new System.Drawing.Point(482, 367);
            this.btnSubmitQuote.Name = "btnSubmitQuote";
            this.btnSubmitQuote.Size = new System.Drawing.Size(166, 45);
            this.btnSubmitQuote.TabIndex = 1;
            this.btnSubmitQuote.Text = "Submit Quote";
            this.btnSubmitQuote.UseVisualStyleBackColor = true;
            this.btnSubmitQuote.Click += new System.EventHandler(this.btnSubmitQuote_Click);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(546, 123);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 20);
            this.numWidth.TabIndex = 2;
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(546, 149);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(120, 20);
            this.numDepth.TabIndex = 3;
            this.numDepth.ValueChanged += new System.EventHandler(this.numDepth_ValueChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(504, 125);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Width";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(503, 149);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(36, 13);
            this.labelDepth.TabIndex = 5;
            this.labelDepth.Text = "Depth";
            // 
            // labelDesk
            // 
            this.labelDesk.AutoSize = true;
            this.labelDesk.Location = new System.Drawing.Point(570, 96);
            this.labelDesk.Name = "labelDesk";
            this.labelDesk.Size = new System.Drawing.Size(64, 13);
            this.labelDesk.TabIndex = 6;
            this.labelDesk.Text = "DESK INFO";
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(546, 175);
            this.numDrawers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(120, 20);
            this.numDrawers.TabIndex = 7;
            // 
            // labelNumberOfDrawers
            // 
            this.labelNumberOfDrawers.AutoSize = true;
            this.labelNumberOfDrawers.Location = new System.Drawing.Point(442, 177);
            this.labelNumberOfDrawers.Name = "labelNumberOfDrawers";
            this.labelNumberOfDrawers.Size = new System.Drawing.Size(98, 13);
            this.labelNumberOfDrawers.TabIndex = 8;
            this.labelNumberOfDrawers.Text = "Number of Drawers";
            this.labelNumberOfDrawers.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(546, 201);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Surface Material";
            // 
            // labelShipping
            // 
            this.labelShipping.AutoSize = true;
            this.labelShipping.Location = new System.Drawing.Point(560, 234);
            this.labelShipping.Name = "labelShipping";
            this.labelShipping.Size = new System.Drawing.Size(86, 13);
            this.labelShipping.TabIndex = 11;
            this.labelShipping.Text = "SHIPPING INFO";
            this.labelShipping.Click += new System.EventHandler(this.labelShipping_Click);
            // 
            // labelShippingDays
            // 
            this.labelShippingDays.AutoSize = true;
            this.labelShippingDays.Location = new System.Drawing.Point(466, 253);
            this.labelShippingDays.Name = "labelShippingDays";
            this.labelShippingDays.Size = new System.Drawing.Size(75, 13);
            this.labelShippingDays.TabIndex = 12;
            this.labelShippingDays.Text = "Shipping Days";
            // 
            // comboBoxShipping
            // 
            this.comboBoxShipping.FormattingEnabled = true;
            this.comboBoxShipping.Location = new System.Drawing.Point(548, 250);
            this.comboBoxShipping.Name = "comboBoxShipping";
            this.comboBoxShipping.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShipping.TabIndex = 13;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(546, 65);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(121, 20);
            this.textCustomerName.TabIndex = 14;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(459, 65);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 15;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelCustomerInfo
            // 
            this.labelCustomerInfo.AutoSize = true;
            this.labelCustomerInfo.Location = new System.Drawing.Point(560, 39);
            this.labelCustomerInfo.Name = "labelCustomerInfo";
            this.labelCustomerInfo.Size = new System.Drawing.Size(96, 13);
            this.labelCustomerInfo.TabIndex = 16;
            this.labelCustomerInfo.Text = "CUSTOMER INFO";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCustomerInfo);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.comboBoxShipping);
            this.Controls.Add(this.labelShippingDays);
            this.Controls.Add(this.labelShipping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelNumberOfDrawers);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.labelDesk);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.btnSubmitQuote);
            this.Controls.Add(this.btnCancelQuote);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelQuote;
        private System.Windows.Forms.Button btnSubmitQuote;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelDesk;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.Label labelNumberOfDrawers;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShipping;
        private System.Windows.Forms.Label labelShippingDays;
        private System.Windows.Forms.ComboBox comboBoxShipping;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerInfo;
    }
}