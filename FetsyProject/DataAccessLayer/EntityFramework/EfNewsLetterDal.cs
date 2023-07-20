using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfNewsLetterDal : GenericRepository<NewsLetter>, INewsLetterDal
    {
    }

}
