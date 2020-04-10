namespace XtermSharp {
	/// <summary>
	/// Defines the set of known Csi command codes
	/// TODO: maybe move this to Xterm proper
	/// </summary>
	static class CsiCommandCodes {
		public const int DECAWM = 7;
		public const int ReverseWraparound = 45;
		public const int DECLRMM = 69;


		public const int DeviceStatus = 6;
	}
}
