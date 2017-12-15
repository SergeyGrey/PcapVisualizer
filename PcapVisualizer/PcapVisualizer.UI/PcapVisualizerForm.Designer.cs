using PcapVisualizer.Presentation;

namespace PcapVisualizer.UI
{
    partial class PcapVisualizerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._visualizerLayout = new System.Windows.Forms.TableLayoutPanel();
            this._dataTextBox = new System.Windows.Forms.TextBox();
            this._filterResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._filterControl = new FilterControl();
            this._packetsDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcePortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._packetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._headerTextBox = new System.Windows.Forms.TextBox();
            this._visualizerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._packetsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._packetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _visualizerLayout
            // 
            this._visualizerLayout.ColumnCount = 1;
            this._visualizerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._visualizerLayout.Controls.Add(this._dataTextBox, 0, 3);
            this._visualizerLayout.Controls.Add(this._filterControl, 0, 0);
            this._visualizerLayout.Controls.Add(this._packetsDataGrid, 0, 1);
            this._visualizerLayout.Controls.Add(this._headerTextBox, 0, 2);
            this._visualizerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._visualizerLayout.Location = new System.Drawing.Point(0, 0);
            this._visualizerLayout.Name = "_visualizerLayout";
            this._visualizerLayout.RowCount = 4;
            this._visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._visualizerLayout.Size = new System.Drawing.Size(882, 414);
            this._visualizerLayout.TabIndex = 0;
            // 
            // _dataTextBox
            // 
            this._dataTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._filterResultsBindingSource, "CurrentData", true));
            this._dataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._dataTextBox.Location = new System.Drawing.Point(3, 290);
            this._dataTextBox.Multiline = true;
            this._dataTextBox.Name = "_dataTextBox";
            this._dataTextBox.ReadOnly = true;
            this._dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._dataTextBox.Size = new System.Drawing.Size(876, 121);
            this._dataTextBox.TabIndex = 3;
            // 
            // _filterResultsBindingSource
            // 
            this._filterResultsBindingSource.DataSource = typeof(ResultPacketsViewModel);
            // 
            // _filterControl
            // 
            this._filterControl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._filterControl.Location = new System.Drawing.Point(3, 3);
            this._filterControl.MaximumSize = new System.Drawing.Size(0, 30);
            this._filterControl.MinimumSize = new System.Drawing.Size(300, 30);
            this._filterControl.Name = "_filterControl";
            this._filterControl.Size = new System.Drawing.Size(876, 30);
            this._filterControl.TabIndex = 0;
            // 
            // _packetsDataGrid
            // 
            this._packetsDataGrid.AllowUserToAddRows = false;
            this._packetsDataGrid.AllowUserToDeleteRows = false;
            this._packetsDataGrid.AutoGenerateColumns = false;
            this._packetsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this._packetsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._packetsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.sourceAdressDataGridViewTextBoxColumn,
            this.sourcePortDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.destinationAddressDataGridViewTextBoxColumn,
            this.destinationPortDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn});
            this._packetsDataGrid.DataSource = this._packetsBindingSource;
            this._packetsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._packetsDataGrid.EnableHeadersVisualStyles = false;
            this._packetsDataGrid.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this._packetsDataGrid.Location = new System.Drawing.Point(3, 38);
            this._packetsDataGrid.MultiSelect = false;
            this._packetsDataGrid.Name = "_packetsDataGrid";
            this._packetsDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._packetsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._packetsDataGrid.RowHeadersVisible = false;
            this._packetsDataGrid.RowTemplate.Height = 24;
            this._packetsDataGrid.RowTemplate.ReadOnly = true;
            this._packetsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._packetsDataGrid.Size = new System.Drawing.Size(876, 120);
            this._packetsDataGrid.TabIndex = 1;
            // 
            // TimeStamp
            // 
            this.TimeStamp.DataPropertyName = "TimeStamp";
            this.TimeStamp.HeaderText = "Time";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            // 
            // sourceAdressDataGridViewTextBoxColumn
            // 
            this.sourceAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sourceAdressDataGridViewTextBoxColumn.DataPropertyName = "SourceAdress";
            this.sourceAdressDataGridViewTextBoxColumn.HeaderText = "Source adress";
            this.sourceAdressDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.sourceAdressDataGridViewTextBoxColumn.Name = "sourceAdressDataGridViewTextBoxColumn";
            this.sourceAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourcePortDataGridViewTextBoxColumn
            // 
            this.sourcePortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sourcePortDataGridViewTextBoxColumn.DataPropertyName = "SourcePort";
            this.sourcePortDataGridViewTextBoxColumn.HeaderText = "Source port";
            this.sourcePortDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.sourcePortDataGridViewTextBoxColumn.Name = "sourcePortDataGridViewTextBoxColumn";
            this.sourcePortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "Protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "Protocol";
            this.protocolDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationAddressDataGridViewTextBoxColumn
            // 
            this.destinationAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationAddressDataGridViewTextBoxColumn.DataPropertyName = "DestinationAddress";
            this.destinationAddressDataGridViewTextBoxColumn.HeaderText = "Destination address";
            this.destinationAddressDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.destinationAddressDataGridViewTextBoxColumn.Name = "destinationAddressDataGridViewTextBoxColumn";
            this.destinationAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationPortDataGridViewTextBoxColumn
            // 
            this.destinationPortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationPortDataGridViewTextBoxColumn.DataPropertyName = "DestinationPort";
            this.destinationPortDataGridViewTextBoxColumn.HeaderText = "Destination port";
            this.destinationPortDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.destinationPortDataGridViewTextBoxColumn.Name = "destinationPortDataGridViewTextBoxColumn";
            this.destinationPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _packetsBindingSource
            // 
            this._packetsBindingSource.DataMember = "Packets";
            this._packetsBindingSource.DataSource = this._filterResultsBindingSource;
            // 
            // _headerTextBox
            // 
            this._headerTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._headerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._filterResultsBindingSource, "CurrentHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._headerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._headerTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._headerTextBox.Location = new System.Drawing.Point(3, 164);
            this._headerTextBox.Multiline = true;
            this._headerTextBox.Name = "_headerTextBox";
            this._headerTextBox.ReadOnly = true;
            this._headerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._headerTextBox.Size = new System.Drawing.Size(876, 120);
            this._headerTextBox.TabIndex = 2;
            // 
            // PcapVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 414);
            this.Controls.Add(this._visualizerLayout);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "PcapVisualizerForm";
            this.Text = "PcapVisualizerForm";
            this._visualizerLayout.ResumeLayout(false);
            this._visualizerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._filterResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._packetsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._packetsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _visualizerLayout;
        private FilterControl _filterControl;
        private System.Windows.Forms.DataGridView _packetsDataGrid;
        private System.Windows.Forms.BindingSource _filterResultsBindingSource;
        private System.Windows.Forms.TextBox _dataTextBox;
        private System.Windows.Forms.TextBox _headerTextBox;
        private System.Windows.Forms.BindingSource _packetsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcePortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
    }
}