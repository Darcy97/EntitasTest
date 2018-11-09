using Entitas;
using Entitas.CodeGeneration.Attributes;

[GameState, Unique, Event(EventTarget.Any)]
public class ScoreComponent : IComponent {
    public int value;
}
