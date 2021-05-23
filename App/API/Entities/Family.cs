using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Family
    {
        public int Id { get; set; }
        public int AggregateSize { get; set; }
        public bool HasChildren { get; set; }
        // for the "dried food" classes: A, B, C, D, etc.
        public string AggregateClass { get; set; }
        public bool IsPending { get; set; }
        public DateTime RegisterDate { get; set; }
        public int ManagerId { get; set; }
        public AppUser Manager { get; set; }
        public ICollection<Presence> Presences { get; set; }

    }
}