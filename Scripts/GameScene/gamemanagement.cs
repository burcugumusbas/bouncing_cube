using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamemanagement : MonoBehaviour
{

    public GameObject cubyMove;
    public GameObject scoreScreen;

    cubyMove end;


    void Update()
    {
        if (cubyMove.transform.position.y < 0)
        {
            EndGame();
        }

    }

    void EndGame()
    {
        cubyMove.SetActive(false);

        SceneManager.LoadScene(2);
    
    
    }

}