﻿namespace liaqati_master.Services.Repositories
{
    public class IRepoHealthyRecipe
    {
        private readonly LiaqatiDBContext _context;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IRepoFavorite _IRepoFavorite;


        public IRepoHealthyRecipe(LiaqatiDBContext context, IHttpContextAccessor httpContextAccessor, IRepoFavorite iRepoFavorite)
        {
            _context = context;
            _HttpContextAccessor = httpContextAccessor;
            _IRepoFavorite = iRepoFavorite;
        }

        public async Task<HealthyRecipe> AddEntityAsync(HealthyRecipe Entity)
        {
            await _context.TblHealthyRecipe.AddAsync(Entity);
            await SaveAsync();
            return Entity;
        }

        public async Task<HealthyRecipe> DeleteEntityAsync(HealthyRecipe Entity)
        {
            if (Entity != null)
            {
                _context.TblHealthyRecipe.Remove(Entity);
                await SaveAsync();
                return Entity;
            }
            else
            {
                return new HealthyRecipe();
            }
        }

        public async Task<HealthyRecipe> DeleteEntityAsync(string Id)
        {
            var healthyRecipe = await _context.TblHealthyRecipe.FindAsync(Id);
            if (healthyRecipe != null)
            {
                _context.TblHealthyRecipe.Remove(healthyRecipe);
                await SaveAsync();
                return healthyRecipe;
            }
            else
            {
                return new HealthyRecipe();
            }
        }

        public async Task<List<HealthyRecipe>> GetbyUserId(string id)
        {
            return await _context.TblHealthyRecipe.Where(p => p.UserId == id).ToListAsync();
        }


        public async Task<IEnumerable<HealthyRecipe>> GetAllAsync()
        {
            //.Include(Category => Category.Category).Include(com => com.comments)
            return await _context.TblHealthyRecipe.ToListAsync();
        }

        public async Task<HealthyRecipe?> GetByIDAsync(string EntityId)
        {
            return await _context.TblHealthyRecipe.FirstOrDefaultAsync(a => a.Id == EntityId);
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async Task<HealthyRecipe> UpdateEntityAsync(HealthyRecipe Entity)
        {
            HealthyRecipe? healthyRecipe = await _context.TblHealthyRecipe.FirstOrDefaultAsync(a => a.Id == Entity.Id);
            if (healthyRecipe != null)
            {
                _context.TblHealthyRecipe.Update(Entity);
                await SaveAsync();
                return Entity;

            }
            else
            {
                return new HealthyRecipe();
            }
        }
        public async Task<HealthyRecipeQueryPageResult> SearchHealty(HealthyRecipeQueryParamters HealthyRecipeQueryParamters)
        {

            IQueryable<VmHealthyRecipe> HealthyRecipess = (await GetAllAsync()).Select(p =>
              new VmHealthyRecipe()
              {
                  Id = p.Id,
                  Image = p.Image ?? "",
                  Price = p.Price,
                  Title = p.Title,
                  Description = p.Description,
                  Calories = p.Calories,
                  PrepTime = p.PrepTime,
                  Protein = p.Protein,
                  Rate = p.Rate,
                  UserId = p.UserId,
                  ExpertName = string.Concat(p.User?.Fname, " ", p.User?.Lname),
                  Total_Carbohydrate = p.Total_Carbohydrate,
                  CreatedDate = p.CreatedDate,
                  MealType = p.MealType ?? "",
                  DietaryType = p.DietaryType ?? "",
                  ShortDescription = p.ShortDescription,
                  RatePercentage = p.RatePercentage,
                  ViewsNumber = p.ViewsNumber,
                  IsFavorite = 0
              }).AsQueryable();


            if (_HttpContextAccessor.HttpContext is not null)
            {
                List<Favorite>? list = new();
                List<string?>? list2 = new();
                var user = _HttpContextAccessor.HttpContext.User;
                List<VmHealthyRecipe> HealthyRecipes = HealthyRecipess.ToList();

                if (user is null)
                {

                    foreach (var item in HealthyRecipes)
                    {
                        item.IsFavorite = 0;


                    }
                }
                else
                {
                    list = await _IRepoFavorite.GetByUserIDAsync(user.FindFirstValue(ClaimTypes.NameIdentifier));
                    list2 = list?.Where(p => p.Type == "وصفات").Select(s => s.HealthyRecipeId).ToList();
                    if (list2 is not null)
                    {
                        foreach (var item in HealthyRecipes)
                        {
                            if (list2.Contains(item.Id))
                                item.IsFavorite = 2;
                            else if (!list2.Contains(item.Id))
                                item.IsFavorite = 1;
                        }
                    }


                }

            }



            if (!string.IsNullOrEmpty(HealthyRecipeQueryParamters.UserId))
            {
                HealthyRecipess = HealthyRecipess.Where(p => p.UserId == HealthyRecipeQueryParamters.UserId);
            }
            if (HealthyRecipeQueryParamters.MinCalories != null)
            {
                HealthyRecipess = HealthyRecipess.Where(p => p.Calories >= HealthyRecipeQueryParamters.MinCalories);
            }
            if (HealthyRecipeQueryParamters.MaxCalories != null)
            {
                HealthyRecipess = HealthyRecipess.Where(p => p.Calories <= HealthyRecipeQueryParamters.MaxCalories);
            }
            if (HealthyRecipeQueryParamters.MinPrepTime != null)
            {
                HealthyRecipess = HealthyRecipess.Where(p => p.PrepTime >= HealthyRecipeQueryParamters.MinPrepTime);
            }
            if (HealthyRecipeQueryParamters.MaxPrepTime != null)
            {
                HealthyRecipess = HealthyRecipess.Where(p => p.PrepTime <= HealthyRecipeQueryParamters.MaxPrepTime);
            }
            if (!string.IsNullOrEmpty(HealthyRecipeQueryParamters.SearchTearm))
            {
                HealthyRecipess = HealthyRecipess.Where(p =>
                   p.Title != null && p.Title.ToLower().Contains(HealthyRecipeQueryParamters.SearchTearm.ToLower()) ||
                    p.ShortDescription != null && p.ShortDescription.ToLower().Contains(HealthyRecipeQueryParamters.SearchTearm.ToLower())
                );
            }

            if (HealthyRecipeQueryParamters.MealType != null)
                if (HealthyRecipeQueryParamters.MealType.Count != 0)
                {
                    List<VmHealthyRecipe> healthyRecipes = new();

                    for (int i = 0; i < HealthyRecipeQueryParamters.MealType.Count; i++)
                    {
                        healthyRecipes.AddRange(HealthyRecipess.Where(p => p.MealType != null && p.MealType.ToLower().Contains(HealthyRecipeQueryParamters.MealType[i].ToLower())));

                    }
                    HealthyRecipess = healthyRecipes.AsQueryable();

                }

            //       healthyRecipes.Clear();

            if (HealthyRecipeQueryParamters.DietaryType != null)
                if (HealthyRecipeQueryParamters.DietaryType.Count != 0)
                {
                    List<VmHealthyRecipe> healthyRecipes = new();

                    for (int i = 0; i < HealthyRecipeQueryParamters.DietaryType.Count; i++)
                    {
                        healthyRecipes.AddRange(HealthyRecipess.Where(p => p.DietaryType != null && p.DietaryType.ToLower().Contains(HealthyRecipeQueryParamters.DietaryType[i].ToLower())));
                    }
                    HealthyRecipess = healthyRecipes.AsQueryable();

                }



            if (!string.IsNullOrEmpty(HealthyRecipeQueryParamters.SortBy))
            {
                if (HealthyRecipeQueryParamters.SortBy.Equals(nameof(HealthyRecipe.RatePercentage), StringComparison.OrdinalIgnoreCase))
                {
                    if (HealthyRecipeQueryParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.RatePercentage);
                    else if (HealthyRecipeQueryParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.RatePercentage);

                }
                else if (HealthyRecipeQueryParamters.SortBy.Equals(nameof(HealthyRecipe.Price), StringComparison.OrdinalIgnoreCase))
                {
                    if (HealthyRecipeQueryParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.Price);
                    else if (HealthyRecipeQueryParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.Price);

                }
                else if (HealthyRecipeQueryParamters.SortBy.Equals(nameof(HealthyRecipe.ViewsNumber), StringComparison.OrdinalIgnoreCase))
                {
                    if (HealthyRecipeQueryParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.ViewsNumber);
                    else if (HealthyRecipeQueryParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.ViewsNumber);

                }
                else if (HealthyRecipeQueryParamters.SortBy.Equals(nameof(HealthyRecipe.CreatedDate), StringComparison.OrdinalIgnoreCase))
                {
                    if (HealthyRecipeQueryParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.CreatedDate);
                    else if (HealthyRecipeQueryParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.CreatedDate);

                }
                else if (HealthyRecipeQueryParamters.SortBy.Equals(nameof(HealthyRecipe.Calories), StringComparison.OrdinalIgnoreCase))
                {
                    if (HealthyRecipeQueryParamters.SortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.Calories);
                    else if (HealthyRecipeQueryParamters.SortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        HealthyRecipess = HealthyRecipess.OrderByDescending(p => p.Calories);

                }

            }
            //     public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            //    new SelectListItem(){Value=nameof(HealthyRecipe.Title),Text="العنوان"},
            //    new SelectListItem(){Value=nameof(HealthyRecipe.Price),Text="السعر"},
            //    new SelectListItem(){Value=nameof(HealthyRecipe.ViewsNumber),Text="عدد المشاهدات"},
            //    new SelectListItem(){Value=nameof(HealthyRecipe.CreatedDate),Text="تاريخ النشر"},
            //    new SelectListItem(){Value=nameof(HealthyRecipe.Calories),Text="عدد السعرات الحرارية"},
            //};

            List<int> MealTypeCounters = new();
            List<string> MealType = Database.GetListOfMealType().Select(b => b.Value).ToList();
            for (int i = 0; i < MealType.Count; i++)
            {
                MealTypeCounters.Add(HealthyRecipess.Count(ex => ex.MealType != null && ex.MealType.Contains(MealType[i])));

            }
            List<int> DietaryTypeCounters = new();
            List<string> DietaryType = Database.GetListOfDietaryType().Select(b => b.Value).ToList();
            for (int i = 0; i < DietaryType.Count; i++)
            {
                DietaryTypeCounters.Add(HealthyRecipess.Count(ex => ex.DietaryType != null && ex.DietaryType.Contains(DietaryType[i])));

            }

            QueryPageResult<VmHealthyRecipe> qpres = CommonMethods.GetPageResult(HealthyRecipess, HealthyRecipeQueryParamters);
            HealthyRecipeQueryPageResult exqpres = new()
            {
                ListOfData = qpres.ListOfData,
                NextPage = qpres.NextPage,
                TotalCount = qpres.TotalCount,
                TotalPages = qpres.TotalPages,
                PreviousPage = qpres.PreviousPage,
                LastRowOnPage = qpres.LastRowOnPage,
                FirstRowOnPage = qpres.FirstRowOnPage,
                DietaryTypeCounters = DietaryTypeCounters,
                MealTypeCounters = MealTypeCounters,


            };




            return exqpres;
        }
    }
}

