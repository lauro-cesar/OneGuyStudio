using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class TriggerEventsOnAwake : EventSubscriber
    {
        public string[] eventsToTrigger;




        public void Awake()
        {
            foreach( string eventName in eventsToTrigger) {
                EventManager.TriggerEvent(eventName);
            }
           
        }




    }
}