using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='AssistActivity']"
	[global::Android.Runtime.Register ("com/tencent/connect/common/AssistActivity", DoNotGenerateAcw=true)]
	public partial class AssistActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='AssistActivity']/field[@name='EXTRA_INTENT']"
		[Register ("EXTRA_INTENT")]
		public const string ExtraIntent = (string) "openSDK_LOG.AssistActivity.ExtraIntent";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/common/AssistActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AssistActivity); }
		}

		protected AssistActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='AssistActivity']/constructor[@name='AssistActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AssistActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AssistActivity)) {
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

		static IntPtr id_getAssistActivityIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='AssistActivity']/method[@name='getAssistActivityIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAssistActivityIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetAssistActivityIntent (global::Android.Content.Context p0)
		{
			if (id_getAssistActivityIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_getAssistActivityIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAssistActivityIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAssistActivityIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setResultData_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetResultData_ILandroid_content_Intent_Handler ()
		{
			if (cb_setResultData_ILandroid_content_Intent_ == null)
				cb_setResultData_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetResultData_ILandroid_content_Intent_);
			return cb_setResultData_ILandroid_content_Intent_;
		}

		static void n_SetResultData_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Common.AssistActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.AssistActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetResultData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setResultData_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='AssistActivity']/method[@name='setResultData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("setResultData", "(ILandroid/content/Intent;)V", "GetSetResultData_ILandroid_content_Intent_Handler")]
		public virtual unsafe void SetResultData (int p0, global::Android.Content.Intent p1)
		{
			if (id_setResultData_ILandroid_content_Intent_ == IntPtr.Zero)
				id_setResultData_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setResultData", "(ILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResultData_ILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultData", "(ILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}
}
