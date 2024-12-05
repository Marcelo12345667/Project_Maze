
using UnityEngine;

public class NoRotation : MonoBehaviour
{
    public Vector3 LookDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(LookDirection);
    }
}
