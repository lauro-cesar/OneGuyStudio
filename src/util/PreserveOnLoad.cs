using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class PreserveOnLoad : EventSubscriber
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }


    }
}
