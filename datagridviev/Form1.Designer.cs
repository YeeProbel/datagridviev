namespace datagridviev
{
    partial class аrmMass
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.cmdStat = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(29, 46);
            this.txtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(205, 30);
            this.txtn.TabIndex = 0;
            this.txtn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество строк n=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество строк m=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(29, 143);
            this.txtm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(205, 30);
            this.txtm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат:";
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(29, 231);
            this.txtRez.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(296, 122);
            this.txtRez.TabIndex = 5;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(332, 12);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(426, 341);
            this.dgvMass.TabIndex = 6;
            // 
            // cmdStat
            // 
            this.cmdStat.Location = new System.Drawing.Point(29, 371);
            this.cmdStat.Name = "cmdStat";
            this.cmdStat.Size = new System.Drawing.Size(217, 33);
            this.cmdStat.TabIndex = 7;
            this.cmdStat.Text = "Вычислить";
            this.cmdStat.UseVisualStyleBackColor = true;
            this.cmdStat.Click += new System.EventHandler(this.cmdStat_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(290, 371);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(217, 33);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Очистка полей";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(541, 371);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(217, 33);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "Завершить работу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // аrmMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 416);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdStat);
            this.Controls.Add(this.dgvMass);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "аrmMass";
            this.Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button cmdStat;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExit;
    }
}

