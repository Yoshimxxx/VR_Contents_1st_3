using UnityEngine;
using System.Collections;

public class CreateComet : MonoBehaviour {

    public GameObject playerObject;
    public GameObject cometPrefab;

    private GameObject comet;
    public GameObject comet_;

    public int cometCount = 0;
    public int mkInt; //生成個数
    public int mkSpeed = 1; //1フレーム当たりの生成個数
    public float spawnPoint;

    public bool startTF = false;
    private bool start = false;

	// Use this for initialization
	void Start () {
        comet_ = GameObject.Find("Comet_");
    }
	
	// Update is called once per frame
	void Update () {
        if (cometCount <= mkInt && start == false)
        {
            for (int i = 0; i < mkSpeed; i++) //mkSpeed個生成
            {
                float randomScale = Random.Range(1.0f, 10.0f);
                transform.position = new Vector3(Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint), Random.Range(-spawnPoint, spawnPoint));
                comet = (GameObject)Instantiate(cometPrefab, transform.position, transform.rotation);
                comet.gameObject.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
                comet.transform.parent = comet_.transform;
                cometCount++;

                if (cometCount >= mkInt)
                {
                    startTF = true;
                    start = true;
                    break;
                }
            }
        }
	}
}
