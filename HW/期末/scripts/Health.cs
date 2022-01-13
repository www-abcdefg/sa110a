using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health: MonoBehaviour
{
    public const int maxHp = 100;
    public int currentHealth = maxHp;
    public RectTransform HealthBar, Hurt;
    private float timer1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }
    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        if (timer1 > 20)
        {
            currentHealth = currentHealth + 10;

            timer1 = 0;
        }
        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("SampleScene1");
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        currentHealth = currentHealth - 10;
        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);

    }

}
