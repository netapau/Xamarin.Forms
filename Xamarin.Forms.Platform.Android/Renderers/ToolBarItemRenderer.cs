using System;
using Android.Content;
using Android.Views;
using AView = Android.Views.View;
using Xamarin.Forms;
using Android.Runtime;

namespace Xamarin.Forms.Platform.Android.Renderers
{
	public class ToolbarItemRenderer : ViewRenderer<View,AView>
	{

		public new ToolbarItem Element => this.Element;

		public ToolbarItemRenderer(Context context) : base(context)
		{
			if (Element.Position == ToolbarItemPosition.Start)
			{
				SetForegroundGravity(GravityFlags.Start);
			}

		}

		public override void OnViewAdded(AView child)
		{
			base.OnViewAdded(child);

			if (Element.Position == ToolbarItemPosition.Start)
			{
				SetForegroundGravity(GravityFlags.Start);
			}
			else
			{
				SetForegroundGravity(GravityFlags.End);
			}
		}
	}
}