﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IBikeTypeRepository BikeType { get; }

        IProductRepository Product { get; }
        void Save();
    }
}
