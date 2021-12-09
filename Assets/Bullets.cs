using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public GameObject carrotBulletPrefab;

    public Transform bulletPoint; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                transform.LookAt(hit.point);
                Debug.Log(hit.transform.name);
                Debug.Log("hit");
            }

            Debug.Log("Pew Pew");
            GameObject _bullet = Instantiate(carrotBulletPrefab, bulletPoint.position, Quaternion.identity);
            _bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f, ForceMode.Impulse); 
        }

        

    }
}
