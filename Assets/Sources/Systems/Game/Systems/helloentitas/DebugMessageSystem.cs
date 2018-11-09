using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class DebugMessageSystem : ReactiveSystem<GameEntity>
{

    public DebugMessageSystem(Contexts contexts) : base(contexts.game)
    {
    }


    protected override void Execute(List<GameEntity> entities)
    {
        // this is the list of entities that meet our conditions
        foreach (var e in entities)
        {
            // we can safely access their DebugMessage component
            // then grab the string data and print it
            Debug.Log(e.debugMessage.message);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasDebugMessage;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.DebugMessage);
    }
}

