
using UnityEngine;

namespace OneGuyStudio
{
    public class OnDisableSpriteRenderer : EventSubscriber
    {

        private void Awake()
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
}
