using System;

namespace Xamarin.Forms
{
	public class ToolbarItem : MenuItem
	{
		static readonly BindableProperty OrderProperty = BindableProperty.Create("Order", typeof(ToolbarItemOrder), typeof(ToolbarItem), ToolbarItemOrder.Default, validateValue: (bo, o) =>
		{
			var order = (ToolbarItemOrder)o;
			return order == ToolbarItemOrder.Default || order == ToolbarItemOrder.Primary || order == ToolbarItemOrder.Secondary;
		});

		static readonly BindableProperty PriorityProperty = BindableProperty.Create("Priority", typeof(int), typeof(ToolbarItem), 0);

		static readonly BindableProperty PositionProperty = BindableProperty.Create("Position", typeof(ToolbarItemPosition), typeof(ToolbarItem), ToolbarItemPosition.End);

		public ToolbarItem()
		{
		}

		public ToolbarItem(string name, string icon, Action activated, ToolbarItemOrder order = ToolbarItemOrder.Default, int priority = 0, ToolbarItemPosition position = ToolbarItemPosition.End)
		{
			if (activated == null)
				throw new ArgumentNullException("activated");

			Text = name;
			Icon = icon;
			Clicked += (s, e) => activated();
			Order = order;
			Priority = priority;
			Position = position;
		}

		public ToolbarItemPosition Position
		{
			get { return (ToolbarItemPosition)GetValue(PositionProperty); }
			set { SetValue(PositionProperty, value); }
		}

		[Obsolete("Name is obsolete as of version 1.3.0. Please use Text instead.")]
		public string Name
		{
			get { return Text; }
			set { Text = value; }
		}

		public ToolbarItemOrder Order
		{
			get { return (ToolbarItemOrder)GetValue(OrderProperty); }
			set { SetValue(OrderProperty, value); }
		}

		public int Priority
		{
			get { return (int)GetValue(PriorityProperty); }
			set { SetValue(PriorityProperty, value); }
		}

		[Obsolete("Activated is obsolete as of version 1.3.0. Please use Clicked instead.")]
		public event EventHandler Activated
		{
			add { Clicked += value; }
			remove { Clicked -= value; }
		}
	}
}