namespace Menu
{
    partial class AddDishForm
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
            this.dish_lbl = new System.Windows.Forms.Label();
            this.dish_txtb = new System.Windows.Forms.TextBox();
            this.meal_combox = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.prot_lbl = new System.Windows.Forms.Label();
            this.prot__txtb = new System.Windows.Forms.TextBox();
            this.fat_lbl = new System.Windows.Forms.Label();
            this.fat_txtb = new System.Windows.Forms.TextBox();
            this.carb_lbl = new System.Windows.Forms.Label();
            this.carb_txtb = new System.Windows.Forms.TextBox();
            this.cal_lbl = new System.Windows.Forms.Label();
            this.cal_txtb = new System.Windows.Forms.TextBox();
            this.gram_lbl = new System.Windows.Forms.Label();
            this.gram_txtb = new System.Windows.Forms.TextBox();
            this.meal_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.desc_txtb = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dish_lbl
            // 
            this.dish_lbl.AutoSize = true;
            this.dish_lbl.Location = new System.Drawing.Point(13, 13);
            this.dish_lbl.Name = "dish_lbl";
            this.dish_lbl.Size = new System.Drawing.Size(156, 17);
            this.dish_lbl.TabIndex = 0;
            this.dish_lbl.Text = "Наименование блюда:";
            // 
            // dish_txtb
            // 
            this.dish_txtb.Location = new System.Drawing.Point(16, 33);
            this.dish_txtb.Name = "dish_txtb";
            this.dish_txtb.Size = new System.Drawing.Size(357, 22);
            this.dish_txtb.TabIndex = 1;
            // 
            // meal_combox
            // 
            this.meal_combox.FormattingEnabled = true;
            this.meal_combox.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Полдник"});
            this.meal_combox.Location = new System.Drawing.Point(203, 168);
            this.meal_combox.Name = "meal_combox";
            this.meal_combox.Size = new System.Drawing.Size(170, 24);
            this.meal_combox.TabIndex = 2;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back_btn.Location = new System.Drawing.Point(16, 331);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(153, 48);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // prot_lbl
            // 
            this.prot_lbl.AutoSize = true;
            this.prot_lbl.Location = new System.Drawing.Point(13, 58);
            this.prot_lbl.Name = "prot_lbl";
            this.prot_lbl.Size = new System.Drawing.Size(153, 17);
            this.prot_lbl.TabIndex = 4;
            this.prot_lbl.Text = "Количество белков, г:";
            // 
            // prot__txtb
            // 
            this.prot__txtb.Location = new System.Drawing.Point(16, 78);
            this.prot__txtb.Name = "prot__txtb";
            this.prot__txtb.Size = new System.Drawing.Size(170, 22);
            this.prot__txtb.TabIndex = 5;
            // 
            // fat_lbl
            // 
            this.fat_lbl.AutoSize = true;
            this.fat_lbl.Location = new System.Drawing.Point(13, 103);
            this.fat_lbl.Name = "fat_lbl";
            this.fat_lbl.Size = new System.Drawing.Size(147, 17);
            this.fat_lbl.TabIndex = 6;
            this.fat_lbl.Text = "Количество жиров, г:";
            // 
            // fat_txtb
            // 
            this.fat_txtb.Location = new System.Drawing.Point(16, 123);
            this.fat_txtb.Name = "fat_txtb";
            this.fat_txtb.Size = new System.Drawing.Size(170, 22);
            this.fat_txtb.TabIndex = 7;
            // 
            // carb_lbl
            // 
            this.carb_lbl.AutoSize = true;
            this.carb_lbl.Location = new System.Drawing.Point(13, 148);
            this.carb_lbl.Name = "carb_lbl";
            this.carb_lbl.Size = new System.Drawing.Size(173, 17);
            this.carb_lbl.TabIndex = 8;
            this.carb_lbl.Text = "Количество углеводов, г:";
            // 
            // carb_txtb
            // 
            this.carb_txtb.Location = new System.Drawing.Point(16, 168);
            this.carb_txtb.Name = "carb_txtb";
            this.carb_txtb.Size = new System.Drawing.Size(170, 22);
            this.carb_txtb.TabIndex = 9;
            // 
            // cal_lbl
            // 
            this.cal_lbl.AutoSize = true;
            this.cal_lbl.Location = new System.Drawing.Point(200, 58);
            this.cal_lbl.Name = "cal_lbl";
            this.cal_lbl.Size = new System.Drawing.Size(137, 17);
            this.cal_lbl.TabIndex = 10;
            this.cal_lbl.Text = "Количество ккал, г:";
            // 
            // cal_txtb
            // 
            this.cal_txtb.Location = new System.Drawing.Point(203, 78);
            this.cal_txtb.Name = "cal_txtb";
            this.cal_txtb.Size = new System.Drawing.Size(170, 22);
            this.cal_txtb.TabIndex = 11;
            // 
            // gram_lbl
            // 
            this.gram_lbl.AutoSize = true;
            this.gram_lbl.Location = new System.Drawing.Point(200, 103);
            this.gram_lbl.Name = "gram_lbl";
            this.gram_lbl.Size = new System.Drawing.Size(143, 17);
            this.gram_lbl.TabIndex = 12;
            this.gram_lbl.Text = "Граммовка блюда, г:";
            // 
            // gram_txtb
            // 
            this.gram_txtb.Location = new System.Drawing.Point(203, 123);
            this.gram_txtb.Name = "gram_txtb";
            this.gram_txtb.Size = new System.Drawing.Size(170, 22);
            this.gram_txtb.TabIndex = 13;
            // 
            // meal_lbl
            // 
            this.meal_lbl.AutoSize = true;
            this.meal_lbl.Location = new System.Drawing.Point(200, 148);
            this.meal_lbl.Name = "meal_lbl";
            this.meal_lbl.Size = new System.Drawing.Size(107, 17);
            this.meal_lbl.TabIndex = 14;
            this.meal_lbl.Text = "Время приёма:";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(13, 193);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(78, 17);
            this.desc_lbl.TabIndex = 15;
            this.desc_lbl.Text = "Описание:";
            // 
            // desc_txtb
            // 
            this.desc_txtb.Location = new System.Drawing.Point(16, 213);
            this.desc_txtb.Multiline = true;
            this.desc_txtb.Name = "desc_txtb";
            this.desc_txtb.Size = new System.Drawing.Size(357, 112);
            this.desc_txtb.TabIndex = 16;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save_btn.Location = new System.Drawing.Point(220, 331);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(153, 48);
            this.save_btn.TabIndex = 17;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 390);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.desc_txtb);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.meal_lbl);
            this.Controls.Add(this.gram_txtb);
            this.Controls.Add(this.gram_lbl);
            this.Controls.Add(this.cal_txtb);
            this.Controls.Add(this.cal_lbl);
            this.Controls.Add(this.carb_txtb);
            this.Controls.Add(this.carb_lbl);
            this.Controls.Add(this.fat_txtb);
            this.Controls.Add(this.fat_lbl);
            this.Controls.Add(this.prot__txtb);
            this.Controls.Add(this.prot_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.meal_combox);
            this.Controls.Add(this.dish_txtb);
            this.Controls.Add(this.dish_lbl);
            this.Name = "AddDishForm";
            this.Text = "Добавление/Изменение блюда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dish_lbl;
        private System.Windows.Forms.TextBox dish_txtb;
        private System.Windows.Forms.ComboBox meal_combox;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label prot_lbl;
        private System.Windows.Forms.TextBox prot__txtb;
        private System.Windows.Forms.Label fat_lbl;
        private System.Windows.Forms.TextBox fat_txtb;
        private System.Windows.Forms.Label carb_lbl;
        private System.Windows.Forms.TextBox carb_txtb;
        private System.Windows.Forms.Label cal_lbl;
        private System.Windows.Forms.TextBox cal_txtb;
        private System.Windows.Forms.Label gram_lbl;
        private System.Windows.Forms.TextBox gram_txtb;
        private System.Windows.Forms.Label meal_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.TextBox desc_txtb;
        private System.Windows.Forms.Button save_btn;
    }
}