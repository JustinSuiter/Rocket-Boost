using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("2dgffdgdf");
                break;
            case "Fuel":
                Debug.Log("Cant collect fuel yet");
                break;
            case "Finish":
                Debug.Log("Finsihed");
                break;
            default:
                Debug.Log("You crashed");
                break;
        }
    }
}
