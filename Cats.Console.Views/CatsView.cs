namespace Cats.Console.Views;

public class CatsView : ICatsView
{
    private readonly ICatsViewModel _viewModel;

    public CatsView(ICatsViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    public async Task RenderCatsAsync()
    {
        await _viewModel.GetCatsAsync();

        foreach (var cat in _viewModel.Cats)
        {
            WriteTop();
            WriteMiddle(cat.Id);
            WriteMiddle(cat.Url);
            WriteMiddle(cat.Width.ToString());
            WriteMiddle(cat.Height.ToString());
            WriteBottom();
        }
    }

    private void WriteTop() =>
        System.Console.WriteLine(" ╔{0}╗", new string('═', 70));

    private void WriteMiddle(string text) =>
        System.Console.WriteLine(" ║ {0,-69}║", text);

    private void WriteBottom() =>
        System.Console.WriteLine(" ╚{0}╝", new string('═', 70));
}