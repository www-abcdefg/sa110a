using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //���U��V�䪺�k���������_����
        {
            ball.transform.Translate(Vector3.right * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //���U��V�䪺�����������_����
        {
            ball.transform.Translate(Vector3.left * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.UpArrow)) //���U��V�䪺�W���������_����
        {
            ball.transform.Translate(Vector3.forward * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.DownArrow)) //���U��V�䪺�U���������_����
        {
            ball.transform.Translate(Vector3.back * 5 * Time.deltaTime); 
        }
    }
}
