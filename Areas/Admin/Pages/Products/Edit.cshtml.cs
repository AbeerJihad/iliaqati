#nullable disable
using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Pages.Products
{
    public class EditProductModel : PageModel
    {

        private readonly IRepoProducts _repoProducts;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;
        public EditProductModel(IFormFileMang iFormFileMang, IRepoFiles repoFiles, IRepoProducts repoProducts, IRepoCategory repoCategory, IRepoService repoService)
        {
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
            _repoProducts = repoProducts;
            _repoCategory = repoCategory;
            _repoService = repoService;
        }
        public SelectList CatogeryName { get; set; }


        [BindProperty(SupportsGet = true)]
        public Product Product { get; set; }
        [AllowedExtensionsMulti(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSizeMulti(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        [BindProperty, Display(Name = "أصف صور المنتج")]
        public IFormFileCollection? Images { get; set; }
        public List<string> paths { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Models.Product)]), nameof(Category.Id), nameof(Category.Name));

            if (id == null)
            {
                return NotFound();
            }

            var product = await _repoProducts.GetByIDAsync(id);

            paths = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == product.Id).Select(fil => fil.Path).ToList();
            if (product == null)
            {
                return NotFound();
            }
            Product = product;

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(Models.Product)]), nameof(Category.Id), nameof(Category.Name));


            if (!ModelState.IsValid)
            {
                return Page();
            }

            var id = Product.Id;
            var item = await _repoProducts.GetByIDAsync(id);
            item.Services!.Title = Product.Services!.Title;
            item.Services.Price = Product.Services.Price;
            item.Services.Description = Product.Services.Description;
            item.Discount = Product.Discount;
            if (Images?.Count > 0)
            {
                List<Files> ImagesPaths = new();
                foreach (var formFile in Images)
                {
                    ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), ServiceId = id, Path = await _IFormFileMang.Upload(formFile, "images", "products") });
                }
                List<Files> images = (await _RepoFiles.GetAllAsync()).Where(file => file.ServiceId == Product.Id).ToList();
                foreach (var image in images)
                {
                    await _RepoFiles.DeleteEntityAsync(image);
                    _IFormFileMang.DeleteFile(image.Path);

                }
                await _RepoFiles.AddRangeOfFiles(ImagesPaths);
                await _RepoFiles.SaveAsync();
                if (ImagesPaths.Count > 0)
                {
                    Product.ImgUrl = ImagesPaths[0].Path;
                }


            }

            await _repoProducts.UpdateEntityAsync(item);

            return RedirectToPage();

            //  _context.Attach(MealPlans).State = EntityState.Modified;

        }
    }
}