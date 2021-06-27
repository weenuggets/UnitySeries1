using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Loot : MonoBehaviour
{
    [Tooltip("The maximum force value for loot 'jumping out'")]
    [SerializeField] Vector3 maxForce;

    // Start is called before the first frame update
    void Start()
    {
        //ramdomise Force (0 to max)
        maxForce.Set(Random.Range(-maxForce.x, maxForce.x),
        Random.Range(0, maxForce.y),
       Random.Range(-maxForce.z, maxForce.z));

        gameObject.GetComponent<Rigidbody>().AddForce(maxForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
