using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collector : MonoBehaviour
{

    public Transform ProdHolderTransform;

    int NumOfProdsHolding = 0;
    void Start()
    {
        
    }

    public void AddNewProd(Transform prodToAdd)
    {
        
        prodToAdd.DOJump(ProdHolderTransform.position + new Vector3(0, 0.025f * NumOfProdsHolding, 0), 1.5f, 1, 0.25f).OnComplete(
            () =>
            {
                prodToAdd.SetParent(ProdHolderTransform, true);
                prodToAdd.localPosition = new Vector3(0, 0.025f * NumOfProdsHolding, 0);
                prodToAdd.localRotation = Quaternion.identity;
                NumOfProdsHolding++;
            }
            );

        
    }
}
