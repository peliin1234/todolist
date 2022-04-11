using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using todolist.Models;


namespace todolist.Controllers
{
    public class datatosController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.datados.ToList();
            return View(degerler);
        }
        public IActionResult Haftalık()
        {
            var degerler = c.datados.ToList();
            return View(degerler);
        }
        public IActionResult Aylık(string searchString)
        {
            string yil  = "";
            string ay = "";
            if (searchString != null)
            {
                
                ay = searchString.Split('-')[1].ToString();
                yil = searchString.Split('-')[0].ToString();
                if (ay[0]=='0')
                {
                    ay= ay[1].ToString();
                }
            }
System.Diagnostics.Debug.WriteLine(searchString);
            var degerler = c.datados.Where(d => d.Datetime.Month.ToString() == ay && d.Datetime.Year.ToString() == yil).ToList();
            return View(degerler);
        }

        public IActionResult Yıllık(string searchString)
        {
            var degerler = c.datados.Where(d => d.Datetime.Year.ToString() == searchString).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKayit(datatodo d)
        {
            c.datados.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KayitSil(int Id)
        {
            var dat = c.datados.Find(Id);
            c.datados.Remove(dat);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KayitGetir(int Id)
        {
            var dat = c.datados.Find(Id);
            return View("KayitGetir", dat);
        }
        public IActionResult KayitGüncelle(datatodo d)
        {
            var dat = c.datados.Find(d.Id);
            dat.Donote = d.Donote;
            dat.Datetime = d.Datetime;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
