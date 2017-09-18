using UnityEngine;
using System.Collections;

public class CatGroundTrigger : MonoBehaviour
{
    public static bool checkGroundContact;

    void Start()
    {
        checkGroundContact = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Ground")
        {
            checkGroundContact = true;
        }
    }
}
