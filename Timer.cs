using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public int minuted;
    public float second;
   

    // Update is called once per frame
    void Update()
    {
       second -= Time.deltaTime;
        if (second <= 0)
        {
            if (minuted > 0) {
                second += 59;
                minuted--;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }    
}
