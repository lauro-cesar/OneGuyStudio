using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneGuyStudio
{
    public class CollectibleManager : EventSubscriber
    {



        private GameObject gemVisuals;
        private GameObject collectedParticleSystem;
        private CircleCollider2D gemCollider2D;
        public int pointValue;
        private float durationOfCollectedParticleSystem;



        void OnCounteMe(){
            GameManager.totalJoiasPorMapa++;
        }

        private void Awake()
        {
            eventListener.Add("countGems",OnCounteMe);
            gemVisuals = transform.Find("GemMesh").gameObject;
            gemCollider2D = transform.GetComponent<CircleCollider2D>();
            collectedParticleSystem = transform.Find("Collected Particle System").gameObject;
            durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;
        }


        void OnTriggerEnter2D(Collider2D theCollider)
        {
            if (theCollider.CompareTag("Player"))
            {
                GemCollected();
            }
        }

        void GemCollected()
        {




            //Debug.Log( GameManager.gameSession.totalStatements);
            //GameManager.gameSession.points+=1;
            gemCollider2D.enabled = false;
            gemVisuals.SetActive(false);
            collectedParticleSystem.SetActive(true);

            GameManager.challenge.playerStats.joias++;

            EventManager.TriggerEvent("newPoint");
            Invoke("DeactivateGemGameObject", durationOfCollectedParticleSystem);
        }

        void DeactivateGemGameObject()
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
        }





    }
}
