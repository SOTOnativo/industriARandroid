using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    printName(hit.transform.gameObject);
                }
            }
        }
    }

    private void printName(GameObject go) {
        print(go.name);
    }
}
