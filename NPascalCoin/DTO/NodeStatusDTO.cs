﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPascalCoin.DTO {

	/// <summary>
	/// Information about node
	/// </summary>
	public class NodeStatusDTO : PascalCoinDTO {

		/// <summary>
		/// Must be true, otherwise Node is not ready to execute operations
		/// </summary>
		[JsonProperty("ready")]
		public bool Ready { get; set; }

		/// <summary>
		/// Human readable information about ready or not
		/// </summary>
		[JsonProperty("ready_s")]
		public string ReadyDescriptor { get; set; }


		/// <summary>
		/// Human readable information about node status...Running, downloading blockchain, discovering servers...
		/// </summary>
		[JsonProperty("status_s")]
		public string StatusDescriptor { get; set; }

		/// <summary>
		/// Server port
		/// </summary>
		[JsonProperty("port")]
		public uint Port { get; set; }

		/// <summary>
		/// True when this wallet is locked, false otherwise
		/// </summary>
		[JsonProperty("locked")]
		public bool Locked { get; set; }

		/// <summary>
		/// Timestamp of the Node
		/// </summary>
		[JsonProperty("timestamp")]
		public uint Timestamp { get; set; }

		/// <summary>
		/// Server version
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }

		/// <summary>
		/// JSON Object with protocol versions
		/// </summary>
		[JsonProperty("netprotocol")]
		public NetProtocolDTO NetProtocol { get; set; }

		/// <summary>
		/// Blockchain blocks
		/// </summary>
		[JsonProperty("blocks")]
		public uint Blocks { get; set; }

		/// <summary>
		/// JSON Object with net information
		/// </summary>
		[JsonProperty("netstats")]
		public NetStatsDTO NetStats { get; set; }


		/// <summary>
		/// JSON Array with servers candidates
		/// </summary>
		[JsonProperty("nodeservers")]
		public NodeServerDTO[] NodeServers { get; set; }
	}
}
