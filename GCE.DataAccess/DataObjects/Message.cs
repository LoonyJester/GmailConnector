using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GCE.Definitions.Enums;
using GCE.Definitions.Interfaces.Entities;

namespace GCE.DataAccess.DataObjects
{
    public class Message: IMessage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        [Index("IX_Messages_MessageId", IsUnique = true)]
        public string MessageId { get; set; }
        [Required]
        [MaxLength(256)]
        [Index("IX_Messages_PrimaryId")]
        public string PrimaryId { get; set; }
        public MessageStatus Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}