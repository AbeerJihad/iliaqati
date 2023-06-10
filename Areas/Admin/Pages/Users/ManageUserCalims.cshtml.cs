namespace liaqati_master.Areas.Admin.Pages.Users
{
    public class ManageUserCalimsModel : PageModel
    {

        private readonly UserManager<User> _UserManager;
        public ManageUserCalimsModel(UserManager<User> userManager)
        {
            _UserManager = userManager;
        }
        public class ClaimVM
        {
            [Required] public string? Type { get; set; }
            [Required] public bool IsActive { get; set; }
        }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public ClaimVM ClaimV { get; set; }
        public IEnumerable<Claim> Claims { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (string.IsNullOrEmpty(Id))
            {
                return RedirectToPage("/");
            }
            User user = await _UserManager.FindByIdAsync(Id);
            Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));
            return Page();
        }
        public async Task<IActionResult> OnPostAddClaimAsync()
        {

            User user = await _UserManager.FindByIdAsync(Id);
            if (!ModelState.IsValid)
            {
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                return Page();
            }
            if (ClaimV is null)
            {
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                return Page();

            }
            if (string.IsNullOrEmpty(ClaimV.Type))
            {
                ModelState.AddModelError(nameof(ClaimV.Type), "اختر احد الصلاحيات من فضلك");
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                return Page();

            }
            var claim = new Claim(ClaimV.Type, ClaimV.IsActive ? "true" : "false");
            var allCliams = await _UserManager.GetClaimsAsync(user);
            var claimOld = allCliams.Where(c => c.Type == claim.Type).FirstOrDefault();
            if (claimOld != null)
            {
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                ModelState.AddModelError(string.Empty, "مضافة مسبقا");

                return Page();
            }
            var result = await _UserManager.AddClaimAsync(user, claim);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, err.Description);
                }
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                return Page();
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostEditClaimAsync([Required] string type, [Required] string value)
        {
            User user = await _UserManager.FindByIdAsync(Id);
            if (ModelState.IsValid)
            {
                var claimNew = new Claim(type, value == "false" ? "true" : "false");
                var claimOld = new Claim(type, value);
                var result = await _UserManager.ReplaceClaimAsync(user, claimOld, claimNew);
            }
            else
            {
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));

                return Page();
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteClaimAsync([Required] string type, string? value)
        {
            User user = await _UserManager.FindByIdAsync(Id);
            if (ModelState.IsValid)
            {
                var claim = new Claim(type, value);
                var result = await _UserManager.RemoveClaimAsync(user, claim);
            }
            else
            {
                Claims = (await _UserManager.GetClaimsAsync(user)).Where(c => Database.AppClaimTypes.Contains(c.Type));
                return Page();
            }
            return RedirectToPage();

        }
    }


}

