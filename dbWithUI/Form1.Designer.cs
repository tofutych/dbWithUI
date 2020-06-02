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
            this.expBox = new System.Windows.Forms.CheckBox();
            this.eduBox = new System.Windows.Forms.CheckBox();
            this.medBox = new System.Windows.Forms.CheckBox();
            this.carBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 204);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(12, 233);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(171, 23);
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
            // 
            // expBox
            // 
            this.expBox.AutoSize = true;
            this.expBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.expBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBox.Location = new System.Drawing.Point(12, 90);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(118, 21);
            this.expBox.TabIndex = 8;
            this.expBox.Text = "Опыт работы";
            this.expBox.UseVisualStyleBackColor = true;
            // 
            // eduBox
            // 
            this.eduBox.AutoSize = true;
            this.eduBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.eduBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eduBox.Location = new System.Drawing.Point(12, 116);
            this.eduBox.Name = "eduBox";
            this.eduBox.Size = new System.Drawing.Size(123, 21);
            this.eduBox.TabIndex = 9;
            this.eduBox.Text = "Образование";
            this.eduBox.UseVisualStyleBackColor = true;
            // 
            // medBox
            // 
            this.medBox.AutoSize = true;
            this.medBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.medBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medBox.Location = new System.Drawing.Point(12, 142);
            this.medBox.Name = "medBox";
            this.medBox.Size = new System.Drawing.Size(120, 21);
            this.medBox.TabIndex = 10;
            this.medBox.Text = "Мед. справка";
            this.medBox.UseVisualStyleBackColor = true;
            // 
            // carBox
            // 
            this.carBox.AutoSize = true;
            this.carBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBox.Location = new System.Drawing.Point(12, 168);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(113, 21);
            this.carBox.TabIndex = 11;
            this.carBox.Text = "Автомобиль";
            this.carBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(195, 265);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.medBox);
            this.Controls.Add(this.eduBox);
            this.Controls.Add(this.expBox);
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
        private System.Windows.Forms.CheckBox expBox;
        private System.Windows.Forms.CheckBox eduBox;
        private System.Windows.Forms.CheckBox medBox;
        private System.Windows.Forms.CheckBox carBox;
    }
}

