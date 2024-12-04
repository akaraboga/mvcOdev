using Microsoft.AspNetCore.Mvc;
using mvcOdev.Models;

namespace mvcOdev.Controllers
{
    public class MusteriBilgi : Controller
    {
         

        
        public IActionResult Index()
        {
            var musteri = new List<Musteri>()//Veriler classının içinde bulunan Müşteri clasının propertylerine değerleri gonderiyoruz
            {
                new Musteri{Ad="Ahmet",SoyAd="Karaboğa",email="a.karabogaa46@gmail.com",id=1}
            };


            var siparisler = new List<Siparis>()//Yukardakş işlemlerin aynısı
            {
                new Siparis{Siparis_id=1,SiparisAdet=2,Fiyat=500,UrunAdı="Telefon"},
                new Siparis{Siparis_id=2,SiparisAdet=1,Fiyat=20000,UrunAdı="Bilgisayar"}
            };





            var ViewModel = new Veriler//VievModel ile Veriler clasının içindeki listelere Yukarda olusturduğumuz musteri ve siparisler nesnesini atıyoruz
            {
               musteri = musteri,
               siparis=siparisler,
              
            };

            return View(ViewModel);//Viewa gonderme
        }

     
       

    }
}
