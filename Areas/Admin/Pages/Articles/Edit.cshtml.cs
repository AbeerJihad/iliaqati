using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Areas.Admin.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly IRepoArticles _repoArticles;
        private readonly IRepoCategory _repoCategory;
        private readonly IFormFileMang _formFileMang;

        public EditModel(IRepoArticles repoArticles, IRepoCategory repoCategory, IFormFileMang formFileMang)
        {
            _repoArticles = repoArticles;
            _repoCategory = repoCategory;
            _formFileMang = formFileMang;
        }
        [BindProperty]
        [Display(Name = "أضف صورة")]
        [AllowedExtensions(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        public IFormFile? Image { get; set; }

        [BindProperty]
        public Article Articles { get; set; } = default!;
        public SelectList CategoriesSelect { get; set; }


        public async Task<IActionResult> OnGetAsync(string? id)
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));


            if (id == null || _repoArticles == null)
            {
                return NotFound();
            }

            var articles = await _repoArticles.GetByIDAsync(id);

            if (articles == null)
            {
                return NotFound();
            }
            Articles = articles;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            CategoriesSelect = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Article)]), nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Articles is not null)
            {
                if (Articles.Id is not null)
                {
                    var articles = await _repoArticles.GetByIDAsync(Articles.Id);
                    if (articles is null)
                    { return NotFound(); }
                    articles.Id = Articles.Id;
                    articles.Introduction = Articles.Introduction;
                    articles.Description = Articles.Description;
                    articles.Title = Articles.Title;
                    articles.CategoryId = Articles.CategoryId;
                    articles.avgReading = Articles.avgReading;

                    if (Image != null)
                    {
                        articles.Image = await _formFileMang.Upload(Image, "Images", "Articles");
                    }

                    await _repoArticles.UpdateEntityAsync(articles);
                }
            }
            else
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }


    }
}
