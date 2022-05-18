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
                if (context.Advisors.Count() == 0)
                {
                    context.Advisors.AddRange(Advisors);
                }
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Contents.Count() == 0)
                {
                    context.Contents.AddRange(Contents);
                }
                if (context.Jobs.Count() == 0)
                {
                    context.Jobs.AddRange(Jobs);
                }
                if (context.Subcategories.Count() == 0)
                {
                    context.Subcategories.AddRange(Subcategories);
                }
                if (context.SubcategoryAdvisors.Count() == 0)
                {
                    context.SubcategoryAdvisors.AddRange(SubcategoryAdvisors);
                }
                context.SaveChanges();
            }
        }

      

        private static Category[] Categories =
        {
            new Category() {CategoryName="Psikoloji",CategoryDescription="Ruh dengesinin bozulmasıyla her şeyin üst üste geldiğini düşünebilirsiniz. Ruhun en ciddi rahatsızlıklarının başlangıcı depresyon, sinsi bir rahatsızlıktır.",CategoryImg=""},
            new Category() {CategoryName="Diyet",CategoryDescription="Acı çekmeden kilo vermek, verilen kiloların ise vücut formunu bozmadan kalıcılığını sağlamak için uzman desteği önemlidir. Diyetisyen ve sağlıklı beslenme uzmanları kişiye özel menüleri ve tavsiyeleri " +
                "ile fazla kilolara veda etmenizi, ihtiyacınız var ise kilo almanızı sağlar.",CategoryImg=""},
            new Category() {CategoryName="Astroloji",CategoryDescription="Ruh dengesinin bozulmasıyla her şeyin üst üste geldiğini düşünebilirsiniz. Ruhun en ciddi rahatsızlıklarının başlangıcı depresyon, sinsi bir rahatsızlıktır.",CategoryImg=""},
            new Category() {CategoryName="Yaşam Koçu",CategoryDescription="Hayatınızı değiştirmek, belirlediğiniz hedef ve amaçlara ulaşmak aslında sizin elinizde. Tek ihtiyacınız olan içinizdeki gücü çıkarabilecek, size hedeflerinize yönelik plan ve program çizecek bir yaşam koçudur.",CategoryImg=""},
            new Category() {CategoryName="Cinsel Sağlık",CategoryDescription="Hayat kalitesini düşüren cinsel sağlık sorunlarının tedavi edilmemesi ciddi hastalıklara da yol açabilir. Üstelik partnerler arasında problemlere de neden olur. Hiçbir sorun çözümsüz değildir,",CategoryImg=""}
        };
        private static Job[] Jobs =
        {
            new Job(){JobName="Psikolog",JobDescription="İnsan, ruh ve beden sağlığı bütünlüğünü koruyabildiği ölçüde mutlu ve dengededir. Kimi tecrübeler hayat kalitemizin düşmesine neden olabilecek kadar zorlu deneyimlerdir. Danışman.com ailesinin uzman psikologları, insanların yaşadığı bu deneyimlere duyarlılık ve farkındalık merceğinden bakılabildiğinde, yaşanan zorlukların en iyi öğretmenlere dönüşebildiğini düşünüyorlar. Değişim yolculuğunuzda güvenebileceğiniz uzman psikologlar Danışman.com farkıyla sizlere kolaylıkla ulaşabilecek kadar yakınlar. Kişisel mahremiyetinizi ve güvenliğinizi önemseyen Danışman.com, deneyimli ve güçlü kadrosuyla farklı alanlarında hizmet vermektedir."},
            new Job(){JobName="Diyetisyen",JobDescription="Kişiye özel olarak hazırlanan diyet listeleri, sağlıklı beslenme tüyoları, sporcu beslenmesi, beslenme tedavisi ve ihtiyacınız olan her durumda Danışman.com uzmanları günün her anı sizlerle birlikte. Düzenli olarak takip edilen eylem planları sayesinde hedeflerinize ulaşın. İster eposta, ister çevrimiçi ulaşabileceğiniz ya da telefon ile görüşme seçenekleriyle, "},
            new Job(){JobName="Astrolog",JobDescription="Yıldız haritanıza göre dilerseniz gelecekte sizleri neler beklediğini öğrenin, dilerseniz ilişki haritanızı danışman.com astrologları sayesinde edinin. Günlük burç yorumlarından çok daha fazlası olan astroloji sayesinde dünyaya geliş amacınızı uzman astrologların tamamen size özel olarak hazırladığı haritalar sayesinde öğrenebilirsiniz. "},
            new Job(){JobName="Yaşam Koçu",JobDescription="Hedef ve hayallerinize ulaşmak, kariyer ve başarı sahibi olmak, sosyal ve duygusal ilişkilerinize ve alışkanlıklarınıza yön vermek için tek ihtiyacınız içinizdeki gücü çıkarabilecek, size hedeflerinize yönelik plan ve program çizecek bir yaşam koçu."},
            new Job(){JobName="Cinsel Sağlık Uzmanı",JobDescription="Cinsel sağlık konusunda yaşanan problemler çözümsüz değildir. Partnerinizle yaşadığınız cinsel sorunlar ya da kişisel rahatsızlıklarda kimi zaman çevrenizdekilerden tavsiye almaktan utanabilir, internette doğru bilgiye ulaşmakta zorlanabilir " +
                "ya da hekime başvurmak için çekinebilirsiniz.Cinsel sorunlarınızın hayat kalitenizi düşürmesine izin vermeyin. İhmal edilen cinsel rahatsızlıkları, daha büyük sorunlara yol açmadan çözebilmeniz için alanında oldukça tecrübeli uzmanlarımıza istediğiniz zaman ulaşabilmeniz mümkün."}
        };

        private static Advisor[] Advisors =
        {
            new Advisor() { AdvisorNameSurname="Gözde Açıker",SuccessRate=85, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[0],Job=Jobs[0]},
            new Advisor() { AdvisorNameSurname="Sinem Taşkın",SuccessRate=95, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[0],Job=Jobs[0]},
            new Advisor() { AdvisorNameSurname="Begüm Isı",SuccessRate=95, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[1],Job=Jobs[1]},
            new Advisor() { AdvisorNameSurname="Bilal Çelik",SuccessRate=100, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[1],Job=Jobs[1]},
            new Advisor() { AdvisorNameSurname="Emel Açıkel",SuccessRate=85, IsSuitable=true ,IsHome=false,IsApproved=true,Category=Categories[2],Job=Jobs[2]},
            new Advisor() { AdvisorNameSurname="Hasan Doğuş",SuccessRate=95, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[2],Job=Jobs[2]},
            new Advisor() { AdvisorNameSurname="Nazan Koç",SuccessRate=95, IsSuitable=true ,IsHome=false,IsApproved=true,Category=Categories[3],Job=Jobs[3]},
            new Advisor() { AdvisorNameSurname="Asena Özgen",SuccessRate=80, IsSuitable=true,IsHome=true ,IsApproved=true,Category=Categories[3],Job=Jobs[3]},
            new Advisor() { AdvisorNameSurname="İlhan Yılmaz",SuccessRate=100, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[4],Job=Jobs[4]},
            new Advisor() { AdvisorNameSurname="Doğuş Yıldız",SuccessRate=95, IsSuitable=true ,IsHome=true,IsApproved=true,Category=Categories[4],Job=Jobs[4]}
        };

        private static Content[] Contents =
        {
            new Content(){ContentName="Sigarayı Bırakmak",ContentImg="",ContentText="Yapılan araştırmalar ortaya koyuyor ki çeşitli " +
                "kanserler ile mücadele etmek durumunda kalan insanların üçte biri sigara yüzünden bu hastalıkla karşı karşıya kalmış." +
                " Hal böyle olunca sağlıklı olmak isteyen insanlar kesinlikle sigaradan uzak durmalı. Bu kötü alışkanlığı kazanmış kişilerin " +
                "ise en kısa zamanda sigarayı bırakmak için adımlar atması bir gereklilik.Tabi ki bir alışkanlıktan vazgeçmeye karar veren kişi" +
                " bu konuda çeşitli kaygılar yaşayabilir.  Zorlanacağını düşünebilir. Bütün bu duyguları hissetmenin normal olduğu bilinmelidir." +
                " Ancak kesin kararlar ile net adımlar atmak kişiyi bu kötü alışkanlıktan kurtaracaktır." +
                " Esasında genel olarak sigaranın zararlı olduğunu hemen herkes kabul eder. Ancak nedendir bilinmez; " +
                "sigara tiryakileri sigarayı bırakmak konusunda karar alırken; zorlanmaktadır.",Category=Categories[0]},

            new Content(){ContentName="Obsesif Kompulsif Bozukluklar",ContentImg="",ContentText="Obsesif kompulsif bozukluklar nedir? Depresyon" +
                " durumunun sürekli bir şekilde tekrarlanmasına bağlı olarak kişinin geliştirmiş olduğu sürekli tekrar eden karakteristik davranış" +
                " durumuna obsesif kompulsif bozukluk denir. Bir obsesif kompulsif bozukluk durumu geliştiği zaman günlük yaşam da içinden çıkılmaz" +
                " bir hal alabilir. Bu durum gayet doğal olarak obsesif kompulsif bozuklukların etkili bir düzeyde tedavi edilmesinin şart olduğu" +
                " gerçeğini karşımıza çıkarmaktadır.İnsanlar yapıları gereği ruhsal denge ile var olurlar. Ruhsal dengenin sağlanmadığı hiçbir alanda" +
                " sağlık düşünülemez. Tıbbın da alanlarından biri olan psikoloji insan ruhsal sağlığı üzerine düşünür ve tedavi geliştirir. Psikoloji " +
                "dalında yaşanan kayda alınmış birçok türde vaka ve hastalık çeşidi bulunmaktadır.",Category=Categories[0]},

            new Content(){ContentName="Kilo Verme Yöntemleri Nelerdir?",ContentImg="",ContentText="Her geçen gün araştırmalar" +
                " ve deneyimler sayesinde farklı farklı kilo verme yöntemleri ortaya çıkmaktadır. Bu yöntemlerden bazıları fazlasıyla" +
                " etkilidir. Öncelikle bol su içmek gerekmektedir. Su sağlıklı yaşamın temelidir. Metabolizmayı hızlandırdığı için" +
                " kalori yakımı kolaylaşmaktadır. Günde en az 2 en fazla 3 litre su içmek kilo vermeye yardımcı olacaktır.Türk kahvesinin" +
                " ve filtre kahvenin yağ yakıcı özelliği ise çok az insan tarafından bilinmektedir. Kafein metabolizmayı hızlandırır. Ayrıca" +
                " egzersizden önce kahve içmek yağ yakımını hızlandıracaktır.Kiminin çok sevdiği kiminin ise hiç sevmediği mucizevi bitki ‘’yeşil çay’’." +
                " Yeşil çay içerisinde çok güçlü antioksidanlar barındırmaktadır. İçerisinde kafein vardır. Metabolizmanın hızlanmasına ve yağ yakımının " +
                "artmasına etki etmektedir. ",Category=Categories[1]},

            new Content(){ContentName="Astroloji Haritası",ContentImg="",ContentText="Astroloji haritası çıkarmak için matematik ve astronomik " +
                "hesaplamaların doğru bir şekilde yapılması gerekir. Kimilerine göre kehanet olarak kabul edilse de aslında astroloji, bilim " +
                "dallarından yardım alınarak hesaplanan bir yöntemdir. Bu nedenle yıldız haritasını hazırlayacak olan kişilerin belirli bilgi" +
                " birikimine sahip olması gerekir.Astroloji haritasının her zaman etkili bir düzeyde merak edildiğini rahatlıkla ifade edebiliriz." +
                " Bu kapsamda astroloji haritalarının yorumlanmasına dair farklı tekniklerin de devreye girdiği bilinmektedir.",Category=Categories[2]},

            new Content(){ContentName="Online Yaşam Koçu Nedir?",ContentImg="",ContentText="Online yaşam koçu nedir? Kişinin kendisinde var olan" +
                " gücü keşfetmesine yönelik çalışmalarını profesyonel bir düzeyde gerçekleştiren bireylere yaşam koçu denir. Yaşam koçu hizmetinin" +
                " online ortamda sunulmasına online yaşam koçu hizmeti denir. Online yaşam koçları, kaliteli yaşam noktasında geniş kapsamlı bir " +
                "hizmetin merkezinde yer alırlar.Günümüzde yeni farklı iş alanları hızla gelişiyor. Son zamanların popüler meslek çeşitleri arasında " +
                "da online yaşam koçu mesleği yer alıyor.",Category=Categories[3]},

            new Content(){ContentName="Cinsel Yaşam ve Sağlık",ContentImg="",ContentText="Cinsellik partnerlerin birbirlerine karşı sevgi" +
                " ve bağlılıklarını ifade etmelerinin önemli araçlarından biri. Üstelik mutluluğunuza olduğu kadar sağlığınıza da katkısı var." +
                "Düzenli ve güvenli seks yapan insanlarda, vücudu mikroplara, virüslere ve diğer davetsiz misafirlere karşı koruyan bağışıklık " +
                "sistemi daha güçlüdür. Araştırmacılar, haftada bir veya iki kez cinsel aktivitede bulunan yetişkinlerde (daha az bulunanlara kıyasla)" +
                " hastalıklara karşı daha güçlü bir bağışıklık sistemi ve yüksek antikor seviyesi saptamıştır.",Category=Categories[4]}
        };

    

        private static Subcategory[] Subcategories =
        {
            new Subcategory(){SubcategoryName="Bireysel Psikoloji",Category=Categories[0]},
            new Subcategory(){SubcategoryName="Evlilik ve İlişki Terapisi",Category=Categories[0]},
            new Subcategory(){SubcategoryName="Sağlıklı Zayıflama",Category=Categories[1]},
            new Subcategory(){SubcategoryName="Sporcu Beslenmesi",Category=Categories[1]},
            new Subcategory(){SubcategoryName="Kişisel Gezegen Analizi",Category=Categories[2]},
            new Subcategory(){SubcategoryName="Doğum Haritası Analizi",Category=Categories[2]},
            new Subcategory(){SubcategoryName="Bireysel Koçluk",Category=Categories[3]},
            new Subcategory(){SubcategoryName="Öğrenci Koçluğu",Category=Categories[3]},
            new Subcategory(){SubcategoryName="Kadın CinseL Sağlığı",Category=Categories[4]},
            new Subcategory(){SubcategoryName="Erkek CinseL Sağlığı",Category=Categories[4]}
        };

        private static SubcategoryAdvisor[] SubcategoryAdvisors =
        {
            new SubcategoryAdvisor(){Subcategory= Subcategories[0], Advisor=Advisors[0]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[1], Advisor=Advisors[0]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[1], Advisor=Advisors[1]},

            new SubcategoryAdvisor(){Subcategory= Subcategories[2], Advisor=Advisors[2]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[3], Advisor=Advisors[3]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[3], Advisor=Advisors[2]},

            new SubcategoryAdvisor(){Subcategory= Subcategories[4], Advisor=Advisors[4]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[4], Advisor=Advisors[5]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[5], Advisor=Advisors[5]},

            new SubcategoryAdvisor(){Subcategory= Subcategories[6], Advisor=Advisors[6]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[7], Advisor=Advisors[7]},

            new SubcategoryAdvisor(){Subcategory= Subcategories[8], Advisor=Advisors[8]},
            new SubcategoryAdvisor(){Subcategory= Subcategories[9], Advisor=Advisors[9]},

        };
    }
}
