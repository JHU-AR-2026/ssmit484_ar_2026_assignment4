//Attatch this script to a Button GameObject
using UnityEngine;
using UnityEngine.EventSystems;
//https://docs.unity.cn/Packages/com.unity.ugui%402.6/api/UnityEngine.UI.Button.html
public class StartButton : MonoBehaviour, IPointerClickHandler
{
    public Rigidbody playerRigidbody;
    public MonoBehaviour playerMovement;
    void Start()
    {
        playerRigidbody.useGravity=false;
        playerMovement.enabled=false;
    }
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
            //Use this to tell when the user right-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
            //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
            Debug.Log(name + " Game Object Right Clicked!");
        }

        //Use this to tell when the user left-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {
            playerRigidbody.useGravity=true; //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Rigidbody-useGravity.html
            playerMovement.enabled=true; //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Behaviour-enabled.html

            gameObject.SetActive(false);
        }
    }
}