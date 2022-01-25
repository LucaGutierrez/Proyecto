using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float Speedenemy = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(16,2,1);
    }

    // Update is called once per frame
    void Update()
    {
      EnemyMove(Vector3.forward);
    }
    void EnemyMove( Vector3 direccion){
        transform.Translate(Speedenemy * Time.deltaTime * direccion);
    }
}
