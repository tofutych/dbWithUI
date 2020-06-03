namespace dbWithUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.experienceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.educationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 194);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(12, 223);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(171, 30);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "Взглянуть на всё";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(171, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(131, 38);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(52, 20);
            this.ageBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваш возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш пол";
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(92, 64);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(91, 20);
            this.sexBox.TabIndex = 7;
            this.sexBox.Enter += new System.EventHandler(this.sexBox_Enter);
            this.sexBox.Leave += new System.EventHandler(this.sexBox_Leave);
            // 
            // experienceBox
            // 
            this.experienceBox.Location = new System.Drawing.Point(131, 90);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(52, 20);
            this.experienceBox.TabIndex = 12;
            this.experienceBox.Enter += new System.EventHandler(this.experienceBox_Enter);
            this.experienceBox.Leave += new System.EventHandler(this.experienceBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Опыт работы";
            // 
            // educationBox
            // 
            this.educationBox.Location = new System.Drawing.Point(131, 116);
            this.educationBox.Name = "educationBox";
            this.educationBox.Size = new System.Drawing.Size(52, 20);
            this.educationBox.TabIndex = 14;
            this.educationBox.Enter += new System.EventHandler(this.educationBox_Enter);
            this.educationBox.Leave += new System.EventHandler(this.educationBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Образование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Мед. справка";
            // 
            // medBox
            // 
            this.medBox.Location = new System.Drawing.Point(131, 142);
            this.medBox.Name = "medBox";
            this.medBox.Size = new System.Drawing.Size(52, 20);
            this.medBox.TabIndex = 17;
            this.medBox.Enter += new System.EventHandler(this.medBox_Enter);
            this.medBox.Leave += new System.EventHandler(this.medBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Автомобиль";
            // 
            // carBox
            // 
            this.carBox.Location = new System.Drawing.Point(131, 168);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(52, 20);
            this.carBox.TabIndex = 19;
            this.carBox.Enter += new System.EventHandler(this.carBox_Enter);
            this.carBox.Leave += new System.EventHandler(this.carBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(195, 258);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.educationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.experienceBox);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "кто я";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.TextBox experienceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox educationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carBox;
    }
}

