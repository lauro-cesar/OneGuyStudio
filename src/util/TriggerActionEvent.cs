using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class TriggerActionEvent : EventSubscriber
    {
        public string[] eventsToTrigger;




        public void OClickMe()
        {
            foreach( string eventName in eventsToTrigger) {
                EventManager.TriggerEvent(eventName);
            }
           
        }




    }
}