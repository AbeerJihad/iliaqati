#nullable disable


using AspNetCoreHero.ToastNotification.Abstractions;
using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        private readonly IRepoProducts _repoProducts;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly INotyfService _toastNotification;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;


        public CreateProductModel(IFormFileMang iFormFileMang, IRepoFiles repoFiles, IRepoProducts repoProducts, IRepoCategory repoCategory, IRepoService repoService, INotyfService toastNotification)
        {
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
            _repoProducts = repoProducts;
            _repoCategory = repoCategory;
            _repoService = repoService;
            _toastNotification = toastNotification;
        }

        public SelectList CatogeryName { get; set; }
        [AllowedExtensionsMulti(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSizeMulti(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        [BindProperty, Required(ErrorMessage = "أضف صورة واحدة على الأقل"), Display(Name = "أصف صور المنتج")]
        public IFormFileCollection Images { get; set; }

        [BindProperty]
        public Product Products { get; set; }
        public async Task OnGet()
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                c => c.Target == Database.GetListOfTargets()[nameof(Product)]),
                nameof(Category.Id), nameof(Category.Name));

        }
        public async Task<IActionResult> OnPostAsync()
        {

            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                c => c.Target == Database.GetListOfTargets()[nameof(Product)]),
                nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string Id = CommonMethods.Id_Guid();
            Products.Id = Id;
            Products.Services!.Id = Id;
            List<Files> ImagesPaths = new();
            foreach (var item in Images)
            {
                ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = Id, Path = await _IFormFileMang.Upload(item, "images", "products") });
            }
            if (ImagesPaths.Count > 0)
            {
                Products.ImgUrl = ImagesPaths[0].Path;
            }
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                Products.Services.UserId = userid;
            }
            await _repoService.AddEntityAsync(Products.Services);
            await _repoProducts.AddEntityAsync(Products);
            await _RepoFiles.AddRangeOfFiles(ImagesPaths);
            return RedirectToPage("./Index");
        }
    }
}
