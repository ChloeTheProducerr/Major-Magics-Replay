using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour
{
    [SerializeField] public AudioClip soundEffect;

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
    }
}
