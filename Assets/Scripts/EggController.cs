using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject EggBroken;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("platform"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(obj:this);
        }
        if (col.gameObject.name.Equals("Box"))
        {
            Destroy(obj:this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
