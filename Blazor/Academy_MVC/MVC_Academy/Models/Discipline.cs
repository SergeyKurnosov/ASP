using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Academy.Models
{
	public class Discipline
	{
		[Column("discipline_id")]
		public short ID { get; set; }
		public string? discipline_name { get; set; }
		public byte number_of_lessons { get; set; }
	}
}
