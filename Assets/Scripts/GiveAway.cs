using UnityEngine;

public class GiveAway : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Give(collision);
    }

    void Give(Collision collision)
    {
        var collector = this.GetComponent<Collector>();
        switch (collision.gameObject.tag)
        {
            case "Producer_2":
                if (GameInfo.Inventory.Count == 0 || GameInfo.Inventory.Peek().CompareTag("Prod_2") || GameInfo.Inventory.Peek().CompareTag("Prod_3") || GameInfo.Prod_2 == 10) return;
                ++GameInfo.Prodcr_2;
                collector.RemoveNewProd();
                break;
            case "Producer_3":
                if (GameInfo.Inventory.Count == 0 || GameInfo.Inventory.Peek().CompareTag("Prod_3") || GameInfo.Prod_3 == 10) return;

                if (GameInfo.Inventory.Peek().CompareTag("Prod_1"))
                {
                    ++GameInfo.Prodcr_3_1;
                    collector.RemoveNewProd();
                }
                else if (GameInfo.Inventory.Peek().CompareTag("Prod_2"))
                {
                    ++GameInfo.Prodcr_3_2;
                    collector.RemoveNewProd();
                }
                break;
        }
    }
}
