using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Domain.Model;
using NHibernate;
using NHibernate.Criterion;
using System.Collections;

namespace Core.Domain.Repositories
{
    public static class Factory
    {
        #region IRepository<Category> Members


        public static void Save(object entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
        }


        public static void Update(object entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }
        }

        public static void Delete(object entity)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }

        public static object GetById(string name, object id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get(name, id);

        }

        public static IList GetAll(string name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var persistentClass = Type.GetType(name);
                ICriteria criteria = session.CreateCriteria(persistentClass);
                return criteria.List();
            }
        }

        public static IList GetAll(string clazz, string field, object value)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var persistentClass = Type.GetType(clazz);
                ICriteria criteria = session.CreateCriteria(persistentClass);

                IList results = criteria.Add(Expression.Eq(field, value)).List();

                return results;
            }
        }


        #endregion
    }
}
