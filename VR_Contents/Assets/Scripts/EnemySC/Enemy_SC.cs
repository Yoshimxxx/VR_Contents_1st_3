using UnityEngine;
using System.Collections;

public class Enemy_SC : MonoBehaviour {

    public int HP = 10;
    public float speed = 0.1f;//enemy move speed
    int firecycle_frame = 30; //reload time

    GameObject mynavi_trigger;
    triggerSC mynavi_triggerSC;

    GameObject targetobj;
    public GameObject bakuhatsu;

    public GameObject simple_bullet,hassyakou;

    public GameObject Marker;
    GameObject MarkerOBJ;//インスタンスしたマーカーの格納先

	// Use this for initialization
	void Start () {

        targetobj = GameObject.FindWithTag("Player");
        mynavi_trigger = gameObject.transform.FindChild("Navi_trigger").gameObject;
        mynavi_triggerSC = mynavi_trigger.transform.GetComponent<triggerSC>();

        MarkerOBJ = Instantiate(Marker, transform.position, new Quaternion(90, 0, 0, 0))as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (mynavi_triggerSC.ontrigger == false)
        {
            transform.Translate(0, 0, speed);
        }else
        {
            if (mynavi_triggerSC.collider_tag=="Player")
            {
                if (firecycle_frame % 30==0)
                {
                    Instantiate(simple_bullet, hassyakou.transform.position, hassyakou.transform.rotation);
                }
                firecycle_frame++;
            }
        }
        mynavi_trigger.transform.LookAt(targetobj.transform);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, mynavi_trigger.transform.rotation, 0.1f);
        RadarMarker();
        //naviの値を元に戻す
        
    }

    void RadarMarker()
    {
        MarkerOBJ.transform.position = transform.position;
        MarkerOBJ.transform.rotation = Quaternion.Euler(90, transform.eulerAngles.y, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "P_bullet")
        {
            HP--;
            
        }else if (collision.gameObject.tag == "Missile")
        {
            HP -= 20;
        }

        if (HP <= 0)
        {
            Instantiate(bakuhatsu, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
