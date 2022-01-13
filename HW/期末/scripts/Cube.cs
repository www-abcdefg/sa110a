using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -2 * Time.deltaTime, 0);
        if (gameObject.transform.position.y < -1)
        {

            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);
    }
}
