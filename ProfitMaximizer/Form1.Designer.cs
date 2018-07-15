namespace ProfitMaximizer
{
    partial class Form1
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
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblMachineList;
            this.lstMachines = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profitTarget = new System.Windows.Forms.TrackBar();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.resultsView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProfitTarget = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblMachineList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMachines
            // 
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.Location = new System.Drawing.Point(6, 36);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.Size = new System.Drawing.Size(322, 173);
            this.lstMachines.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.Location = new System.Drawing.Point(13, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(166, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Profit Maximizer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfitTarget);
            this.groupBox1.Controls.Add(this.btnAnalyse);
            this.groupBox1.Controls.Add(this.profitTarget);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(lblMachineList);
            this.groupBox1.Controls.Add(this.lstMachines);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 443);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblMachineList
            // 
            lblMachineList.AutoSize = true;
            lblMachineList.Location = new System.Drawing.Point(7, 20);
            lblMachineList.Name = "lblMachineList";
            lblMachineList.Size = new System.Drawing.Size(95, 13);
            lblMachineList.TabIndex = 1;
            lblMachineList.Text = "Gambling Machine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target Profit %";
            // 
            // profitTarget
            // 
            this.profitTarget.Location = new System.Drawing.Point(7, 233);
            this.profitTarget.Maximum = 20;
            this.profitTarget.Name = "profitTarget";
            this.profitTarget.Size = new System.Drawing.Size(321, 45);
            this.profitTarget.TabIndex = 3;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(202, 285);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(125, 33);
            this.btnAnalyse.TabIndex = 4;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // resultsView
            // 
            this.resultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsView.Location = new System.Drawing.Point(3, 16);
            this.resultsView.Name = "resultsView";
            this.resultsView.Size = new System.Drawing.Size(427, 424);
            this.resultsView.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultsView);
            this.groupBox2.Location = new System.Drawing.Point(354, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 443);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblProfitTarget
            // 
            this.lblProfitTarget.AutoSize = true;
            this.lblProfitTarget.Location = new System.Drawing.Point(291, 216);
            this.lblProfitTarget.Name = "lblProfitTarget";
            this.lblProfitTarget.Size = new System.Drawing.Size(0, 13);
            this.lblProfitTarget.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(lblTitle);
            this.Name = "Form1";
            this.Text = "Profit Maximizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMachines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.TrackBar profitTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultsView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProfitTarget;
    }
}

