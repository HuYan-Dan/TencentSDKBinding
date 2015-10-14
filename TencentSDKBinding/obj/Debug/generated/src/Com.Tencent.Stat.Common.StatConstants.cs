using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']"
	[global::Android.Runtime.Register ("com/tencent/stat/common/StatConstants", DoNotGenerateAcw=true)]
	public partial class StatConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='MTA_COOPERATION_TAG']"
		[Register ("MTA_COOPERATION_TAG")]
		public const string MtaCooperationTag = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='MTA_SERVER']"
		[Register ("MTA_SERVER")]
		public const string MtaServer = (string) "pingma.qq.com:80";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='MTA_STAT_URL']"
		[Register ("MTA_STAT_URL")]
		public const string MtaStatUrl = (string) "/mstat/report";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='SDK_ONLINE_CONFIG_TYPE']"
		[Register ("SDK_ONLINE_CONFIG_TYPE")]
		public const int SdkOnlineConfigType = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='STAT_DB_VERSION']"
		[Register ("STAT_DB_VERSION")]
		public const int StatDbVersion = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='USER_ONLINE_CONFIG_TYPE']"
		[Register ("USER_ONLINE_CONFIG_TYPE")]
		public const int UserOnlineConfigType = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.6.2";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/common/StatConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatConstants); }
		}

		protected StatConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatConstants']/constructor[@name='StatConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatConstants)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
