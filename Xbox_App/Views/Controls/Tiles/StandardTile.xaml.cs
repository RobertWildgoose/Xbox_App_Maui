namespace Xbox_App.Views.Controls.Tiles;

public partial class StandardTile : ContentView
{
    public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(HeaderTile), default(string));

    public string Image { get { return (string)GetValue(ImageProperty); } set { SetValue(ImageProperty, value); } }

    public StandardTile()
    {
        InitializeComponent();
        Content.BindingContext = this;
    }
}