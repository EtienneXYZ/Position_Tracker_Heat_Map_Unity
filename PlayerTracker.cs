using System.IO;
using UnityEngine;
using UnityEngine.XR;

public class PlayerTracker : MonoBehaviour
{
    public int roomDesign;
    private string filePath;

    private void Start()
    {
        filePath = Application.dataPath + "/PlayerData.csv";
        InvokeRepeating("RecordPlayerData", 1f, 1f);
    }

    private void RecordPlayerData()
    {
        Vector3 position = InputTracking.GetLocalPosition(XRNode.CenterEye);
        Quaternion rotation = InputTracking.GetLocalRotation(XRNode.CenterEye);
        string timeStamp = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{timeStamp},{position.x},{position.y},{position.z},{rotation.x},{rotation.y},{rotation.z},{roomDesign}");
        }
    }
}









