using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] GameObject prodMover;


    void Update()
    {
        ChangeMovingCharacteristics();
    }

    void ChangeMovingCharacteristics()
    {
        var Comp = prodMover.GetComponent<Production_1>();

        switch (prodMover.tag)
        {
            case "Prod_1 Mover":
                if (GameInfo.Prod_1 < 10)
                {
                    Comp.enabled = true;
                }
                else if (GameInfo.Prod_1 == 10)
                {
                    Comp.enabled = false;
                }
                break;
            case "Prod_Mover_1.5":
                if (GameInfo.Prodcr_2 < 10 && GameInfo.Prodcr_2 > 0)
                {
                    prodMover.GetComponent<Rigidbody>().isKinematic = false;
                    Comp.enabled = true;
                }
                else
                {
                    prodMover.GetComponent<Rigidbody>().isKinematic = true;
                    Comp.enabled = false;
                }
                break;
            case "Prod_Mover2":
                {
                    if (GameInfo.Factory_2 == 0)
                    {
                        prodMover.GetComponent<Rigidbody>().isKinematic = true;
                        Comp.enabled = false;
                    }
                    else
                    {
                        prodMover.GetComponent<Rigidbody>().isKinematic = false;
                        Comp.enabled = true;
                    }
                    break;
                }
            case "Prod_Mover2.5":
                {
                    if (GameInfo.Prodcr_3_1 < 10 && GameInfo.Prodcr_3_1 > 0)
                    {

                        prodMover.GetComponent<Rigidbody>().isKinematic = false;
                        Comp.enabled = true;
                    }
                    else
                    {

                        prodMover.GetComponent<Rigidbody>().isKinematic = true;
                        Comp.enabled = false;
                    }
                    break;
                }
            case "Prod_Mover2.5(1)":
                {

                    if (GameInfo.Prodcr_3_2 < 10 && GameInfo.Prodcr_3_2 > 0)
                    {

                        prodMover.GetComponent<Rigidbody>().isKinematic = false;
                        Comp.enabled = true;
                    }
                    else
                    {

                        prodMover.GetComponent<Rigidbody>().isKinematic = true;
                        Comp.enabled = false;
                    }
                    break;
                }
            case "Prod_Mover3":
                {
                    if (GameInfo.Factory_3_1 > 0 && GameInfo.Factory_3_2 > 0)
                    {

                        prodMover.GetComponent<Rigidbody>().isKinematic = false;
                        Comp.enabled = true;
                    }
                    else
                    {
                        prodMover.GetComponent<Rigidbody>().isKinematic = true;
                        Comp.enabled = false;
                    }
                    break;
                }
        }
    }
}
