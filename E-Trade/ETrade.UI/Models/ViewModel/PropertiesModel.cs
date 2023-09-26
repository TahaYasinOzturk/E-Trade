using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class PropertiesModel : BaseCrud
    {
        public Properties Properties { get; set; }  = new Properties();
        //newledik 
        //select-option icin gerekli foodsdto u cagırığ kullandık
        public List<FoodsDTO> FoodsDTOs { get; set; }
    }
}
