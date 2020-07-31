using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OpenCamera : MonoBehaviour
{
    public GameObject Scripts;
    public UnityEngine.UI.RawImage rawImage0;
    public UnityEngine.UI.RawImage rawImage1;
    public UnityEngine.UI.RawImage rawImage2;
    public UnityEngine.UI.RawImage rawImage3;
    public UnityEngine.UI.RawImage rawImage4;
    public UnityEngine.UI.RawImage rawImage5;
    public UnityEngine.UI.RawImage rawImage6;
    public UnityEngine.UI.RawImage rawImage7;
    public UnityEngine.UI.RawImage rawImage8;
    public Texture2D tempTexture;

    public int firstEmptyImage;
    bool firstImageSet;
    public List<RawImage> images = new List<RawImage>();
    public List<Texture> pictures = new List<Texture>();
    // Start is called before the first frame update
    void Start()
    {
        firstImageSet = false;
        images.Add(rawImage0);
        images.Add(rawImage1);
        images.Add(rawImage2);
        images.Add(rawImage3);
        images.Add(rawImage4);
        images.Add(rawImage5);
        images.Add(rawImage6);
        images.Add(rawImage7);
        images.Add(rawImage8); //make and array of images
        int numOfImages = images.Count;
        foreach (RawImage image in images)
        {
            if (!image.texture)
                image.enabled = false;
            if (firstImageSet == false && !image.texture)
            {
                firstEmptyImage = images.IndexOf(image); //find the index of the first empty image
                Debug.Log("first empty image is: " + firstEmptyImage);
                firstImageSet = true;
            }

        }

    }

    void Update()
    {
        foreach (RawImage image in images)
        {
            if (!image.texture)
            {
                image.enabled = false;
            }
            else
            {
                image.enabled = true;
            }
        }
    }
    public void checkIfBusy()
    {
        if (NativeCamera.IsCameraBusy())
        {
            Debug.Log("Device doesn't have a camera");
            var screenshot = ScreenCapture.CaptureScreenshotAsTexture();
            rawImage0.texture = screenshot;
            tempTexture = screenshot;
            // return;
        }
        else
        {
            if (firstEmptyImage == 9)
            {
                Debug.Log("Sorry no more room!");
            }
            TakePicture(512);
        }
    }


    private void TakePicture(int maxSize)
    {
        NativeCamera.Permission permission = NativeCamera.TakePicture((path) =>
       {
           Debug.Log("Image path: " + path);
           if (path != null)
           {
               // Create a Texture2D from the captured image
               Texture2D texture = NativeCamera.LoadImageAtPath(path, maxSize);
               if (texture == null)
               {
                   Debug.Log("Couldn't load texture from " + path);
                   return;
               }
               images[firstEmptyImage].texture = texture; // add textures to the first empty image
               images[firstEmptyImage].enabled = true;  //show the image
               //Debug.Log("first empty image is: " + firstEmptyImage);
               firstEmptyImage++;  //go to the next empty image
               tempTexture = texture;
               Scripts.GetComponent<UploadPicture>().startUpload();
               if (Scripts.GetComponent<UploadPicture>().DownloadURL != "")
               {
                   Scripts.GetComponent<DownloadPicture>().Trigger();
               }
           }
       }, maxSize);

        Debug.Log("Permission result: " + permission);
    }

}