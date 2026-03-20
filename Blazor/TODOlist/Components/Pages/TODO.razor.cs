using TODOlist.Classes;
using System.Linq;

namespace TODOlist.Components.Pages
{
	public partial class TODO
	{
		string task = "Hello";

		List<TODOitem> todos = [];

		void AddTask()
		{
			if (string.IsNullOrWhiteSpace(task)) return;
			//if (todos.Contains(new TODOitem { Title = task })) return;
			TODOitem find_copy = todos.FirstOrDefault(f => f.Title == task);
			if (find_copy == null)
				todos.Add(new TODOitem { Title = task });
			task = "";
		}
	}
}
