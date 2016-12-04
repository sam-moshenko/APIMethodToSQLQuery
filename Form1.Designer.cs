namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.listInputs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSQLColumn = new System.Windows.Forms.TextBox();
            this.txtInputParam = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL for parsing:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(15, 25);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(341, 20);
            this.txtURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Method:";
            // 
            // comboMethod
            // 
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboMethod.Location = new System.Drawing.Point(15, 65);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(121, 21);
            this.comboMethod.TabIndex = 3;
            // 
            // listInputs
            // 
            this.listInputs.FormattingEnabled = true;
            this.listInputs.Location = new System.Drawing.Point(16, 167);
            this.listInputs.Name = "listInputs";
            this.listInputs.Size = new System.Drawing.Size(339, 95);
            this.listInputs.TabIndex = 4;
            this.listInputs.SelectedIndexChanged += new System.EventHandler(this.listInputs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input params:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(142, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Corresponding SQL name of columns:";
            // 
            // txtSQLColumn
            // 
            this.txtSQLColumn.Location = new System.Drawing.Point(145, 127);
            this.txtSQLColumn.Name = "txtSQLColumn";
            this.txtSQLColumn.Size = new System.Drawing.Size(98, 20);
            this.txtSQLColumn.TabIndex = 8;
            // 
            // txtInputParam
            // 
            this.txtInputParam.Location = new System.Drawing.Point(16, 127);
            this.txtInputParam.Name = "txtInputParam";
            this.txtInputParam.Size = new System.Drawing.Size(112, 20);
            this.txtInputParam.TabIndex = 9;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(302, 124);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(54, 23);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddInput_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(145, 304);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(202, 66);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(154, 20);
            this.txtTableName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Table name:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(280, 268);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 16;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApplication2.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 339);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtInputParam);
            this.Controls.Add(this.txtSQLColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listInputs);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Convert API method to SQL table";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.ListBox listInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSQLColumn;
        private System.Windows.Forms.TextBox txtInputParam;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
    }
}

