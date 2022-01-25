using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    public int lifeplayer = 100;
    public float Speedplayer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-10,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(Vector3.back);
    }
    void MovePlayer(Vector3 direccion){
    transform.Translate(Speedplayer * Time.deltaTime * direccion);
    }
    void damage( int dmg){
        lifeplayer -= dmg;
    }
    void addlife(int addlife){
        lifeplayer += addlife;
    }
}
