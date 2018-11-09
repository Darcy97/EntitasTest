using Entitas;

public class HelloWorldSystem : IInitializeSystem
{
    // always handy to keep a reference to the context 
    // we're going to be interacting with it
    readonly GameContext _context;


    public HelloWorldSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        _context.CreateEntity().AddDebugMessage("Hello World!");
    }
}
