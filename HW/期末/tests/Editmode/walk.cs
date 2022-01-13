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
        if (Input.GetKey(KeyCode.RightArrow)) //���U��V�䪺�k���������_����
        {
            float right = ball.transform.position.x; //��x�b����
            Assert.AreEqual(ball.transform.position.x, right);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //���U��V�䪺�����������_����
        {
            float left = -ball.transform.position.x; //��-x�b����
            Assert.AreEqual(ball.transform.position.x, left);
        }
        if (Input.GetKey(KeyCode.UpArrow)) //���U��V�䪺�W���������_����
        {
            float forward = ball.transform.position.z; //��z�b����
            Assert.AreEqual(ball.transform.position.z, forward);
        }
        if (Input.GetKey(KeyCode.DownArrow)) //���U��V�䪺�U���������_����
        {
            float back = -ball.transform.position.z; //��-z�b����
            Assert.AreEqual(ball.transform.position.z, back);
        }
    }

}
