using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace OneGuyStudio {
public class OnOpenLink : EventSubscriber {

    public void openLink(string url)
    {
        AnalyticsEvent.Custom(url);
        Application.OpenURL(url);
    }

}

}