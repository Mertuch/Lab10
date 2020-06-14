using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulka : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject kuleczka;

    public Material Material1;
    public Material Material2;
    public Material Material3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //print(x);
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //print(y);
        transform.Translate(x, 0, y);

        if (Input.GetMouseButtonDown(0))
        {
            //print(Input.mousePosition.x + "   " + Input.mousePosition.y);
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            Instantiate(kuleczka, pozycja, Quaternion.identity);
            int los = Random.Range(0, 3);
            if (los == 0) { kuleczka.GetComponent<MeshRenderer>().material = Material1; }
            if (los == 1) { kuleczka.GetComponent<MeshRenderer>().material = Material2; }
            if (los == 2) { kuleczka.GetComponent<MeshRenderer>().material = Material3; }



        }
        if (Input.GetMouseButtonDown(1))
        {
            print("PPM");
        }
        if (Input.GetMouseButtonDown(2))
        {
            print("Kółeczko");
        }
    }
}
