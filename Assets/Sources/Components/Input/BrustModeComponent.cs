using Entitas.CodeGeneration.Attributes;
using Entitas;

[Input, Unique, Event(EventTarget.Any), Event(EventTarget.Any, EventType.Removed)]
public sealed class BrustModeComponent : IComponent
{
}
