using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
	/// <summary>Создаем публичные поля string Path и int Count.</summary>
	public class ProjectSettings
	{
		public string Path { get; set; }

		public int Count { get; set; }

		//Присваиваем им значения
		public ProjectSettings()
		{
			Path = "Первое свойство";
			Count = 4;
		}

	}
}
