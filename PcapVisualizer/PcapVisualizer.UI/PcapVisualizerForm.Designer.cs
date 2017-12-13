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
            this.visualizerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.packegesDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filterControl = new PcapVisualizer.UI.FilterControl();
            this.sourceAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcePortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualizerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packegesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizerLayout
            // 
            this.visualizerLayout.ColumnCount = 1;
            this.visualizerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.visualizerLayout.Controls.Add(this.textBox2, 0, 3);
            this.visualizerLayout.Controls.Add(this.filterControl, 0, 0);
            this.visualizerLayout.Controls.Add(this.packegesDataGrid, 0, 1);
            this.visualizerLayout.Controls.Add(this.textBox1, 0, 2);
            this.visualizerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizerLayout.Location = new System.Drawing.Point(0, 0);
            this.visualizerLayout.Name = "visualizerLayout";
            this.visualizerLayout.RowCount = 4;
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.visualizerLayout.Size = new System.Drawing.Size(882, 414);
            this.visualizerLayout.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(876, 121);
            this.textBox2.TabIndex = 3;
            // 
            // packegesDataGrid
            // 
            this.packegesDataGrid.AllowUserToAddRows = false;
            this.packegesDataGrid.AllowUserToDeleteRows = false;
            this.packegesDataGrid.AutoGenerateColumns = false;
            this.packegesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.packegesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packegesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.sourceAdressDataGridViewTextBoxColumn,
            this.sourcePortDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.destinationAddressDataGridViewTextBoxColumn,
            this.destinationPortDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn});
            this.packegesDataGrid.DataSource = this.packetsBindingSource;
            this.packegesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packegesDataGrid.Location = new System.Drawing.Point(3, 38);
            this.packegesDataGrid.MultiSelect = false;
            this.packegesDataGrid.Name = "packegesDataGrid";
            this.packegesDataGrid.ReadOnly = true;
            this.packegesDataGrid.RowHeadersVisible = false;
            this.packegesDataGrid.RowTemplate.Height = 24;
            this.packegesDataGrid.RowTemplate.ReadOnly = true;
            this.packegesDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.packegesDataGrid.Size = new System.Drawing.Size(876, 120);
            this.packegesDataGrid.TabIndex = 1;
            // 
            // TimeStamp
            // 
            this.TimeStamp.DataPropertyName = "TimeStamp";
            this.TimeStamp.HeaderText = "Time";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            // 
            // packetsBindingSource
            // 
            this.packetsBindingSource.DataMember = "Packets";
            this.packetsBindingSource.DataSource = this.filterResultsBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(876, 120);
            this.textBox1.TabIndex = 2;
            // 
            // filterControl
            // 
            this.filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl.Location = new System.Drawing.Point(3, 3);
            this.filterControl.MaximumSize = new System.Drawing.Size(0, 30);
            this.filterControl.MinimumSize = new System.Drawing.Size(300, 30);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(876, 30);
            this.filterControl.TabIndex = 0;
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
            // filterResultsBindingSource
            // 
            this.filterResultsBindingSource.DataSource = typeof(PcapVisualizer.Presentation.ResultPacketsViewModel);
            // 
            // PcapVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 414);
            this.Controls.Add(this.visualizerLayout);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "PcapVisualizerForm";
            this.Text = "PcapVisualizerForm";
            this.visualizerLayout.ResumeLayout(false);
            this.visualizerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packegesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterResultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel visualizerLayout;
        private FilterControl filterControl;
        private System.Windows.Forms.DataGridView packegesDataGrid;
        private System.Windows.Forms.BindingSource filterResultsBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource packetsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcePortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;

    }
}