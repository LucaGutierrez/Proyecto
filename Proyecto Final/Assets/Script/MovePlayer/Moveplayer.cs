using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    public int lifeplayer = 100;
    public float Speedplayer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(30,2,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
