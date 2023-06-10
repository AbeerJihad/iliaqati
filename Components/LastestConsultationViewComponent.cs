namespace liaqati_master.Components
{
    public class LastestConsultationViewComponent : ViewComponent
    {
        private readonly IRepoConsultation _unitOfWork;

        public LastestConsultationViewComponent(IRepoConsultation unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AthleticPrograms =(await _unitOfWork.GetAllAsync()).OrderByDescending(a => a.CreatedDate).Take(3).ToList();
            return View(AthleticPrograms);
        }
    }
}
