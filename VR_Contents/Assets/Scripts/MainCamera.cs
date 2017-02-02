using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    public GameObject playerObject;

	// Use this for initialization
	void Start () {
        transform.localPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(playerObject.transform.position.x, playerObject.transform.position.y, playerObject.transform.position.z);
    }
}
