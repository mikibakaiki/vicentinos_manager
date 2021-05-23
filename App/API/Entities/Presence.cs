using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Presence
    {
        public Guid Id { get; set; }
        public Family Family { get; set; }
        public DateTime Date { get; set; }
        public bool IsDryFood { get; set; }
    }
}