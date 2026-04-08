using Academy2.Components.Model;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Academy2.Data
{
	public class Academy2Context : DbContext
	{
		public Academy2Context(DbContextOptions<Academy2Context> options)
			: base(options)
		{
		}

		public DbSet<Academy2.Components.Model.Direction> Directions { get; set; } = default!;
		public DbSet<Academy2.Components.Model.Group> Groups { get; set; } = default!;
		public DbSet<Academy2.Components.Model.Student> Students { get; set; } = default!;

		public string Get_URL_IMG_From_Byte_Array(byte[] byteArray)
		{
			string? avatarIMG = "";
			if (byteArray != null && byteArray.Length > 0)
			{
				ImageFormat format;

				using (var ms = new MemoryStream(byteArray))
				{
					using (Image img = Image.FromStream(ms))
					{
						format = img.RawFormat;
					}
				}
				avatarIMG = $"data:image/{format.ToString()};base64,{Convert.ToBase64String(byteArray)}";
			}
			return avatarIMG;
		}

		public Stream Get_Stream_For_Load_Image(InputFileChangeEventArgs e)
		{
			Stream stream = null;
			IBrowserFile file = e.File;
			string[] allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
			string extension = Path.GetExtension(file.Name).ToLowerInvariant();
			if (allowedExtensions.Contains(extension))
			{
				stream = file.OpenReadStream(maxAllowedSize: 10 * 1024 * 1024);
			}
			return stream;
		}
	}
}
