//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Menu
{
    using System;
    using System.Collections.Generic;
    
    public partial class DishMealTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DishMealTime()
        {
            this.ClassMenus = new HashSet<ClassMenu>();
        }
    
        public int Id { get; set; }
        public int DishId { get; set; }
        public string MealTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassMenu> ClassMenus { get; set; }
        public virtual Dish Dish { get; set; }
        public virtual MealTime MealTime1 { get; set; }
    }
}
