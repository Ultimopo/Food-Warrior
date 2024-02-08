using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;


public class Yeet : MonoBehaviour
{
    public GameObject fruit;
    public GameObject bomb;

    public float spawnRate = 1;
    public float bombChance = 20;

    public List<Wave> waves = new();

    [System.Serializable]

    public class Wave
    {
        public List<SpawnItemData> items;
    }

    [System.Serializable]

    public class SpawnItemData
    {
        public float delay;
        public bool isBOMB;
        public bool isRandomVelocity;
        public bool IsRandomPosition;
        public bool IsRandomBomb;
        public float x;
        public Vector2 velocity = new Vector2(0, 10f);
    }

    // Start is called before the first frame update
    async void Start()
    {
        foreach (var wave in waves)
        {
            foreach (var item in wave.items)
            {
                await new WaitForSeconds(item.delay);
 
                var prefab = item.isBOMB ? bomb : fruit;
                var go = Instantiate(prefab);


                if (!item.IsRandomPosition)
                {
                    go.transform.position = new Vector3(item.x, -5, 0);
                }
                else
                {
                    item.x = UnityEngine.Random.Range(-5f, 5f);
                    go.transform.position = new Vector3(item.x, -5, 0);
                }

                go.GetComponent<Rigidbody2D>().velocity = item.velocity;

            }

            await new WaitForSeconds(3);
        }
    }

    public void Spawn()
    {
        var prefab = Random.Range(0, 100) < (100 - bombChance) ? fruit : bomb;

        var obj = Instantiate(prefab);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x, -5, 0);
    }


}
