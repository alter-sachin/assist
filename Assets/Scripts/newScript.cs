using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARRaycastManager))]
public class newScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject m_instantprefab;


    public GameObject placedPrefab{
    	get{ return m_instantprefab;}
    	set{ m_instantprefab = value;}
    }

    public GameObject spawnedObject{
    	get;
    	private set;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
