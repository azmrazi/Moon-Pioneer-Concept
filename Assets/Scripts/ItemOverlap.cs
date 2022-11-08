using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOverlap : MonoBehaviour
{

    bool isAlreadyCollected = false;
    void OnTriggerEnter(Collider other)
    {
        if (isAlreadyCollected) return;

        if (other.CompareTag("Player"))
        {
            Collector collector;
            if (other.TryGetComponent(out collector))
            {
                collector.AddNewProd(this.transform);
                isAlreadyCollected = true;
            }
        }
    }
}
