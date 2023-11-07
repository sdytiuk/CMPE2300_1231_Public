namespace Demo_LL_Dictionary
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumberToAdd = new System.Windows.Forms.TextBox();
            this.txtNumberLookingFor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDictionaryWords = new System.Windows.Forms.ListBox();
            this.txtDict1 = new System.Windows.Forms.TextBox();
            this.txtDict2 = new System.Windows.Forms.TextBox();
            this.btnAddDict = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 186);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddNumberAfter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumberToAdd
            // 
            this.txtNumberToAdd.Location = new System.Drawing.Point(355, 55);
            this.txtNumberToAdd.Name = "txtNumberToAdd";
            this.txtNumberToAdd.Size = new System.Drawing.Size(100, 20);
            this.txtNumberToAdd.TabIndex = 2;
            // 
            // txtNumberLookingFor
            // 
            this.txtNumberLookingFor.Location = new System.Drawing.Point(355, 110);
            this.txtNumberLookingFor.Name = "txtNumberLookingFor";
            this.txtNumberLookingFor.Size = new System.Drawing.Size(100, 20);
            this.txtNumberLookingFor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick a number to add after the number entered below the button:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Now presenting the DICTIONARY:";
            // 
            // lbDictionaryWords
            // 
            this.lbDictionaryWords.FormattingEnabled = true;
            this.lbDictionaryWords.Location = new System.Drawing.Point(16, 276);
            this.lbDictionaryWords.Name = "lbDictionaryWords";
            this.lbDictionaryWords.Size = new System.Drawing.Size(201, 147);
            this.lbDictionaryWords.TabIndex = 6;
            this.lbDictionaryWords.SelectedIndexChanged += new System.EventHandler(this.lbDictionaryWords_SelectedIndexChanged);
            // 
            // txtDict1
            // 
            this.txtDict1.Location = new System.Drawing.Point(544, 250);
            this.txtDict1.Name = "txtDict1";
            this.txtDict1.Size = new System.Drawing.Size(234, 20);
            this.txtDict1.TabIndex = 7;
            // 
            // txtDict2
            // 
            this.txtDict2.Location = new System.Drawing.Point(544, 285);
            this.txtDict2.Multiline = true;
            this.txtDict2.Name = "txtDict2";
            this.txtDict2.Size = new System.Drawing.Size(234, 95);
            this.txtDict2.TabIndex = 8;
            // 
            // btnAddDict
            // 
            this.btnAddDict.Location = new System.Drawing.Point(544, 386);
            this.btnAddDict.Name = "btnAddDict";
            this.btnAddDict.Size = new System.Drawing.Size(234, 23);
            this.btnAddDict.TabIndex = 9;
            this.btnAddDict.Text = "Add To Dictionary";
            this.btnAddDict.UseVisualStyleBackColor = true;
            this.btnAddDict.Click += new System.EventHandler(this.btnAddDict_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Definition";
            // 
            // lblDefinition
            // 
            this.lblDefinition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDefinition.Location = new System.Drawing.Point(245, 276);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(226, 147);
            this.lblDefinition.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Display Dictionary To Console";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddDict);
            this.Controls.Add(this.txtDict2);
            this.Controls.Add(this.txtDict1);
            this.Controls.Add(this.lbDictionaryWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberLookingFor);
            this.Controls.Add(this.txtNumberToAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumberToAdd;
        private System.Windows.Forms.TextBox txtNumberLookingFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDictionaryWords;
        private System.Windows.Forms.TextBox txtDict1;
        private System.Windows.Forms.TextBox txtDict2;
        private System.Windows.Forms.Button btnAddDict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Button button2;
    }
}

