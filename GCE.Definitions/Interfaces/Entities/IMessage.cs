using System;
using GCE.Definitions.Enums;

namespace GCE.Definitions.Interfaces.Entities
{
    public interface IMessage: IEntity
    {
        string MessageId { get; set; }
        string PrimaryId { get; set; }
        MessageStatus Status { get; set; }
        DateTime Timestamp { get; set; }
    }
}