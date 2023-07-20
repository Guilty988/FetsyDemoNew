﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {

        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
                _featureDal = featureDal;
        }


        public List<Feature> GetAll()
        {
            return _featureDal.GetList();
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
