using ProjectEditor.Core.Entities;
using ProjectEditor.Core.Repositories.Base;
using ProjectEditor.Persistence.Repositories.DBContext;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEditor.Persistence.Repositories.Base
{
    public class BaseRepository : IBaseRepository
    {

        private ProjectEditorDbContext projectEditorDbContext;

        #region Ctor ¦ Dtor 
        public BaseRepository()
        {
            this.projectEditorDbContext = new ProjectEditorDbContext();
        }

        public BaseRepository(ProjectEditorDbContext projectEditorDbContext)
        {
            this.projectEditorDbContext = projectEditorDbContext;
        }
        #endregion


        public void Save()
        {
            this.projectEditorDbContext.SaveChanges();
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await this.projectEditorDbContext.SaveChangesAsync();
        }

        #region [C]REATE
        public void Add<T>(T entity, bool saveImmediately)
            where T : class, IEntity
        {
            if (entity == null)
            {
                return;
            }

            this.projectEditorDbContext.Add(entity);

            if (saveImmediately)
            {
                this.Save();
            }
        }

        public async Task AddAsync<T>(T entity, bool saveImmediately, CancellationToken cancellationToken)
            where T : class, IEntity
        {
            if (entity == null)
            {
                return;
            }

            await this.projectEditorDbContext.AddAsync(entity);

            if (saveImmediately)
            {
                await this.SaveAsync(cancellationToken);
            }
        }


        #endregion

        #region [R]EAD
        public IQueryable<T> QueryFrom<T>(Expression<Func<T, bool>> whereFilter = null) // Abfragen am SQL Server sind per default nicht case sensitive! (Kann in der Datenbank geändert werden [database properties]
           where T : class, IEntity
        {
            var query = this.projectEditorDbContext.Set<T>(); // Set bestimmt mit welcher Entität gearbeitet wird -> where übergiebt den Wert
            if (whereFilter != null)
            {
                return query.Where(whereFilter);
            }
            return query;
        }

        #endregion

        #region [U]PDATE
        public T Update<T>(T entity, object key, bool saveImmediately)
            where T : class, IEntity
        {
            if (entity == null)
            {
                return null;
            }

            var toUpdate = this.projectEditorDbContext.Set<T>().Find(key);
            if (toUpdate != null)
            {
                this.projectEditorDbContext.Entry(toUpdate).CurrentValues.SetValues(entity);
                if (saveImmediately)
                {
                    this.Save();
                }
            }

            return toUpdate;
        }

        public async Task<T> UpdateAsync<T>(T entity, object key, bool saveImmediately, CancellationToken cancellationToken)
            where T : class, IEntity
        {
            if (entity == null)
            {
                return null;
            }

            var toUpdate = await this.projectEditorDbContext.Set<T>().FindAsync(key);
            if (toUpdate != null)
            {
                this.projectEditorDbContext.Entry(toUpdate).CurrentValues.SetValues(entity);
                if (saveImmediately)
                {
                    await this.SaveAsync();
                }
            }

            return toUpdate;
        }
        #endregion

        #region [D]ELETE
        public void Remove<T>(T entity, bool saveImmediately)
             where T : class, IEntity
        {
            if (entity == null)
            {
                return;
            }

            this.projectEditorDbContext.Remove(entity);

            if (saveImmediately)
            {
                this.Save();
            }
        }

        public async Task RemoveAsync<T>(T entity, bool saveImmediately, CancellationToken cancellationToken)
            where T : class, IEntity
        {
            if (entity == null)
            {
                return;
            }

            this.projectEditorDbContext.Remove(entity);

            if (saveImmediately)
            {
                await this.SaveAsync(cancellationToken);
            }
        }

        public void RemoveByKey<T>(object key, bool saveImmediately)
             where T : class, IEntity
        {
            if (key == null)
            {
                return;
            }

            var toRemove = this.projectEditorDbContext.Set<T>().Find(key);
            if (toRemove != null)
            {
                this.projectEditorDbContext.Remove(toRemove);

                if (saveImmediately)
                {
                    this.Save();
                }
            }
        }

        public async Task RemoveByKeyAsync<T>(object key, bool saveImmediately, CancellationToken cancellationToken)
            where T : class, IEntity
        {
            if (key == null)
            {
                return;
            }

            var toRemove = await this.projectEditorDbContext.Set<T>().FindAsync(key);
            if (toRemove != null)
            {
                this.projectEditorDbContext.Remove(toRemove);

                if (saveImmediately)
                {
                    await this.SaveAsync();
                }
            }
        }
        #endregion
    }
}
