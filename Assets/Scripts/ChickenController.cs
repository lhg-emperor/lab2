using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject Egg;
    private int cout = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cout++;
        if (cout > 100)
        {
            Instantiate(Egg, transform.position, Quaternion.identity);
            cout = 0;
        }
    }
}
