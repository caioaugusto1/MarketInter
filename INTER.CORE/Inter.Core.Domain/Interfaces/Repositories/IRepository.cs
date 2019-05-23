﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inter.Core.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();

        TEntity GetById(int id);

        void Insert(TEntity obj);

        void Update(TEntity obj);

        Task<List<TEntity>> FindByFilter(Expression<Func<TEntity, bool>> predicate);
        
    }
}
