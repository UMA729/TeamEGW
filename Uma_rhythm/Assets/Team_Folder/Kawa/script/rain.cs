using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    public GameObject rainPrefab;
    private float time;
    private int vecY;


    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;

        if(time<=0.0f)
        {
            vecY = 3;
            Instantiate(rainPrefab, new Vector3(-8, vecY, 0), Quaternion.identity);
            time = 1.0f;
        }

    }
}
