using liaqati_master.Models;
using MessagePack;
using System.Security.Claims;

namespace liaqati_master.Pages.ProgramPages
{
    [AllowAnonymous]

    public class ToDaycshtmlModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;
        readonly IRepoTraking _repoTraking;
        readonly IRepoOrder_Details _repoOrder_Details;
        private readonly IHttpContextAccessor _HttpContextAccessor;




        public ToDaycshtmlModel(IRepoProgram context, IRepoProgramExercies repocontext, IRepoExercise repocontextExer , IRepoTraking repoTraking, IRepoOrder_Details repoOrder_Details, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
            _repoTraking = repoTraking;
            _repoOrder_Details = repoOrder_Details;
            _HttpContextAccessor = httpContextAccessor;
        }



        [BindProperty(SupportsGet = true)]
        public List<Exercise> Exercises { get; set; }




        [BindProperty(SupportsGet = true)]
        public List<Tracking> Tracking { get; set; }



        [BindProperty(SupportsGet = true)]
        public List<Exercies_program> Exercies_programs { get; set; }


        [BindProperty(SupportsGet = true)]
        public DateTime Today { get; set; }


        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }


        [BindProperty(SupportsGet = true)]
        public DateTime Start { get; set; }



        [BindProperty(SupportsGet = true)]
        public int day { get; set; }


        [BindProperty(SupportsGet = true)]
        public int week { get; set; }



        public async Task OnGet(string id , DateTime DateDay, DateTime startProgram)
        {
            var user = _HttpContextAccessor.HttpContext.User;


            Today = DateDay;
            ID = id;
            Start= startProgram;


            int m= (DateDay - startProgram).Days +1;
            
             day = 0;
             week = 1;




            for (int i = 0; i < 4; i++)
            {
                if (m > 6)
                {
                    m -= 7;
                    week += 1;

                }
                else
                {
                    day = m;
                }





            }

            if (day == 0)
            {
                day= 7;
                week -= 1;

            }
           






            Exercies_programs = (await _repocontext.GetAllExercies_program()).Where(p=>p.SportsProgramId == id).ToList();

            Exercies_programs = Exercies_programs.Where(s => s.Day == day && s.Week == week).ToList();


            if(Exercies_programs is not null)
            {
            var orderdetails=(await _repoOrder_Details.GetAllAsync()).ToList().FirstOrDefault(p => p.ServiceId == id && p.Order.UserId== user.FindFirstValue(ClaimTypes.NameIdentifier));







                foreach (Exercies_program ex in Exercies_programs)
                {

                 var tr=   (await _repoTraking.GetAllAsync()).ToList().FirstOrDefault(p => p.Exercies_programId == ex.Id && p.Order_Details.Order.UserId == user.FindFirstValue(ClaimTypes.NameIdentifier));

                    if (tr == null)
                    {

                        Tracking track = new Tracking()
                        {
                            Id = CommonMethods.Id_Guid(),
                            CreatedDate = orderdetails.CreatedDate,
                            Exercies_programId = ex.Id,
                            Iscomplete = false,
                            Order_DetailsId = orderdetails.Id,

                        };

                        Tracking.Add(track);
                        await _repoTraking.AddEntityAsync(track);

                    }
                    else
                    {
                        Tracking.Add(tr);

                    }


                    //var tracking = (await _repoTraking.GetAllAsync()).ToList();
                    //Tracking track = tracking.FirstOrDefault(p=>p.Exercies_programId==ex.Id);



                                      

                }





            }













            //List<string> list2 = list.Split(',').ToList();

            //foreach (var x in list2)
            //{
            //    Exercise item = await _repocontextExer.GetByIDAsync(x);
            //    Exercises.Add(item);

            //}

         //   return RedirectToPage();

            //  List<string>


        }





        public async Task<IActionResult> OnPostUpdateTraking(string id , bool Iscomplete)
        {

           Tracking tracking=await _repoTraking.GetByIDAsync(id);


            _repoTraking.UpdateEntityAsync(tracking);



            return Page();
        }





    }
}
