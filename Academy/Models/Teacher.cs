using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[Table("Teachers")]
	public class Teacher
	{
		[Key]
		[Column("teacher_id")]
		public short teacher_id { get; set; }

		[Required, Column("last_name")] 
		public string last_name { get; set; }
		[Required, Column("first_name")] 
		public string first_name { get; set; }
		[Column("middle_name")] 
		public string? middle_name { get; set; }

		[Column("birth_date", TypeName = "date")] 
		public DateTime? birth_date { get; set; }
		[Column("email")] 
		public string? email { get; set; }
		[Column("phone")] 
		public string? phone { get; set; }

		[Column("work_since", TypeName = "date")] 
		public DateTime? work_since { get; set; }

		[Column("rate", TypeName = "smallmoney")] 
		public decimal? rate { get; set; }
	}
}
