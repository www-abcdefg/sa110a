using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject Cube1;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.15)
        {
            Vector3 position = new Vector3(Random.Range(-4f, 4f), 10, Random.Range(-4f, 4f));
            //Vector3 position = new Vector3(0 ,5, 0);
            Instantiate(Cube1, position, Cube1.transform.rotation);

            timer = 0;
        }

    }
}
