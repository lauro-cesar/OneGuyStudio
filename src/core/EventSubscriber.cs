using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


namespace OneGuyStudio {

public class EventSubscriber : MonoBehaviour {
    public  Dictionary<string, UnityAction> eventListener = new Dictionary<string, UnityAction>();



   public void OnEnable(){
    foreach( KeyValuePair<string, UnityAction> kvp in eventListener )
        {
            EventManager.StartListening(kvp.Key.ToString(),eventListener[kvp.Key]);
        }
    }

    public void OnDisable(){
        foreach( KeyValuePair<string, UnityAction> kvp in eventListener )
            {
                EventManager.StopListening(kvp.Key.ToString(),eventListener[kvp.Key]);
        }
    }
}
}