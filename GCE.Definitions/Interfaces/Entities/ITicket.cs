using System;
using GCE.Definitions.Enums;

namespace GCE.Definitions.Interfaces.Entities
{
    public interface ITicket: IEntity
    {
        int MessageId { get; set; }
        int CWTiketId { get; set; }
        TikcketJoinType TikcketJoinType { get; set; }
        DateTime Timestamp { get; set; }
    }
}