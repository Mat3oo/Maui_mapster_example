using Microsoft.Extensions.Logging;
using Models;
using Mapster;

namespace maui_mapster;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        try
        {
            var parent1 = new Parent() { Id = "Parent1", Childrens = new List<Child>() { new Child() { ChildId = "Child1" } } };
            var parent2 = new Parent() { Id = "Parent2", Childrens = new List<Child>() { new Child() { ChildId = "Child2" } } };

            var parentList = new List<Parent>() { parent1, parent2 };

            var mapped = parentList.Adapt<ICollection<ParentDTO>>();
        }
        catch (Exception ex)
        {
            throw;
        }

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

