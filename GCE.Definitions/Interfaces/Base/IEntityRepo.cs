using GCE.Definitions.Interfaces.Entities;

namespace GCE.Definitions.Interfaces.Base
{
    public interface IEntityRepo<TInfoEntity> : IRepo
        where TInfoEntity : IEntity, new()
    {
        TInfoEntity Get(int id);
        TInfoEntity Save(TInfoEntity item);
        void Remove(int id);
    }
}