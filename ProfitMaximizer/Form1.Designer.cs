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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRoulette = new System.Windows.Forms.RadioButton();
            this.radDiceRoll = new System.Windows.Forms.RadioButton();
            this.lblProfitTarget = new System.Windows.Forms.Label();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.resultsView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diceCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.diceFaceCount = new System.Windows.Forms.NumericUpDown();
            this.pnlDice = new System.Windows.Forms.Panel();
            this.pnlRoulette = new System.Windows.Forms.Panel();
            this.blackCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.redCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.whiteCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblMachineList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFaceCount)).BeginInit();
            this.pnlDice.SuspendLayout();
            this.pnlRoulette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteCount)).BeginInit();
            this.SuspendLayout();
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
            // lblMachineList
            // 
            lblMachineList.AutoSize = true;
            lblMachineList.Location = new System.Drawing.Point(7, 20);
            lblMachineList.Name = "lblMachineList";
            lblMachineList.Size = new System.Drawing.Size(95, 13);
            lblMachineList.TabIndex = 1;
            lblMachineList.Text = "Gambling Machine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlRoulette);
            this.groupBox1.Controls.Add(this.pnlDice);
            this.groupBox1.Controls.Add(this.radRoulette);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radDiceRoll);
            this.groupBox1.Controls.Add(this.lblProfitTarget);
            this.groupBox1.Controls.Add(this.btnAnalyse);
            this.groupBox1.Controls.Add(lblMachineList);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 443);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radRoulette
            // 
            this.radRoulette.AutoSize = true;
            this.radRoulette.Location = new System.Drawing.Point(5, 130);
            this.radRoulette.Name = "radRoulette";
            this.radRoulette.Size = new System.Drawing.Size(65, 17);
            this.radRoulette.TabIndex = 7;
            this.radRoulette.Text = "Roulette";
            this.radRoulette.UseVisualStyleBackColor = true;
            // 
            // radDiceRoll
            // 
            this.radDiceRoll.AutoSize = true;
            this.radDiceRoll.Checked = true;
            this.radDiceRoll.Location = new System.Drawing.Point(6, 36);
            this.radDiceRoll.Name = "radDiceRoll";
            this.radDiceRoll.Size = new System.Drawing.Size(68, 17);
            this.radDiceRoll.TabIndex = 6;
            this.radDiceRoll.TabStop = true;
            this.radDiceRoll.Text = "Dice Roll";
            this.radDiceRoll.UseVisualStyleBackColor = true;
            // 
            // lblProfitTarget
            // 
            this.lblProfitTarget.AutoSize = true;
            this.lblProfitTarget.Location = new System.Drawing.Point(282, 144);
            this.lblProfitTarget.Name = "lblProfitTarget";
            this.lblProfitTarget.Size = new System.Drawing.Size(0, 13);
            this.lblProfitTarget.TabIndex = 5;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(203, 404);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Die Faces per Dice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Dice";
            // 
            // diceCount
            // 
            this.diceCount.Location = new System.Drawing.Point(105, 8);
            this.diceCount.Name = "diceCount";
            this.diceCount.Size = new System.Drawing.Size(120, 20);
            this.diceCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Die Faces per Dice";
            // 
            // diceFaceCount
            // 
            this.diceFaceCount.Location = new System.Drawing.Point(105, 34);
            this.diceFaceCount.Name = "diceFaceCount";
            this.diceFaceCount.Size = new System.Drawing.Size(120, 20);
            this.diceFaceCount.TabIndex = 13;
            // 
            // pnlDice
            // 
            this.pnlDice.Controls.Add(this.label1);
            this.pnlDice.Controls.Add(this.label5);
            this.pnlDice.Controls.Add(this.diceFaceCount);
            this.pnlDice.Controls.Add(this.label3);
            this.pnlDice.Controls.Add(this.diceCount);
            this.pnlDice.Controls.Add(this.label6);
            this.pnlDice.Location = new System.Drawing.Point(10, 59);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(266, 65);
            this.pnlDice.TabIndex = 15;
            // 
            // pnlRoulette
            // 
            this.pnlRoulette.Controls.Add(this.blackCount);
            this.pnlRoulette.Controls.Add(this.label9);
            this.pnlRoulette.Controls.Add(this.redCount);
            this.pnlRoulette.Controls.Add(this.label10);
            this.pnlRoulette.Controls.Add(this.whiteCount);
            this.pnlRoulette.Controls.Add(this.label11);
            this.pnlRoulette.Location = new System.Drawing.Point(10, 153);
            this.pnlRoulette.Name = "pnlRoulette";
            this.pnlRoulette.Size = new System.Drawing.Size(210, 90);
            this.pnlRoulette.TabIndex = 16;
            // 
            // blackCount
            // 
            this.blackCount.Location = new System.Drawing.Point(77, 33);
            this.blackCount.Name = "blackCount";
            this.blackCount.Size = new System.Drawing.Size(120, 20);
            this.blackCount.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Black";
            // 
            // redCount
            // 
            this.redCount.Location = new System.Drawing.Point(77, 59);
            this.redCount.Name = "redCount";
            this.redCount.Size = new System.Drawing.Size(120, 20);
            this.redCount.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Red";
            // 
            // whiteCount
            // 
            this.whiteCount.Location = new System.Drawing.Point(77, 7);
            this.whiteCount.Name = "whiteCount";
            this.whiteCount.Size = new System.Drawing.Size(120, 20);
            this.whiteCount.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "White";
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
            ((System.ComponentModel.ISupportInitialize)(this.resultsView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFaceCount)).EndInit();
            this.pnlDice.ResumeLayout(false);
            this.pnlDice.PerformLayout();
            this.pnlRoulette.ResumeLayout(false);
            this.pnlRoulette.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.DataGridView resultsView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProfitTarget;
        private System.Windows.Forms.RadioButton radRoulette;
        private System.Windows.Forms.RadioButton radDiceRoll;
        private System.Windows.Forms.Panel pnlRoulette;
        private System.Windows.Forms.Panel pnlDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown diceFaceCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown diceCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown blackCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown redCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown whiteCount;
        private System.Windows.Forms.Label label11;
    }
}

