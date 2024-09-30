using Microsoft.AspNetCore.Mvc;
using POS.BLL.Guide;
using POS.Common;
using POS.DTO.Guide;

namespace POS.Web.Areas.Guide.Controllers
{
    [Area(AppConstant.Areas.Guide)]
    public class StoreController(StockBll stockBll) : Controller
    {
        private readonly StockBll _stockBll = stockBll;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(StockDto mdl) => Ok(_stockBll.Save(mdl));



    }
}
