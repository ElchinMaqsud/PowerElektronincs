using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Db
{
    public class FinalProject_Db:IdentityDbContext<ApplicationUser>
    {
        public FinalProject_Db(DbContextOptions<FinalProject_Db> options) : base(options)
        {
        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<AnsImages> AnsImages { get; set; }
        public DbSet<Operator> Operators { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
                    new Category { Id=1, Name="Telefon"},
                    new Category { Id=2, Name="Planşet"},
                    new Category { Id=3,Name="Notbuk"},
                    new Category { Id=4, Name="Televizor"},
                    new Category { Id=5, Name="SmartWatch"}

                );
            builder.Entity<Operator>().HasData(
                new Operator { Id=1, OperatorNumber="050"},
                new Operator { Id = 2, OperatorNumber = "051" },
                new Operator { Id = 3, OperatorNumber = "055" },
                new Operator { Id = 4, OperatorNumber = "070" },
                new Operator { Id = 5, OperatorNumber = "077" }
                );
            
            builder.Entity<City>().HasData(
                new City { Id = 1, Name = "Abşeron" },
                new City { Id = 2, Name = "Ağcabədi" },
                new City { Id = 3, Name = "Ağdam" },
                new City { Id = 4, Name = "Ağdaş" },
                new City { Id = 5, Name = "Ağstafa" },
                new City { Id = 6, Name = "Ağsu" },
                new City { Id = 7, Name = "Astara" },
                new City { Id = 8, Name = "Bakı" },
                new City { Id = 9, Name = "Balakən" },
                new City { Id = 10, Name = "Beyləqan" },
                new City { Id = 11, Name = "Bərdə" },
                new City { Id = 12, Name = "Biləsuvar" },
                new City { Id = 13, Name = "Cəbrayıl" },
                new City { Id = 14, Name = "Cəlilabad" },
                new City { Id = 15, Name = "Daşkəsən" },
                new City { Id = 16, Name = "Füzuli" },
                new City { Id = 17, Name = "Gədəbəy" },
                new City { Id = 18, Name = "Gəncə" },
                new City { Id = 19, Name = "Goranboy" },
                new City { Id = 20, Name = "Göyçay" },
                new City { Id = 21, Name = "Göygöl" },
                new City { Id = 22, Name = "Hacıqabul" },
                new City { Id = 23, Name = "Xaçmaz" },
                new City { Id = 24, Name = "Xankəndi" },
                new City { Id = 25, Name = "Xızı" },
                new City { Id = 26, Name = "Xocalı" },
                new City { Id = 27, Name = "Xocavənd" },
                new City { Id = 28, Name = "İmişli" },
                new City { Id = 29, Name = "İsmayıllı" },
                new City { Id = 30, Name = "Kəlbəcər" },
                new City { Id = 31, Name = "Kürdəmir" },
                new City { Id = 32, Name = "Qax" },
                new City { Id = 33, Name = "Qazax" },
                new City { Id = 34, Name = "Qəbələ" },
                new City { Id = 35, Name = "Qobustan" },
                new City { Id = 36, Name = "Quba" },
                new City { Id = 37, Name = "Qubadlı" },
                new City { Id = 38, Name = "Qusar" },
                new City { Id = 39, Name = "Laçın" },
                new City { Id = 40, Name = "Lerik" },
                new City { Id = 41, Name = "Lənkəran" },
                new City { Id = 42, Name = "Masallı" },
                new City { Id = 43, Name = "Mingəçevir" },
                new City { Id = 44, Name = "Naftalan" },
                new City { Id = 45, Name = "Neftçala" },
                new City { Id = 46, Name = "Oğuz" },
                new City { Id = 47, Name = "Saatlı" },
                new City { Id = 48, Name = "Sabirabad" },
                new City { Id = 49, Name = "Salyan" },
                new City { Id = 50, Name = "Samux" },
                new City { Id = 51, Name = "Siyəzən" },
                new City { Id = 52, Name = "Sumqayıt" },
                new City { Id = 53, Name = "Şabran" },
                new City { Id = 54, Name = "Şamaxı" },
                new City { Id = 55, Name = "Şirvan" },
                new City { Id = 56, Name = "Şəki" },
                new City { Id = 57, Name = "Şəmkir" },
                new City { Id = 58, Name = "Şuşa" },
                new City { Id = 59, Name = "Tərtər" },
                new City { Id = 60, Name = "Tovuz" },
                new City { Id = 61, Name = "Ucar" },
                new City { Id = 62, Name = "Yardımlı" },
                new City { Id = 63, Name = "Yevlax" },
                new City { Id = 64, Name = "Zaqatala" },
                new City { Id = 65, Name = "Zəngilan" },
                new City { Id = 66, Name = "Zərdab" }
            );
            builder.Entity<Mark>().HasData(
                    new Mark { Id = 1, Name = "Apple", CategoryId = 1 },
                    new Mark { Id = 2, Name = "Samsung", CategoryId = 1 },
                    new Mark { Id = 3, Name = "Xiaomi", CategoryId = 1 },
                    new Mark { Id = 4, Name = "Huawei", CategoryId = 1 },
                    new Mark { Id = 5, Name = "Honor", CategoryId = 1 },
                    new Mark { Id = 6, Name = "Htc", CategoryId = 1 },
                    new Mark { Id = 7, Name = "Sony", CategoryId = 1 },

                    new Mark { Id = 8, Name = "Apple", CategoryId = 2 },
                    new Mark { Id = 9, Name = "Samsung", CategoryId = 2 },
                    new Mark { Id = 10, Name = "Lenovo", CategoryId = 2 },
                    new Mark { Id = 11, Name = "Huawei", CategoryId = 2 },
                    new Mark { Id = 12, Name = "Acer", CategoryId = 2 },


                    new Mark { Id = 13, Name = "Apple", CategoryId = 3 },
                    new Mark { Id = 14, Name = "Microsoft", CategoryId = 3 },
                    new Mark { Id = 15, Name = "Acer", CategoryId = 3 },
                    new Mark { Id = 16, Name = "Lenovo", CategoryId = 3 },
                    new Mark { Id = 17, Name = "Asus", CategoryId = 3 },
                    new Mark { Id = 18, Name = "Dell", CategoryId = 3 },
                    new Mark { Id = 19, Name = "Hp", CategoryId = 3 },


                    new Mark { Id = 20, Name = "Hoffmann", CategoryId = 4 },
                    new Mark { Id = 21, Name = "Lg", CategoryId = 4 },
                    new Mark { Id = 22, Name = "Panasonic", CategoryId = 4 },
                    new Mark { Id = 23, Name = "Samsung", CategoryId = 4 },
                    new Mark { Id = 24, Name = "Sony", CategoryId = 4 },


                    new Mark { Id = 25, Name = "Apple", CategoryId = 5 },
                    new Mark { Id = 26, Name = "Samsung", CategoryId = 5 },
                    new Mark { Id = 27, Name = "Xiaomi", CategoryId = 5 },
                    new Mark { Id = 28, Name = "Huawei", CategoryId = 5 },
                    new Mark { Id = 29, Name = "Honor", CategoryId = 5 }
                );

            builder.Entity<Model>().HasData(
                 new Model { Id = 1, Name = "X", MarkId = 1 },
                 new Model { Id = 2, Name = "XS", MarkId = 1 },
                 new Model { Id = 3, Name = "XS Max", MarkId = 1 },
                 new Model { Id = 4, Name = "11", MarkId = 1 },
                 new Model { Id = 5, Name = "11 Pro", MarkId = 1 },
                 new Model { Id = 6, Name = "11 Pro Max ", MarkId = 1 },

                 new Model { Id = 7, Name = "Galaxy Note 5", MarkId = 2 },
                 new Model { Id = 8, Name = "Galaxy Note 7", MarkId = 2 },
                 new Model { Id = 9, Name = "Galaxy Note 8", MarkId = 2 },
                 new Model { Id = 10, Name = "Galaxy Note 9", MarkId = 2 },
                 new Model { Id = 11, Name = "Galaxy S6", MarkId = 2 },
                 new Model { Id = 12, Name = "Galaxy S7", MarkId = 2 },


                 new Model { Id = 13, Name = "Mi A2 Lite", MarkId = 3 },
                 new Model { Id = 14, Name = "Mi A2", MarkId = 3 },
                 new Model { Id = 15, Name = "Mi A3", MarkId = 3 },
                 new Model { Id = 16, Name = "Redmi Note 4", MarkId = 3 },
                 new Model { Id = 17, Name = "Redmi Note 5", MarkId = 3 },
                 new Model { Id = 18, Name = "Redmi Note 7", MarkId = 3 },

                 new Model { Id = 19, Name = "Mate 20 Lite", MarkId = 4 },
                 new Model { Id = 20, Name = "Mate 20", MarkId = 4 },
                 new Model { Id = 21, Name = "Mate 20 Pro ", MarkId = 4 },
                 new Model { Id = 22, Name = "P20 Pro", MarkId = 4 },
                 new Model { Id = 23, Name = "P30 Lite", MarkId = 4 },
                 new Model { Id = 24, Name = "P30 Pro", MarkId = 4 },


                 new Model { Id = 25, Name = "7A", MarkId = 5 },
                 new Model { Id = 26, Name = "8S", MarkId = 5 },
                 new Model { Id = 27, Name = "9 Lite ", MarkId = 5 },
                 new Model { Id = 28, Name = "10 Lite", MarkId = 5 },
                 new Model { Id = 29, Name = "8X", MarkId = 5 },
                 new Model { Id = 30, Name = "10", MarkId = 5 },


                 new Model { Id = 31, Name = "Desire 630 Dual", MarkId = 6 },
                 new Model { Id = 32, Name = "U Play", MarkId = 6 },
                 new Model { Id = 33, Name = "Desire 530 ", MarkId = 6 },
                 new Model { Id = 34, Name = "One M8", MarkId = 6 },
                 new Model { Id = 35, Name = "One M9", MarkId = 6 },
                 new Model { Id = 36, Name = "One M10", MarkId = 6 },


                 new Model { Id = 37, Name = "Xperia Z", MarkId = 7 },
                 new Model { Id = 38, Name = "Xperia Z1", MarkId = 7 },
                 new Model { Id = 39, Name = "Xperia Z2 ", MarkId = 7 },
                 new Model { Id = 40, Name = "Xperia Z3", MarkId = 7 },
                 new Model { Id = 41, Name = "Xperira Z5", MarkId = 7 },
                 new Model { Id = 42, Name = "Xpeira XZ", MarkId = 7 },



                 new Model { Id = 43, Name = "iPad 6", MarkId = 8 },
                 new Model { Id = 44, Name = "iPad Pro 2018", MarkId = 8 },
                 new Model { Id = 45, Name = "iPad Air 2019", MarkId = 8},
                 new Model { Id = 46, Name = "iPad Mini 2019", MarkId = 8 },
                 new Model { Id = 47, Name = "iPad Pro 2019", MarkId = 8 },

                 new Model { Id = 48, Name = "Tab E 8.1", MarkId = 9 },
                 new Model { Id = 49, Name = "Tab E 10.1", MarkId = 9 },
                 new Model { Id = 50, Name = "Tab A 7.1", MarkId = 9 },
                 new Model { Id = 51, Name = "Tab A 8.1", MarkId = 9 },
                 new Model { Id = 52, Name = "Tab A 10.1", MarkId = 9 },

                 new Model { Id = 53, Name = "Tab E 10", MarkId = 10 },
                 new Model { Id = 54, Name = "Tab 10", MarkId = 10 },
                 new Model { Id = 55, Name = "Tab 4", MarkId = 10 },
                 new Model { Id = 56, Name = "Tab TB 7104", MarkId = 10 },
                 new Model { Id = 57, Name = "Tab E10 TB", MarkId = 10 },


                 new Model { Id = 58, Name = "Tab E 10", MarkId = 11 },
                 new Model { Id = 59, Name = "Tab 10", MarkId = 11 },
                 new Model { Id = 60, Name = "Tab 4", MarkId = 11 },
                 new Model { Id = 61, Name = "Tab TB 7104", MarkId = 11 },
                 new Model { Id = 62, Name = "Tab E10 TB", MarkId = 11 },


                 new Model { Id = 63, Name = "M5 Lite 32Gb", MarkId = 12 },
                 new Model { Id = 64, Name = "M5 64gb", MarkId = 12 },
                 new Model { Id = 65, Name = "MediaPad T5 2+16gb", MarkId = 12 },
                 new Model { Id = 66, Name = "MediaPad T5 3+32gb", MarkId = 12 },
                 new Model { Id = 67, Name = "MediaPad T5 4+64gb", MarkId = 12 },



                 new Model { Id = 68, Name = "MacBook Air 13″ MRE82", MarkId = 13 },
                 new Model { Id = 69, Name = "Macbook Pro 13″ MR9Q2", MarkId = 13 },
                 new Model { Id = 70, Name = "MacBook Air 13″ MREE2", MarkId = 13 },
                 new Model { Id = 71, Name = "Macbook Pro 13″ MV962", MarkId = 13 },
                 new Model { Id = 72, Name = "MacBook Pro 15″ MR932", MarkId = 13 },

                 new Model { Id = 73, Name = "Surface 4 Pro", MarkId = 14 },
                 new Model { Id = 74, Name = "Surface 5 Pro", MarkId = 14 },
                 new Model { Id = 75, Name = "Surface 6 Pro", MarkId = 14},
                 new Model { Id = 76, Name = "Surface Book", MarkId = 14 },
                 new Model { Id = 77, Name = "Surface Pro Book", MarkId = 14 },

                 new Model { Id = 78, Name = "Swift 3 SF-314", MarkId = 15 },
                 new Model { Id = 79, Name = "Swift 3 SF-315", MarkId = 15 },
                 new Model { Id = 80, Name = "Predator Helios 300", MarkId = 15 },
                 new Model { Id = 81, Name = "Predator Helios 700", MarkId = 15 },
                 new Model { Id = 82, Name = "Swift 5 SF-314ur", MarkId = 15 },

                 new Model { Id = 83, Name = "IdeaPad 110", MarkId = 16 },
                 new Model { Id = 84, Name = "IP330", MarkId = 16 },
                 new Model { Id = 85, Name = "IdeaPad 320", MarkId = 16 },
                 new Model { Id = 86, Name = "IP 340", MarkId = 16 },
                 new Model { Id = 87, Name = "Lenovo ThinkPad", MarkId = 16 },

                 new Model { Id = 88, Name = "Zenbook 13.3", MarkId = 17 },
                 new Model { Id = 89, Name = "Zenbook 14", MarkId = 17 },
                 new Model { Id = 90, Name = "Zenbook 15", MarkId = 17 },
                 new Model { Id = 91, Name = "Vivobook 13.3", MarkId = 17 },
                 new Model { Id = 92, Name = "Vivobook 14", MarkId = 17 },

                 new Model { Id = 93, Name = "AlianWare", MarkId = 18 },
                 new Model { Id = 94, Name = "G3", MarkId = 18 },
                 new Model { Id = 95, Name = "G3 Pro", MarkId = 18 },
                 new Model { Id = 96, Name = "5587-6588", MarkId = 18 },
                 new Model { Id = 97, Name = "3579-8973", MarkId = 18 },

                 new Model { Id = 98, Name = "15-ra047ur", MarkId = 19 },
                 new Model { Id = 99, Name = "15-ra059ur-3qu42ea", MarkId = 19 },
                 new Model { Id = 100, Name = "15-ra047ur", MarkId = 19 },
                 new Model { Id = 101, Name = "250-G6", MarkId = 19 },
                 new Model { Id = 102, Name = "250-G7", MarkId = 19 },



                 new Model { Id = 103, Name = "LED 40A3500", MarkId = 20 },
                 new Model { Id = 104, Name = "LED 32A3500", MarkId = 20 },
                 new Model { Id = 105, Name = "LED 65R7", MarkId = 20 },
                 new Model { Id = 106, Name = "LED 55A3500", MarkId = 20 },
                 new Model { Id = 107, Name = "LED 49E3400", MarkId = 20 },

                 new Model { Id = 108, Name = "LED 43LM6500", MarkId = 21 },
                 new Model { Id = 109, Name = "LED 32LM6350", MarkId = 21 },
                 new Model { Id = 110, Name = "OLED 65B9", MarkId = 21 },
                 new Model { Id = 111, Name = "OLED 55B9PLA", MarkId = 21 },
                 new Model { Id = 112, Name = "LED 55UM7450", MarkId = 21 },

                 new Model { Id = 113, Name = "LED TX-65GXR900", MarkId = 22 },
                 new Model { Id = 114, Name = "LED TX-40FSR500", MarkId = 22 },
                 new Model { Id = 115, Name = "LED TX-32DR400", MarkId = 22 },
                 new Model { Id = 116, Name = "LED TX-55FXR740", MarkId = 22 },
                 new Model { Id = 117, Name = "LED TX-49FXR740", MarkId = 22 },

                 new Model { Id = 118, Name = "LED UE55RU7300UXRU", MarkId = 23 },
                 new Model { Id = 119, Name = "LED QE55Q67RAUXRU", MarkId = 23 },
                 new Model { Id = 120, Name = "LED UE55RU7140UXRU", MarkId = 23 },
                 new Model { Id = 121, Name = "LED UE43RU7470UXRU", MarkId = 23 },
                 new Model { Id = 122, Name = "LED QE65Q9FNAUXRU", MarkId = 23 },

                 new Model { Id = 123, Name = "KD-85XF8596 RU3", MarkId = 24 },
                 new Model { Id = 124, Name = "KD-65XF7096 RU3", MarkId = 24 },
                 new Model { Id = 125, Name = "KD-49XF7596", MarkId = 24 },
                 new Model { Id = 126, Name = "KD-43XF7096", MarkId = 24 },
                 new Model { Id = 127, Name = "KDL-43WF665", MarkId = 24 },


                 new Model { Id = 128, Name = "Watch 3 42mm", MarkId = 25 },
                 new Model { Id = 129, Name = "Watch 3 44mm", MarkId = 25 },
                 new Model { Id = 130, Name = "Watch 4 42mm", MarkId = 25 },
                 new Model { Id = 131, Name = "Watch 4 44mm", MarkId = 25 },
                 new Model { Id = 132, Name = "Watch 4 40mm", MarkId = 25 },

                 new Model { Id = 133, Name = "Galaxy Fit", MarkId = 26 },
                 new Model { Id = 134, Name = "Galaxy Fit e", MarkId = 26 },
                 new Model { Id = 135, Name = "Galaxy Watch SM-R800", MarkId = 26 },
                 new Model { Id = 136, Name = "Galaxy Watch Active SM-R500", MarkId = 26 },
                 new Model { Id = 137, Name = "Galaxy Watch SM-R810", MarkId = 26 },

                 new Model { Id = 138, Name = "Amazfit GTR", MarkId = 27 },
                 new Model { Id = 139, Name = "Mi Band 4", MarkId = 27 },
                 new Model { Id = 140, Name = "Amazfit Verge", MarkId = 27 },
                 new Model { Id = 141, Name = "Amazfit Stratos", MarkId = 27 },
                 new Model { Id = 142, Name = "Amazfit Bip", MarkId = 27 },

                 new Model { Id = 143, Name = "Band 3e", MarkId = 28 },
                 new Model { Id = 144, Name = "Watch GT", MarkId = 28 },
                 new Model { Id = 145, Name = "Band 3", MarkId = 28 },
                 new Model { Id = 146, Name = "Watch GT2", MarkId = 28 },
                 new Model { Id = 147, Name = "Band 4e", MarkId = 28 },

                 new Model { Id = 148, Name = "Watch Magic", MarkId = 29 },
                 new Model { Id = 149, Name = "5 CRS", MarkId = 29 },
                 new Model { Id = 150, Name = "Band 5", MarkId = 29 },
                 new Model { Id = 151, Name = "Band 3", MarkId = 29 },
                 new Model { Id = 152, Name = "Band 4", MarkId = 29 }
                );
            builder.Entity<News>().HasData(
                 new News { Id = 1, Title = "Iphone 11PRO MAX", PhotoUrl = "iphone11pro.jpg", Info = "Sürətli enerji yığma illərdir Android istifadəçiləri üçün daha əlçatan olsa da, artıq iphone 11 Pro və Pro Max istifadəçiləri",AddDate=DateTime.Now },
                 new News { Id = 2, Title = "Samsung Galaxy Note10", PhotoUrl = "samsungNote10.jpg", Info = "Galaxy Note 10 modelləri böyük həcmli batareyalara sahib olacaqlar. ",AddDate=DateTime.Now },
                 new News { Id = 3, Title = "Huawei P30 Pro", PhotoUrl = "huaweiP30pro.jpg", Info = "Beləliklə hər iki smartfon modeli (P30 və P30 Pro) ön kamera üçün nəzərdə tutulmuş damcı formalı çıxıntı hissə ilə təchiz olunacaq.",AddDate=DateTime.Now }

                );
            builder.Entity<Announcement>().HasData(
                  new Announcement { Id = 1, Name = "Satilir Xiaomi Mi A2", PhotoUrl = "adsMain.jpg", IsVip = false, Price = 1200, AddDate = DateTime.Now, CityId = 1, ModelId = 3, Info=" 64gb  Yaxshi veziyyetdedir",IsConfirmed=true },
                  new Announcement { Id = 2, Name = "Satilir Samsung Galaxy S10", PhotoUrl = "s10.jpg", IsVip = false, Price = 1400, AddDate = DateTime.Now, CityId = 8, ModelId = 10, Info="Satilir samsung galaxy s10 128 gb yasil reng." },
                  new Announcement { Id = 3, Name = "Satilir Huawei P30 Pro", PhotoUrl = "huaweiP30Proo.jpg", IsVip = false, Price = 1350, AddDate = DateTime.Now, CityId = 52, ModelId = 24, Info="Huawei P30 pro. Ideal veziyyetdedir..." },

                  new Announcement { Id = 4, Name = "Satilir Samsung Tab E", PhotoUrl = "samsungTabE.jpg", IsVip = false, Price = 450, AddDate = DateTime.Now, CityId = 1, ModelId = 48,Info="Ela veziyyetdir 32gb, Qiymetde Cuzi Endirim Olacaq", IsConfirmed = true },
                  new Announcement { Id = 5, Name = "Satilir Ipad Pro 2018", PhotoUrl = "ipadPro.jpg", IsVip = false, Price = 960, AddDate = DateTime.Now, CityId = 8, ModelId = 44, Info = "Ipad pro 2018 her bir aksesuari var.." },
                  new Announcement { Id = 6, Name = "Satilir Lenovo Tab 4", PhotoUrl = "lenovoTab.jpg", IsVip = false, Price = 1350, AddDate = DateTime.Now, CityId = 52, ModelId = 55, Info = "Keyfiyyetli plansetdir nomre(4g) destekleyir" },

                  new Announcement { Id = 7, Name = "Satilir Acer Swift 3", PhotoUrl = "swift3.jpg", IsVip = false, Price = 2100, AddDate = DateTime.Now, CityId = 1, ModelId = 78, Info = "Acer swift 3 14 ekran ram 8 videokarti intel uhd620 1.8Ghz up to 4.0 Ghz", IsConfirmed = true },
                  new Announcement { Id = 8, Name = "Satilir Hp Omen", PhotoUrl = "hpOmen.jpg", IsVip = false, Price = 2300, AddDate = DateTime.Now, CityId = 8, ModelId = 98, Info = "Ram 16gb videocarti geforce gtx 1050ti 4gb" },
                  new Announcement { Id = 9, Name = "Satilir Dell G3", PhotoUrl = "dellG3.jpg", IsVip = false, Price = 1750, AddDate = DateTime.Now, CityId = 52, ModelId = 94, Info = "G3 ram 16gb ssd 256 videocarti 6gb geforce gtx 1060" },

                  new Announcement { Id = 10, Name = "Satilir Panasonic 4k", PhotoUrl = "sonyTv.jpg", IsVip = false, Price = 2100, AddDate = DateTime.Now, CityId = 1, ModelId = 127, Info = "104 ekran, Uhd,yeni kimidir", IsConfirmed = true },
                  new Announcement { Id = 11, Name = "Satilir Sony QHD", PhotoUrl = "panasonicTv.jpg", IsVip = false, Price = 2300, AddDate = DateTime.Now, CityId = 8, ModelId = 114, Info = "120 ekran,Uhd, qiymetde razilawmaq olar" },
                  new Announcement { Id = 12, Name = "Satilir Lg UHD ", PhotoUrl = "lgTv.jpg", IsVip = false, Price = 1750, AddDate = DateTime.Now, CityId = 52, ModelId = 112, Info = "Lg 104 ekran, Qhd, yeni nesil televizor, Yenidir! qiymet sondur" },

                  new Announcement { Id = 13, Name = "Satilir Apple Watch 4", PhotoUrl = "appleWatch.jpg", IsVip = false, Price = 2100, AddDate = DateTime.Now, CityId = 1, ModelId = 128, Info = "" },
                  new Announcement { Id = 14, Name = "Satilir Samsung Watch Active", PhotoUrl = "samsungWatch.jpg", IsVip = false, Price = 2300, AddDate = DateTime.Now, CityId = 8, ModelId = 135, Info = "" },
                  new Announcement { Id = 15, Name = "Satilir Xiaomi Mi Band 4 ", PhotoUrl = "XiaomiWatch.jpg", IsVip = false, Price = 1750, AddDate = DateTime.Now, CityId = 52, ModelId = 139, Info = "" }
              );

            builder.Entity<AnsImages>().HasData(
                    new AnsImages { Id = 1, AdsPhotoUrl = "ads4.jpg", AnnouncementId = 1 },
                    new AnsImages { Id = 2, AdsPhotoUrl = "ads3.jpg", AnnouncementId = 1 },
                    new AnsImages { Id = 3, AdsPhotoUrl = "ads2.jpg", AnnouncementId = 1 },
                    new AnsImages { Id = 4, AdsPhotoUrl = "ads1.jpg", AnnouncementId = 1 },

                    new AnsImages { Id = 5, AdsPhotoUrl = "s10.jpg", AnnouncementId = 2 },
                    new AnsImages { Id = 6, AdsPhotoUrl = "s10.jpg", AnnouncementId = 2 },
                    new AnsImages { Id = 7, AdsPhotoUrl = "s10.jpg", AnnouncementId = 2 },
                    new AnsImages { Id = 8, AdsPhotoUrl = "s10.jpg", AnnouncementId = 2 },

                    new AnsImages { Id = 9, AdsPhotoUrl = "huaweiP30Proo.jpg", AnnouncementId = 3 },
                    new AnsImages { Id = 10, AdsPhotoUrl = "huaweiP30Proo.jpg", AnnouncementId = 3 },
                    new AnsImages { Id = 11, AdsPhotoUrl = "huaweiP30Proo.jpg", AnnouncementId = 3 },
                    new AnsImages { Id = 12, AdsPhotoUrl = "huaweiP30Proo.jpg", AnnouncementId = 3 },





                    new AnsImages { Id = 13, AdsPhotoUrl = "samsungTabE.jpg", AnnouncementId = 4 },
                    new AnsImages { Id = 14, AdsPhotoUrl = "samsungTabE.jpg", AnnouncementId = 4 },
                    new AnsImages { Id = 15, AdsPhotoUrl = "samsungTabE.jpg", AnnouncementId = 4 },
                    new AnsImages { Id = 16, AdsPhotoUrl = "samsungTabE.jpg", AnnouncementId = 4 },

                    new AnsImages { Id = 17, AdsPhotoUrl = "ipadPro.jpg", AnnouncementId = 5 },
                    new AnsImages { Id = 18, AdsPhotoUrl = "ipadPro.jpg", AnnouncementId = 5 },
                    new AnsImages { Id = 19, AdsPhotoUrl = "ipadPro.jpg", AnnouncementId = 5 },
                    new AnsImages { Id = 20, AdsPhotoUrl = "ipadPro.jpg", AnnouncementId = 5 },

                    new AnsImages { Id = 21, AdsPhotoUrl = "lenovoTab.jpg", AnnouncementId = 6 },
                    new AnsImages { Id = 22, AdsPhotoUrl = "lenovoTab.jpg", AnnouncementId = 6 },
                    new AnsImages { Id = 23, AdsPhotoUrl = "lenovoTab.jpg", AnnouncementId = 6 },
                    new AnsImages { Id = 24, AdsPhotoUrl = "lenovoTab.jpg", AnnouncementId = 6 },





                    new AnsImages { Id = 25, AdsPhotoUrl = "swift3.jpg", AnnouncementId = 7 },
                    new AnsImages { Id = 26,  AdsPhotoUrl = "swift3.jpg", AnnouncementId = 7 },
                    new AnsImages { Id = 27,  AdsPhotoUrl = "swift3.jpg", AnnouncementId = 7 },
                    new AnsImages { Id = 28,  AdsPhotoUrl = "swift3.jpg", AnnouncementId = 7 },

                     new AnsImages { Id = 29,  AdsPhotoUrl = "hpOmen.jpg", AnnouncementId = 8 },
                    new AnsImages { Id = 30,  AdsPhotoUrl = "hpOmen.jpg", AnnouncementId = 8 },
                    new AnsImages { Id = 31,  AdsPhotoUrl = "hpOmen.jpg", AnnouncementId = 8 },
                    new AnsImages { Id = 32,  AdsPhotoUrl = "hpOmen.jpg", AnnouncementId = 8 },

                     new AnsImages { Id = 33,  AdsPhotoUrl = "dellG3.jpg", AnnouncementId = 9 },
                    new AnsImages { Id = 34,  AdsPhotoUrl = "dellG3.jpg", AnnouncementId = 9 },
                    new AnsImages { Id = 35,  AdsPhotoUrl = "dellG3.jpg", AnnouncementId = 9 },
                    new AnsImages { Id = 36,  AdsPhotoUrl = "dellG3.jpg", AnnouncementId = 9 },



                      new AnsImages { Id = 37, AdsPhotoUrl = "sonyTv.jpg", AnnouncementId = 10 },
                    new AnsImages { Id = 38, AdsPhotoUrl = "sonyTv.jpg", AnnouncementId = 10 },
                    new AnsImages { Id = 39, AdsPhotoUrl = "sonyTv.jpg", AnnouncementId = 10 },
                    new AnsImages { Id = 40, AdsPhotoUrl = "sonyTv.jpg", AnnouncementId = 10 },

                      new AnsImages { Id = 41, AdsPhotoUrl = "panasonicTv.jpg", AnnouncementId = 11 },
                    new AnsImages { Id = 42, AdsPhotoUrl = "panasonicTv.jpg", AnnouncementId = 11 },
                    new AnsImages { Id = 43, AdsPhotoUrl = "panasonicTv.jpg", AnnouncementId = 11 },
                    new AnsImages { Id = 44, AdsPhotoUrl = "panasonicTv.jpg", AnnouncementId = 11 },

                    new AnsImages { Id = 45, AdsPhotoUrl = "lgTv.jpg", AnnouncementId = 12 },
                    new AnsImages { Id = 46, AdsPhotoUrl = "lgTv.jpg", AnnouncementId = 12 },
                    new AnsImages { Id = 47, AdsPhotoUrl = "lgTv.jpg", AnnouncementId = 12 },
                    new AnsImages { Id = 48, AdsPhotoUrl = "lgTv.jpg", AnnouncementId = 12 },



                    new AnsImages { Id = 49, AdsPhotoUrl = "appleWatch.jpg", AnnouncementId = 13 },
                    new AnsImages { Id = 50, AdsPhotoUrl = "appleWatch.jpg", AnnouncementId = 13 },
                    new AnsImages { Id = 51, AdsPhotoUrl = "appleWatch.jpg", AnnouncementId = 13 },
                    new AnsImages { Id = 52, AdsPhotoUrl = "appleWatch.jpg", AnnouncementId = 13 },

                     new AnsImages { Id = 53, AdsPhotoUrl = "samsungWatch.jpg", AnnouncementId = 14 },
                    new AnsImages { Id = 54, AdsPhotoUrl = "samsungWatch.jpg", AnnouncementId = 14 },
                    new AnsImages { Id = 55, AdsPhotoUrl = "samsungWatch.jpg", AnnouncementId = 14 },
                    new AnsImages { Id = 56, AdsPhotoUrl = "samsungWatch.jpg", AnnouncementId = 14 },

                    new AnsImages { Id = 57, AdsPhotoUrl = "XiaomiWatch.jpg", AnnouncementId = 15 },
                    new AnsImages { Id = 58, AdsPhotoUrl = "XiaomiWatch.jpg", AnnouncementId = 15 },
                    new AnsImages { Id = 59, AdsPhotoUrl = "XiaomiWatch.jpg", AnnouncementId = 15 },
                    new AnsImages { Id = 60, AdsPhotoUrl = "XiaomiWatch.jpg", AnnouncementId = 15 }

                );




        }
    }
}
