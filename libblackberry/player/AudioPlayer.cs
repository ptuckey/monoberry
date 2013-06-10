using System;
using System.Runtime.InteropServices;
using Hyena;

namespace BlackBerry.Renderer
{
	public class AudioPlayer : IDisposable
	{
		private const string TAG = "AudioPlayer";

		// Read, write, execute/search
		private const int S_IRUSR = 000400;

		// Execute/search permission
		private const int S_IXUSR = 000100;

		[DllImport ("mmrndclient")]
		static extern IntPtr mmr_connect(string name);

		[DllImport ("mmrndclient")]
		static extern IntPtr mmr_context_create(IntPtr connection, string name, uint flags, uint mode);

		[DllImport ("mmrndclient")]
		static extern int mmr_output_attach (IntPtr ctxt, string url, string type);

		[DllImport ("mmrndclient")]
		static extern int mmr_output_parameters(IntPtr ctxt, int output_id, IntPtr parms);
		
		[DllImport ("mmrndclient")]
		static extern int mmr_input_attach(IntPtr ctxt, string url, string type);

		[DllImport ("mmrndclient")]
		static extern int mmr_play(IntPtr ctxt);

		static bool initialized = false;

		public AudioPlayer()
		{
			Initialize();
		}

		static void Initialize()
		{
			if (initialized) {
				return;
			}
			PlatformServices.Initialize ();

			initialized = true;
		}

		public void Play(string url)
		{
			var connection = mmr_connect(null);
			uint mode = S_IRUSR | S_IXUSR;
			var ctxt = mmr_context_create(connection, "testplayer", 0, mode);
			mmr_output_attach(ctxt, "audio:default", "audio");
			var inputType = "track";
			mmr_input_attach(ctxt, url, inputType);
			mmr_play(ctxt);
		}

		#region IDisposable implementation

		void IDisposable.Dispose()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

