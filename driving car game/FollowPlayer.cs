using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
        public GameObject player;
        public Vector3 offset = new (0,5,-7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Changing update to LateUpdate will update after the update method happens. 
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
                
    }
}
