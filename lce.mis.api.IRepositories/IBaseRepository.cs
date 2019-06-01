using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using lce.mis.api.Entities;
using lce.mis.api.Provider;

namespace lce.mis.api.IRepositories
{
    /// <summary>
    /// action：
    /// file name：lce.mis.api.IRepositories.IBaseRepository
    /// author：lynx.kor @ 2019/6/1 15:04:10
    /// desc：
    /// > add description for IBaseRepository
    /// revision：
    ///
    /// </summary>
    public interface IBaseRepository<T> where T : IEntity
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> Add(T entity);

        /// <summary>
        /// 更新/更新指定列
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="properties">null则更新所有字段，NOT NULL则更新指定字段</param>
        /// <returns></returns>
        Task<int> Update(T entity, IList<string> properties = null);

        /// <summary>
        /// 更新非指定字段
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="properties">NULL则更新时不排除字段，NOT NULL则更新指定字段以外的</param>
        /// <returns></returns>
        Task<int> UpdateExcept(T entity, IList<string> properties = null);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> Delete(T entity);

        /// <summary>
        /// 按查询条件删除，即可批量删除
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<int> Delete(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="expression">条件</param>
        /// <returns></returns>
        Task<T> Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 列表(ALL)
        /// </summary>
        /// <param name="expression">条件</param>
        /// <param name="orders">排序字段</param>
        /// <returns></returns>
        Task<IList<T>> FindList(Expression<Func<T, bool>> expression, IList<OrderParam> orders = null);

        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="size">页阀</param>
        /// <param name="expression">条件</param>
        /// <param name="orders">排序字段</param>
        /// <returns></returns>
        Task<IList<T>> FindList(int page, int size, Expression<Func<T, bool>> expression, IList<OrderParam> orders = null);
        
    }
}
