using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneGuyStudio
{
    public class TeleTransport : EventSubscriber
    {

        [Header("Portal de destino")]
        public Transform nextPortal;
        [Header("Efeito de Entrada")]
        public ParticleSystem inEffects;
        [Header("Efeito de Saida")]
        public ParticleSystem outEffects;

        private Collider2D objectCollider;




      

        void OnTriggerEnter2D(Collider2D theCollider)
        {
            if (theCollider.CompareTag("Player"))
            {



                GameManager.gameSession.newPlayerPosition = nextPortal;

                EventManager.TriggerEvent("teletransportPlayer");


            }
        }



    }
}
