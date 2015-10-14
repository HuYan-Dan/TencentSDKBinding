using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatMid']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatMid", DoNotGenerateAcw=true)]
	public partial class StatMid : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatMid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatMid); }
		}

		protected StatMid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatMid']/constructor[@name='StatMid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatMid ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatMid)) {
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

		static IntPtr id_getDeviceInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatMid']/method[@name='getDeviceInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceInfo", "(Landroid/content/Context;)Lcom/tencent/stat/DeviceInfo;", "")]
		public static unsafe global::Com.Tencent.Stat.DeviceInfo GetDeviceInfo (global::Android.Content.Context p0)
		{
			if (id_getDeviceInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceInfo", "(Landroid/content/Context;)Lcom/tencent/stat/DeviceInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Tencent.Stat.DeviceInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatMid']/method[@name='getMid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMid (global::Android.Content.Context p0)
		{
			if (id_getMid_Landroid_content_Context_ == IntPtr.Zero)
				id_getMid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_updateDeviceInfo_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatMid']/method[@name='updateDeviceInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateDeviceInfo", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void UpdateDeviceInfo (global::Android.Content.Context p0, string p1)
		{
			if (id_updateDeviceInfo_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDeviceInfo_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateDeviceInfo", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateDeviceInfo_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
