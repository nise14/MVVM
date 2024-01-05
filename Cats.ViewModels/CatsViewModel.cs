namespace Cats.ViewModels;

public class CatsViewModel : ICatsViewModel
{
    private readonly ICatsModel _model;

    public CatsViewModel(ICatsModel model)
    {
        _model = model;
    }

    public IReadOnlyCollection<Cat> Cats { get; private set; } = null!;

    public async Task GetCatsAsync()
    {
        Cats = await _model.GetCatsAsync();
    }
}