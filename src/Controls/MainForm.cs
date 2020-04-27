using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
	public partial class MainForm : Form
	{
		private ProjectSettings _projectSettings;

		/// <summary>Создаем объекты contol и присваем их соответствующим панелям.</summary>
		/// <param name="projectSettings">Переданный параметр projectSettings.</param>
		public MainForm(ProjectSettings projectSettings)
		{
			_projectSettings = projectSettings;

			InitializeComponent();

			//создаем объект control и присваиваем его соответствуещей понели
			var logControl = new LogControl();
			_pnlLogControl.Controls.Add(logControl);
			//задаем свойство заполнения
			logControl.Dock = DockStyle.Fill;

			//создаем объект control и присваиваем его соответствуещей понели
			var playerControl = new PlayerControl();
			_pnlPlayerControl.Controls.Add(playerControl);
			//задаем свойство заполнения
			playerControl.Dock = DockStyle.Fill;

			//создаем объект control и присваиваем его соответствуещей понели
			var settingsControl = new SettingsControl();
			_pnlSettingsControl.Controls.Add(settingsControl);
			//задаем свойство заполнения
			settingsControl.Dock = DockStyle.Fill;

		}
	}
}
