using TODOlist.Classes;

namespace TODOlist.Components.Pages
{
	public partial class TODO
	{
		string task = "Hello";

		List<TODOitem> todos = [];

		void AddTask()
		{
			if (string.IsNullOrWhiteSpace(task)) return;
			if (todos.Contains(new TODOitem { Title = task })) return;
			todos.Add(new TODOitem { Title = task });
			task = "";
		}
	}
}
