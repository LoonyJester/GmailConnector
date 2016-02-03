using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GCE.Definitions.Enums;
using GCE.Definitions.Interfaces.Entities;

namespace GCE.DataAccess.DataObjects
{
    public class Ticket: ITicket
    {
        [Key]
        public int Id { get; set; }

        public int MessageId { get; set; }
        public int CWTiketId { get; set; }
        public TikcketJoinType TikcketJoinType { get; set; }
        public DateTime Timestamp { get; set; }

        [ForeignKey("MessageId")]
        public Message Message { get; set; }
    }
}