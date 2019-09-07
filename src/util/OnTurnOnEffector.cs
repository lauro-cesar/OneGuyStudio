using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class OnTurnOnEffector : EventSubscriber
    {
        public SurfaceEffector2D effectorToTurnOn;
        public string[] actionsToInvoke;
        private float originalSpeed;
        public float slowSpeed;


        //private void OnGUI()
        //{

        //    int selectionGridInt = 0;
        //    string[] selectionStrings = { totalInTransit.ToString(), timeOut.ToString(), originalSpeed.ToString(), "Grid 4" };
        //    selectionGridInt = GUI.SelectionGrid(new Rect(100, 100, 300, 60), selectionGridInt, selectionStrings, 2);

        //}

        private void Awake()
        {
            originalSpeed = effectorToTurnOn.speed;
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {

            //if (collision.gameObject.layer == gameObject.layer)
            //{
            //    totalInTransit++;
            //    if (timeOut > minTimeout)
            //    {
            //        timeOut -= 0.15f;
            //    }
            //    effectorToTurnOn.speed = originalSpeed;
            //}
        }


        private void OnTurnOffEffector()
        {
            //if (totalInTransit < 1)
            //{
            //    effectorToTurnOn.speed = slowSpeed;
            //}
            //else
            //{
            //    Invoke("OnTurnOffEffector", timeOut);
            //}
        }



        private void OnTriggerExit2D(Collider2D collision)
        {





            //if (gameObject.layer == 20)
            //{
            //    if (effectorToTurnOn.speed > (slowSpeed + 0.95f))
            //    {
            //        effectorToTurnOn.speed -= 0.95f;
            //    }
            //    //(originalSpeed / (float)(DitadoManager.totalLetters - 1));
            //}
            //else
            //{

            //    //if (effectorToTurnOn.speed < (slowSpeed + 0.95f))
            //    //{
            //    //    effectorToTurnOn.speed -= 0.95f;
            //    //}
            //}



        }




    }
}