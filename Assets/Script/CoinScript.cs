using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float spin;
    public GameObject collecteffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroys();
        }
    }

    public void Destroys()
    {
        Instantiate(collecteffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
