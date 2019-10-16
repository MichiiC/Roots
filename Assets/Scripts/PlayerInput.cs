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
                if (go.CompareTag("Grass")){

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToGrass");
                    print("Grass Touched");
                }
                if (go.CompareTag("Abandon"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToAbandon");
                    print("Abandon Touched");
                }
                if (go.CompareTag("Smoke"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToSmoke");
                    print("Smoke Touched");
                }
                if (go.CompareTag("Lights"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToLight");
                    print("Lights Touched");
                }
                if (go.CompareTag("Dog"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToDog");
                    print("Dog Touched");
                }
                if (go.CompareTag("Tree"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToTree");
                    print("Tree Touched");
                }
                if (go.CompareTag("Ground"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToGround");
                    print("Ground Touched");
                }
                if (go.CompareTag("Well"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToWell");
                    print("Well Touched");
                }
                if (go.CompareTag("Bird"))
                {

                    Animator cameraAnimator = camera.GetComponent<Animator>();
                    cameraAnimator.Play("CameraMoveToBird");
                    print("Bird Touched");
                }

            }
        }

    }
}
