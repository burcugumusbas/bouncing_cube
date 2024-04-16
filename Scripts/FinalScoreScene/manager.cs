using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    private void Update()
    {

        if(Input.GetMouseButton(0)){
            SceneManager.LoadScene(1);
            Admin.scorePoint = 0;
        }
        else if(Input.GetMouseButton(1)){
            SceneManager.LoadScene(0);
            Admin.scorePoint = 0;

        }

        
    }
}
