﻿
using System.Linq.Expressions;


namespace Company.Data.Services
{
    public class DbService : IDbService
    {

        private readonly CompanyContext _db;
        private readonly IMapper _mapper;

        public DbService(CompanyContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<TDto>> GetAsync<TEntity, TDto>()
        where TEntity : class, IEntity
        where TDto : class
        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);
            
        }

        private async Task<TEntity?> SingleAsync<TEntity>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity =>
            await _db.Set<TEntity>().SingleOrDefaultAsync(expression);

        public async Task<TDto> SingleAsync<TEntity, TDto>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity
            where TDto : class
        {

            var entity = await SingleAsync(expression);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TEntity> AddAsync<TEntity, TDto>(TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> SaveChangesAsync() =>
            await _db.SaveChangesAsync() >= 0;
        



        //private async Task<IEntity?> SingleAsync<TEntity>(Expression<Func<TEntity, bool>>) expression);

    }
}
