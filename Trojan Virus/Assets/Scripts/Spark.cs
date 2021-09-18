using UnityEngine;

public class Spark : MonoBehaviour
{
    [SerializeField] Transform pos;
    [SerializeField] float speed;
    Vector3 targetpos;
    float Sparktime;                    // start of sparks runtime
    float timelapse;                    // timeperiod of each cycle
    [SerializeField] float freezeTime;
    float freezeStart;
    int checkSt = 0;                    //running status of spark
    
    // Start is called before the first frame update
    void Start()
    {
        Sparktime = Time.time;
        timelapse = Random.Range(4, 10)*0.2f;
        TargetPos();
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.position != targetpos)
        {
            pos.position=Vector3.MoveTowards(transform.position,targetpos,speed*Time.deltaTime);
        }

        else
        {
            if (Time.time >= Sparktime + timelapse)
            {                
                switch (checkSt)
                {
                    case 0:
                        freezeStart = Time.time;
                        checkSt = 1;
                        speed = 0;
                        break;
                    case 1:
                        if (Time.time >= freezeStart + freezeTime)
                        {
                            Sparktime = Time.time;
                            timelapse = Random.Range(4, 10) * 0.2f;
                            speed = 40;
                            checkSt= 0;
                            TargetPos();
                        }
                        break;
                }
            }
            else
            {
                TargetPos();
            }
        }

    }
    private void TargetPos()
    {
        targetpos.x = (Random.Range(0,3)-1)*5.2f;
        targetpos.y = (Random.Range(0,3)-1)*5.2f;
        targetpos.z = 0.0f;
        }
}
