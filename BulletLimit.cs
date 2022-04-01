using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class BulletLimit : MonoBehaviour
{
   

    List<GameObject> list;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        list = Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "Circle(Clone)").ToList();

        if (list.Count != 0) {
            {
                for (int i = 0; list.Count > i; i++)
                {
                    float distance = Vector3.Distance(list[i].transform.position, Camera.main.transform.position);

                    if (distance > i)
                    {
                        
                Destroy(list[i], 6f);
                list.Remove(list[i]);
                    }
        }

            }
        }

    }
}
 
