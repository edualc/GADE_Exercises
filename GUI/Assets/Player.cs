using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text pillCount;
    private GameObject pillContainer;

    // Start is called before the first frame update
    void Start()
    {
        pillContainer = GameObject.Find("PillContainer");
        setPillCount(pillContainer.transform.childCount);
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
            setPillCount(pillContainer.transform.childCount - 1);

            if (pillContainer.transform.childCount - 1 <= 0) {
                GameObject.Find("MenuLogic").GetComponent<MenuLogic>().won();
            }
        }

    }

    void setPillCount(int count)
    {
        pillCount.text = "Pill Count: " + count;
    }
}
