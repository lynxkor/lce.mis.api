using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using lce.mis.api.Entities;
using lce.mis.api.IRepositories;
using lce.mis.api.IServices;
using lce.mis.api.Provider;

namespace lce.mis.api.Services
{
    /// <summary>
    /// action：
    /// file name：lce.mis.api.Services.BaseService
    /// author：lynx.kor @ 2019/6/1 16:03:52
    /// desc：
    /// > add description for BaseService
    /// revision：
    ///
    /// </summary>
    public class BaseService<T> : IBaseService<T> where T : IEntity
    {
        readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        async Task<int> IBaseService<T>.Add(T entity)
        {
            return await _repository.Add(entity);
        }

        async Task<int> IBaseService<T>.Delete(T entity)
        {
            return await _repository.Delete(entity);
        }

        async Task<int> IBaseService<T>.Delete(Expression<Func<T, bool>> expression)
        {
            return await _repository.Delete(expression);
        }

        async Task<T> IBaseService<T>.Find(Expression<Func<T, bool>> expression)
        {
            return await _repository.Find(expression);
        }

        async Task<IList<T>> IBaseService<T>.FindList(Expression<Func<T, bool>> expression, IList<OrderParam> orders)
        {
            return await _repository.FindList(expression, orders);
        }

        async Task<IList<T>> IBaseService<T>.FindList(int page, int size, Expression<Func<T, bool>> expression, IList<OrderParam> orders)
        {
            return await _repository.FindList(page, size, expression, orders);
        }

        async Task<int> IBaseService<T>.Update(T entity, IList<string> properties)
        {
            return await _repository.Update(entity, properties);
        }

        async Task<int> IBaseService<T>.UpdateExcept(T entity, IList<string> properties)
        {
            return await _repository.UpdateExcept(entity, properties);
        }
    }
}
