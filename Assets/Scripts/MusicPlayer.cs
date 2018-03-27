using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    void Awake() {

        Debug.Log("Music player " + GetInstanceID() + " is awake.");

        if (instance != null) {

            Destroy(gameObject);
            Debug.Log("Duplicate music player detected. Destroying second instance.");
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
