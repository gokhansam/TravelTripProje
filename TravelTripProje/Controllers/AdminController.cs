using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sinifler;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize] //giris sayfasından k.adi-sifre ile girişi sağlar. Webconfig'de de belirtmek şart.
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet] // sayfa açıldıgında, bize sayfayi getirsin. Başka birşey yapmasın.
        public ActionResult YeniBlog() //yeniblog ekleme sayfası
        {
            return View();
        }
        [HttpPost] // sayfada herhangi bir işlem yaptıgım zaman, bu alttaki ActionResult'taki kodları çalıştır.
        //yeniblog sayfasında eklenecek bilgileri buton yardımıyla db.ye kayıtedecez.
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil (int id)
        {
            var b =c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        // var olan satırı güncelemek için önce seçilen satırı 'BlogGetir' sayfasına çekmemiz lazım.
        
        public ActionResult BlogGetir (int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl); // BlogGetir sayfasını getir fakat getirirken de 'bl' nin içindekilerle beraber getir.
        }
        // 'bloggetir' sayfasında çektiğimiz satırı, burada button aracılığıyla güncelliyoruz
        public ActionResult BlogGuncelle (Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
                blg.Aciklama = b.Aciklama;
                blg.Baslik = b.Baslik;
                blg.BlogImage = b.BlogImage;
                blg.Tarih =b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil (int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir (int id)
        {
            var yrm = c.Yorumlars.Find(id);
            return View("YorumGetir",yrm);
        }
        public ActionResult YorumGuncelle (Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    } 
}