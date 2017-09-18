using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject objectCat;
    public GameObject catInstance;

    void Start()
    {
        catInstance = (GameObject)Instantiate(objectCat, objectCat.transform.position, objectCat.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
            Destroy(collider.gameObject);
    }
}
