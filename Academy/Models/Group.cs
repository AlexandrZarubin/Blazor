using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[Table("Groups")]
	public class Group
	{
		[Key]
		[Column("group_id")]
		public int group_id { get; set; }

		[Required]
		[Column("group_name")]
		public string group_name { get; set; }

		[Column("direction", TypeName = "tinyint")]
		public byte? direction { get; set; }

		[ForeignKey(nameof(direction))]
		public Direction? Direction { get; set; }
	}
}
