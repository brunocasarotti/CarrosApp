﻿using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces;
using CarsCollectors.Data.Context;
using System;
using System.Linq;

namespace CarsCollectors.Data.Repository
{
    public class FabricanteRepository : BaseRepository<Fabricante>, IFabricanteRepository
    {
        public FabricanteRepository(CarsCollectorsContext context) : base(context)
        {

        }

        public IQueryable<Fabricante> GetAll()
        {
            return db.Fabricantes.AsQueryable();
        }
    }
}
