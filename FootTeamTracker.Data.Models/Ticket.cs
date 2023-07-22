using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	public class Ticket
	{
        public Ticket()
        {
            Id = Guid.NewGuid();
            IsReserved = false;
        }

        [Key]
        public Guid Id { get; set; }

        
        public string? UserId { get; set; }


        public AppUser? TicketHolder { get; set; }


        [Required]
        public bool IsReserved { get; set; }


        [Required]
        public int StadiumId { get; set; }


        
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;
	}
}
