using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
 public void LoadScene(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
 public void ExitScene(int sceneid)
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(sceneid);
        }
    }
}
