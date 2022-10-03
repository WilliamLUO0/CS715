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
        //创建表 设置表名
        dt = new DataTable("Sheet1");
        //创建列 有三列
        dt.Columns.Add("Time");
        dt.Columns.Add("Exercise Intensity Value (GPS)");
        dt.Columns.Add("Average Moving Steps");
        dt.Columns.Add("Magnet Energy");
        dt.Columns.Add("Level of Reward");
        dt.Columns.Add("Number of Gems");
        dt.Columns.Add("Number of Dragon Babies");
        dt.Columns.Add("Number of Adult Dragons");

        String currentDateTime = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy_MM_dd_HH_mm_ss");
        filePath = Application.persistentDataPath + "/Exercise_Intensity_Data_" + currentDateTime + ".csv";
    }

    public void SaveCSV(string CSVPath, DataTable mSheet)
    {
        //判断数据表内是否存在数据
        if (mSheet.Rows.Count < 1)
            return;

        //读取数据表行数和列数
        int rowCount = mSheet.Rows.Count;
        int colCount = mSheet.Columns.Count;

        //创建一个StringBuilder存储数据
        StringBuilder stringBuilder = new StringBuilder();

        //读取数据
        for (int i = 0; i < mSheet.Columns.Count; i++)
        {
            stringBuilder.Append(mSheet.Columns[i].ColumnName + ",");
        }
        stringBuilder.Append("\r\n");
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                //使用","分割每一个数值
                stringBuilder.Append(mSheet.Rows[i][j] + ",");
            }
            //使用换行符分割每一行
            stringBuilder.Append("\r\n");
        }

        //写入文件
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

        //创建行 每一行有三列数据
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

        // debugText.text = "File Saved: " + time.ToString();
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
        //发送邮箱的地址
        mail.From = new MailAddress("2894735011@qq.com");
        //收件人邮箱地址 如需发送多个人添加多个Add即可
        mail.To.Add(emailAddress);
        //标题
        mail.Subject = "AR Exergame Data";
        //正文
        mail.Body = "Contains Exercise intensity data";
        //添加一个本地附件 
        mail.Attachments.Add(new Attachment(filePath));
 
        //所使用邮箱的SMTP服务器
        SmtpClient smtpServer = new SmtpClient("smtp.qq.com");
        //SMTP端口
        smtpServer.Port = 587;
        //账号密码 一般邮箱会提供一串字符来代替密码  (IMAP:yglsvmuopmkddfhd POP3:rjkghklvufhbdhfg)
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
