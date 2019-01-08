

using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;


namespace OneGuyStudio {

public class EventManager : MonoBehaviour {
    private Dictionary <string, UnityEvent> eventDictionary;
    private static EventManager eventManager;

    public static EventManager instance {
        get {
            if(!eventManager){
                eventManager = FindObjectOfType(typeof(EventManager)) as EventManager;
                eventManager.Init();
            }
            return eventManager;
        }
    }


   void Awake() {
        if(eventManager == null){
            DontDestroyOnLoad(gameObject);
            eventManager = this;
            eventDictionary = new Dictionary<string, UnityEvent>();
        } else {
            if(eventManager != this){
                Destroy(gameObject);
            }
        }
    }

    void Init(){
        if(eventDictionary == null){
            eventDictionary = new Dictionary<string, UnityEvent>();
        }
    }


    public static void StartListening(string eventName, UnityAction listener){
        UnityEvent thisEvent =null;

        if(instance.eventDictionary.TryGetValue(eventName, out thisEvent)){
            thisEvent.AddListener(listener);
        } else {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            instance.eventDictionary.Add(eventName, thisEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction listener){
        if(eventManager == null){
            return;
        }
        UnityEvent thisEvent = null;
        if(instance.eventDictionary.TryGetValue(eventName, out thisEvent)){
            thisEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName){
        UnityEvent thisEvent = null;
        if(instance.eventDictionary.TryGetValue(eventName, out thisEvent)){
            thisEvent.Invoke();
        }
    }
}
}