using UnityEngine;
using DG.Tweening;

public class Collector : MonoBehaviour
{
    [SerializeField] Transform ProdHolderTransform;

    int NumOfProdsHolding = 0;
    public void AddNewProd(Transform prodToAdd)
    {
        DoMove(prodToAdd);
    }

    public void RemoveNewProd()
    {
        if (GameInfo.Inventory.Count == 0) return;

        var obj = GameInfo.Inventory.Pop();
        Destroy(obj);
        --NumOfProdsHolding;
        --TakeFromStorage.n;
    }

    void DoMove(Transform prodToAdd)
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
