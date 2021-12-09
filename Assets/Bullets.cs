using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public GameObject carrotBulletPrefab; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Pew Pew");
            GameObject _bullet = Instantiate(carrotBulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
