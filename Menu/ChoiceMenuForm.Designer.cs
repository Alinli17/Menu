namespace Menu
{
    partial class ChoiceMenuForm
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
            this.class_lbl = new System.Windows.Forms.Label();
            this.choice_class_combox = new System.Windows.Forms.ComboBox();
            this.SearchClass_btn = new System.Windows.Forms.Button();
            this.menu_lbl = new System.Windows.Forms.Label();
            this.data_menu_list = new System.Windows.Forms.ListBox();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.Detail_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // class_lbl
            // 
            this.class_lbl.AutoSize = true;
            this.class_lbl.Location = new System.Drawing.Point(11, 20);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(51, 17);
            this.class_lbl.TabIndex = 0;
            this.class_lbl.Text = "Класс:";
            // 
            // choice_class_combox
            // 
            this.choice_class_combox.FormattingEnabled = true;
            this.choice_class_combox.Location = new System.Drawing.Point(68, 17);
            this.choice_class_combox.Name = "choice_class_combox";
            this.choice_class_combox.Size = new System.Drawing.Size(175, 24);
            this.choice_class_combox.TabIndex = 1;
            // 
            // SearchClass_btn
            // 
            this.SearchClass_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SearchClass_btn.Location = new System.Drawing.Point(267, 12);
            this.SearchClass_btn.Name = "SearchClass_btn";
            this.SearchClass_btn.Size = new System.Drawing.Size(132, 33);
            this.SearchClass_btn.TabIndex = 2;
            this.SearchClass_btn.Text = "Найти";
            this.SearchClass_btn.UseVisualStyleBackColor = false;
            // 
            // menu_lbl
            // 
            this.menu_lbl.AutoSize = true;
            this.menu_lbl.Location = new System.Drawing.Point(11, 60);
            this.menu_lbl.Name = "menu_lbl";
            this.menu_lbl.Size = new System.Drawing.Size(168, 17);
            this.menu_lbl.TabIndex = 3;
            this.menu_lbl.Text = "Меню, составленное за:";
            // 
            // data_menu_list
            // 
            this.data_menu_list.FormattingEnabled = true;
            this.data_menu_list.ItemHeight = 16;
            this.data_menu_list.Location = new System.Drawing.Point(12, 80);
            this.data_menu_list.Name = "data_menu_list";
            this.data_menu_list.Size = new System.Drawing.Size(231, 196);
            this.data_menu_list.TabIndex = 4;
            // 
            // Choose_btn
            // 
            this.Choose_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Choose_btn.Location = new System.Drawing.Point(267, 106);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(132, 33);
            this.Choose_btn.TabIndex = 5;
            this.Choose_btn.Text = "Выбрать";
            this.Choose_btn.UseVisualStyleBackColor = false;
            // 
            // Detail_btn
            // 
            this.Detail_btn.Location = new System.Drawing.Point(267, 163);
            this.Detail_btn.Name = "Detail_btn";
            this.Detail_btn.Size = new System.Drawing.Size(132, 33);
            this.Detail_btn.TabIndex = 6;
            this.Detail_btn.Text = "Подробнее";
            this.Detail_btn.UseVisualStyleBackColor = true;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Back_btn.Location = new System.Drawing.Point(267, 225);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(132, 33);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Назад";
            this.Back_btn.UseVisualStyleBackColor = false;
            // 
            // ChoiceMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 295);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Detail_btn);
            this.Controls.Add(this.Choose_btn);
            this.Controls.Add(this.data_menu_list);
            this.Controls.Add(this.menu_lbl);
            this.Controls.Add(this.SearchClass_btn);
            this.Controls.Add(this.choice_class_combox);
            this.Controls.Add(this.class_lbl);
            this.Name = "ChoiceMenuForm";
            this.Text = "Готовые меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.ComboBox choice_class_combox;
        private System.Windows.Forms.Button SearchClass_btn;
        private System.Windows.Forms.Label menu_lbl;
        private System.Windows.Forms.ListBox data_menu_list;
        private System.Windows.Forms.Button Choose_btn;
        private System.Windows.Forms.Button Detail_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}