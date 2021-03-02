using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public Button btn2;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    void bye()
    {
        this.gameObject.SetActive(false);
        btn2.interactable = true;
    }
}
