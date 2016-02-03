using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using AutoMapper;
using GCE.Definitions.Interfaces.Base;
using GCE.Definitions.Interfaces.Entities;

namespace GCE.DataAccess
{
    public abstract class BaseRepo<TDataObject, TInfoEntity> :
        IEntityRepo<TInfoEntity>
        where TDataObject : class, IEntity, new()
        where TInfoEntity : class, IEntity, new()
    {

        protected readonly GCEContext DB;

        protected BaseRepo(GCEContext db)
        {
            DB = db;
        }

        public virtual TInfoEntity Get(int id)
        {
            var g = DB.Set<TDataObject>().SingleOrDefault(x => x.Id == id);


            if (g == null) return null;

            return Mapper.Map<TDataObject, TInfoEntity>(g);
        }

        public void Remove(int id)
        {
            var entity = DB
                .Set<TDataObject>()
                .FirstOrDefault(x => x.Id == id);

            if (entity == null)
                return;

            DB.Set<TDataObject>().Remove(entity);
            DB.SaveChanges();
        }

        protected IQueryable<TDataObject> All(params string[] relatedObjects)
        {
            if (relatedObjects == null || !relatedObjects.Any())
                return DB.Set<TDataObject>();
            var raw = DB.Set<TDataObject>().AsQueryable();
            return relatedObjects.Aggregate(raw, (current, related) => current.Include(related));
        }

        public virtual TInfoEntity Save(TInfoEntity item)
        {
            var data = item.Id != 0
                ? DB.Set<TDataObject>().SingleOrDefault(x => x.Id == item.Id)
                : new TDataObject();

            if (data == null)
                return null;

            data = Mapper.Map(item, data);

            DB.Set<TDataObject>().AddOrUpdate(data);
            try
            {
                DB.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                var s = new StringBuilder();
                foreach (var eve in e.EntityValidationErrors)
                {
                    s.AppendFormat("Entity of type '{0}' in state '{1}' has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s.AppendFormat("- Property: '{0}', Error: '{1}'",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(s.ToString());
            }
            return Mapper.Map<TDataObject, TInfoEntity>(data);
        }
    }
}