using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Camera cam;
    public float maxWidth;
    public GameObject cat;
    public GameObject gameOverText;
    public GameObject restartQuitText;

	// Use this for initialization
	void Start ()
	{
        gameOverText.SetActive(false);
        restartQuitText.SetActive(false);
	    if (cam == null)
	    {
	        cam = Camera.main;
	    }

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
	    Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
	    var component = cat.GetComponent<Renderer>();
	    float catWidth = component.bounds.extents.x;
	    maxWidth = targetWidth.x - catWidth;

	    StartCoroutine(Spawn());
	}

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        while (!CatGroundTrigger.checkGroundContact)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-9, 9), transform.position.y, transform.position.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(cat, spawnPosition, spawnRotation);


            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }
        gameOverText.SetActive(true);
        restartQuitText.SetActive(true);
        Time.timeScale = 0;
    }
}
