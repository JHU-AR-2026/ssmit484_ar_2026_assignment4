using UnityEngine;

public class followballl : MonoBehaviour
{
    public Transform ballTransform;

    private Vector3 offset; // Reference the balls transform
    private float maxz=9f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset=transform.position-ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos=ballTransform.position+offset;
        newpos.z=Mathf.Min(newpos.z,maxz);
        transform.position=newpos;
    }
}
