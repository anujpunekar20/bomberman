using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;

    [Range(0f, 1f)]
    public float itemSpawnChance = 0.3f;
    public GameObject[] spawnableItems;

    private void Start(){
        Destroy(gameObject, destructionTime);
    }

    public void OnDestroy(){
        if(spawnableItems.Length > 0 && Random.value < itemSpawnChance){
            int randomIndex = Random.Range(0, spawnableItems.Length);
            GameObject item = spawnableItems[randomIndex];
            Instantiate(item, transform.position, Quaternion.identity);
        }
    }
}
