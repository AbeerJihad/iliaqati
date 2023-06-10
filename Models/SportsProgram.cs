namespace liaqati_master.Models
{
    public class SportsProgram : BaseEntity
    {

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Length { get; set; }

        [Display(Name = " التقييم"), Range(0, 100)]
        public double? RatePercentage { get; set; }

        [Display(Name = "مستوى الصعوبة")]
        public int? Difficulty { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدة")]
        public int Duration { get; set; }
        [Display(Name = "الجزءالذي يركز عليه النظام من الجسم")]
        public string? BodyFocus { get; set; }
        [Display(Name = "المعدات")]
        public string? Equipment { get; set; }

       
        [Display(Name = "نوع التدريب")]
        public string? TrainingType { get; set; }

      
        [Display(Name = "المدرب")]
        public string? Trainer { get; set; }

       

        [Display(Name = "صورة")]
        public string? Image { get; set; }

        [Display(Name = "فيديو")]
        public string? Video { get; set; }

        [Display(Name = "تقدير الحرق")]
        public string? BurnEstimate { get; set; }
        [ForeignKey(nameof(Id))]
        public virtual Service? Services { get; set; }
        public virtual List<Exercies_program>? Exercies_Programs { get; set; }

    }
}
