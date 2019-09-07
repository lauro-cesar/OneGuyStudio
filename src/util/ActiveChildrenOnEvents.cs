using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OneGuyStudio
{

    public class ActiveChildrenOnEvents : EventSubscriber
    {
        public string[] eventsToActive;
        public string[] eventsToDeActive;


        void DeActiveChildren() {


            foreach(Transform transformes in gameObject.GetComponentsInChildren<Transform>(true))
            {
                transformes.gameObject.SetActive(false);
            }
            gameObject.SetActive(true);

        }



        void ActiveChildren() {


            foreach(Transform transformes in gameObject.GetComponentsInChildren<Transform>(true))
            {
                transformes.gameObject.SetActive(true);
            }

        }

        private void Awake()
        {
             foreach( string evento in eventsToActive){
                eventListener.Add(evento,ActiveChildren);
            }

            foreach( string evento in eventsToDeActive){
                eventListener.Add(evento,DeActiveChildren);
            }

        }


    }
}