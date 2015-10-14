using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']"
	[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthConstants", DoNotGenerateAcw=true)]
	public partial class AuthConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='CANCEL_URI']"
		[Register ("CANCEL_URI")]
		public const string CancelUri = (string) "auth://cancel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='CLOSE_URI']"
		[Register ("CLOSE_URI")]
		public const string CloseUri = (string) "auth://close";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='DOWNLOAD_URI']"
		[Register ("DOWNLOAD_URI")]
		public const string DownloadUri = (string) "download://";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='ON_LOGIN_URI']"
		[Register ("ON_LOGIN_URI")]
		public const string OnLoginUri = (string) "auth://onLoginSubmit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='PROGRESS_URI']"
		[Register ("PROGRESS_URI")]
		public const string ProgressUri = (string) "auth://progress";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/field[@name='REDIRECT_BROWSER_URI']"
		[Register ("REDIRECT_BROWSER_URI")]
		public const string RedirectBrowserUri = (string) "auth://browser";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/auth/AuthConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthConstants); }
		}

		protected AuthConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthConstants']/constructor[@name='AuthConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AuthConstants)) {
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
