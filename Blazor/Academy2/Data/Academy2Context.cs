using Academy2.Components.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy2.Data
{
    public class Academy2Context : DbContext
    {
        public Academy2Context (DbContextOptions<Academy2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Components.Model.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Components.Model.Group> Groups { get; set; } = default!;

		public string DecimalToBinary(int num)
		{
			string result = "";
			int day = 1, degree = 1;

			while (day <= 7)
			{
				if ((num & degree) != 0)
				{
					result += NameDayForNumber(day);
				}
				day += 1;
				degree *= 2;
			}
			return result[..^1];
		}


		public string NameDayForNumber(int num)
		{
			switch (num)
			{
				case 1:
					return "Пн-";
				case 2:
					return "Вт-";
				case 3:
					return "Ср-";
				case 4:
					return "Чт-";
				case 5:
					return "Пт-";
				case 6:
					return "Сб-";
				case 7:
					return "Вс-";
				default:
					return "Error";
			}
		}

		public int Convert(bool[] learning_days)
		{
			int result = 0;
			for (int i = 0; i < learning_days.Length; ++i)
			{
				if (learning_days[i])
					result |= 1 << i;
			}
			return result;
		}

	}
}
