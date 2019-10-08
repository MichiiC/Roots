using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public GameObject camera;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        m_SelectObject();
    }

    private void m_SelectObject() {

        RaycastHit hit = new RaycastHit();
        
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                
                GameObject go = hit.transform.gameObject;

                if (go.CompareTag("Fork Lift")) {
                    
                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToForkLift");
                    print("Fork Lift Touched");
                }

            }
        }

    }
}
