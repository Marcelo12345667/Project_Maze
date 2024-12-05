using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveToObject : MonoBehaviour
{
    private NavMeshAgent _agent;
    
    public GameObject moveToObject;

    public int health;
    public TextMeshPro TheEnd;
    
    public int healthRegen;
    public Vector3 ReSpawn;
    public LayerMask Spikes;
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) //Left click
        {
            MoveAgentToPoint(true);
            moveToObject = null;
        }

        if (Input.GetMouseButton(1)) //Right click
        {
            MoveAgentToPoint(false);
        }
       
        if(moveToObject != null)
        {
            _agent.destination = moveToObject.transform.position;
        }
        _agent = GetComponent<NavMeshAgent>();
        
    }

    void MoveAgentToPoint(bool isFollowMouse)
    {
        //Create the data for our ray cast
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Stores information about the collider the raycast hit
        RaycastHit hitinfo;

        //Run the raycast
        if (Physics.Raycast(ray.origin, ray.direction, out hitinfo))
        {
            if (isFollowMouse)
            {
                //Go to mouse position
                _agent.destination = hitinfo.point;
            }
            else
            {
                //Follow the gameobject
                moveToObject = hitinfo.transform.gameObject;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("enemy"))
        {
            health--;
            if (health <= 0)
            {
                SceneManager.LoadScene(0);

            }


        }
        if (collision.transform.tag == "End")
        {
            TheEnd.text = "The" + "\n" + "End";
        }



    }
}

