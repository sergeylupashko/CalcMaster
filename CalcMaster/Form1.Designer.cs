namespace CalcMaster
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
            this.level = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.oppanel = new System.Windows.Forms.Panel();
            this.res = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Label();
            this.cGood = new System.Windows.Forms.Label();
            this.cBad = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.oppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // level
            // 
            this.level.DisplayMember = "1";
            this.level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level.FormattingEnabled = true;
            this.level.Items.AddRange(new object[] {
            "1. результат в пределах десятка",
            "2. результат в пределах 20",
            "3. одно из слагаемых однозначное",
            "4. результат в пределах 100",
            "5. результат в пределах 200"});
            this.level.Location = new System.Drawing.Point(127, 12);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(240, 21);
            this.level.TabIndex = 0;
            this.level.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уровень сложности";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(388, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Старт";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // oppanel
            // 
            this.oppanel.Controls.Add(this.res);
            this.oppanel.Controls.Add(this.label5);
            this.oppanel.Controls.Add(this.op2);
            this.oppanel.Controls.Add(this.op);
            this.oppanel.Controls.Add(this.op1);
            this.oppanel.Location = new System.Drawing.Point(12, 51);
            this.oppanel.Name = "oppanel";
            this.oppanel.Size = new System.Drawing.Size(717, 125);
            this.oppanel.TabIndex = 3;
            this.oppanel.Visible = false;
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(523, 3);
            this.res.MaxLength = 3;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(175, 116);
            this.res.TabIndex = 12;
            this.res.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.res_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(437, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 108);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            // 
            // op2
            // 
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.op2.Location = new System.Drawing.Point(252, 6);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(204, 108);
            this.op2.TabIndex = 10;
            this.op2.Text = "000";
            this.op2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // op
            // 
            this.op.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.op.Location = new System.Drawing.Point(180, 6);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(101, 108);
            this.op.TabIndex = 9;
            this.op.Text = "+";
            this.op.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // op1
            // 
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.op1.Location = new System.Drawing.Point(5, 6);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(204, 108);
            this.op1.TabIndex = 8;
            this.op1.Text = "000";
            this.op1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cGood
            // 
            this.cGood.AutoSize = true;
            this.cGood.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cGood.ForeColor = System.Drawing.Color.Red;
            this.cGood.Location = new System.Drawing.Point(12, 210);
            this.cGood.Name = "cGood";
            this.cGood.Size = new System.Drawing.Size(63, 53);
            this.cGood.TabIndex = 4;
            this.cGood.Text = "J";
            // 
            // cBad
            // 
            this.cBad.AutoSize = true;
            this.cBad.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cBad.ForeColor = System.Drawing.Color.Blue;
            this.cBad.Location = new System.Drawing.Point(400, 210);
            this.cBad.Name = "cBad";
            this.cBad.Size = new System.Drawing.Size(63, 53);
            this.cBad.TabIndex = 5;
            this.cBad.Text = "L";
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGood.Location = new System.Drawing.Point(69, 210);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(51, 55);
            this.lblGood.TabIndex = 6;
            this.lblGood.Text = "0";
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBad.Location = new System.Drawing.Point(457, 210);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(51, 55);
            this.lblBad.TabIndex = 7;
            this.lblBad.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 273);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.cBad);
            this.Controls.Add(this.cGood);
            this.Controls.Add(this.oppanel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level);
            this.Name = "Form1";
            this.Text = "Вычислитель";
            this.oppanel.ResumeLayout(false);
            this.oppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel oppanel;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label cGood;
        private System.Windows.Forms.Label cBad;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblBad;
    }
}

