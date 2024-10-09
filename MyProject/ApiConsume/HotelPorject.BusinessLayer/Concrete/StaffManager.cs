using HotelPorject.BusinessLayer.Abstract;
using HotelPorject.DataAccessLayer.Abstract;
using HotelPorject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPorject.BusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		readonly IStaffDal _staffDal;
		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}
		public void TDelete(Staff entity)
		{
			_staffDal.Delete(entity);
		}

		public List<Staff> TGetAll()
		{
			return _staffDal.GetAll();
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

		public void TInsert(Staff entity)
		{
			_staffDal.Insert(entity);
		}

		public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}
