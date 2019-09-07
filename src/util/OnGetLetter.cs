using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace OneGuyStudio
{
    public class OnGetLetter : EventSubscriber
    {
        public string myLetter;
        public TextMeshPro myLabel;
        public bool isReady;


        private void Awake()
        {
            isReady = true;
        }



        public void Setup()
        {
            myLabel.SetText(myLetter);
            isReady = true;
        }


    }
}
