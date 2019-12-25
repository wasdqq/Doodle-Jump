using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    private GameObject myPlat;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.name.StartsWith("Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                Destroy(collider2D.gameObject);
                Instantiate(springPrefab,
                    new Vector2(Random.Range(-4.5f, 4.5f),
                        player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);


            }
            else
            {

                collider2D.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f),
                    player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }

        }
        else if (collider2D.gameObject.name.StartsWith("Spring"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collider2D.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f),
                    player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }
            else
            {

                Destroy(collider2D.gameObject);
                Instantiate(platformPrefab,
                    new Vector2(Random.Range(-4.5f, 4.5f),
                        player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);


            }

        }
    }

    /*if (Random.Range(1, 6) > 1)
    {

        myPlat = Instantiate(platformPrefab,
            new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))),
            Quaternion.identity);
        //Destroy(collider2D.gameObject);
    }
    else
    {
        myPlat = Instantiate(springPrefab,
            new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))),
            Quaternion.identity);
        //Destroy(collider2D.gameObject);
    }
    
    Destroy(collider2D.gameObject);*/
    
}
