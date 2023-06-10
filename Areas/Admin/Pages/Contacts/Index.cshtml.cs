namespace liaqati_master.Areas.Admin.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly IRepoContactUs _IRepoContactUs;

        public IndexModel(IRepoContactUs IRepoContactUs)
        {
            _IRepoContactUs = IRepoContactUs;

        }

        public IQueryable<ContactUs> ContactUses { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public QueryParameters qParamters { get; set; }
        public QueryPageResult<Models.ContactUs> QueryPageResult { get; set; }
        public IEnumerable<SelectListItem> lstPageSize { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){Value="5", Text="5"},
            new SelectListItem(){Value="10", Text="10"},
            new SelectListItem(){Value="20", Text="20"}
        };

        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value=nameof(ContactUs.FullName),Text="الاسم"},
            new SelectListItem(){Value=nameof(ContactUs.Phone),Text="رقم الجوال"},
            new SelectListItem(){Value=nameof(ContactUs.Email),Text="الإيميل"},
            new SelectListItem(){Value=nameof(ContactUs.CreatedDate),Text="تاريخ الإرسال"},
        };


        public async Task OnGetAsync()
        {
            if (_IRepoContactUs != null)
            {
                ContactUses = (await _IRepoContactUs.GetAllAsync()).AsQueryable();
                if (!string.IsNullOrEmpty(qParamters.SortBy))
                {
                    if (qParamters.SortBy.Equals(nameof(ContactUs.FullName), StringComparison.OrdinalIgnoreCase))
                    {
                        if (qParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderBy(p => p.FullName);
                        else if (qParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderByDescending(p => p.FullName);

                    }
                    else if (qParamters.SortBy.Equals(nameof(ContactUs.Phone), StringComparison.OrdinalIgnoreCase))
                    {
                        if (qParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderBy(p => p.Phone);
                        else if (qParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderByDescending(p => p.Phone);

                    }
                    else if (qParamters.SortBy.Equals(nameof(ContactUs.Email), StringComparison.OrdinalIgnoreCase))
                    {
                        if (qParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderBy(p => p.Email);
                        else if (qParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderByDescending(p => p.Email);

                    }
                    else if (qParamters.SortBy.Equals(nameof(ContactUs.CreatedDate), StringComparison.OrdinalIgnoreCase))
                    {
                        if (qParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderBy(p => p.CreatedDate);
                        else if (qParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                            ContactUses = ContactUses.OrderByDescending(p => p.CreatedDate);

                    }
                }
                QueryPageResult = CommonMethods.GetPageResult(ContactUses, qParamters);
            }
        }
    }
}
