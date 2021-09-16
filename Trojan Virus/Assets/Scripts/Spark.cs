using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour
{
    [SerializeField] Transform pos;
    [SerializeField] float speed;
    Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {
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
            TargetPos();
        }

    }
    private void TargetPos()
    {
        targetpos.x = Random.Range(-1,1)*5.2f;
        targetpos.y = Random.Range(-1,1)*5.2f;
        targetpos.z = 0.0f;
        Debug.Log(targetpos);
    }
}
