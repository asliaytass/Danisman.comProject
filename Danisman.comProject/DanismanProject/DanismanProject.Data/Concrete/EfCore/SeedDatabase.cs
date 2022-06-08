using DanismanProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new DanismanContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
               
                
                if (context.Jobs.Count() == 0)
                {
                    context.Jobs.AddRange(Jobs);
                }
                //if (context.Advisors.Count() == 0)
                //{
                //    context.Advisors.AddRange(Advisors);
                //}
               


                context.SaveChanges();
            }
        }
        

      
        private static Job[] Jobs =
        {
            new Job(){JobName="Psikolog",JobImg="psikoloji.jpg",JobDescription="İnsan, ruh ve beden sağlığı bütünlüğünü koruyabildiği ölçüde mutlu ve dengededir. Kimi tecrübeler hayat kalitemizin düşmesine neden olabilecek kadar zorlu deneyimlerdir. Danışman.com ailesinin uzman psikologları, insanların yaşadığı bu deneyimlere duyarlılık ve farkındalık merceğinden bakılabildiğinde, yaşanan zorlukların en iyi öğretmenlere dönüşebildiğini düşünüyorlar. Değişim yolculuğunuzda güvenebileceğiniz uzman psikologlar Danışman.com farkıyla sizlere kolaylıkla ulaşabilecek kadar yakınlar. Kişisel mahremiyetinizi ve güvenliğinizi önemseyen Danışman.com, deneyimli ve güçlü kadrosuyla farklı alanlarında hizmet vermektedir."},
            new Job(){JobName="Diyetisyen",JobImg="diyetisyen.jpg",JobDescription="Kişiye özel olarak hazırlanan diyet listeleri, sağlıklı beslenme tüyoları, sporcu beslenmesi, beslenme tedavisi ve ihtiyacınız olan her durumda Danışman.com uzmanları günün her anı sizlerle birlikte. Düzenli olarak takip edilen eylem planları sayesinde hedeflerinize ulaşın. İster eposta, ister çevrimiçi ulaşabileceğiniz ya da telefon ile görüşme seçenekleriyle, "},
            new Job(){JobName="Astrolog",JobImg="astroloji.jpg",JobDescription="Yıldız haritanıza göre dilerseniz gelecekte sizleri neler beklediğini öğrenin, dilerseniz ilişki haritanızı danışman.com astrologları sayesinde edinin. Günlük burç yorumlarından çok daha fazlası olan astroloji sayesinde dünyaya geliş amacınızı uzman astrologların tamamen size özel olarak hazırladığı haritalar sayesinde öğrenebilirsiniz. "},
            new Job(){JobName="Yaşam Koçu",JobImg="yasamkoclugu.jpg",JobDescription="Hedef ve hayallerinize ulaşmak, kariyer ve başarı sahibi olmak, sosyal ve duygusal ilişkilerinize ve alışkanlıklarınıza yön vermek için tek ihtiyacınız içinizdeki gücü çıkarabilecek, size hedeflerinize yönelik plan ve program çizecek bir yaşam koçu."},
            new Job(){JobName="Cinsel Sağlık Uzmanı",JobImg="cinselsaglik.jpg",JobDescription="Cinsel sağlık konusunda yaşanan problemler çözümsüz değildir. Partnerinizle yaşadığınız cinsel sorunlar ya da kişisel rahatsızlıklarda kimi zaman çevrenizdekilerden tavsiye almaktan utanabilir, internette doğru bilgiye ulaşmakta zorlanabilir " +
                "ya da hekime başvurmak için çekinebilirsiniz.Cinsel sorunlarınızın hayat kalitenizi düşürmesine izin vermeyin. İhmal edilen cinsel rahatsızlıkları, daha büyük sorunlara yol açmadan çözebilmeniz için alanında oldukça tecrübeli uzmanlarımıza istediğiniz zaman ulaşabilmeniz mümkün."}
        };

        //private static Advisor[] Advisors =
        //{
        //    new Advisor() { AdvisorName="Gözde ",AdvisorSurname="Açıker",SuccessRate=85,AdvisorImg ="advisor1.jpg",IsSuitable=true ,IsApproved=true,Job=Jobs[0]},
        //    new Advisor() { AdvisorName="Sinem ",AdvisorSurname="Taşkın",SuccessRate=95 , IsSuitable=true ,IsApproved=true,Job=Jobs[0]},
        //    new Advisor() {AdvisorName="Begüm ",AdvisorSurname="Isı",SuccessRate=95 ,AdvisorImg ="advisor2.jpeg", IsSuitable=true ,IsApproved=true,Job=Jobs[1]},
        //    new Advisor() {AdvisorName="Bilai ",AdvisorSurname="Çelik",SuccessRate=100 , IsSuitable=true ,IsApproved=true,Job=Jobs[1]},
        //    new Advisor() {AdvisorName="Emel ",AdvisorSurname="Açıkel", SuccessRate=85 ,AdvisorImg ="advisor2.jpg", IsSuitable=true ,IsApproved=true,Job=Jobs[2]},
        //    new Advisor() {AdvisorName="Hasan ",AdvisorSurname="Doğuş",SuccessRate=95 ,AdvisorImg ="advisor3.jpg", IsSuitable=true ,IsApproved=true,Job=Jobs[2]},
        //    new Advisor() {AdvisorName="Nazan ",AdvisorSurname="Koç", SuccessRate=95, IsSuitable=true ,IsApproved=true,Job=Jobs[3]},
        //    new Advisor() {AdvisorName="Asena ",AdvisorSurname="Özgen",SuccessRate=80, IsSuitable=true,IsApproved=true,Job=Jobs[3]},
        //    new Advisor() {AdvisorName="İlhan ",AdvisorSurname="Yılmaz" ,SuccessRate=100, IsSuitable=true ,IsApproved=true,Job=Jobs[4]},
            
        //};   

    

      
    }
}
