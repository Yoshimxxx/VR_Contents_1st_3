using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultTextSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Text>().text = "RESULT\n\nScore="+Player.Score.ToString()+"\n\n\n後ろを振り向くと初期画面に戻ります";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
