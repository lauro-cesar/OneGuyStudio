using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OneGuyStudio
{

    public class TriggerEventsOnEnable : EventSubscriber
    {
        public string[] eventsToTrigger;




        public void OnEnable(){

                foreach( string eventName in eventsToTrigger) {

                    EventManager.TriggerEvent(eventName);
            }

        }

        public void OnDisable(){


		}




    }
}