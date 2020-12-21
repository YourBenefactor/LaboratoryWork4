
namespace Laboratory_Work_4
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SelectSolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Accomplish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileSelect = new System.Windows.Forms.Button();
            this.PathToFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedNumbers = new System.Windows.Forms.TextBox();
            this.AllNumbers = new System.Windows.Forms.TextBox();
            this.Tasks = new System.Windows.Forms.ImageList(this.components);
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FolderSelect = new System.Windows.Forms.Button();
            this.PathToFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.AllNumbers1 = new System.Windows.Forms.TextBox();
            this.ChangingText = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.File1 = new System.Windows.Forms.TextBox();
            this.File2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FolderSelect1 = new System.Windows.Forms.Button();
            this.PathToFolder1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Accomplish);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SelectSolution);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(278, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 27);
            this.panel3.TabIndex = 3;
            // 
            // SelectSolution
            // 
            this.SelectSolution.FormattingEnabled = true;
            this.SelectSolution.Items.AddRange(new object[] {
            "Задание 1",
            "Задание 2",
            "Задание 3",
            "Задание 4",
            "Задание 5"});
            this.SelectSolution.Location = new System.Drawing.Point(62, 2);
            this.SelectSolution.Name = "SelectSolution";
            this.SelectSolution.Size = new System.Drawing.Size(203, 21);
            this.SelectSolution.TabIndex = 4;
            this.SelectSolution.SelectedIndexChanged += new System.EventHandler(this.SelectSolution_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Задание:";
            // 
            // Accomplish
            // 
            this.Accomplish.Location = new System.Drawing.Point(3, 1);
            this.Accomplish.Name = "Accomplish";
            this.Accomplish.Size = new System.Drawing.Size(269, 31);
            this.Accomplish.TabIndex = 1;
            this.Accomplish.Text = "Выполнить";
            this.Accomplish.UseVisualStyleBackColor = true;
            this.Accomplish.Click += new System.EventHandler(this.Accomplish_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FileSelect);
            this.panel2.Controls.Add(this.PathToFile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 27);
            this.panel2.TabIndex = 1;
            // 
            // FileSelect
            // 
            this.FileSelect.Location = new System.Drawing.Point(509, 1);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(24, 20);
            this.FileSelect.TabIndex = 2;
            this.FileSelect.Text = "...";
            this.FileSelect.UseVisualStyleBackColor = true;
            this.FileSelect.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // PathToFile
            // 
            this.PathToFile.Location = new System.Drawing.Point(85, 2);
            this.PathToFile.Multiline = true;
            this.PathToFile.Name = "PathToFile";
            this.PathToFile.Size = new System.Drawing.Size(418, 20);
            this.PathToFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к файлу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Текстовый файл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выбранные строки:";
            // 
            // SelectedNumbers
            // 
            this.SelectedNumbers.Location = new System.Drawing.Point(281, 52);
            this.SelectedNumbers.Multiline = true;
            this.SelectedNumbers.Name = "SelectedNumbers";
            this.SelectedNumbers.Size = new System.Drawing.Size(263, 221);
            this.SelectedNumbers.TabIndex = 4;
            // 
            // AllNumbers
            // 
            this.AllNumbers.Location = new System.Drawing.Point(3, 52);
            this.AllNumbers.Multiline = true;
            this.AllNumbers.Name = "AllNumbers";
            this.AllNumbers.Size = new System.Drawing.Size(272, 221);
            this.AllNumbers.TabIndex = 3;
            // 
            // Tasks
            // 
            this.Tasks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Tasks.ImageStream")));
            this.Tasks.TransparentColor = System.Drawing.Color.Transparent;
            this.Tasks.Images.SetKeyName(0, "Task1.PNG");
            this.Tasks.Images.SetKeyName(1, "Task2.PNG");
            this.Tasks.Images.SetKeyName(2, "Task3.PNG");
            this.Tasks.Images.SetKeyName(3, "Task4.PNG");
            this.Tasks.Images.SetKeyName(4, "Task5.PNG");
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.ItemSize = new System.Drawing.Size(183, 18);
            this.Menu.Location = new System.Drawing.Point(2, 40);
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(556, 304);
            this.Menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Menu.TabIndex = 7;
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AllNumbers);
            this.tabPage1.Controls.Add(this.SelectedNumbers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1-2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.Value);
            this.tabPage2.Controls.Add(this.AllNumbers1);
            this.tabPage2.Controls.Add(this.ChangingText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 3-4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Текстовый файл:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.FolderSelect);
            this.panel4.Controls.Add(this.PathToFolder);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 27);
            this.panel4.TabIndex = 6;
            // 
            // FolderSelect
            // 
            this.FolderSelect.Location = new System.Drawing.Point(509, 1);
            this.FolderSelect.Name = "FolderSelect";
            this.FolderSelect.Size = new System.Drawing.Size(24, 20);
            this.FolderSelect.TabIndex = 2;
            this.FolderSelect.Text = "...";
            this.FolderSelect.UseVisualStyleBackColor = true;
            this.FolderSelect.Click += new System.EventHandler(this.FolderSelect_Click);
            // 
            // PathToFolder
            // 
            this.PathToFolder.Location = new System.Drawing.Point(85, 2);
            this.PathToFolder.Multiline = true;
            this.PathToFolder.Name = "PathToFolder";
            this.PathToFolder.Size = new System.Drawing.Size(418, 20);
            this.PathToFolder.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 5);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сохранить в:";
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(280, 149);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(262, 28);
            this.Value.TabIndex = 9;
            // 
            // AllNumbers1
            // 
            this.AllNumbers1.Location = new System.Drawing.Point(3, 52);
            this.AllNumbers1.Multiline = true;
            this.AllNumbers1.Name = "AllNumbers1";
            this.AllNumbers1.Size = new System.Drawing.Size(272, 221);
            this.AllNumbers1.TabIndex = 8;
            // 
            // ChangingText
            // 
            this.ChangingText.AutoSize = true;
            this.ChangingText.Location = new System.Drawing.Point(346, 133);
            this.ChangingText.Name = "ChangingText";
            this.ChangingText.Size = new System.Drawing.Size(137, 13);
            this.ChangingText.TabIndex = 7;
            this.ChangingText.Text = "Максимальное значение:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.File1);
            this.tabPage3.Controls.Add(this.File2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(548, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task 5";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(3, 52);
            this.File1.Multiline = true;
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(272, 221);
            this.File1.TabIndex = 7;
            // 
            // File2
            // 
            this.File2.Location = new System.Drawing.Point(281, 52);
            this.File2.Multiline = true;
            this.File2.Name = "File2";
            this.File2.Size = new System.Drawing.Size(263, 221);
            this.File2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Файл F:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Файл W:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.FolderSelect1);
            this.panel5.Controls.Add(this.PathToFolder1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(541, 27);
            this.panel5.TabIndex = 8;
            // 
            // FolderSelect1
            // 
            this.FolderSelect1.Location = new System.Drawing.Point(509, 1);
            this.FolderSelect1.Name = "FolderSelect1";
            this.FolderSelect1.Size = new System.Drawing.Size(24, 20);
            this.FolderSelect1.TabIndex = 2;
            this.FolderSelect1.Text = "...";
            this.FolderSelect1.UseVisualStyleBackColor = true;
            this.FolderSelect1.Click += new System.EventHandler(this.FolderSelect_Click);
            // 
            // PathToFolder1
            // 
            this.PathToFolder1.Location = new System.Drawing.Point(85, 2);
            this.PathToFolder1.Multiline = true;
            this.PathToFolder1.Name = "PathToFolder1";
            this.PathToFolder1.Size = new System.Drawing.Size(418, 20);
            this.PathToFolder1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 5);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Сохранить в:";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 345);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.Name = "Window";
            this.Text = "Лабораторная работа №4";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox SelectSolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.TextBox PathToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accomplish;
        private System.Windows.Forms.ImageList Tasks;
        private System.Windows.Forms.TextBox AllNumbers;
        private System.Windows.Forms.TextBox SelectedNumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button FolderSelect;
        private System.Windows.Forms.TextBox PathToFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox AllNumbers1;
        private System.Windows.Forms.Label ChangingText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button FolderSelect1;
        private System.Windows.Forms.TextBox PathToFolder1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox File1;
        private System.Windows.Forms.TextBox File2;
    }
}

