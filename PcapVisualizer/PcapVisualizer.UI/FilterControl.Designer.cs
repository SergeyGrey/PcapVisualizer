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
            this._selectProtocolLabel = new System.Windows.Forms.Label();
            this._pcapFilePathTextbox = new System.Windows.Forms.TextBox();
            this._pcapFilePathLabel = new System.Windows.Forms.Label();
            this._browseButton = new System.Windows.Forms.Button();
            this._filterLayout = new System.Windows.Forms.TableLayoutPanel();
            this._protocolSelectionComboBox = new PcapVisualizer.UI.SmallComboBox();
            this._filterParametersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._filterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParametersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _selectProtocolLabel
            // 
            this._selectProtocolLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectProtocolLabel.AutoSize = true;
            this._selectProtocolLabel.Location = new System.Drawing.Point(373, 6);
            this._selectProtocolLabel.Name = "_selectProtocolLabel";
            this._selectProtocolLabel.Size = new System.Drawing.Size(104, 17);
            this._selectProtocolLabel.TabIndex = 1;
            this._selectProtocolLabel.Text = "select protocol:";
            // 
            // _pcapFilePathTextbox
            // 
            this._pcapFilePathTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._filterParametersBindingSource, "SelectedFile", true));
            this._pcapFilePathTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pcapFilePathTextbox.Location = new System.Drawing.Point(108, 3);
            this._pcapFilePathTextbox.Name = "_pcapFilePathTextbox";
            this._pcapFilePathTextbox.ReadOnly = true;
            this._pcapFilePathTextbox.Size = new System.Drawing.Size(179, 22);
            this._pcapFilePathTextbox.TabIndex = 2;
            // 
            // _pcapFilePathLabel
            // 
            this._pcapFilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._pcapFilePathLabel.AutoSize = true;
            this._pcapFilePathLabel.Location = new System.Drawing.Point(3, 6);
            this._pcapFilePathLabel.Name = "_pcapFilePathLabel";
            this._pcapFilePathLabel.Size = new System.Drawing.Size(97, 17);
            this._pcapFilePathLabel.TabIndex = 1;
            this._pcapFilePathLabel.Text = "pcap file path:";
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(293, 3);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(74, 23);
            this._browseButton.TabIndex = 3;
            this._browseButton.Text = "browse";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // _filterLayout
            // 
            this._filterLayout.ColumnCount = 5;
            this._filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this._filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this._filterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this._filterLayout.Controls.Add(this._browseButton, 2, 0);
            this._filterLayout.Controls.Add(this._pcapFilePathTextbox, 1, 0);
            this._filterLayout.Controls.Add(this._selectProtocolLabel, 3, 0);
            this._filterLayout.Controls.Add(this._pcapFilePathLabel, 0, 0);
            this._filterLayout.Controls.Add(this._protocolSelectionComboBox, 4, 0);
            this._filterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._filterLayout.Location = new System.Drawing.Point(0, 0);
            this._filterLayout.Name = "_filterLayout";
            this._filterLayout.RowCount = 1;
            this._filterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._filterLayout.Size = new System.Drawing.Size(600, 30);
            this._filterLayout.TabIndex = 4;
            // 
            // _protocolSelectionComboBox
            // 
            this._protocolSelectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("MySelectedIndex", this._filterParametersBindingSource, "SelectedProtocolState", true));
            this._protocolSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._protocolSelectionComboBox.FormattingEnabled = true;
            this._protocolSelectionComboBox.Items.AddRange(new object[] {
            "All",
            "Ethernet",
            "TCP",
            "UDP",
            "ICMP",
            "HTTP"});
            this._protocolSelectionComboBox.Location = new System.Drawing.Point(483, 3);
            this._protocolSelectionComboBox.MySelectedIndex = 0;
            this._protocolSelectionComboBox.Name = "_protocolSelectionComboBox";
            this._protocolSelectionComboBox.Size = new System.Drawing.Size(114, 24);
            this._protocolSelectionComboBox.TabIndex = 4;
            // 
            // _filterParametersBindingSource
            // 
            this._filterParametersBindingSource.DataSource = typeof(PcapVisualizer.Presentation.FilterParametersViewModel);
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._filterLayout);
            this.MaximumSize = new System.Drawing.Size(0, 30);
            this.MinimumSize = new System.Drawing.Size(600, 30);
            this.Name = "FilterControl";
            this.Size = new System.Drawing.Size(600, 30);
            this._filterLayout.ResumeLayout(false);
            this._filterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterParametersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _selectProtocolLabel;
        private System.Windows.Forms.TextBox _pcapFilePathTextbox;
        private System.Windows.Forms.Label _pcapFilePathLabel;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.TableLayoutPanel _filterLayout;
        private SmallComboBox _protocolSelectionComboBox;
        private System.Windows.Forms.BindingSource _filterParametersBindingSource;
    }
}
