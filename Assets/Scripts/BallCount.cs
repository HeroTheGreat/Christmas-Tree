using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCount : MonoBehaviour
{
    public Text text2;
    int Ballcount = 15;
    public Button buton;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sphere")
        {
            Debug.Log("Anubis");
            Ballcount--;
        }
        text2.text = "Balls..: " + Ballcount;
    }
    private void Update()
    {
        if (Ballcount<1)
        {
            buton.gameObject.SetActive(true);
            Destroy(GameObject.FindWithTag("sphere"));
            Destroy(GameObject.FindWithTag("Gift 1"));
            Destroy(GameObject.FindWithTag("Partcile System"));
        }
    }
}

