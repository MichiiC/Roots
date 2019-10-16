using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerInput : MonoBehaviour
{

    public GameObject camera;
    public GameObject descriptionPanel;
    public GameObject descriptionPanelText;

    public string selectedObject = "";

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
                Animator cameraAnimator = camera.GetComponent<Animator>();


                switch (selectedObject)
                {
                    case "Fork Lift":
                        cameraAnimator.Play("CameraMoveBackFromForkLift");
                        selectedObject = "";
                        break;
                    case "Abandon":
                        cameraAnimator.Play("CameraMoveBackFromAbandon");
                        selectedObject = "";
                        break;
                    default:
                        break;
                }

                if (go.CompareTag("Fork Lift")) 
                {
                    cameraAnimator.Play("CameraMoveToForkLift");
                    selectedObject = "Fork Lift";
                }
                if (go.CompareTag("Grass"))
                {
                    cameraAnimator.Play("CameraMoveToGrass");
                    print("Grass Touched");
                }
                if (go.CompareTag("Abandon"))
                {
                    cameraAnimator.Play("CameraMoveToAbandon");
                    selectedObject = "Abandon";
                    print("Abandon Touched");
                }
                if (go.CompareTag("Smoke"))
                {
                    cameraAnimator.Play("CameraMoveToSmoke");
                    print("Smoke Touched");
                }
                if (go.CompareTag("Lights"))
                {
                    cameraAnimator.Play("CameraMoveToLight");
                    print("Lights Touched");
                }
                if (go.CompareTag("Dog"))
                {
                    cameraAnimator.Play("CameraMoveToDog");
                    print("Dog Touched");
                }
                if (go.CompareTag("Tree"))
                {
                    cameraAnimator.Play("CameraMoveToTree");
                    print("Tree Touched");
                }
                if (go.CompareTag("Ground"))
                {
                    cameraAnimator.Play("CameraMoveToGround");
                    print("Ground Touched");
                }
                if (go.CompareTag("Well"))
                {
                    cameraAnimator.Play("CameraMoveToWell");
                    print("Well Touched");
                }
                if (go.CompareTag("Bird"))
                {
                    cameraAnimator.Play("CameraMoveToBird");
                    print("Bird Touched");
                }

            }
        }

    }
}
