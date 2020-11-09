﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStrore.Models.Repositores
{
    public interface IBookStroreRepository<TEntity> 
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(TEntity entity , int id);
        void Delete(int id);
    }
}
