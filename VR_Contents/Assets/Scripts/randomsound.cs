using UnityEngine;
using System.Collections;

public class randomsound : MonoBehaviour {
    //ランダムでSEを鳴らすスクリプト
    

    AudioSource oto; //これをアタッチしたオブジェクトのAudioSource
    bool playflag = false;
    int destroytime = 0;
    
    public AudioClip[] sound = new AudioClip[5];
    // Use this for initialization
    void Start () {
        oto = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playflag == false)
        {
            oto.PlayOneShot(sound[Random.Range(0, sound.Length)]);
            playflag = true;
        }
        /*else
        {
            if (destroytime >= 240)
            {
                Destroy(this.gameObject);
            }
            destroytime++;
        }*/
	
	}
}
