﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassTransit.Cluster.Messages
{
	public class Win : IClusterMessage
	{
		public uint SourceIndex { get; set; }
	}
}