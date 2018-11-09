using UnityEngine.UI;
using UnityEngine;

public class ScoreLabelController : MonoBehaviour, IScoreListener{


    public Text label;

    public void OnScore(GameStateEntity entity, int value)
    {
        label.text = "score" + value;
    }

    void Start () {
        Contexts.sharedInstance.gameState.CreateEntity().AddScoreListener(this);
	}
	
}
