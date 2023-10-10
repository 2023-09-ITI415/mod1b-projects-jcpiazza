using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallScore : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();

        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 20)
        {
            winTextObject.SetActive(true);
        }
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Target"))
        {
            other.gameObject.SetActive(true);
            count = count + 1;

            SetCountText();
        }
    }
}
