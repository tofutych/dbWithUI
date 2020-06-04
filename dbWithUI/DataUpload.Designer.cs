namespace dbWithUI
{
    partial class DataUpload
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиКПросмотруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачальноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.numericCreate = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Choose = new System.Windows.Forms.Button();
            this.numericChoose = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCreate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(18, 58);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(770, 380);
            this.dataGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Режим редактирования";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem,
            this.перейтиКПросмотруToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.изменитьToolStripMenuItem.Text = "Выгрузить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбранноеToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // выбранноеToolStripMenuItem
            // 
            this.выбранноеToolStripMenuItem.Name = "выбранноеToolStripMenuItem";
            this.выбранноеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбранноеToolStripMenuItem.Text = "Выбранное";
            this.выбранноеToolStripMenuItem.Click += new System.EventHandler(this.выбранноеToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // перейтиКПросмотруToolStripMenuItem
            // 
            this.перейтиКПросмотруToolStripMenuItem.Name = "перейтиКПросмотруToolStripMenuItem";
            this.перейтиКПросмотруToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.перейтиКПросмотруToolStripMenuItem.Text = "Перейти к просмотру";
            this.перейтиКПросмотруToolStripMenuItem.Click += new System.EventHandler(this.перейтиКПросмотруToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачальноеОкноToolStripMenuItem,
            this.изПрограммыToolStripMenuItem});
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem1.Text = "Выйти";
            // 
            // вНачальноеОкноToolStripMenuItem
            // 
            this.вНачальноеОкноToolStripMenuItem.Name = "вНачальноеОкноToolStripMenuItem";
            this.вНачальноеОкноToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.вНачальноеОкноToolStripMenuItem.Text = "в начальное окно";
            this.вНачальноеОкноToolStripMenuItem.Click += new System.EventHandler(this.вНачальноеОкноToolStripMenuItem_Click);
            // 
            // изПрограммыToolStripMenuItem
            // 
            this.изПрограммыToolStripMenuItem.Name = "изПрограммыToolStripMenuItem";
            this.изПрограммыToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.изПрограммыToolStripMenuItem.Text = "из программы";
            this.изПрограммыToolStripMenuItem.Click += new System.EventHandler(this.изПрограммыToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.numericCreate);
            this.groupBox1.Location = new System.Drawing.Point(430, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сколько данных добавить";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(101, 19);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(69, 20);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // numericCreate
            // 
            this.numericCreate.Location = new System.Drawing.Point(6, 19);
            this.numericCreate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCreate.Name = "numericCreate";
            this.numericCreate.Size = new System.Drawing.Size(89, 20);
            this.numericCreate.TabIndex = 0;
            this.numericCreate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Choose);
            this.groupBox2.Controls.Add(this.numericChoose);
            this.groupBox2.Location = new System.Drawing.Point(612, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Какую запись изменить";
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(101, 19);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(69, 20);
            this.Choose.TabIndex = 1;
            this.Choose.Text = "Выбрать";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // numericChoose
            // 
            this.numericChoose.Location = new System.Drawing.Point(6, 19);
            this.numericChoose.Name = "numericChoose";
            this.numericChoose.Size = new System.Drawing.Size(89, 20);
            this.numericChoose.TabIndex = 0;
            this.numericChoose.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DataUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DataUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataUpload";
            this.Shown += new System.EventHandler(this.DataUpload_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCreate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиКПросмотруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вНачальноеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изПрограммыToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.NumericUpDown numericCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.NumericUpDown numericChoose;
    }
}