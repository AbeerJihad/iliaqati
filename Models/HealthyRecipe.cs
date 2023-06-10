namespace liaqati_master.Models
{
    public class HealthyRecipe : BaseEntity
    {
        // [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Required(ErrorMessage = "{0} هذا الحقل مطلوب"), Display(Name = "إسم الوصفة")]
        public string? Title { get; set; }
        //    [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "تفاصيل أخرى عن الوصفة"), Column(TypeName = "NTEXT"), Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        public string? Description { get; set; }
        [Display(Name = "وصف قصير")]
        [Required(ErrorMessage = " {0} هذا الحقل مطلوب")]
        public string? ShortDescription { get; set; }
        [Required(ErrorMessage = " {0} هذا الحقل مطلوب")]
        [Display(Name = " سعر الوصفة")]
        public double? Price { get; set; }
        //[Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        //[Display(Name = "رقم الصنف")]
        //public string? CategoryId { get; set; }
        //[ForeignKey(nameof(CategoryId))]
        //public virtual Category? Category { get; set; }

        public string? Image { get; set; } = " ";
        [Display(Name = "نوع الوجبة")]

        public string? MealType { get; set; }

        [Display(Name = "النوع الغذائي")]
        public string? DietaryType { get; set; }

        [Required(ErrorMessage = " {0} هذا الحقل مطلوب")]
        [Display(Name = "وقت التحضير")]
        public int PrepTime { get; set; }

        [Required(ErrorMessage = " {0}  هذا الحقل مطلوب")]
        [Display(Name = "السعرات الحرارية")]
        public int Calories { get; set; }
        [Display(Name = "مجموع الكاربوهيدرات")]
        public int Total_Carbohydrate { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "كمية البروتين")]
        public int Protein { get; set; }
        [Display(Name = "عدد المشاهدات")]
        public int ViewsNumber { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "المكونات"), Column(TypeName = "NTEXT")]
        public string? Ingredients { get; set; }
        [Required(ErrorMessage = "{0} هذا الحقل مطلوب")]
        [Display(Name = "طريقة التحضير؟"), Column(TypeName = "NTEXT")]
        public string? PreparationMethod { get; set; }
        [Display(Name = " التقييم"), Range(0, 100)]
        public double? RatePercentage { get; set; }
        [Display(Name = "هل هو مميز؟")]
        public bool IsFeatured { get; set; } = false;
        [Display(Name = "هل هو متاح؟")]
        public bool IsAvailable { get; set; } = false;
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }
        public virtual List<Rate>? Rate { get; set; }
        public virtual List<Meal_Healthy>? Meal_Healthy { get; set; }
        public virtual List<Files>? Files { get; set; }
        public virtual List<Favorite>? Favorite { get; set; }


    }
    public enum DietaryTypeStatus { Omnivore, Vegetarian }
    public enum MealTypeTypeStatus { SideDish, Breakfast, Lunch, Dinner, Snack }
}

