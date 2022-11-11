using UnityEngine;

public class TakeFromStorage : MonoBehaviour
{
    [SerializeField] GameObject prod_1;
    [SerializeField] GameObject prod_2;
    [SerializeField] GameObject prod_3;

    public static int n = 0;
    void OnCollisionEnter(Collision collision)
    {
        Take(collision);
    }

    void TakeProd(GameObject obj)
    {
        if (n == 10) return;

        var prod = Instantiate(obj, this.transform.position, Quaternion.identity);
        GameInfo.Inventory.Push(prod);
        var Overlap = prod.GetComponent<ItemOverlap>();
        Overlap.OnTriggerEnter(this.GetComponent<Collider>());
        ++n;

    }

    void Take(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Storage":
                if (GameInfo.Prod_1 == 0 || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_2")) || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_3")))
                {
                    return;
                }
                else
                {
                    if (n == 10) return;
                    TakeProd(prod_1);
                    --GameInfo.Prod_1;
                }
                break;
            case "Storage_2":
                if (GameInfo.Prod_2 == 0 || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_1")) || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_3")))
                {
                    return;
                }
                else
                {
                    if (n == 10) return;
                    TakeProd(prod_2);
                    --GameInfo.Prod_2;
                }
                break;
            case "Storage_3":
                if (GameInfo.Prod_3 == 0 || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_2")) || (GameInfo.Inventory.Count != 0 && GameInfo.Inventory.Peek().CompareTag("Prod_1")))
                {
                    return;
                }
                else
                {
                    if (n == 10) return;
                    TakeProd(prod_3);
                    --GameInfo.Prod_3;
                }
                break;
        }
    }

    
}
