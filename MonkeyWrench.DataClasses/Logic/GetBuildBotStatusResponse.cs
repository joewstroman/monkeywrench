﻿/*
 * GetBuildBotStatusResponse.cs
 *
 * Authors:
 *   Rolf Bjarne Kvinge (RKvinge@novell.com)
 *   
 * Copyright 2009 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonkeyWrench;

namespace MonkeyWrench.DataClasses.Logic
{
	public class GetBuildBotStatusResponse : WebServiceResponse
	{
		public List<DBBuildBotStatus> Status;
		public List<DBHost> Hosts;
		public List<DBRelease> Releases;
	}
}
