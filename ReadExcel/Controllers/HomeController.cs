using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using OfficeOpenXml;
using ReadExcel.Models;
using System.Data;

namespace ReadExcel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReadExcelUsingEpplus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReadExcel(HttpPostedFileBase uploadFile)
        {
            if (Path.GetExtension(uploadFile.FileName) == ".xlsx" || Path.GetExtension(uploadFile.FileName) == ".xls")
            {
                ExcelPackage package = new ExcelPackage(uploadFile.InputStream);
                DataTable Dt = ExcelPackageExtensions.ToDataTable(package);
            }
            return View();
        }
    }
}
