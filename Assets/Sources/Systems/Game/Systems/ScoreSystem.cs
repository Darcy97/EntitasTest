using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ScoreSystem : ReactiveSystem<GameEntity>, IInitializeSystem {

    readonly Contexts _contexts;

    public ScoreSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        _contexts.gameState.SetScore(0);
    }

    protected override void Execute(List<GameEntity> entities)
    {
        _contexts.gameState.ReplaceScore(_contexts.gameState.score.value + entities.Count);
    }

    protected override bool Filter(GameEntity entity)
    {
        throw new System.NotImplementedException();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        throw new System.NotImplementedException();
        //return context.CreateCollector(GameMatcher.GameBoardElement.Removed());
    }
}
