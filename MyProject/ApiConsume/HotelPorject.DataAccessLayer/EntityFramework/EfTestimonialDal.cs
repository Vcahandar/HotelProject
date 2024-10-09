using HotelPorject.DataAccessLayer.Abstract;
using HotelPorject.DataAccessLayer.Concrete;
using HotelPorject.DataAccessLayer.Repositories;
using HotelPorject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPorject.DataAccessLayer.EntityFramework
{
	public class EfTestimonialDal: GenericRepository<Testimonial>, ITestimonialDal
	{
        public EfTestimonialDal(Context context) : base(context)
		{
            
        }
    }
}
