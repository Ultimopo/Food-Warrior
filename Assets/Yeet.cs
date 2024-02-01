using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeet : MonoBehaviour
{
    public GameObject fruit;
    public float cooldown;
    public int throwerTurn;
    public Transform throwerPos;
    public Transform throwerPos2;
    public Transform throwerPos3;
    public Transform throwerPos4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;

        if(cooldown <= 0)
        {
            
            cooldown = 3;
            throwerTurn = Random.Range(1, 4);
            if (throwerTurn == 1)
            {
                Instantiate(fruit, throwerPos.position, throwerPos.rotation);
            }
            if (throwerTurn == 2)
            {
                Instantiate(fruit, throwerPos2.position, throwerPos2.rotation);
            }
            if (throwerTurn == 3)
            {
                Instantiate(fruit, throwerPos3.position, throwerPos3.rotation);
            }
            if (throwerTurn == 4)
            {
                Instantiate(fruit, throwerPos4.position, throwerPos4.rotation);
            }
        }

    }
}
