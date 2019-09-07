using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneGuyStudio
{
    public class PlayClipAndParticle : EventSubscriber
    {

 
        public ParticleSystem effectSource;
        public AudioSource audioSource;
        public string[] eventName;

        void OnPlay() {

            effectSource.Play(); 
            audioSource.Play();

        }

        private void Awake()
        {
             foreach( string evento in eventName){
                eventListener.Add(evento,OnPlay);
            }
           
        }


    }
}
