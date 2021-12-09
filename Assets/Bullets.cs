using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public GameObject carrotBulletPrefab;

    public Transform bulletPoint;

    public float force; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(hit.point);
            Debug.Log(hit.transform.name);
            Debug.Log("hit");
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            

            Debug.Log("Pew Pew");
            GameObject _bullet = Instantiate(carrotBulletPrefab, bulletPoint.position, Quaternion.identity);
            _bullet.GetComponent<Rigidbody>().AddForce(bulletPoint.transform.forward * force, ForceMode.Impulse); 
        }

        

    }
}
