using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blogMVC.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryName="c#"},
                new Category() {CategoryName="Asp .net MVC"},
                new Category() {CategoryName="Asp .net WebForm"},
                new Category() {CategoryName="Windows Form"},
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa = true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-5), Anasayfa = false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-20), Anasayfa = true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-2), Anasayfa = true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(0), Anasayfa = false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-12), Anasayfa = true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa = true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# Deleegates Hakkında", EklemeTarihi=DateTime.Now.AddDays(-10), Anasayfa = true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg",CategoryId=1},


            };

            base.Seed(context);
        }
    }
}