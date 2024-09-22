using HotelPorject.EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPorject.EntityLayer.Entities
{
	public class Service:BaseEntity
	{
        public string Title { get; set; }
        public string ServiceIcon { get; set; }
        public string Description { get; set; }
    }
}
