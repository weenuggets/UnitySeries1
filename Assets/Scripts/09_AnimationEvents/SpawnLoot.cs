using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLoot : MonoBehaviour
{
    [Tooltip("The item to spawn")]
    [SerializeField] GameObject lootItem;
    [SerializeField] int minItems;
    [SerializeField] int maxItems;

    [Tooltip("Where to spawn the items")]
    [SerializeField] Transform spawnPoint;

    public void SpawnLootItems()
    {
        //Decide how many to spawn
        int num = Random.Range(minItems, maxItems);
      
        //Spawn the random amount of loot items
        for(int i = 0; i < num; i++)
        {
            Instantiate(lootItem, spawnPoint.transform.position, spawnPoint.rotation);
        }
    }
}
