using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{

    public class TriggerEventsOnStart : EventSubscriber
    {
        public string[] eventsToTrigger;

        public void OnEnable(){

            // Debug.Log("Ativando");

        }

        public void OnDisable(){
            // Debug.Log("DesAtivando");
        }


        public void Start()
        {

            foreach( string eventName in eventsToTrigger) {

                    EventManager.TriggerEvent(eventName);
            }

        }

    }
}