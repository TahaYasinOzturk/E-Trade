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
    public class PropertyRepository : BaseRepository<Properties>, IPropertyRepository
    {
        public PropertyRepository(Context context) : base(context)
        {

        }
        public List<PropertiesDTO> GetProperties()
        {
            return Set().Select(x => new PropertiesDTO
            {
                // sol taraf ProductDTO sağ taraf Properties entt tarafı
                Id = x.PropertyId,
                PropertyName = x.PropertyName,

                //          public string PropertyName { get; set; }
                //          public decimal Price { get; set; }
                //          public ICollection<Foods> Foods { get; set; }


            }).ToList();
        }
    }
}