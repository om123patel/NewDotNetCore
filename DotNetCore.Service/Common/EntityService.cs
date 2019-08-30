using AutoMapper;
using DotNetCore.DataLayer;
using DotNetCore.Model;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DotNetCore.Service
{
    public abstract class EntityService<TEntity, TDomain> : IEntityService<TEntity, TDomain>
        where TEntity : BaseEntity
        where TDomain : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TEntity> _repository;

        public EntityService(IMapper mapper, IUnitOfWork unitOfWork, IBaseRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }

        public virtual void Create(TDomain entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            var model = _mapper.Map<TEntity>(entity);
            _repository.Add(model);
            _unitOfWork.Commit();
        }
        public virtual void Update(TDomain entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            var model = _mapper.Map<TEntity>(entity);
            _repository.Update(model);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<TDomain> GetAll()
        {
            var records = _repository.FindBy();
            return _mapper.Map<IEnumerable<TDomain>>(records);
        }

        public virtual void Delete(object Id)
        {
            _repository.Delete(Id);
            _unitOfWork.Commit();
        }
    }
}
