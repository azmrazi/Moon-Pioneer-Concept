using UnityEngine;

public class Production_1 : MonoBehaviour
{
    [SerializeField] Transform Stock;
    [SerializeField] Transform Prod;
    [SerializeField] Transform Flag;

    [SerializeField] float speed = 2f;

    [SerializeField ]GameObject Collision;
    void Update()
    {
        transform.position = Vector3.Lerp(Stock.transform.position, Prod.transform.position, Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == Collision.tag)
        {
            Release();
            Distribute();
        }
        Destroy(GameObject.FindWithTag(this.tag));

    }
    void Release()
    {
        Instantiate(this, Flag.transform.position, Quaternion.identity);
    }

    void Distribute()
    {
        switch(this.tag)
        {
            case "Prod_1 Mover":
                ++GameInfo.Prod_1;
                break;
            case "Prod_Mover_1.5":
                --GameInfo.Prodcr_2;
                ++GameInfo.Factory_2;
                break;
            case "Prod_Mover2":
                --GameInfo.Factory_2;
                ++GameInfo.Prod_2;
                break;
            case "Prod_Mover2.5":
                --GameInfo.Prodcr_3_1;
                ++GameInfo.Factory_3_1;
                break;
            case "Prod_Mover2.5(1)":
                --GameInfo.Prodcr_3_2;
                ++GameInfo.Factory_3_2;
                break;
            case "Prod_Mover3":
                --GameInfo.Factory_3_1;
                --GameInfo.Factory_3_2;
                ++GameInfo.Prod_3;
                break;

        }
        
    }


}
