using Mapster;
using mapsterTest;
using Models;

try
{
    var parent1  = new Parent() { Id = "Parent1", Childrens = new List<Child>() { new Child() { ChildId = "Child1" } } };
    var parent2 = new Parent() { Id = "Parent2", Childrens = new List<Child>() { new Child() { ChildId = "Child2" } } };

    var parentList = new List<Parent>() { parent1, parent2 };

    var mapped = parentList.Adapt<ICollection<ParentDTO>>();
}
catch (Exception ex)
{
    throw;
}

// This is the main entry point of the application.
// If you want to use a different Application Delegate class from "AppDelegate"
// you can specify it here.
UIApplication.Main(args, null, typeof(AppDelegate));