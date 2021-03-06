﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
// ReSharper disable InconsistentNaming

namespace NPascalCoin.DTO {

	/// <summary>
	/// A "Multioperation object" is a JSON object with information about a multioperation.
	/// </summary>
	public class RawMultiOperationDTO : PascalCoinDTO {

		public RawMultiOperationDTO() {
			Senders = new SenderDTO[0];
			Receivers = new ReceiverDTO[0];
			Changers = new ChangerDTO[0];
		}

		/// <summary>
		/// HEXASTRING - Single multioperation in RAW format
		/// </summary>
		[JsonProperty("rawoperations")]
		public string RawOperations { get; set; }

		/// <summary>
		/// Senders of PASC
		/// </summary>
		[JsonProperty("senders")]
		public SenderDTO[] Senders { get; set; }

		/// <summary>
		/// Receivers of PASC
		/// </summary>
		[JsonProperty("receivers")]
		public ReceiverDTO[] Receivers { get; set; }

		/// <summary>
		/// Account information changers
		/// </summary>
		[JsonProperty("changers")]
		public ChangerDTO[] Changers { get; set; }

		/// <summary>
		/// Amount received by receivers
		/// </summary>
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// Equal to "total send" - "total received"
		/// </summary>
		[JsonProperty("fee")]
		public decimal Fee { get; set; }

		/// <summary>
		/// How many accounts in operations are signed. Does not check if signature is valid for a multioperation not included in blockchain
		/// </summary>
		[JsonProperty("signed_count")]
		public int SignedCount { get; set; }

		/// <summary>
		///  How many accounts are pending to be signed
		/// </summary>
		[JsonProperty("not_signed_count")]
		public int NotSignedCount { get; set; }

		/// <summary>
		/// If everybody signed. Does not check if MultiOperation is well formed or can be added to Network because is an offline call
		/// </summary>
		[JsonProperty("signed_can_execute")]
		public bool SignedCanExecute { get; set; }


		/// <summary>
		/// Number of senders.
		/// </summary>
		[JsonProperty("senders_count")]
		public int SendersCount { get; set; }


		/// <summary>
		/// Number of receivers.
		/// </summary>
		[JsonProperty("receivers_count")]
		public int ReceiversCount { get; set; }


		/// <summary>
		/// Number of changers.
		/// </summary>
		[JsonProperty("changesinfo_count")]
		public int ChangersCount { get; set; }
	}
}