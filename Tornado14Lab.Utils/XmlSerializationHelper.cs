using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Tornado14Lab.Utils
{
    /// <summary>
    /// XML Serialization Helper.
    /// </summary>
    public static class XmlSerializationHelper
    {

        #region Constants
        //----------------------------------------------------------------------------------------------------
        // Constants
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Attributes
        //----------------------------------------------------------------------------------------------------
        // Attributes
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Static Initializers
        //----------------------------------------------------------------------------------------------------
        // Static Initializers
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Constructors
        //----------------------------------------------------------------------------------------------------
        // Constructors & Destructor
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Properties
        //----------------------------------------------------------------------------------------------------
        // Properties
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Indexers
        //----------------------------------------------------------------------------------------------------
        // Indexers
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Events
        //----------------------------------------------------------------------------------------------------
        // Events
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Operators
        //----------------------------------------------------------------------------------------------------
        // Operators
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region EventHandler
        //----------------------------------------------------------------------------------------------------
        // EventHandler
        //----------------------------------------------------------------------------------------------------

        #endregion

        #region Methods
        //----------------------------------------------------------------------------------------------------
        // Methods
        //----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Serializes the specified object (UTF-8).
        /// </summary>
        /// <param name="obj">The object to be serialzed.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The object parameter is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown by the <see cref="XmlSerializer"/>.</exception>
        public static string Serialize(object obj1)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = System.Text.Encoding.UTF8;
            settings.NewLineHandling = NewLineHandling.Entitize;
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            StringWriter StringWriter = new StringWriter();
            XmlWriter writer = XmlWriter.Create(StringWriter, settings);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            XmlSerializer MySerializer = new XmlSerializer(obj1.GetType());

            MySerializer.Serialize(writer, obj1, namespaces);
            string s = StringWriter.ToString();
            return s;


            //string result = null;
            //Type runtimeType = obj.GetType();
            //// Xml witer
            //MemoryStream stream = new MemoryStream();
            //XmlTextWriter writer = new XmlTextWriter(stream, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };

            //// serializer
            //XmlSerializer serializer = new XmlSerializer(runtimeType);
            //try
            //{
            //    serializer.Serialize(writer, obj);
            //}
            //catch (InvalidOperationException)
            //{
            //    throw;
            //}
            //stream.Position = 0;
            //stream.Flush();
            //// read string
            //StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
            //while (reader.Peek() >= 0)
            //{
            //    result += reader.ReadLine();
            //}
            //reader.Close();


            //writer.Close();
            //stream.Close();
            //return result;

        }

        /// <summary>
        /// Desirializes the specified object XML.
        /// </summary>
        /// <param name="objectXml">The object XML.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static T Desirialize<T>(string objectXml)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            serializer.UnknownAttribute += new XmlAttributeEventHandler(OnSerializerUnknownAttribute);
            serializer.UnknownElement += new XmlElementEventHandler(OnSerializerUnknownElement);
            serializer.UnknownNode += new XmlNodeEventHandler(OnSerializerUnknownNode);
            serializer.UnreferencedObject += new UnreferencedObjectEventHandler(OnSerializerUnreferencedObject);

            MemoryStream memStream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(memStream, System.Text.Encoding.UTF8);

            streamWriter.Write(objectXml);

            //memStream.Flush();
            streamWriter.Flush();
            memStream.Position = 0;



            XmlReaderSettings settings = new XmlReaderSettings();
            settings.CheckCharacters = false;
            settings.CloseInput = false;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            settings.ValidationType = ValidationType.None;
            settings.ValidationFlags = System.Xml.Schema.XmlSchemaValidationFlags.None;
            settings.IgnoreProcessingInstructions = true;


            XmlReader reader = XmlReader.Create(memStream, settings);

            T result = (T)serializer.Deserialize(reader);

            reader.Close();
            streamWriter.Close();
            memStream.Close();

            return result;
        }


        /// <summary>
        /// Called when [serializer unreferenced object].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.UnreferencedObjectEventArgs"/> instance containing the event data.</param>
        static void OnSerializerUnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            string message = string.Format("Unreferenced Object: ID: {0}, Object: {1}", e.UnreferencedId, e.UnreferencedObject);
            System.Diagnostics.Debug.WriteLine(message, "Xml Desirialization");
        }


        /// <summary>
        /// Called when [serializer unknown node].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlNodeEventArgs"/> instance containing the event data.</param>
        static void OnSerializerUnknownNode(object sender, XmlNodeEventArgs e)
        {
            string message = string.Format("Unknown node: Line: {0}, Position: {1}, LocalName: {2}, Name: {3}, NodeType: {4}, Text: {5}", e.LineNumber, e.LinePosition, e.LocalName, e.Name, e.NodeType, e.Text);
            System.Diagnostics.Debug.WriteLine(message, "Xml Desirialization");
        }


        /// <summary>
        /// Called when [serializer unknown element].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlElementEventArgs"/> instance containing the event data.</param>
        static void OnSerializerUnknownElement(object sender, XmlElementEventArgs e)
        {
            string message = string.Format("Unknown element: Element: {0}, Expected: {1}, Line: {2}, Position: {3}", e.Element.Name, e.ExpectedElements, e.LineNumber, e.LinePosition);
            System.Diagnostics.Debug.WriteLine(message, "Xml Desirialization");
        }


        /// <summary>
        /// Called when [serializer unknown attribute].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlAttributeEventArgs"/> instance containing the event data.</param>
        static void OnSerializerUnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            string message = string.Format("Unknown attribute: Attribute: {0}, Expected: {1}, Line: {2}, Position: {3}", e.Attr.Name, e.ExpectedAttributes, e.LineNumber, e.LinePosition);
            System.Diagnostics.Debug.WriteLine(message, "Xml Desirialization");
        }


        #endregion

        #region Inner Types
        //----------------------------------------------------------------------------------------------------
        // Inner Types
        //----------------------------------------------------------------------------------------------------

        #endregion



    }
}
