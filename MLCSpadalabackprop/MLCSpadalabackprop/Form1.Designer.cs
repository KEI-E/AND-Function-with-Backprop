namespace MLCSpadalabackprop
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
            this.makeneuralBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openWeights = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // makeneuralBtn
            // 
            this.makeneuralBtn.Location = new System.Drawing.Point(12, 12);
            this.makeneuralBtn.Name = "makeneuralBtn";
            this.makeneuralBtn.Size = new System.Drawing.Size(101, 23);
            this.makeneuralBtn.TabIndex = 0;
            this.makeneuralBtn.Text = "make neural net";
            this.makeneuralBtn.UseVisualStyleBackColor = true;
            this.makeneuralBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(12, 41);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(101, 23);
            this.trainBtn.TabIndex = 1;
            this.trainBtn.Text = "train network";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(138, 15);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(138, 44);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 3;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(259, 28);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 4;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(137, 75);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(101, 23);
            this.testBtn.TabIndex = 5;
            this.testBtn.Text = "test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(51, 104);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(101, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "save weights";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openWeights
            // 
            this.openWeights.Location = new System.Drawing.Point(212, 104);
            this.openWeights.Name = "openWeights";
            this.openWeights.Size = new System.Drawing.Size(101, 23);
            this.openWeights.TabIndex = 7;
            this.openWeights.Text = "open weights";
            this.openWeights.UseVisualStyleBackColor = true;
            this.openWeights.Click += new System.EventHandler(this.openWeights_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 138);
            this.Controls.Add(this.openWeights);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.makeneuralBtn);
            this.Name = "Form1";
            this.Text = "AND Function with Backprop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeneuralBtn;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openWeights;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

