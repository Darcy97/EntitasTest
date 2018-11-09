using UnityEngine;
using UnityEngine.UI;

public class ModeLabelController : MonoBehaviour, IBrustModeListener, IBrustModeRemovedListener{

    public Text label;

    string _text;

    private void Awake()
    {
        _text = label.text;
    }

    public void OnBrustMode(InputEntity entity)
    {
        label.text = _text + ": on";
    }

    public void OnBrustModeRemoved(InputEntity entity)
    {
        
        label.text = _text + ": off";
    }
    

    void Start () {

        print("start");

        var contexts = Contexts.sharedInstance;
        var listener = contexts.input.CreateEntity();
        listener.AddBrustModeListener(this);
        listener.AddBrustModeRemovedListener(this);

        if (contexts.input.isBrustMode)
        {
            OnBrustMode(contexts.input.brustModeEntity);
        }
        else
        {
            OnBrustModeRemoved(contexts.input.brustModeEntity);
        }

	}
	

   
}
