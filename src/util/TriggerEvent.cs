using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OneGuyStudio
{
    public class TriggerEvent : EventSubscriber
    {

        public void saveChallengeCode(string challengCode)
        {
            // Debug.Log(challengCode);
        }


        public void OnTriggerEvent(string eventName)
        {
            EventManager.TriggerEvent(eventName);
        }

        public void OnShowScreen(string screenName)
        {
            GameManager.gameSession.activeTab = screenName;
            EventManager.TriggerEvent("showOverLay");
        }

    }
}
