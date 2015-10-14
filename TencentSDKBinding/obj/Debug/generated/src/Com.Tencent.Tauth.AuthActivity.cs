using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tauth']/class[@name='AuthActivity']"
	[global::Android.Runtime.Register ("com/tencent/tauth/AuthActivity", DoNotGenerateAcw=true)]
	public partial class AuthActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='AuthActivity']/field[@name='ACTION_KEY']"
		[Register ("ACTION_KEY")]
		public const string ActionKey = (string) "action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='AuthActivity']/field[@name='ACTION_SHARE_PRIZE']"
		[Register ("ACTION_SHARE_PRIZE")]
		public const string ActionSharePrize = (string) "sharePrize";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tauth/AuthActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthActivity); }
		}

		protected AuthActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tauth']/class[@name='AuthActivity']/constructor[@name='AuthActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AuthActivity)) {
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
