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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filterResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterControl = new PcapVisualizer.FilterControl();
            this.visualizerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packegesDataGrid)).BeginInit();
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
            this.packegesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.packegesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packegesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packegesDataGrid.Location = new System.Drawing.Point(3, 38);
            this.packegesDataGrid.Name = "packegesDataGrid";
            this.packegesDataGrid.RowTemplate.Height = 24;
            this.packegesDataGrid.Size = new System.Drawing.Size(876, 120);
            this.packegesDataGrid.TabIndex = 1;
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
            this.filterControl.ViewModel = null;
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

    }
}

