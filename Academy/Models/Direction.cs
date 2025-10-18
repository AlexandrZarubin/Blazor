using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[Table("Directions")]
	public class Direction
	{
		[Key]
		[Column("direction_id", TypeName = "tinyint")]
		public byte direction_id { get; set; }

		[Column("direction_name")]
		public string? direction_name { get; set; }
	}
}
