using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            Dish dish = new Dish();
            DishMealTime dishMealTime = new DishMealTime();

            dish.Calories = Convert.ToDouble(cal_txtb.Text);
            dish.DishName = dish_txtb.Text;
            dish.Carbohydrates = Convert.ToDouble(carb_txtb.Text);
            dish.Descr = desc_txtb.Text;
            dish.Fats = Convert.ToDouble(fat_txtb.Text);
            dish.Weight = Convert.ToDouble(gram_txtb.Text);
            dish.Protein = Convert.ToDouble(prot__txtb.Text);

            DBConnection.Entities.Dishes.Add(dish);
            DBConnection.Entities.SaveChanges();

            dishMealTime.DishId = dish.DishId;
            dishMealTime.MealTime = meal_combox.Text;

            DBConnection.Entities.DishMealTimes.Add(dishMealTime);
            DBConnection.Entities.SaveChanges();

            this.Close();
        }
    }
}
