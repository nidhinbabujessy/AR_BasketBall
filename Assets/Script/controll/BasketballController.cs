using UnityEngine;

public class BasketballController : MonoBehaviour
{
    public Rigidbody basketballPrefab; // Drag and drop your basketball prefab here in the Inspector
    public Transform throwPoint; // The point from which the basketball will be thrown
    public float throwForce = 10f; // Adjust this value to control the throw force
    public float throwHeight = 5f; // Adjust this value to control the throw height

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBasketball();
        }
    }

    public void ThrowBasketball()
    {
        // Create a new instance of the basketball at the throw point
        Rigidbody basketballInstance = Instantiate(basketballPrefab, throwPoint.position, throwPoint.rotation);

        // Calculate the forward force
        Vector3 throwDirection = throwPoint.forward * throwForce;

        // Calculate the upward force for height
        Vector3 throwHeightVector = Vector3.up * throwHeight;

        // Apply the combined force to throw the basketball
        basketballInstance.AddForce(throwDirection + throwHeightVector, ForceMode.Impulse);
    }
}
