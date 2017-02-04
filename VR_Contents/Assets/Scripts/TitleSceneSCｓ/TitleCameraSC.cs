using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleCameraSC : MonoBehaviour {

    public Camera cameraSC;
    int raytime = 0;

    // Use this for initialization
    void Start () {
        cameraSC = this.GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = cameraSC.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "start_sprite")//当たった物体
            {
                hit.transform.Rotate(0, 0, 3);
                raytime++;
                if (raytime > 100)//一定時間以上視点を合わせると
                {
                    SceneManager.LoadScene("Main");
                }
            }
            else if (hit.collider.name == "endtext")//当たった物体
            {
                
                raytime++;
                if (raytime > 100)//一定時間以上視点を合わせると
                {
                    Player.Score = 0;
                    SceneManager.LoadScene("Title");
                }
            }
            else
            {
                raytime = 0;
            }

        }
    }
}
