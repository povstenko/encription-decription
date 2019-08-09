using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPHW2
{
	public partial class Form1 : Form
	{
		long key;
		string path;
		public Form1()
		{
			InitializeComponent();
			key = (long)nudKey.Value;
			path = textBox1.Text;
		}

		private static string Encrypt(string message, long key)
		{
			string result = "";
			for (int i = 0; i < message.Length; i++)
				result += (char)(message[i] ^ key);
			return result;
		}
		private static string Decrypt(string message, long key)
		{
			return Encrypt(message, key);
		}
		private static string ReadFile(string path)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				return sr.ReadToEnd();
			}
		}
		private static void WriteFile(string path, string text)
		{
			using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
			{
				sw.WriteLine(text);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string message = decrypted.Text;
			message = Encrypt(message, key);
			encrypted.Text = message;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string message = encrypted.Text;
			message = Decrypt(message, key);
			decrypted.Text = message;
		}

		private void nudKey_ValueChanged(object sender, EventArgs e)
		{
			key = (long)nudKey.Value;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			path = textBox1.Text;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			decrypted.Text = ReadFile(path);
		}
	}
}
