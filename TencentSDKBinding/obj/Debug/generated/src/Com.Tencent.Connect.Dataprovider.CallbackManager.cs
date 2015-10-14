using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Dataprovider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']"
	[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/CallbackManager", DoNotGenerateAcw=true)]
	public sealed partial class CallbackManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/dataprovider/CallbackManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallbackManager); }
		}

		internal CallbackManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/constructor[@name='CallbackManager' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe CallbackManager (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CallbackManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_isCallFromTencentApp;
		public unsafe bool IsCallFromTencentApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='isCallFromTencentApp' and count(parameter)=0]"
			[Register ("isCallFromTencentApp", "()Z", "GetIsCallFromTencentAppHandler")]
			get {
				if (id_isCallFromTencentApp == IntPtr.Zero)
					id_isCallFromTencentApp = JNIEnv.GetMethodID (class_ref, "isCallFromTencentApp", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCallFromTencentApp);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestDateTypeFlag;
		public unsafe int RequestDateTypeFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='getRequestDateTypeFlag' and count(parameter)=0]"
			[Register ("getRequestDateTypeFlag", "()I", "GetGetRequestDateTypeFlagHandler")]
			get {
				if (id_getRequestDateTypeFlag == IntPtr.Zero)
					id_getRequestDateTypeFlag = JNIEnv.GetMethodID (class_ref, "getRequestDateTypeFlag", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getRequestDateTypeFlag);
				} finally {
				}
			}
		}

		static IntPtr id_isSupportType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='isSupportType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSupportType", "(I)Z", "")]
		public unsafe bool IsSupportType (int p0)
		{
			if (id_isSupportType_I == IntPtr.Zero)
				id_isSupportType_I = JNIEnv.GetMethodID (class_ref, "isSupportType", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_isSupportType_I, __args);
			} finally {
			}
		}

		static IntPtr id_sendTextAndImagePath_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='sendTextAndImagePath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendTextAndImagePath", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public unsafe int SendTextAndImagePath (string p0, string p1)
		{
			if (id_sendTextAndImagePath_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTextAndImagePath_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendTextAndImagePath", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_sendTextAndImagePath_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendTextAndVideoPath_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='sendTextAndVideoPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendTextAndVideoPath", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public unsafe int SendTextAndVideoPath (string p0, string p1)
		{
			if (id_sendTextAndVideoPath_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTextAndVideoPath_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendTextAndVideoPath", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_sendTextAndVideoPath_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendTextOnly_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='CallbackManager']/method[@name='sendTextOnly' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendTextOnly", "(Ljava/lang/String;)I", "")]
		public unsafe int SendTextOnly (string p0)
		{
			if (id_sendTextOnly_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTextOnly_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendTextOnly", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_sendTextOnly_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
