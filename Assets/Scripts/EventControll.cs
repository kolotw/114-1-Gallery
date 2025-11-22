using UnityEngine;

public class EventControll : MonoBehaviour
{
    public GameObject[] posters;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        posters = GameObject.FindGameObjectsWithTag("Watch");
        if (posters != null)
        {
            foreach (GameObject poster in posters)
            {
                poster.SetActive(false);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (posters != null)
            {
                foreach (GameObject poster in posters)
                {
                    poster.SetActive(false);
                }
            }
        }
    }
}
