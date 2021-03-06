﻿using Inter.Core.Domain.Entities;
using Inter.Core.Domain.Interfaces.Repositories;
using Inter.Core.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inter.Core.Infra.Data.Repositories
{
    public class ReceivePaymentCulturalExchangeRepository : RepositoryBase<ReceivePaymentCulturalExchange>, IReceivePaymentCulturalExchangeRepository
    {
        private readonly DbContextOptions<MySQLContext> _OptionsBuilder;

        public ReceivePaymentCulturalExchangeRepository()
        {
            _OptionsBuilder = new DbContextOptions<MySQLContext>();
        }

        public List<ReceivePaymentCulturalExchange> GetAllIncludedDependencys(Guid environmentId)
        {
            using (var db = new MySQLContext(_OptionsBuilder))
            {
                return db.Set<ReceivePaymentCulturalExchange>()
                    .Include(x => x.Environment)
                    .Include(x => x.CulturalExchange)
                    .ThenInclude(x => x.Student)
                    .ToList();
            }
        }

        public List<ReceivePaymentCulturalExchange> GetAllIncludedDependencysByCulturalExchangeId(Guid culturalExchangeId)
        {
            using (var db = new MySQLContext(_OptionsBuilder))
            {
                return db.Set<ReceivePaymentCulturalExchange>()
                    .Include(x => x.Environment)
                    .Include(x => x.CulturalExchange)
                    .ThenInclude(x => x.Student)
                    .Include(x => x.CulturalExchange.College)
                    .ThenInclude(col => col.CollegeTime)
                    .Where(x => x.CulturalExchangeId == culturalExchangeId)
                    .ToList();
            }
        }

        public ReceivePaymentCulturalExchange GetByIdIncludedDependency(Guid id)
        {
            using (var db = new MySQLContext(_OptionsBuilder))
            {
                return db.Set<ReceivePaymentCulturalExchange>()
                    .Include(x => x.Environment)
                    .Include(x => x.CulturalExchange)
                    .ThenInclude(x => x.Student)
                    .FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
