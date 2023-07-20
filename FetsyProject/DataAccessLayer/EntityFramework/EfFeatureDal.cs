﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntitiesLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
    }

}
