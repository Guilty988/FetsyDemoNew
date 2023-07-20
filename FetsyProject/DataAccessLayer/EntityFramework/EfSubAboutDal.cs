using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSubAboutDal : GenericRepository<SubAbout>, ISubAboutDal
    {
    }

}
