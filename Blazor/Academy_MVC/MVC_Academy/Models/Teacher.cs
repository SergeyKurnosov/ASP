using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Academy.Models
{
	public class Teacher
	{
		[Column("teacher_id")]
		public short ID { get; set; }
		public string? last_name { get; set; }
		public string? first_name { get; set; }
		public string? middle_name { get; set; }
		[DataType(DataType.Date)]
		public DateTime? birth_date { get; set; }
		public string? email { get; set; }
		public string? phone { get; set; }
		public byte[]? photo { get; set; }
		[DataType(DataType.Date)]
		public DateTime? work_since { get; set; }
		public decimal? rate { get; set; }
	}
}
