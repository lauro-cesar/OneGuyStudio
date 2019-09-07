using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class InvokeOnEvent : EventSubscriber
    {
        public string[] eventsToListen;
         public string[] actionsToInvoke;



        private void OnEventTrigger() {

           foreach( string actionName in actionsToInvoke) {              
               Invoke(actionName,0.1f);
            }

        }

        public void Awake()
        {


              foreach( string eventName in eventsToListen) {
                    eventListener.Add(eventName,OnEventTrigger);
                }


         
           
        }




    }
}