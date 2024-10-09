using HotelPorject.EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPorject.EntityLayer.Entities
{
	public class Room:BaseEntity
	{
        public string RoomCoverImg { get; set; }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
