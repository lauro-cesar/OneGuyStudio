using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OneGuyStudio
{
    public class FollowTheMouse : EventSubscriber
    {
        private bool showMouse;
        private bool rotateMouse;


        void OnOrthoIn(){
            OnShowMouse();

            //transform.localScale = new Vector3(0.05f,0.05f,0.05f);
        }



        void OnOrthoOut(){
            OnHideMouse();
            showMouse=true;
            //transform.localScale = new Vector3(0.02f,0.02f,0.02f);
        }

        void OnHideMouse(){
            GameObject.Find("/GameScreenBoard/mouse").gameObject.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            showMouse=false;
        }
        void OnShowMouse(){
            GameObject.Find("/GameScreenBoard/mouse").gameObject.SetActive(true);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            showMouse=true;
        }



        private void Awake()
        {
            showMouse=true;
            rotateMouse=false;
            eventListener.Add("orthoIn",OnOrthoIn);
            eventListener.Add("orthoOut",OnOrthoOut);
            eventListener.Add("showMouse",OnShowMouse);
            eventListener.Add("hideMouse",OnHideMouse);

            // Cursor.lockState = CursorLockMode.None;
            // Cursor.visible = false;
            //transform.rotation = Quaternion.Euler(0, 180, 135);
            //transform.localScale = new Vector3(-0.15f, -0.15f, 0.15f);

        }

        void Update()
        {
            if(showMouse){
            int count = Camera.allCameras.Length;
            if(count >0 ){

            Cursor.visible = false;

                    Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f);
            // transform.rotation = Quaternion.identity
            transform.position = Camera.main.ScreenToWorldPoint(pos);



                    if (rotateMouse){
                transform.LookAt(Camera.main.transform.position);
            }
            }
            } else {
                Cursor.visible = true;
            }
        }

    }
}
