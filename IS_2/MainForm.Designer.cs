namespace IS_2
{
    partial class MainForm
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
            this.label_Var = new System.Windows.Forms.Label();
            this.label_Executor = new System.Windows.Forms.Label();
            this.label_Group = new System.Windows.Forms.Label();
            this.button_About = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_Algo = new System.Windows.Forms.Label();
            this.button_Culс = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Var
            // 
            this.label_Var.AutoSize = true;
            this.label_Var.Location = new System.Drawing.Point(12, 9);
            this.label_Var.Name = "label_Var";
            this.label_Var.Size = new System.Drawing.Size(78, 13);
            this.label_Var.TabIndex = 0;
            this.label_Var.Text = "Вариант: №11";
            // 
            // label_Executor
            // 
            this.label_Executor.AutoSize = true;
            this.label_Executor.Location = new System.Drawing.Point(12, 22);
            this.label_Executor.Name = "label_Executor";
            this.label_Executor.Size = new System.Drawing.Size(124, 13);
            this.label_Executor.TabIndex = 1;
            this.label_Executor.Text = "Выполнил: Крутов М.В.";
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(12, 35);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(91, 13);
            this.label_Group.TabIndex = 2;
            this.label_Group.Text = "Группа: ПИбд-41";
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(12, 64);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 3;
            this.button_About.Text = "Справка";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(472, 195);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 4;
            this.button_Load.Text = "Load File";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(150, 195);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(316, 20);
            this.textBox_Result.TabIndex = 5;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(150, 25);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(397, 151);
            this.textBox_Input.TabIndex = 6;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(147, 9);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(95, 13);
            this.label_Date.TabIndex = 7;
            this.label_Date.Text = "Входные данные:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(147, 179);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(132, 13);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "Результат хеширования:";
            // 
            // label_Algo
            // 
            this.label_Algo.AutoSize = true;
            this.label_Algo.Location = new System.Drawing.Point(12, 48);
            this.label_Algo.Name = "label_Algo";
            this.label_Algo.Size = new System.Drawing.Size(85, 13);
            this.label_Algo.TabIndex = 9;
            this.label_Algo.Text = "Алгоритм: MD5";
            // 
            // button_Culс
            // 
            this.button_Culс.Location = new System.Drawing.Point(12, 93);
            this.button_Culс.Name = "button_Culс";
            this.button_Culс.Size = new System.Drawing.Size(75, 23);
            this.button_Culс.TabIndex = 10;
            this.button_Culс.Text = "Вычислить";
            this.button_Culс.UseVisualStyleBackColor = true;
            this.button_Culс.Click += new System.EventHandler(this.button_Culс_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 225);
            this.Controls.Add(this.button_Culс);
            this.Controls.Add(this.label_Algo);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.label_Executor);
            this.Controls.Add(this.label_Var);
            this.Name = "MainForm";
            this.Text = "MD5 MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Var;
        private System.Windows.Forms.Label label_Executor;
        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_Algo;
        private System.Windows.Forms.Button button_Culс;
    }
}

