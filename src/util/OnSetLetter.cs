// 
// 2/7/2019
// 7:00 AM
// Lauro Cesar
// lauro@dlceducationalgames.com
// /Users/olarva/JogosOficina/Ditado/Assets/OneGuyStudio/util/NewMonoBehaviour.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace OneGuyStudio
{
    public class OnSetLetter : EventSubscriber
    {
        public string myLetter;
        public TextMeshPro myLabel;

        public void Setup()
        {
            myLabel.SetText(myLetter);
        }


    }
}
