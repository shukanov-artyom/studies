using UnityEngine;

public class circleBehavior : MonoBehaviour
{
    private Vector3 initPos;

    void Start ()
    {
        GameObject t = GameObject.Find("circle");
        if (t != null)
        {
            Transform tr = t.GetComponent<Transform>();
            if (tr != null)
            {
                initPos = new Vector3(tr.position.x, tr.position.y, tr.position.z);
            }
        }
    }
    
    void Update ()
    {
        GameObject t = GameObject.Find("circle");
        if (t != null)
        {
            Transform tr = t.GetComponent<Transform>();
            if (tr != null)
            {
                if (tr.position.x < 100)
                {
                   
                }
            }
        }
    }
}
