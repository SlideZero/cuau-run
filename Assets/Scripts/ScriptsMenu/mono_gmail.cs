using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class mono_gmail : MonoBehaviour {

	public IngresarCorreo correo;
	public IngresarNombre nombre;
	public IngresarTelefono telefono;


	public void SendMail() {
		MailMessage mail = new MailMessage ();

		mail.From = new MailAddress ("infocuaurun@gmail.com");
		mail.To.Add ("infocuaurun@gmail.com");
		mail.Subject = "Informacion de usuario: " + nombre.getInputNombre();
		mail.Body = "Nombre: " + nombre.getInputNombre() + "\n" + "Correo: " + correo.getInputCorreo() + "\n" + "Telefono: " + telefono.getInputTelefono();

		SmtpClient smtpServer = new SmtpClient ("smtp.gmail.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential ("infocuaurun@gmail.com", "megustaelaguadehorchata") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate X509Certificate, X509Chain chain, SslPolicyErrors sslPolicyErrrors) {
			return true;
		};
		smtpServer.Send (mail);
		Debug.Log ("victoria!");
	}
}