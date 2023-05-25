namespace Xbox_App.Views.Controls.Tiles;

public partial class GameClipTile : ContentView
{
    public static readonly BindableProperty HeadlineProperty = BindableProperty.Create(nameof(Headline), typeof(string), typeof(HeaderTile), default(string));
    public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(HeaderTile), default(string));

    public string Headline { get { return (string)GetValue(HeadlineProperty); } set { SetValue(HeadlineProperty, value); } }
    public string Image { get { return (string)GetValue(ImageProperty); } set { SetValue(ImageProperty, value); } }
    public GameClipTile()
    {
        InitializeComponent();
        Content.BindingContext = this;
    }
}