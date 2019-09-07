using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneGuyStudio
{
    public class DragMeAround : EventSubscriber
    {

        private bool followMouse;
        private Vector3 originalScale;
        private Vector3 originalPosition;
        private float originalColliderRadius;
        public float speed;
        private float originalSpeed;
        private bool isClone;
        public float alphaColor;
        public float hoverScale;
        private Color originalColor;
        private Color transparentColor;
        public SpriteRenderer localRenderer;
        public CircleCollider2D localCollider;
        public OnGetLetter getLetter;
        private bool moveback;
        private int originalLayer;
        public int targetLayer;




        private void OnChangeLayer()
        {
            //originalLayer = gameObject.layer;
            //gameObject.layer = targetLayer;
        }

        private void Awake()
        {
            isClone = false;
            moveback = false;
            originalColliderRadius = localCollider.radius;
            eventListener.Add("resetDictionary", DestroyMe);

            originalColor = localRenderer.color;
            transparentColor = new Color(originalColor.r, originalColor.g, originalColor.b, alphaColor);
            originalPosition = transform.position;
            originalSpeed = speed;
            originalScale = transform.localScale;
            followMouse = false;

        }


        public void OnTriggerEnter2D(Collider2D collision)
        {


        }


        public void ResetObject()
        {
            followMouse = false;
            //gameObject.layer = originalLayer;
            speed = originalSpeed;
            transform.position = originalPosition;
            localRenderer.color = originalColor;


            Invoke("ResetTransform", 0.01f);
        }
        public void ResetTransform()
        {
            transform.localScale = originalScale;





        }
        private void OnMouseExit()
        {

            Invoke("ResetTransform", 0.01f);


        }

        private void OnMouseEnter()
        {
            if (getLetter.isReady)
            {
                //originalLayer = gameObject.layer;
                //localCollider.size = new Vector2((float)(localCollider.size.x / hoverScale), (float)(localCollider.size.y / hoverScale));
                transform.localScale = new Vector3(hoverScale, hoverScale, hoverScale);
            }
        }


        private void OnMouseDown()
        {
            if (getLetter.isReady)
            {
                followMouse = true;
                //originalLayer = gameObject.layer;
                //gameObject.layer = targetLayer;
                //localCollider.radius = localCollider.radius / hoverScale;
                localRenderer.color = transparentColor;

            }

            //transform.localScale = new Vector3(hoverScale, hoverScale, hoverScale);

            //localCollider.size = new Vector2((float)(localCollider.size.x / hoverScale), (float)(localCollider.size.y / hoverScale));

        }

        private void OnMouseUp()
        {
            if (getLetter.isReady)
            {
                //gameObject.layer = originalLayer;
                //localCollider.radius = originalColliderRadius;
                Invoke("ResetObject", 0.01f);
            }
        }

        void Update()
        {

            if (followMouse)
            {
                Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f);
                transform.position = Camera.main.ScreenToWorldPoint(pos);
            }
            //if (moveback)
            //{

            //    if (Vector3.Distance(transform.position, originalPosition) > 0.001f)
            //    {

            //        speed *= 1.3f;
            //        transform.position = Vector3.MoveTowards(transform.position, originalPosition, speed * Time.deltaTime);

            //    }
            //    else
            //    {
            //        moveback = false;
            //        if (isClone)
            //        {
            //            Destroy(gameObject);
            //        }

            //    }



            //}







        }

    }
}
