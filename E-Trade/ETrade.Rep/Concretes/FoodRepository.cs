using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class FoodRepository : BaseRepository<Foods>, IFoodRepository
    {
        public FoodRepository(Context context) : base(context)
        {
        }

        public List<FoodsDTO> GetFoods()
        {
            return Set().Select(x => new FoodsDTO
            {
                // sol taraf ProductDTO sağ taraf Products
                FoodId = x.FoodId,
                FoodName = x.FoodName,
                


        //        public string FoodName { get; set; }
        //public Guid CategoryId { get; set; }
        //public Guid PropertyId { get; set; }
        //public string Description { get; set; }
        //public string Img { get; set; }
        //public DateTime LastUpdated { get; set; }
        //public DateTime CreatedDate { get; set; }

    }).ToList();
        }

        
    }
}
