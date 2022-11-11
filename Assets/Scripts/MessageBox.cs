using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour
{
    private Text MessageText;
    private Text MessageText_1;
    private Text MessageText_2;
    private Text MessageText_3;
    private Text MessageText_4;


    void Awake()
    {
        MessageText = GameObject.FindWithTag("Message").GetComponent<Text>();
        MessageText_1 = GameObject.FindWithTag("Message_1").GetComponent<Text>();
        MessageText_2 = GameObject.FindWithTag("Message_2").GetComponent<Text>();
        MessageText_3 = GameObject.FindWithTag("Message_3").GetComponent<Text>();
        MessageText_4 = GameObject.FindWithTag("Message_4").GetComponent<Text>();
    }
    void Update()
    {
        Storage_1_IsFull();
        Producer_2_IsEmpty();
        Storage_2_IsFull();
        Producer_3_IsEmpty();
        Storage_3_IsFull();
    }

    void ShowMessage(string str, Text Message)
    {
        Message.text = str;
        Message.enabled = true;
    }

    void Storage_1_IsFull()
    {
        if (GameInfo.Prod_1 == 10)
        {
            ShowMessage("Storage_1 is full. Take products", MessageText);
        }
        else
        {
            ShowMessage("", MessageText);
        }
    }

    void Producer_2_IsEmpty()
    {
        if (GameInfo.Prodcr_2 == 0)
        {
            ShowMessage("Producer_2 is empty", MessageText_1);
        }
        else
        {
            ShowMessage("", MessageText_1);
        }
    }
    void Storage_2_IsFull()
    {
        if (GameInfo.Prod_2 == 10)
        {
            ShowMessage("Storage_2 is full. Take products", MessageText_2);
        }
        else
        {
            ShowMessage("", MessageText_2);
        }
    }

    void Producer_3_IsEmpty()
    {
        if (GameInfo.Prodcr_3_1 == 0 && GameInfo.Prodcr_3_2 == 0)
        {
            ShowMessage("Producer_3 is empty", MessageText_3);
        }
        else if (GameInfo.Prodcr_3_1 == 0 && GameInfo.Prodcr_3_2 > 0)
        {
            ShowMessage("Producer_3 need Product 1", MessageText_3);
        }
        else if (GameInfo.Prodcr_3_1 > 0 && GameInfo.Prodcr_3_2 == 0)
        {
            ShowMessage("Producer_3 need Product 2", MessageText_3);
        }
        else
        {
            ShowMessage("", MessageText_3);
        }
    }
    void Storage_3_IsFull()
    {
        if (GameInfo.Prod_3 == 10)
        {
            ShowMessage("Storage_3 is full. Take products", MessageText_4);
        }
        else
        {
            ShowMessage("", MessageText_4);
        }
    }    


}
