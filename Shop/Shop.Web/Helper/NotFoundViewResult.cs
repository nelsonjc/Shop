﻿namespace Shop.Web.Helper
{
	using Microsoft.AspNetCore.Mvc;
	using System.Net;

	public class NotFoundViewResult : ViewResult
	{
		public NotFoundViewResult(string viewName)
		{
			ViewName = viewName;
			StatusCode = (int)HttpStatusCode.NotFound;
		}
	}

}
