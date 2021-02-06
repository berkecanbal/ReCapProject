﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Data access layer
    public interface ICarDal:IEntityRepository<Car>
    {

    }
}
