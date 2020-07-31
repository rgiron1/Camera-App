using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;
using Firebase.Storage;

public class UploadPicture : MonoBehaviour
{
    //Texture2D picture
    public GameObject Scripts;
    public string DownloadURL;
    public int numOfPics;
    public bool full;
    public int n;
    public List<PictureObject> pictures = new List<PictureObject>();



    void Start()
    {
        numOfPics = pictures.Count;
        n = 1;
    }
    public void startUpload()
    {
        if (numOfPics == 9)
        {
            full = true;
        }
        else
        {
            full = false;
        }

        if (full)
        {
            Debug.Log("No more room for pictures! Sorry!");
        }
        else
            StartCoroutine(UploadCoroutine(Scripts.GetComponent<OpenCamera>().tempTexture));
    }

    private IEnumerator UploadCoroutine(Texture2D picture) //upload picture to Firebase Storage
    {
        DownloadURL = "";
        var storage = FirebaseStorage.DefaultInstance;
        var pictureRefrence = storage.GetReference($"/Ryan_Giron/Picture" + n + ".png");
        var bytes = picture.EncodeToPNG();
        var uploadTask = pictureRefrence.PutBytesAsync(bytes);
        yield return new WaitUntil(() => uploadTask.IsCompleted);
        n++;

        if (uploadTask.Exception != null)
        {
            Debug.LogError($"Failed to upload because {uploadTask.Exception}");
            yield break;
        }


        PictureObject pic = new PictureObject(pictureRefrence, Scripts.GetComponent<OpenCamera>().tempTexture); //create a new picture object everytime a picture is taken
        pictures.Add(pic); // store new picture object in list of pictures
        numOfPics++;
        Debug.Log("num of pics:" + numOfPics);

        pictureRefrence.GetDownloadUrlAsync().ContinueWith((Task<Uri> task) =>
        {
            if (!task.IsFaulted && !task.IsCanceled)
            {
                DownloadURL = task.Result.ToString();
                Debug.Log("Download URL: " + task.Result);
            }
        });

    }
}
