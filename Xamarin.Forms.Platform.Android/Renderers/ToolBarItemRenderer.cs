using Android.Content;
using Android.Views;
using AView = Android.Views.View;

namespace Xamarin.Forms.Platform.Android.Renderers
{
	public class ToolbarItemRenderer : ViewRenderer<View,AView>
	{
		public Context MyContext { get; set; }

		public new ToolbarItem Element => this.Element;

		public ToolbarItemRenderer(Context context) : base(context)
		{
			MyContext = context;
		}

		public override void OnViewAdded(AView child)
		{
			base.OnViewAdded(child);

			// Start => Ltr.
			if (Element.Position == ToolbarItemPosition.Start)
			{
				LayoutDirection = LayoutDirection.Ltr;
			}
			else
			{
				LayoutDirection = LayoutDirection.Rtl;
			}
		}
	}
}