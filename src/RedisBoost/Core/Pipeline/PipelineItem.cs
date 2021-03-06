﻿#region Apache Licence, Version 2.0
/*
 Copyright 2015 Andrey Bulygin.

 Licensed under the Apache License, Version 2.0 (the "License"); 
 you may not use this file except in compliance with the License. 
 You may obtain a copy of the License at 

		http://www.apache.org/licenses/LICENSE-2.0

 Unless required by applicable law or agreed to in writing, software 
 distributed under the License is distributed on an "AS IS" BASIS, 
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
 See the License for the specific language governing permissions 
 and limitations under the License.
 */
#endregion

using System;

namespace RedisBoost.Core.Pipeline
{
	internal struct PipelineItem
	{
		public PipelineItem(byte[][] request, Action<Exception, RedisResponse> callBack, bool isOneWay)
		{
			CallBack = callBack;
			Request = request;
			IsOneWay = isOneWay;
		}
		public PipelineItem(Action<Exception, RedisResponse> callBack)
		{
			IsOneWay = true;
			CallBack = callBack;
			Request = null;
		}

		public bool IsOneWay;
		public byte[][] Request;
		public Action<Exception, RedisResponse> CallBack;
	}
}
