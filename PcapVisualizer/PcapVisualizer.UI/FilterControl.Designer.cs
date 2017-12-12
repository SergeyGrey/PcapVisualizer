namespace PcapVisualizer.UI
{
    partial class FilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.selectprotocolLabel = new System.Windows.Forms.Label();
            this.pcapFilePathTextbox = new System.Windows.Forms.TextBox();
            this.pcapFilePathLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.filterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.smallComboBox1 = new PcapVisualizer.UI.SmallComboBox();
            this._filterParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectprotocolLabel
            // 
            this.selectprotocolLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectprotocolLabel.AutoSize = true;
            this.selectprotocolLabel.Location = new System.Drawing.Point(373, 6);
            this.selectprotocolLabel.Name = "selectprotocolLabel";
            this.selectprotocolLabel.Size = new System.Drawing.Size(104, 17);
            this.selectprotocolLabel.TabIndex = 1;
            this.selectprotocolLabel.Text = "select protocol:";
            // 
            // pcapFilePathTextbox
            // 
            this.pcapFilePathTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcapFilePathTextbox.Location = new System.Drawing.Point(108, 3);
            this.pcapFilePathTextbox.Name = "pcapFilePathTextbox";
            this.pcapFilePathTextbox.ReadOnly = true;
            this.pcapFilePathTextbox.Size = new System.Drawing.Size(179, 22);
            this.pcapFilePathTextbox.TabIndex = 2;
            // 
            // pcapFilePathLabel
            // 
            this.pcapFilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcapFilePathLabel.AutoSize = true;
            this.pcapFilePathLabel.Location = new System.Drawing.Point(3, 6);
            this.pcapFilePathLabel.Name = "pcapFilePathLabel";
            this.pcapFilePathLabel.Size = new System.Drawing.Size(97, 17);
            this.pcapFilePathLabel.TabIndex = 1;
            this.pcapFilePathLabel.Text = "pcap file path:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(293, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filterLayout
            // 
            this.filterLayout.ColumnCount = 5;
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.filterLayout.Controls.Add(this.browseButton, 2, 0);
            this.filterLayout.Controls.Add(this.pcapFilePathTextbox, 1, 0);
            this.filterLayout.Controls.Add(this.selectprotocolLabel, 3, 0);
            this.filterLayout.Controls.Add(this.pcapFilePathLabel, 0, 0);
            this.filterLayout.Controls.Add(this.smallComboBox1, 4, 0);
            this.filterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterLayout.Location = new System.Drawing.Point(0, 0);
            this.filterLayout.Name = "filterLayout";
            this.filterLayout.RowCount = 1;
            this.filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterLayout.Size = new System.Drawing.Size(600, 30);
            this.filterLayout.TabIndex = 4;
            // 
            // smallComboBox1
            // 
            this.smallComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smallComboBox1.FormattingEnabled = true;
            this.smallComboBox1.Location = new System.Drawing.Point(483, 3);
            this.smallComboBox1.MySelectedIndex = -1;
            this.smallComboBox1.Name = "smallComboBox1";
            this.smallComboBox1.Size = new System.Drawing.Size(114, 24);
            this.smallComboBox1.TabIndex = 4;
            // 
            // _filterParametersBindingSource
            // 
            this._filterParametersBindingSource.DataSource = typeof(PcapVisualizer.Presentation.FilterParametersViewModel);
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterLayout);
            this.MaximumSize = new System.Drawing.Size(0, 30);
            this.MinimumSize = new System.Drawing.Size(600, 30);
            this.Name = "FilterControl";
            this.Size = new System.Drawing.Size(600, 30);
            this.filterLayout.ResumeLayout(false);
            this.filterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParametersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectprotocolLabel;
        private System.Windows.Forms.TextBox pcapFilePathTextbox;
        private System.Windows.Forms.Label pcapFilePathLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel filterLayout;
        private SmallComboBox smallComboBox1;
        private System.Windows.Forms.BindingSource _filterParametersBindingSource;
    }
}
