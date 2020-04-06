## Xml文件的写入和读取
有两种方式：
- `XmlDocument`   
创建新的文档对象,`XmlDocument doc = new XmlDocument()`或从现有XML文件中加载`doc.Load("my.xml")`,   
添加文档声明`doc.CreateDeclaration("1.0,"utf-8","yes")`,   
创建元素，`XmlElement el = doc.CreateElement("My")`,追加元素，`doc.AppendChild(el)`;获取子节点，`el.ChildNodes`   
查询特定元素，`doc.GetElementById('id')`,`doc.GetElementsByTagName('MyTag')`  
获取元素的值，`el.InnerText`或`el.InnerXml`

- `XDocument`
创建新的文档对象,`XDocument doc = new XDocument()`,或从现有文件中加载`XDocument doc = XDocument.Load("my.xml")`   
添加文档声明`doc.Declaration = new Declaration("1.0,"utf-8","yes")`,   
创建元素，`XElement el = new XElement("My")`,追加元素，`doc.Add(el)`;获取子元素，`el.Element()`或`el.Elements()`,获取后代元素  
`el.Decendants()`;   
获取特定子元素，`el.Element("MyElemen")`或`el.Elements("MyElemen")`,获取特定后代元素  
`el.Decendants("MyElemen")`；   
获取元素的值，`el.Value`
