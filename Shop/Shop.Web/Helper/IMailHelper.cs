﻿namespace Shop.Web.Helper
{
	public interface IMailHelper
	{
		void SendMail(string to, string subject, string body);

	}

}
