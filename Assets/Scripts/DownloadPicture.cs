using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Storage;
using UnityEngine.Events;

public class DownloadPicture : MonoBehaviour
{
    public GameObject scripts;
    public void Trigger()
    {
        StartCoroutine(DownloadPictureCoroutine(scripts.GetComponent<UploadPicture>().DownloadURL));
    }

    private IEnumerator DownloadPictureCoroutine(string path)
    {
        var storage = FirebaseStorage.DefaultInstance;
        var pictureRefrence = storage.GetReference(path);

        var downloadTask = pictureRefrence.GetBytesAsync(long.MaxValue);
        yield return new WaitUntil(() => downloadTask.IsCompleted);

        var texture = new Texture2D(4096, 4096);
        texture.LoadImage(downloadTask.Result);
    }
}
