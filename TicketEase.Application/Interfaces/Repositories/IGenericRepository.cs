﻿
using System.Linq.Expressions;

namespace TicketEase.Application.Interfaces.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		T GetById(int id);
		List<T> GetAll();
		List<T> Find(Expression<Func<T,bool>> predicate);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}