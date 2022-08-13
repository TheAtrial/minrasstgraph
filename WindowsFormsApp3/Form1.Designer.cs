namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sheet = new System.Windows.Forms.PictureBox();
            this.VertexB = new System.Windows.Forms.Button();
            this.SelectB = new System.Windows.Forms.Button();
            this.EdgeB = new System.Windows.Forms.Button();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.AdjB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Shw = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(12, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(662, 570);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // VertexB
            // 
            this.VertexB.Location = new System.Drawing.Point(729, 130);
            this.VertexB.Name = "VertexB";
            this.VertexB.Size = new System.Drawing.Size(75, 23);
            this.VertexB.TabIndex = 1;
            this.VertexB.Text = "VertexB";
            this.VertexB.UseVisualStyleBackColor = true;
            this.VertexB.Click += new System.EventHandler(this.VertexB_Click);
            // 
            // SelectB
            // 
            this.SelectB.Location = new System.Drawing.Point(729, 84);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(75, 23);
            this.SelectB.TabIndex = 2;
            this.SelectB.Text = "SelectB";
            this.SelectB.UseVisualStyleBackColor = true;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // EdgeB
            // 
            this.EdgeB.Location = new System.Drawing.Point(729, 178);
            this.EdgeB.Name = "EdgeB";
            this.EdgeB.Size = new System.Drawing.Size(75, 23);
            this.EdgeB.TabIndex = 3;
            this.EdgeB.Text = "EdgeB";
            this.EdgeB.UseVisualStyleBackColor = true;
            this.EdgeB.Click += new System.EventHandler(this.EdgeB_Click);
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 16;
            this.listBoxMatrix.Location = new System.Drawing.Point(729, 294);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(260, 276);
            this.listBoxMatrix.TabIndex = 4;
            // 
            // AdjB
            // 
            this.AdjB.Location = new System.Drawing.Point(729, 230);
            this.AdjB.Name = "AdjB";
            this.AdjB.Size = new System.Drawing.Size(75, 23);
            this.AdjB.TabIndex = 5;
            this.AdjB.Text = "AdjB";
            this.AdjB.UseVisualStyleBackColor = true;
            this.AdjB.Click += new System.EventHandler(this.AdjB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(853, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            // 
            // Shw
            // 
            this.Shw.Location = new System.Drawing.Point(853, 253);
            this.Shw.Name = "Shw";
            this.Shw.Size = new System.Drawing.Size(75, 23);
            this.Shw.TabIndex = 7;
            this.Shw.Text = "Calculate";
            this.Shw.UseVisualStyleBackColor = true;
            this.Shw.Click += new System.EventHandler(this.Shw_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(853, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(853, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Минимальное расстояние";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Shw);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AdjB);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.EdgeB);
            this.Controls.Add(this.SelectB);
            this.Controls.Add(this.VertexB);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.Text = "Курсовой проект";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VertexB;
        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button EdgeB;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button AdjB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Shw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

