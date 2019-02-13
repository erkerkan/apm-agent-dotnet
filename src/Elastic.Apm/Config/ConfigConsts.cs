﻿using System;

namespace Elastic.Apm.Config
{
	public static class ConfigConsts
	{
		internal static (string Level, string Urls, string ServiceName) ConfigKeys = (
			Level: "ELASTIC_APM_LOG_LEVEL",
			Urls: "ELASTIC_APM_SERVER_URLS",
			ServiceName: "ELASTIC_APM_SERVICE_NAME"
		);

		public static Uri DefaultServerUri => new Uri("http://localhost:8200");
	}
}
