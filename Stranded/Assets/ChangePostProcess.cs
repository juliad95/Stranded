using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ChangePostProcess : MonoBehaviour
{

    public PostProcessingProfile normal, fx;

    private PostProcessingBehaviour camImageFx;
   
    void Start()
    {
        camImageFx = FindObjectOfType<PostProcessingBehaviour>();
            }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
                {
            camImageFx.profile = fx;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            camImageFx.profile = normal;
        }
    }

}
