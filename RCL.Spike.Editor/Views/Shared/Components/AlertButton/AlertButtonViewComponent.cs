namespace RCL.Spike.Editor.Views.Shared.Components
{
    using Microsoft.AspNetCore.Mvc;

    public class AlertButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string id)
        {
            return View(new Model { Id = id });
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var a = await Task.FromResult(true);

        //    return View();
        //}

        public class Model
        {
            public string Id { get; set; }
        }
    }
}
