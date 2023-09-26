using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class CategoriesModel :BaseCrud
    {
        //Bu nesnenin adı bu nesnenin ıdsi vs. public Categories Categories yapıyoruz.
        //her sayfa acıldıgında new categories yapıyoruz. ki null gelmesin.
        public Categories Categories { get; set; } = new Categories();

        

    }
}
