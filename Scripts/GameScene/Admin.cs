using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Admin : MonoBehaviour
{
    public Text Score;
    public static float scorePoint;


    void Update()
    {
        Score.text = scorePoint.ToString();
        
        
    }

    

}



