using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barkod_Otomasyon.Models;
namespace Barkod_Otomasyon
{
    public class SatisUrunu
    {
        public Urun urun{get;set;}
        public int adet{get;set;}
        public decimal adetFiyat{get;set;}
        public decimal adetAlisFiyati { get; set; }
        public decimal toplamFiyat { get; set; }
        
    }
}
