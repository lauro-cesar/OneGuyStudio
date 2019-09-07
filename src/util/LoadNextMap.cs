using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OneGuyStudio
{
    public class LoadNextMap : EventSubscriber
    {

        [Header("Mapas para mostrar e ocultar")]
        public GameObject nextMap;
        public GameObject prevMap;




        void OnTriggerEnter2D(Collider2D theCollider)
        {
            if (theCollider.CompareTag("Player"))
            {


                    prevMap.SetActive(theCollider.gameObject.GetComponentInParent<Animator>().GetBool("FacingLeft"));
                    nextMap.SetActive(theCollider.gameObject.GetComponentInParent<Animator>().GetBool("FacingRight"));
            }
        }



    }
}
