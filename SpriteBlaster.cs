using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpriteBlaster : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed;
    public float fireDelay = 1.0f;
    private Vector3 targetposition;
    public float horizontal;
    public float veritical;
    private float Nextfire;


    // Start is called before the first frame update
    void Start()
    {
        targetposition = new Vector3(horizontal, veritical);
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //Horizontal is defined within the input manager already so we don't need to worry about creating inputs
        veritical = Input.GetAxisRaw("Vertical");
        if (Input.GetMouseButtonDown(0) && Time.time > Nextfire)
        {
            targetposition = Input.mousePosition;
            targetposition = Camera.main.ScreenToWorldPoint(new Vector3(targetposition.x, targetposition.y));

            Rigidbody2D bulletinstance = Instantiate(bullet, transform.position, Quaternion.identity);

            bulletinstance.velocity = (targetposition - bulletinstance.transform.position).normalized * speed;

            Nextfire = Time.time + fireDelay;

        }
      


    }
    
}