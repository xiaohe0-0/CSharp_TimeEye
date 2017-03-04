using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace TimeEye
{
    public class XmlOperation
    {
        public Boolean CreateMessageInfoNode(string date,string time,string innerText)
        {
            Boolean createSign = true;
            XmlDocument xmlDoc = new XmlDocument();
            try {
                xmlDoc.Load(Utils.xmlRecordFile);
                //获取root节点的所有子节点
                XmlNode root = xmlDoc.SelectSingleNode(Utils.RootNode);
                XmlNodeList nodeList = root.ChildNodes;

                //遍历所有子节点
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn; //将子节点类型转换为XmlElement类型
                    if (xe.GetAttribute(Utils.MessageAttribute).Equals(date))//如果date属性值为date
                    {
                        if (!time.Equals("")) {
                            XmlElement xec = xmlDoc.CreateElement(Utils.InfoNode);//创建一个InfoNode节点
                            xec.SetAttribute(Utils.InfoAttribute, time);//设置该节点time属性
                            xec.InnerText = innerText;//设置节点的文本值
                            xn.AppendChild(xec);
                            xmlDoc.Save(Utils.xmlRecordFile);
                        }
                        createSign = false;
                        break;
                    }
                }

                if (createSign) {
                    XmlElement xec = xmlDoc.CreateElement(Utils.MessageNode);//创建一个Message节点
                    xec.SetAttribute(Utils.MessageAttribute, date);//设置该节点date属性
                    root.AppendChild(xec);
                    xmlDoc.Save(Utils.xmlRecordFile);
                }
                return true;
            }
            catch (Exception e) {
                Console.WriteLine("Create Message Node Error: "+e.ToString());
                return false;
            }
        }

        public Boolean CreateXMLFile(String fileName) {
            try
            {
                //创建文件夹
                if (!Directory.Exists(Utils.xmlDirectory)) {
                    Directory.CreateDirectory(Utils.xmlDirectory);
                }
                if (!Directory.Exists(Utils.configDirectory))
                    Directory.CreateDirectory(Utils.configDirectory);
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建根节点  
                XmlNode root = xmlDoc.CreateElement(Utils.RootNode);
                xmlDoc.AppendChild(root);
                xmlDoc.Save(fileName);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean WriteTimeSetting(string fileName,string[] values) {
             XmlDocument xmlDoc = new XmlDocument();
             try
             {
                 xmlDoc.Load(fileName);
                 //获取root节点的所有子节点
                 XmlNode root = xmlDoc.SelectSingleNode(Utils.RootNode);

                 for (int i = 0; i < Utils.content_time_settings.Length; i++) { 
                     XmlNode settingNode = root.SelectSingleNode("//"+Utils.content_time_settings[i]);
                     if (settingNode == null)
                     {
                         XmlElement xec = xmlDoc.CreateElement(Utils.content_time_settings[i]);//创建一个节点
                        // xec.InnerText = Utils.value_time_settings[i];//设置节点的文本值
                         root.AppendChild(xec);
                         xmlDoc.Save(fileName);
                     }
                     settingNode = root.SelectSingleNode("//" + Utils.content_time_settings[i]);
                     settingNode.InnerText = values[i];//设置节点的文本值
                     xmlDoc.Save(fileName);
                 }
                 return true;
             }
            catch(Exception e){
                return false;
            }
        }

        public void ReadTimeSetting(string fileName) { 
             XmlDocument xmlDoc = new XmlDocument();
             try
             {
                 xmlDoc.Load(fileName);
                 //获取root节点的所有子节点
                 XmlNode root = xmlDoc.SelectSingleNode(Utils.RootNode);
                 XmlNodeList nodeList = root.ChildNodes;

                 //遍历所有子节点
                 foreach (XmlNode xn in nodeList)
                 {
                     XmlElement xe = (XmlElement)xn; //将子节点类型转换为XmlElement类型
                     switch (xe.Name) { 
                         case Utils.content_start_work:
                             Utils.time_start_work = xe.InnerText;
                             break;
                         case Utils.content_end_work:
                             Utils.time_end_work = xe.InnerText;
                             break;
                         case Utils.content_remind_work:
                             Utils.time_remind_work = int.Parse(xe.InnerText);
                             break;
                         case Utils.content_remind_rest:
                             Utils.time_remind_rest = int.Parse(xe.InnerText);
                             break;
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("Read Time Setting File Error: " + e.ToString());
             }
        }
    }
}
