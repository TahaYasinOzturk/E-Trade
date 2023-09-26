using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class AdminModel
    {
        public AdminModel()
        {
            SelectedFood = new Foods();
        }
        public Foods SelectedFood { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Properties> Properties { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
    }
}
