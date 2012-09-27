﻿using System.Collections.Generic;
using MassTransit.Cluster.Messages;

namespace MassTransit.Cluster.Bully.Messages
{
    public class Answer : IClusterMessage
	{
        public uint SourceIndex { get; set; }
        public uint[] Clock { get; set; }
	}
}
