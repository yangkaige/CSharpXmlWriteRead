using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLUsageDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Person> list = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(new Person() { Name = "AAA", Age = 18, Email = "154@163.com" });
            list.Add(new Person() { Name = "BBB", Age = 48, Email = "fds@163.com" });
            list.Add(new Person() { Name = "CCC", Age = 55, Email = "fdsa@163.com" });
            list.Add(new Person() { Name = "DDD", Age = 28, Email = "fewe@163.com" });
            list.Add(new Person() { Name = "EEE", Age = 60, Email = "rtret@163.com" });
        }
        /// <summary>
        /// XmlDocument方式写入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXMLDocumentWrite_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "yes");
            //添加文档声明
            xmlDocument.AppendChild(xmlDeclaration);
            //创建根元素
            XmlElement xmlRootElement = xmlDocument.CreateElement("List");
            xmlDocument.AppendChild(xmlRootElement);
            foreach (var item in list)
            {
                //创建Person子元素
                XmlElement xmlPersonElement = xmlDocument.CreateElement("Person");
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("id");
                xmlAttribute.Value = Guid.NewGuid().ToString();
                xmlPersonElement.Attributes.Append(xmlAttribute);
                //创建姓名子元素
                XmlElement xmlNameElement = xmlDocument.CreateElement("Name");
                xmlNameElement.InnerText = item.Name;
                xmlPersonElement.AppendChild(xmlNameElement);
                //创建年龄子元素
                XmlElement xmlAgeElement = xmlDocument.CreateElement("Age");
                xmlAgeElement.InnerText = item.Age.ToString();
                xmlPersonElement.AppendChild(xmlAgeElement);
                //创建邮箱子元素
                XmlElement xmlEmailElement = xmlDocument.CreateElement("Email");
                xmlEmailElement.InnerText = item.Email;
                xmlPersonElement.AppendChild(xmlEmailElement);

                xmlRootElement.AppendChild(xmlPersonElement);
            }
            xmlDocument.Save("List.xml");
            MessageBox.Show("写入成功!!");
        }
        /// <summary>
        /// XDocument方式写入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXDocumentWrite_Click(object sender, EventArgs e)
        {
            XDocument xDocument = new XDocument();
            //创建文档声明
            xDocument.Declaration = new XDeclaration("1.0", "uft-8", "no");
            //添加根节点
            XElement xRootElement = new XElement("List");
            xDocument.Add(xRootElement);
            foreach (var item in list)
            {
                //添加子元素
                XElement xPersonElement = new XElement("Person");
                xPersonElement.SetAttributeValue("id", Guid.NewGuid().ToString());
                //添加姓名
                XElement xNameElement = new XElement("Name");
                xNameElement.Value = item.Name;
                xPersonElement.Add(xNameElement);
                //添加年龄
                XElement xAgeElement = new XElement("Age");
                xAgeElement.Value = item.Age.ToString();
                xPersonElement.Add(xAgeElement);
                //添加Email
                XElement xEmailElement = new XElement("Email");
                xEmailElement.Value = item.Email;
                xPersonElement.Add(xEmailElement);

                //添加Person到根元素
                xRootElement.Add(xPersonElement);
            }

            xDocument.Save("xList.xml");
            MessageBox.Show("保存成功");
        }
        /// <summary>
        /// XmlDocument方式读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXmlDocumentRead_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("List.xml");
            XmlElement root = xmlDocument.DocumentElement;
            listBox.Items.Clear();
            foreach (XmlNode item in root.ChildNodes)
            {
                string person = string.Empty;
                foreach (XmlNode subItem in item.ChildNodes)
                {
                    person += string.Format("\t{0}:{1}\t", subItem.Name, subItem.InnerText);
                }
                listBox.Items.Add(person);
            }
        }
        /// <summary>
        /// XDocument方式读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXDocumentRead_Click(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load("List.xml");
            XElement root = xDocument.Root;

            listBox.Items.Clear();
            foreach (var item in root.Elements("Person"))
            {
                string name = item.Element("Name").Value;
                string age = item.Element("Age").Value;
                string email = item.Element("Email").Value;
                
                listBox.Items.Add(string.Format("\tName:{0},Age:{1},Email:{2}\t", name, age, email));

            }
        }
    }
}
