using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManagerx : MonoBehaviour
{
    [SerializeField] LightSpark lsprefab;
    [SerializeField] Spark sprefab;
    //[SerializeField] GameObject ls;
    
    //[SerializeField] private bool mouseclick;
    private bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        //GenerateSpark();
    }

    // Update is called once per frame
    void Update()
    {
        /*private bool checkmouseclick()
        {
            mouseclick = Input.GetButtonDown(KeyCode.Mouse(0))
            //Input.GetMouseButtonDown(1)
        }*/
        /*if(check)
            GenerateSpark();*/
    }

    /* private void GenerateSpark()
    {
        int i = Random.Range(0,2);
        float x = (i-1)*5.2f;
        int j = Random.Range(0,2);
        float y = (j - 1)* 5.2f;
        var _lightspark = Instantiate(ls, new Vector2((float)x,(float)y), Quaternion.identity);
        //_lightspark.Name = $"LightSpark {i} {j}";
        check = false;

        /*if(Input.GetMouseButtonDown(0))
        {
            
        }
        //Destroy(_lightspark, 2.0f);
        //check = true;
    }*/
}
