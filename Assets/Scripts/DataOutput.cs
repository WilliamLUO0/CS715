using System.Collections;
using System.Collections.Generic;
using System;
using System.Data;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Android;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class DataOutput : MonoBehaviour
{
    private DataTable dt;
    public TextMeshProUGUI debugText;
    public LevelMechanism levelMechanism;
    public Text numOfGems;
    public Text numOfDragonBabies;
    public Text numOfAdultDragons;
    public String emailAddress = "";

    private String filePath;

    // Start is called before the first frame update
    void Start()
    {
        // create data table
        dt = new DataTable("Sheet1");
        // create columns
        dt.Columns.Add("Time");
        dt.Columns.Add("Exercise Intensity Value (GPS)");
        dt.Columns.Add("Average Moving Steps");
        dt.Columns.Add("Magnet Energy");
        dt.Columns.Add("Level of Reward");
        dt.Columns.Add("Number of Gems");
        dt.Columns.Add("Number of Dragon Babies");
        dt.Columns.Add("Number of Adult Dragons");

        // Set output file name
        String currentDateTime = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy_MM_dd_HH_mm_ss");
        filePath = Application.persistentDataPath + "/Exercise_Intensity_Data_" + currentDateTime + ".csv";
    }

    public void SaveCSV(string CSVPath, DataTable mSheet)
    {
        // check whether data table has data
        if (mSheet.Rows.Count < 1)
            return;

        // read data table
        int rowCount = mSheet.Rows.Count;
        int colCount = mSheet.Columns.Count;

        // create StringBuilder
        StringBuilder stringBuilder = new StringBuilder();

        // start to read data
        for (int i = 0; i < mSheet.Columns.Count; i++)
        {
            stringBuilder.Append(mSheet.Columns[i].ColumnName + ",");
        }
        stringBuilder.Append("\r\n");
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                // using ',' split each cell
                stringBuilder.Append(mSheet.Rows[i][j] + ",");
            }
            // using '\r\n' split each row
            stringBuilder.Append("\r\n");
        }

        // write to the file
        using (FileStream fileStream = new FileStream(CSVPath, FileMode.Create, FileAccess.Write))
        {
            using (TextWriter textWriter = new StreamWriter(fileStream,Encoding.UTF8))
            {
                textWriter.Write(stringBuilder.ToString());
            }
        }
    }

    public void insertCsvRow(double time, double exerciseIntensityValue, double averageMovingSteps)
    {
        char currentRewardLevel = levelMechanism.getCurrentItemLevel();
        int magnetEnergy = levelMechanism.getMagnetEnergy();
        String numOfGemsString = numOfGems.text;
        String numOfDragonBabiesString = numOfDragonBabies.text;
        String numOfAdultDragonsString = numOfAdultDragons.text;

        // create rows
        DataRow dr = dt.NewRow();
        dr["Time"] = time.ToString();
        dr["Exercise Intensity Value (GPS)"] = exerciseIntensityValue.ToString();
        dr["Average Moving Steps"] = averageMovingSteps.ToString();
        dr["Magnet Energy"] = magnetEnergy.ToString();
        dr["Level of Reward"] = currentRewardLevel.ToString();
        dr["Number of Gems"] = numOfGemsString;
        dr["Number of Dragon Babies"] = numOfDragonBabiesString;
        dr["Number of Adult Dragons"] = numOfAdultDragonsString;

        dt.Rows.Add(dr);
        SaveCSV(filePath, dt);

        // debugText.text = "File Saved: " + time.ToString();  // debug only
    }

    public void sendCsvFileToEmail()
    {
        debugText.enabled = true;
        if (emailAddress == "") {
            debugText.text = "Sending data file failed, no email address!";
            return;
        }
        debugText.text = "Sending data file to email...";
        MailMessage mail = new MailMessage();
        // sender email address
        mail.From = new MailAddress("2894735011@qq.com");
        // reciver email address
        mail.To.Add(emailAddress);
        // email title
        mail.Subject = "AR Exergame Data";
        // email content
        mail.Body = "Contains Exercise intensity data";
        // add an attachment to the email
        mail.Attachments.Add(new Attachment(filePath));
 
        // SMTP server
        SmtpClient smtpServer = new SmtpClient("smtp.qq.com");
        // SMTP Port number
        smtpServer.Port = 587;
        // email user account details
        smtpServer.Credentials = new System.Net.NetworkCredential("2894735011@qq.com", "yglsvmuopmkddfhd") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
 
        smtpServer.Send(mail);
        debugText.text = "Email has been sent successfully!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
