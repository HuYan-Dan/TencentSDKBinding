using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Web.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']"
	[global::Android.Runtime.Register ("com/tencent/open/web/security/JniInterface", DoNotGenerateAcw=true)]
	public partial class JniInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/web/security/JniInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JniInterface); }
		}

		protected JniInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']/constructor[@name='JniInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JniInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JniInterface)) {
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

		static IntPtr id_BackSpaceChar_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']/method[@name='BackSpaceChar' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("BackSpaceChar", "(ZI)Z", "")]
		public static unsafe bool BackSpaceChar (bool p0, int p1)
		{
			if (id_BackSpaceChar_ZI == IntPtr.Zero)
				id_BackSpaceChar_ZI = JNIEnv.GetStaticMethodID (class_ref, "BackSpaceChar", "(ZI)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_BackSpaceChar_ZI, __args);
			} finally {
			}
		}

		static IntPtr id_clearAllPWD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']/method[@name='clearAllPWD' and count(parameter)=0]"
		[Register ("clearAllPWD", "()Z", "")]
		public static unsafe bool ClearAllPWD ()
		{
			if (id_clearAllPWD == IntPtr.Zero)
				id_clearAllPWD = JNIEnv.GetStaticMethodID (class_ref, "clearAllPWD", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_clearAllPWD);
			} finally {
			}
		}

		static IntPtr id_getPWDKeyToMD5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']/method[@name='getPWDKeyToMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPWDKeyToMD5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPWDKeyToMD5 (string p0)
		{
			if (id_getPWDKeyToMD5_Ljava_lang_String_ == IntPtr.Zero)
				id_getPWDKeyToMD5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPWDKeyToMD5", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPWDKeyToMD5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_insetTextToArray_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='JniInterface']/method[@name='insetTextToArray' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("insetTextToArray", "(ILjava/lang/String;I)Z", "")]
		public static unsafe bool InsetTextToArray (int p0, string p1, int p2)
		{
			if (id_insetTextToArray_ILjava_lang_String_I == IntPtr.Zero)
				id_insetTextToArray_ILjava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "insetTextToArray", "(ILjava/lang/String;I)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_insetTextToArray_ILjava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
