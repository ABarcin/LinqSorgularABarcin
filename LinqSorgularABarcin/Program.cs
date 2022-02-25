using LinqSorgularABarcin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSorgularABgrin
{
    class Program
    {
        static void Main(string[] args)
        {
            Slytherin_AracIhaleEntities context = new Slytherin_AracIhaleEntities();
            int year = 2019;
            int year2 = 2023;
            //Belirtilen iki tarih arasında 2.el teklif verilen araç sayısı ve Marka Model bilgisini sıralayan ihale çıkış fiyatının ustunde olanların ortalamasını alıp ortalama fiyatın ustunde değer verenlerin "ortalamanın ustunde" , ortalama fiyatın altında teklif verenlerin ise "ortalamanın altında" olarak belirteln bir rapor çekiniz. 
            var query = (from aracIhale in context.IhaleArac.ToList()
                         join aracTeklif in context.AracTeklif.ToList() on aracIhale.IhaleAracID equals aracTeklif.IhaleAracID
                         join arac in context.Arac.ToList() on aracIhale.AracID equals arac.AracID
                         where aracTeklif.Tarih.Value.Year>year && aracTeklif.Tarih.Value.Year<year2
                         group new {aracIhale,aracTeklif,arac } by new {arac.AracID } into gr
                         select new 
                         {
                            AracID=gr.Key,
                            Average=gr.Average(x=>x.aracTeklif.TeklifFiyat),
                            Price=gr.Where(x=>x.aracTeklif.TeklifOnay==true).Select(x=>x.aracTeklif.TeklifFiyat).FirstOrDefault(),
                            Model=gr.Select(x=>x.arac.ArabaModel.Ad).FirstOrDefault(),
                            Marka=gr.Select(x=>x.arac.Marka.Ad),
                            AracTeklifCount=gr.Select(x=>x.aracIhale.AracID).Count()
                         }).ToList();

            //Araç Başı karlılık oranını hesaplayınız.
            var query2 = (from arac in context.Arac.ToList()
                                join aracFiyat in context.AracFiyat on arac.AracID equals aracFiyat.AracID
                                join aracIhale in context.IhaleArac on arac.AracID equals aracIhale.AracID
                                join t in context.AracTeklif on aracIhale.IhaleAracID equals t.IhaleAracID
                                group new { arac, aracFiyat, t } by new { arac.AracID } into gr
                                select new
                                {
                                    AracID = gr.Key,
                                    Kar = (gr.Where(x => x.t.TeklifOnay == true).OrderByDescending(x => x.t.TeklifFiyat).Select(x => x.t.TeklifFiyat).FirstOrDefault()) - (gr.OrderByDescending(x => x.aracFiyat.Tarih)).Select(x => x.aracFiyat.Fiyat).FirstOrDefault()
                                }).ToList();
            //2.el araç ekspertiz yapılan araç sayısı çoktan aza sıralayınız. 
            var query3 = (from aracTramer in context.AracTramer.ToList()
                                   group new { aracTramer } by new { aracTramer.AracID } into gr
                                   select new
                                   {
                                       AracID = gr.Key,
                                       EkspertCount = gr.Count()
                                   }).ToList().OrderByDescending(x => x.EkspertCount);

            Console.ReadLine();

        }
    }
}
