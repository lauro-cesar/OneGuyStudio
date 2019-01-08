using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;
namespace OneGuyStudio {
//
public class GameManager : EventSubscriber {
	[System.Serializable]
	public struct GameSession
	{
		public float speed;
		public float paddleSpeed;
		public float maxSpeed;
    }
	public static GameManager gameManager;
	public static GameSession gameSession;





	public static void Serialize(object item, string path)
	{
		XmlSerializer serializer = new XmlSerializer(item.GetType());
		StreamWriter writer = new StreamWriter(path);
		serializer.Serialize(writer.BaseStream, item);
		writer.Close();
	}

	public static T Deserialize<T>(string path)
	{
		XmlSerializer serializer = new XmlSerializer(typeof(T));
		StreamReader reader = new StreamReader(path);
		T deserialized = (T)serializer.Deserialize(reader.BaseStream);
		reader.Close();
		return deserialized;
	}



   	public static GameManager instance {
        get {
            if(!gameManager){
                gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
            }
            return gameManager;
        }
    }

	void OnQuitGame(){
	}





	void Awake(){
		gameSession.speed=35f;
		gameSession.maxSpeed=45f;
		gameSession.paddleSpeed=1.5f;
  		if(gameManager == null){
            DontDestroyOnLoad(gameObject);
            gameManager = this;
			eventListener.Add("quitGame", OnQuitGame);
		}
	}
}
}