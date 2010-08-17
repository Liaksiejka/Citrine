
using System;

namespace TestClasses
{
	/// <summary>
	/// Description of TestIO.
	/// </summary>
	public class TestIO
	{
		public TestIO()
		{
			
			/// <summary>
			/// Записывает XML файл
			/// </summary>
			/// <param name="path">путь к создаваемому файлу</param>
			public void Write(string path) {
				// TODO: переписать работу с файлами на using

				// создаем сериалайзер
				XmlSerializer sr = new XmlSerializer(typeof(TestSuite));
				// создаем writer в который и будет происходить сериализация
				StringBuilder sb = new StringBuilder();
				StringWriter w = new StringWriter(sb, System.Globalization.CultureInfo.InvariantCulture);
				// сериализуем
				sr.Serialize(w,this);
				// получаем xml строку
				string xml = sb.ToString();
				
				// записываем xml в файл
				StreamWriter outfile = new StreamWriter(path);
				outfile.Write(xml);
				outfile.Close();

				return true;
			}
			
			public static TestSuite Read(string path) {
				// TODO: переписать работу с файлами на using
				// читаем xml из файла
				StreamReader infile = File.OpenText(path);
				string xml = infile.ReadToEnd();
				StringReader sr = new StringReader(xml);
				// создаем XmlSerializer
				XmlSerializer dsr = new XmlSerializer(typeof(TestSuite));
				// десериализуем
				return (TestSuite) dsr.Deserialize(sr);
			}
		}
	}
}
