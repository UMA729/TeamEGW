using UnityEngine;

public class umarank : MonoBehaviour
{

    public float Speed = 5; //Playerのスピード
    public GameObject[] uma;
    [SerializeField] Transform[] PtoG;


    int rnd = 0;

    public int speedmin = 0;
    public int speedmax = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    int SetRandom()
    {
        rnd = Random.Range(speedmin, speedmax);
        return rnd;
    }

    public void UmaRankP()
    {
        for(int i=0;i<=1;i++)
        {
               Speed = SetRandom();
        uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);
        }
   
        Debug.Log("パフェ");
    }
    public void UmaRankG()
    {
        for (int i = 0; i <= 1; i++)
        {
            Speed = SetRandom();
            uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, -Speed * Time.deltaTime);
        }

        Debug.Log("パフェ");
    }
    public void UmaRankB()
    {
        for (int i = 0; i <= 1; i++)
        {
            Speed = SetRandom();
            uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);
        }

        Debug.Log("パフェ");
    }
    public void UmaRankM()
    {
        for (int i = 0; i <= 1; i++)
        {
            Speed = SetRandom();
            uma[i].transform.position = Vector3.MoveTowards(uma[i].transform.position, PtoG[i].position, Speed * Time.deltaTime);
        }

        Debug.Log("パフェ");
    }
}