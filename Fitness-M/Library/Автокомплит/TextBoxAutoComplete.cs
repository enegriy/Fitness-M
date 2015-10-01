using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
	/// <summary>
	/// Автодополнение для TextBox
	/// </summary>
	public static class TextBoxAutoComplete
	{
		public static void Initializer(TextBox textBox, string[] values)
		{
			var collection = new AutoCompleteStringCollection();
			collection.AddRange(values);

			textBox.AutoCompleteCustomSource = collection;
			textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
	}
}
