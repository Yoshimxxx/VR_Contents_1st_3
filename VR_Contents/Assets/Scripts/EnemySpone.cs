﻿using UnityEngine;
using System.Collections;

public class EnemySpone : MonoBehaviour {

    public GameObject Enemy;
    Vector3 random_tf;
    GameObject now_create_enemy;

    GameObject[] tagObjects;

    bool createflag = false;
    int gamecount=0;

    // Use this for initialization
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {
        if (createflag == false)
        {
            random_tf = new Vector3(Random.Range(-300f, 300f), Random.Range(-300f, 300f), Random.Range(100f, 400f));
            
            Instantiate(Enemy, random_tf + transform.position, transform.rotation);
            createflag = true;
        }

        Check("Enemy"); 
    }

    void Check(string tagname)
    {
        if (gamecount % 300 == 0)
        {
            tagObjects = GameObject.FindGameObjectsWithTag(tagname);


            if (tagObjects.Length <= 5)
            {
                createflag = false;
            }
        }
        gamecount++;
    }
}
