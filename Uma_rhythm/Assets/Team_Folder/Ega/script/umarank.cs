using UnityEngine;

public class umarank : MonoBehaviour
{

    public float Speed = 5; //Playerのスピード
    public GameObject[] uma;
    [SerializeField] Transform[] PtoG;

    int rnd = 0;
    float min = 0;
    float min1 = 0;
    float max = 0;
    float max1 = 0;

    public int speedmin = 0;
    public int speedmax = 0;
    public int speedmin2 = 0;
    public int speedmax2 = 0;
    int SetRandom()
    {
        rnd = Random.Range(speedmin, speedmax);
        return rnd;
    }
    int SetRandom2()
    {
        rnd = Random.Range(speedmin2, speedmax2);
        return rnd;
    }

    public void UmaRankP()
    {
        for(int i=0;i<=1;i++)
        {
            if(150>max && i == 0)
            {
                Speed = SetRandom2();
                max += Speed;
                min -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);
                
            }
            if(150>max1 && i == 1)
            {
                Speed = SetRandom();
                max1 += Speed;
                min1 -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);
            }
               
        }
   
        Debug.Log("パフェ");
    }
    public void UmaRankG()
    {
        for (int i = 0; i <= 1; i++)
        {
            if (150 > max && i == 0)
            {
                Speed = SetRandom2() + 1;
                max += Speed;
                min -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);

            }
            if (150 > max1 && i == 1)
            {
                Speed = SetRandom() + 1;
                max1 += Speed;
                min1 -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);
            }
        }

        Debug.Log("パフェ");
    }
    public void UmaRankB()
    {
        for (int i = 0; i <= 1; i++)
        {
            if (300 > min && i == 0)
            {
                Speed = SetRandom() - 1;
                min += Speed;
                max -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);

            }
            if (300 > min1 && i == 1)
            {
                Speed = SetRandom2() - 1;
                min1 += Speed;
                max1 -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);
            }
        }

        Debug.Log("パフェ");
    }
    public void UmaRankM()
    {
        for (int i = 0; i <= 1; i++)
        {
            if (300 > min && i == 0)
            {
                Speed = SetRandom();
                min += Speed;
                max -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);

            }
            if (300 > min1 && i == 1)
            {
                Speed = SetRandom2();
                min1 += Speed;
                max1 -= Speed;
                uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);
            }
        }

        Debug.Log("パフェ");
    }
}