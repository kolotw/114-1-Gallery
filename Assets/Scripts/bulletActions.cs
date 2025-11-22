using UnityEngine;

public class bulletActions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "poster")
        {
            GameObject[] ps = GameObject.Find("/00EventControlll").GetComponent<EventControll>().posters;
            foreach(GameObject p in ps)
            {
                string path = "/Canvas/" + other.name;
                if (p.name == other.name)
                {                    
                    p.SetActive(true);
                }
                else
                {
                    p.SetActive(false);
                }
            }
            
        }
    }
}
