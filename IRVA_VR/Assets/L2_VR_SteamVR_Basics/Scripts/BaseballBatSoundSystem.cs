using UnityEngine;

public class BaseballBatOnHit : MonoBehaviour
{
    [SerializeField]
    private AudioClip hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        Vector3 contactPoint = collision.contacts[0].point;
        AudioSource.PlayClipAtPoint(hitSound, contactPoint);
    }
}