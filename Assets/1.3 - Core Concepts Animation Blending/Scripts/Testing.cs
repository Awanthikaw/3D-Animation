using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    Image Image;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Image = gameObject.AddComponent<Image> ();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log (gameObject.transform.localPosition);
        Debug.Log (gameObject.transform.localRotation);
        Debug.Log (Image.color);

        //rb.velocity (rb.transform.forward);
    }
}
