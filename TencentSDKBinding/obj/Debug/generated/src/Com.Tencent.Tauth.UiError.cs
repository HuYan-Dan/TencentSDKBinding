using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tauth']/class[@name='UiError']"
	[global::Android.Runtime.Register ("com/tencent/tauth/UiError", DoNotGenerateAcw=true)]
	public partial class UiError : global::Java.Lang.Object {


		static IntPtr errorCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='UiError']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				return JNIEnv.GetIntField (Handle, errorCode_jfieldId);
			}
			set {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				try {
					JNIEnv.SetField (Handle, errorCode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr errorDetail_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='UiError']/field[@name='errorDetail']"
		[Register ("errorDetail")]
		public string ErrorDetail {
			get {
				if (errorDetail_jfieldId == IntPtr.Zero)
					errorDetail_jfieldId = JNIEnv.GetFieldID (class_ref, "errorDetail", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, errorDetail_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (errorDetail_jfieldId == IntPtr.Zero)
					errorDetail_jfieldId = JNIEnv.GetFieldID (class_ref, "errorDetail", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, errorDetail_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr errorMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='UiError']/field[@name='errorMessage']"
		[Register ("errorMessage")]
		public string ErrorMessage {
			get {
				if (errorMessage_jfieldId == IntPtr.Zero)
					errorMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "errorMessage", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, errorMessage_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (errorMessage_jfieldId == IntPtr.Zero)
					errorMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "errorMessage", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, errorMessage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tauth/UiError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UiError); }
		}

		protected UiError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tauth']/class[@name='UiError']/constructor[@name='UiError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe UiError (int p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (UiError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
