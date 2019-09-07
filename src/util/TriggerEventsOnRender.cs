using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneGuyStudio
{

    public class TriggerEventsOnRender : EventSubscriber
    {
        public string[] eventsToTrigger;

        public void OnRenderObject(){

                foreach( string eventName in eventsToTrigger) {
                    EventManager.TriggerEvent(eventName);
            }

        }




    }
}