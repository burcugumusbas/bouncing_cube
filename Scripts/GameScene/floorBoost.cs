using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorBoost : MonoBehaviour
{
    public GameObject floor;
    Transform tr;
    public int floorCount;
    public float floorWidth;
    public float minY, maxY;

    private void Start(){

        tr = floor.GetComponent<Transform>();
        Vector3 spawnlocation = new Vector3();
        Vector2 newscale = new Vector2();
        
        for(int i=0 ; i<floorCount ; i++){
            newscale.x = Random.Range(0.9f,1.1f);
            newscale.y = Random.Range(0.9f,1.1f);
            tr.localScale = newscale;

            spawnlocation.y += Random.Range(minY,maxY);
            spawnlocation.x = Random.Range(-floorWidth,floorWidth);
            
            Instantiate(floor,spawnlocation,Quaternion.identity);

        }
    }


}