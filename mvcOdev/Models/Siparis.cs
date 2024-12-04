namespace mvcOdev.Models
{
    public class Siparis//Sipariş classının propertyleri
    {

      
        public int Siparis_id { get; set; }
        public string UrunAdı { get; set; } = "";
        public int Fiyat { get; set; }
        public int SiparisAdet { get; set; }

    }
}
