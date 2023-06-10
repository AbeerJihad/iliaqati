namespace liaqati_master.Pages.ContactUs
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly IRepoContactUs _repoContactUs;
        public IndexModel(IRepoContactUs repoContactUs, SignInManager<User> signInManager)
        {
            _repoContactUs = repoContactUs;
        }
        public class ContactUsVM
        {
            [Required, Display(Name = "الإسم الكامل")]
            public string? FullName { get; set; }
            [Required, Display(Name = "البريد الإلكتروني")]
            public string? Email { get; set; }
            [Required, Display(Name = "مقدمة الرقم")]
            public string? PhoneIntro { get; set; }
            [Required, Display(Name = "رقم الجوال"), RegularExpression(@"^\d{7}$")]
            public string? Phone { get; set; }
            [Required, Display(Name = "محتوى الرسالة"), StringLength(500, MinimumLength = 10, ErrorMessage = " رجاءً ادخل ملاحظاتك")]
            public string? MessageContent { get; set; }

        }

        public ContactUsVM ContactUsVMs { get; set; }


        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (ContactUsVMs != null)
                {
                    Models.ContactUs contactUs = new()
                    {
                        Email = ContactUsVMs.Email,
                        Phone = String.Concat(ContactUsVMs.PhoneIntro, ContactUsVMs.Phone),
                        MessageContent = ContactUsVMs.MessageContent,
                        FullName = ContactUsVMs.FullName

                    };
                    await _repoContactUs.AddEntityAsync(contactUs);

                }
            }
            return Page();
        }

    }
}
