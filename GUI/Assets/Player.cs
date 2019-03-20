using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text pillCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pill") {

            Destroy(other.gameObject);

            GameObject container = GameObject.Find("PillContainer");
            pillCount.text = (container.transform.childCount - 1).ToString();
        }

    }
}
