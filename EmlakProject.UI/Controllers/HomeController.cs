using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmlakProject.UI.Models;
using EmlakProject.BLL.Abstract;
using EmlakProject.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Spire.Xls;
using System.Data;
using FastMember;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EmlakProject.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IEmlakciBLL _emlakciBLL;
        private readonly IEmlakBilgisiBLL _emlakBilgisiBLL;
        private readonly IMusteriBLL _musteriBLL;
        public HomeController(ILogger<HomeController> logger,IEmlakBilgisiBLL emlakBilgisiBLL,IEmlakciBLL emlakciBLL,IMusteriBLL musteriBLL)
        {
            _logger = logger;
            _emlakBilgisiBLL = emlakBilgisiBLL;
            _emlakciBLL = emlakciBLL;
            _musteriBLL = musteriBLL;
        }


        public ActionResult DownloadExcel() //TODO: buradaki sıkıntıya bak load from file da 
        {
            Workbook workbook = new Workbook();
            
            workbook.LoadFromFile(@"C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\wwwroot\DetailFormatInExcel\DetailsFormat.xlsx");
            var worksheet1 = workbook.Worksheets[0];
            byte[] array = null;
            var dt1 = _emlakBilgisiBLL.GetAll();

            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(dt1))
            {
                table.Load(reader);
            }
            worksheet1.InsertDataTable(table, false, 3, 1);
            
            using (var ms = new System.IO.MemoryStream())
            {
                workbook.SaveToStream(ms, FileFormat.Version2010);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                array = ms.ToArray();
            }

            return File(array, "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", " Detail.xlsx");
        }

        public IActionResult EmlakciList()
        {
            return View(_emlakciBLL.GetAll());
        }

        public IActionResult AddEmlakci()
        {
            GetAllEmlakciToDLL();
            return View();
        }

        [HttpPost]
        public ActionResult AddEmlakci(Emlakci model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GetAllEmlakciToDLL();

                    Emlakci emlakci = new Emlakci();
                    emlakci.EmlakciAdi = model.EmlakciAdi;
                    emlakci.Adres = model.Adres;
                    emlakci.Fax = model.Fax;
                    emlakci.Telefon = model.Telefon;
                    emlakci.YetkiliAdSoyad = model.YetkiliAdSoyad;
                    
                    try
                    {
                        _emlakciBLL.Add(emlakci);
                        return RedirectToAction("EmlakciList");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Girdiğiniz bilgileri kontrol ediniz");
                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }

        public IActionResult MusteriList()
        {
            return View(_musteriBLL.GetAll());
        }

        public IActionResult AddMusteri()
        {
            GetAllEmlakciToDLL();
            return View();
        }

        [HttpPost]
        public ActionResult AddMusteri(Musteri model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GetAllEmlakciToDLL();

                    Musteri musteri = new Musteri();
                    musteri.Ad = model.Ad;
                    musteri.Soyad = model.Soyad;
                    musteri.Email = model.Email;
                    musteri.EvTel = model.EvTel;
                    musteri.CepTel = model.CepTel;
                    musteri.EmlakciId = model.EmlakciId;
                    try
                    {
                        _musteriBLL.Add(musteri);
                        return RedirectToAction("MusteriList");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Girdiğiniz bilgileri kontrol ediniz");
                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }


        public IActionResult Emlaklar()
        {
            return View(_emlakBilgisiBLL.GetAll());
        }

        public IActionResult EmlakEkle()
        {
            GetAllEmlakciToDLL();
            EmlakTuruFromEnumToDLL();
            return View();
        }

        [HttpPost]
        public ActionResult EmlakEkle(EmlakBilgisi model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GetAllEmlakciToDLL();

                    EmlakBilgisi emlakBilgisi = new EmlakBilgisi();
                    emlakBilgisi.BinaKati = model.BinaKati;
                    emlakBilgisi.EmlakciId = model.EmlakciId;
                    emlakBilgisi.EmlakTuru = model.EmlakTuru;
                    emlakBilgisi.MetreKare = model.MetreKare;
                    emlakBilgisi.OdaSayisi = model.OdaSayisi;
                    emlakBilgisi.Kat = model.Kat;
                   
                    try
                    {
                        _emlakBilgisiBLL.Add(emlakBilgisi);
                        return RedirectToAction("Emlaklar");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", ex.Message);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Girdiğiniz bilgileri kontrol ediniz");
                }
            }
            catch (Exception ex)
            {

            }
            return View();
        }

        public IActionResult GetEmlakciID(int emlakciId)
        {
            GetAllEmlakciToDLL();
            EmlakTuruFromEnumToDLL();
            
            return View(_emlakBilgisiBLL.GetEmlakBYEmlakciId(emlakciId));
        }

        [HttpPost]
        public ActionResult GetEmlakciID(int oda,string metrekare)
        {
            decimal metre = Convert.ToDecimal(metrekare);
            var data=_emlakBilgisiBLL.EmlakBYOdaAndMetre(oda, metre);
            if (data.Count==0)
            {
                ViewBag.CountZero = "Aradığınız kriterlere göre veri bulunmamaktadır.";
            }
            return View(data);
        }

        private void GetAllEmlakciToDLL()
        {
            List<SelectListItem> emlakcilar = new List<SelectListItem>();
            foreach (Emlakci item in _emlakciBLL.GetAll())
            {
                emlakcilar.Add(new SelectListItem { Text = item.EmlakciAdi, Value = item.Id.ToString() });
            }
            ViewBag.Emlakcilar = emlakcilar;
        }

        //emlak tur enum 
        private void EmlakTuruFromEnumToDLL()
        {
            string[] emlakTurEnums = Enum.GetNames(typeof(EmlakTur));
            List<SelectListItem> emlakTur = new List<SelectListItem>();
            foreach (string item in emlakTurEnums)
            {
                emlakTur.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.EmlakTuru = emlakTur;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
