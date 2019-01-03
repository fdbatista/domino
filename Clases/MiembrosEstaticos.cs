using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ControlDomino.Clases
{
	public static class MiembrosEstaticos
	{
		const string key = "ABCDEFGHIJKLM?><@#$%^&*()+_|:{}~`ÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz" +
			"BVNHNME^&<%^YHBDRT?GHRE%^Y$%G^&*(}+hgvfcdSdhge#$%^YUHTGfdhnM(P)9iu7ytrVBHJ%E^&I*MKRTEW";
		
		public static void SerializarObjeto(object objeto, string rutaFichero)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(rutaFichero, FileMode.Create, FileAccess.Write, FileShare.None);
			formatter.Serialize(stream, objeto);
			stream.Close();
		}
		
		public static object DeserializarObjeto(string rutaFichero)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(rutaFichero, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				object objeto = (object) formatter.Deserialize(stream);
				stream.Close();
				return objeto;
			}
			catch (Exception exc)
			{
				stream.Close();
				throw exc;
			}
		}
		
		public static string Encriptar(string texto)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }

        public static string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            tdes.Clear();
            string res = UTF8Encoding.UTF8.GetString(resultArray);
            return res;
        }
        
        public static string NormalizarCadena(string pCadena, bool initCaps, bool aMayuscula)
        {
        	string res = pCadena.Trim().ToLower();
        	if (aMayuscula)
        		res = res.ToUpper();
			while (res.Contains("  "))
				res = res.Replace("  ", " ");
			if (initCaps)
			{
				string[] subCads = res.Split(new char[]{' '});
				res = "";
				for (int i = 0; i < subCads.Length; i++)
					res = res + subCads[i].Substring(0, 1).ToUpper() + subCads[i].Substring(1) + " ";
				return res.Trim();
			}
			else
				return res;
        }
        
        public static string CadenaHTML(string pCadena)
        {
			return pCadena.Trim().Replace("á", "&aacute;").Replace("é", "&eacute;").Replace("í", "&iacute;").Replace("ó", "&oacute;").Replace("ú", "&uacute;").Replace("ñ", "&ntilde;").Replace("Á", "&Aacute;").Replace("É", "&Eacute;").Replace("Í", "&Iacute;").Replace("Ó", "&Oacute;").Replace("Ú", "&Uacute;").Replace("Ñ", "&Ntilde;");
        }
        
        public static void GuardarFichero(string ruta, List<string> valores)
        {
			StreamWriter cabezal = new StreamWriter(ruta);
			for (int i = 0; i < valores.Count; i++)
				cabezal.WriteLine(valores[i]);
			cabezal.Close();
        }
        
        public static DialogResult InputBox(string title, string promptText, ref string value)
		{
			Form form = new Form();
			Label label = new Label();
			TextBox textBox = new TextBox();
			Button buttonOk = new Button();
			Button buttonCancel = new Button();
			
			form.Text = title;
			label.Text = promptText;
			textBox.Text = value;
			
			buttonOk.Text = "OK";
			buttonCancel.Text = "Cancel";
			buttonOk.DialogResult = DialogResult.OK;
			buttonCancel.DialogResult = DialogResult.Cancel;
			
			label.SetBounds(9, 20, 372, 13);
			textBox.SetBounds(12, 36, 372, 20);
			buttonOk.SetBounds(228, 72, 75, 23);
			buttonCancel.SetBounds(309, 72, 75, 23);
			
			label.AutoSize = true;
			textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
			buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			
			form.ClientSize = new Size(396, 107);
			form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
			form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterParent;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = buttonOk;
			form.CancelButton = buttonCancel;
			
			DialogResult dialogResult = form.ShowDialog();
			value = textBox.Text;
			return dialogResult;
		}
        
        public static DialogResult InputBoxPrioridad(ref string value)
		{
			Form form = new Form();
			Label label = new Label();
			ComboBox comboBox = new ComboBox();
			Button buttonOk = new Button();
			Button buttonCancel = new Button();
			
			form.Text = "DominARTE";
			label.Text = "Nueva prioridad:";
			
			buttonOk.Text = "Aceptar";
			buttonCancel.Text = "Cancelar";
			buttonOk.DialogResult = DialogResult.OK;
			buttonCancel.DialogResult = DialogResult.Cancel;
			
			label.SetBounds(9, 20, 372, 13);
			comboBox.SetBounds(95, 15, 55, 20);
			buttonOk.SetBounds(9, 48, 70, 23);
			buttonCancel.SetBounds(82, 48, 70, 23);
			
			label.AutoSize = true;
			buttonOk.Cursor = Cursors.Hand;
			buttonCancel.Cursor = Cursors.Hand;
			comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox.Cursor = Cursors.Hand;
			for (int i = 1; i < 21; i++)
				comboBox.Items.Add(i.ToString());
			comboBox.SelectedItem = value;
			
			form.ClientSize = new Size(165, 85);
			form.Controls.AddRange(new Control[] { label, comboBox, buttonOk, buttonCancel });
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterParent;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = buttonOk;
			form.CancelButton = buttonCancel;
			
			DialogResult dialogResult = form.ShowDialog();
			value = comboBox.Text;
			return dialogResult;
		}
        
        public static DialogResult MostrarError(string mensaje)
        {
        	return MessageBox.Show(mensaje, "DominARTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static DialogResult MostrarAdvertencia(string mensaje)
        {
        	return MessageBox.Show(mensaje, "DominARTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public static DialogResult MostrarInformacion(string mensaje)
        {
        	return MessageBox.Show(mensaje, "DominARTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public static DialogResult MostrarPregunta(string mensaje)
        {
        	return MessageBox.Show(mensaje, "DominARTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
	}
}
