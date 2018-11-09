using System.Collections.Generic;
using Entitas;
using System.Linq;
using UnityEngine;

public class InputSystem : ReactiveSystem<InputEntity>, ICleanupSystem
{

    readonly Contexts _contexts;
    readonly IGroup<InputEntity> _input;
    readonly List<InputEntity> _inputBuffer = new List<InputEntity>();


    public InputSystem(Contexts contexts) : base(contexts.input)
    {
        _contexts = contexts;
        _input = contexts.input.GetGroup(InputMatcher.Input);
    }

   
    protected override void Execute(List<InputEntity> entities)
    {
        var inputEntity = entities.SingleEntity();
        var input = inputEntity.input;
        //Debug.Log( input.x + "," + input.y);


        foreach (var e in _contexts.game.GetEntitiesWithPosition(new IntVector2(input.x, input.y)).Where(e => e.isInteractive))
        {
            e.isDestroyed = true;
        }
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInput;
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.Input);
    }


    public void Cleanup()
    {
        foreach (var e in _input.GetEntities(_inputBuffer))
        {
            e.Destroy();
        }
    }
}
