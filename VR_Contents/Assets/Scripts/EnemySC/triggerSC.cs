using UnityEngine;
using System.Collections;

public class triggerSC : MonoBehaviour {

    public bool ontrigger=false;

    public string collider_tag;
	public void OnTriggerStay(Collider collider)
    {
        collider_tag = collider.gameObject.tag;
        if (collider.gameObject.tag == "comet")
        {
            ontrigger = true;
        }
        else if (collider.gameObject.tag=="Player")
        {
            ontrigger = true;
        }
        else
        {
            
        }
    }
    void OnTriggerExit(Collider collider)
    {
        ontrigger = false;
    }
}
