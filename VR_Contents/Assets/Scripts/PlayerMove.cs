using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(GameObject cameraObject, float speed, int moveType, float rotaF)
    {
        this.transform.Translate(0, 0, speed);
        
        speed += Input.GetAxis("Vertical") / 200;
        if(speed < 0)
        {
            speed = 0;
        }
        else if(speed > 0.7)
        {
            speed = 0.7f;
        }
        GetComponent<Player>().speed = speed;

        if (moveType == 0)
        {
            this.transform.Rotate(-Input.GetAxis("Vertical2"), Input.GetAxis("Horizontal"), -Input.GetAxis("Horizontal2"));
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
        else if (moveType == 1)
        {
            this.transform.Rotate(Input.GetAxis("Vertical2"), -Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal2"));
            cameraObject.transform.Rotate(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
        }
    }
}
