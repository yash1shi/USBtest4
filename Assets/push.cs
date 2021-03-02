using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class push : MonoBehaviour
{

    public GameObject img;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.interactable = true;
        img.SetActive(false);
    }

    public void Button_press()
    {
        img.SetActive(true);
        btn.interactable = false;
        Invoke("bye", 3);
    }

    void bye()
    {
        img.SetActive(false);
        btn.interactable = true;
    }

}
