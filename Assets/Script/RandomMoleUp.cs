using UnityEngine;
public class RandomMoleUp : MonoBehaviour
{
    [SerializeField] GameObject GM;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject[] Moles;
    public float span = 2.0f;
    public float span2 = 3.0f;
    public float span3 = 7.0f;
    private float currentTime = 0f;
    private float currentTime2 = 0f;
    private float currentTime3 = 0f;
    public float ZeroTime = 0.0f;
    [SerializeField] private int number;
   
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GM.GetComponent<GameManager>();
    }

    void Update()
    {
        float remainingTime = gameManager.time;
        currentTime += Time.deltaTime;
        currentTime2 += Time.deltaTime;
        currentTime3 += Time.deltaTime;
        if (remainingTime > ZeroTime && currentTime > span)
        {
            currentTime = ZeroTime;
            MoleUp();
        }
         if(remainingTime > ZeroTime && currentTime2 > span2)
        {
            currentTime2 = ZeroTime;
            MoleUp();
        }
         if(remainingTime > ZeroTime && currentTime3 > span3)
        {
            currentTime3 = ZeroTime;
            MoleUp();
        }
    }

    public void MoleUp()
    {
        number = Random.Range(0, Moles.Length);
        Moles[number].GetComponent<MoleAction>().MoleActionStart();
    }

}
