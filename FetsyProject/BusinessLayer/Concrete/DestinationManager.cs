using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationalDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationalDal = destinationDal;
        }

        public List<Destination> GetAll()
        {
            return _destinationalDal.GetList();
        }

        public Destination GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
