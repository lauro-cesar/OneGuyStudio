using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneGuyStudio
{
    public class OnBaseNoveloEvents : EventSubscriber
    {
        private SurfaceEffector2D effector;
        private float originalSpeed;



        private void OnEnterThinking() {
            effector.speed = 0;
        }

        private void OnExitThinking() {
            effector.speed = originalSpeed;
        }


        private void Awake()
        {

            effector = gameObject.GetComponent<SurfaceEffector2D>();


            originalSpeed = effector.speed;
            eventListener.Add("exitThinking", OnExitThinking);
            eventListener.Add("enterThinking", OnEnterThinking);

        }




    }
}
