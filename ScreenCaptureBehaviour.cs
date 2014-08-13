using UnityEngine;
using System.Collections;

public class ScreenCaptureBehaviour : MonoBehaviour {

  public bool isRecording = false;
  public bool useNewFolder = true;
  public string directory = "screenshots";
  public int frameRate = 25;
  public int scale = 1;

  private string folder;

  void Update() {
    // Capture the screenshot
    if (isRecording == false) {
      return;
    }

    if (Time.captureFramerate != frameRate) {
      // Sets the playback framerate so real time doesn't influence time anymore.
      //http://docs.unity3d.com/ScriptReference/Time-captureFramerate.html
      CreateFolder();
      Time.captureFramerate = frameRate;
    }

    var img = string.Format("{0}/{1:D04}-shot.png", folder, Time.frameCount);
    Application.CaptureScreenshot(img, scale);
  }

  private void CreateFolder() {
    // get to the end of the folders
    string path = "screenshots/" + directory + "/";

    int count = 1;
    while (System.IO.Directory.Exists(path + count)) {
      count++;
    }

    //  if we're not creating a new folder, use the last existing folder
    if (useNewFolder == false && count > 1) {
      count--;
    }

    folder = path + count;

    if (!System.IO.Directory.Exists(folder)) {
      System.IO.Directory.CreateDirectory(folder);
    }
  }
}
