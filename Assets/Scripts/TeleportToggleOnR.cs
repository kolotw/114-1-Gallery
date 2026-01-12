using UnityEngine;

public class TeleportToggleOnR : MonoBehaviour
{
    bool goA = true;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            if (goA)
                transform.position = new Vector3(15, 0, 48);
            else
                transform.position = new Vector3(0, 0, 15); 

            goA = !goA;
        }
    }
}
