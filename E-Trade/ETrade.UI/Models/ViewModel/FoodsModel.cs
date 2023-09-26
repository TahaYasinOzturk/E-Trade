using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class FoodsModel:BaseCrud
    {
        //public FoodsModel()
        //{
        //    SelectedFood = new Foods();
        //}
        public Foods Foods { get; set; } = new Foods();
        //public List<Categories> Categories { get; set; }
        //public string Head { get; set; }
        //public string Text { get; set; }
        //public string Class { get; set; }
        public List<CategoriesDTO> Categories { get; set; }
    }
}
