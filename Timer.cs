using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool isActive; // Bonus

    public int minutes; // You put values in the editor
    public float seconds;
    
    [SerializeField] Text countdownText;

    // Update is called roughly every 0.01 seconds
    void Update()
    {
        countdownText.text = seconds.ToString();
        if (isActive)
        {
            seconds -= Time.deltaTime;
            if (seconds <= 0.0f)
            {
                if (minutes > 0)
                {
                    seconds += 60.0f;
                    minutes--;
                }
                else {
                    // No time left, change scene
                    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(sceneIndex);

                    // And disable the timer
                    isActive = false;
                }
            }
        }
    }


}