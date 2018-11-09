using Entitas;

public class TutorialSystems : Feature {

    public TutorialSystems(Contexts contexts) : base ("Tutorial Systems")
    {
        //Input

        Add(new InputSystem(contexts));

        //Update



        //Events
        Add(new InputEventSystems(contexts));

       // Add(new HelloWorldSystem(contexts));
       // Add(new LogMouseClickSystem(contexts));
       // Add(new DebugMessageSystem(contexts));
       // Add(new CleanupDebugMessageSystem(contexts));
    }
}
