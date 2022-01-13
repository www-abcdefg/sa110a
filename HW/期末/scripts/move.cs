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
        if (Input.GetKey(KeyCode.RightArrow)) //按下方向鍵的右的期間不斷執行
        {
            ball.transform.Translate(Vector3.right * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //按下方向鍵的左的期間不斷執行
        {
            ball.transform.Translate(Vector3.left * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.UpArrow)) //按下方向鍵的上的期間不斷執行
        {
            ball.transform.Translate(Vector3.forward * 5 * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.DownArrow)) //按下方向鍵的下的期間不斷執行
        {
            ball.transform.Translate(Vector3.back * 5 * Time.deltaTime); 
        }
    }
}
