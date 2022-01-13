using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class walk
{
    public GameObject ball;
    [Test]
    public void walking()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //按下方向鍵的右的期間不斷執行
        {
            float right = ball.transform.position.x; //往x軸移動
            Assert.AreEqual(ball.transform.position.x, right);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //按下方向鍵的左的期間不斷執行
        {
            float left = -ball.transform.position.x; //往-x軸移動
            Assert.AreEqual(ball.transform.position.x, left);
        }
        if (Input.GetKey(KeyCode.UpArrow)) //按下方向鍵的上的期間不斷執行
        {
            float forward = ball.transform.position.z; //往z軸移動
            Assert.AreEqual(ball.transform.position.z, forward);
        }
        if (Input.GetKey(KeyCode.DownArrow)) //按下方向鍵的下的期間不斷執行
        {
            float back = -ball.transform.position.z; //往-z軸移動
            Assert.AreEqual(ball.transform.position.z, back);
        }
    }

}
