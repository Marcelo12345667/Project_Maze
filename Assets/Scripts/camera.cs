using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    [SerializeField]
    public float CoinRotateSpeed;
    [SerializeField]
    Vector3 rotateDirection = new Vector3();
    private void Update()
    {
        transform.Rotate(CoinRotateSpeed * rotateDirection * Time.deltaTime);
    }
}

