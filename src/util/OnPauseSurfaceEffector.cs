using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneGuyStudio
{
    public class OnPauseSurfaceEffector : EventSubscriber
    {
        public string[] eventsToListen;
        public SurfaceEffector2D[] surfaceEffectors;



        public void OnPauseEffectors()
        {
            foreach (SurfaceEffector2D effector in surfaceEffectors)
            {
                effector.speed = 0f;
            }
        }
        private void Awake()
        {

            foreach (string evento in eventsToListen)
            {
                eventListener.Add(evento, OnPauseEffectors);
            }

        }

    }


}
