using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static GameObject instance;
	
	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = gameObject;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			GameObject.DestroyImmediate(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
