using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;
using System.Linq;
using TMPro;

namespace OneGuyStudio
{
    public class OnLetterEnter : EventSubscriber
    {

        private Vector3 originalScale;
        private Color originalColor;
        public int indexe = 0;
        public float hoverScale;
        private bool isReady;
        public TextMeshPro myLabel;
        private string myLetter;
        private bool isCorrect;
        public AudioSource letterIn;
        private bool isInside;




        private void OnReset()
        {
            myLabel.SetText("");
            myLetter = "";
            isInside = false;
            isCorrect = false;
            isReady = false;
            myLabel.color = originalColor;
            transform.localScale = originalScale;
        }


        private void Awake()
        {
            originalScale = transform.localScale;
            originalColor = myLabel.color;
            OnReset();
            eventListener.Add("resetDictionary", OnReset);
            eventListener.Add("countResult", OnCountResult);

        }


        void OnCountResult()
        {

            if (isReady)
            {
                if (isCorrect)
                {
                    DitadoManager.totalCorrects++;
                }
                else
                {
                    DitadoManager.totalCorrects--;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Letter"))
            {
                transform.localScale = originalScale;
            }
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {



            if (collision.CompareTag("Letter"))
            {

                OnGetLetter getLetter = collision.gameObject.GetComponentInChildren<OnGetLetter>();

                if (getLetter != null)
                {
                    myLabel.SetText(getLetter.myLetter);
                    myLetter = getLetter.myLetter;
                    letterIn.Play();
                }

                if (DitadoManager.palavraAtiva != null)
                {
                    if (DitadoManager.palavraAtiva.palavraDitada.Length >= indexe)
                    {

                        if (myLetter.Equals(DitadoManager.palavraAtiva.palavraDitada[indexe].ToString()))
                        {
                            isCorrect = true;
                            isReady = true;
                            myLabel.color = new Color(0, 0, 0);
                        }
                        else
                        {
                            isCorrect = false;
                            isReady = true;
                            myLabel.color = originalColor;
                        }

                        //Debug.Log(DitadoManager.palavraAtiva.palavraDitada[indexe].ToString());
                    }
                }


                transform.localScale = new Vector3(hoverScale, hoverScale, hoverScale);

            }
        }





    }
}