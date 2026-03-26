using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Academy.Models
{
	public class Direction
	{
		[Column("direction_id")]
		public byte ID { get; set; }
		public string? direction_name { get; set; }
	}
}
