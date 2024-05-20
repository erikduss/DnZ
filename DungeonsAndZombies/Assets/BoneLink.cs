using UnityEngine;

public class BoneLink : MonoBehaviour
{
    [SerializeField] private Transform transformToLink;
    [SerializeField] private Transform transformToLinkTo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transformToLinkTo.hasChanged)
        {
            transformToLink.position = transformToLinkTo.position;
            transformToLink.rotation = transformToLinkTo.rotation;

            transformToLinkTo.hasChanged = false;
        }
    }
}
