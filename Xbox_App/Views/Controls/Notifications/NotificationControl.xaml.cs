using Xbox_App.Models;

namespace Xbox_App.Views.Controls.Notifications;

public partial class NotificationControl : ContentView
{
    public static readonly BindableProperty TileProperty = BindableProperty.Create(nameof(Tile), typeof(NotificationTile), typeof(NotificationControl), default(NotificationTile));

    public NotificationTile Tile { get { return (NotificationTile)GetValue(TileProperty); } set { SetValue(TileProperty, value); } }
    public NotificationControl()
	{
		InitializeComponent();
        Content.BindingContext = this;
	}
}