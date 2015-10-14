using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Web.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']"
	[global::Android.Runtime.Register ("com/tencent/open/web/security/SecureJsInterface", DoNotGenerateAcw=true)]
	public partial class SecureJsInterface : global::Com.Tencent.Open.A.B {


		static IntPtr isPWDEdit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/field[@name='isPWDEdit']"
		[Register ("isPWDEdit")]
		public static bool IsPWDEdit {
			get {
				if (isPWDEdit_jfieldId == IntPtr.Zero)
					isPWDEdit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isPWDEdit", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isPWDEdit_jfieldId);
			}
			set {
				if (isPWDEdit_jfieldId == IntPtr.Zero)
					isPWDEdit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isPWDEdit", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isPWDEdit_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/web/security/SecureJsInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecureJsInterface); }
		}

		protected SecureJsInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/constructor[@name='SecureJsInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecureJsInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SecureJsInterface)) {
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

		static Delegate cb_getMD5FromNative;
#pragma warning disable 0169
		static Delegate GetGetMD5FromNativeHandler ()
		{
			if (cb_getMD5FromNative == null)
				cb_getMD5FromNative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMD5FromNative);
			return cb_getMD5FromNative;
		}

		static IntPtr n_GetMD5FromNative (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Web.Security.SecureJsInterface __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Web.Security.SecureJsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MD5FromNative);
		}
#pragma warning restore 0169

		static IntPtr id_getMD5FromNative;
		public virtual unsafe string MD5FromNative {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/method[@name='getMD5FromNative' and count(parameter)=0]"
			[Register ("getMD5FromNative", "()Ljava/lang/String;", "GetGetMD5FromNativeHandler")]
			get {
				if (id_getMD5FromNative == IntPtr.Zero)
					id_getMD5FromNative = JNIEnv.GetMethodID (class_ref, "getMD5FromNative", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMD5FromNative), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMD5FromNative", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearAllEdit;
#pragma warning disable 0169
		static Delegate GetClearAllEditHandler ()
		{
			if (cb_clearAllEdit == null)
				cb_clearAllEdit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAllEdit);
			return cb_clearAllEdit;
		}

		static void n_ClearAllEdit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Web.Security.SecureJsInterface __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Web.Security.SecureJsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllEdit ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAllEdit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/method[@name='clearAllEdit' and count(parameter)=0]"
		[Register ("clearAllEdit", "()V", "GetClearAllEditHandler")]
		public virtual unsafe void ClearAllEdit ()
		{
			if (id_clearAllEdit == IntPtr.Zero)
				id_clearAllEdit = JNIEnv.GetMethodID (class_ref, "clearAllEdit", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearAllEdit);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllEdit", "()V"));
			} finally {
			}
		}

		static Delegate cb_curPosFromJS_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCurPosFromJS_Ljava_lang_String_Handler ()
		{
			if (cb_curPosFromJS_Ljava_lang_String_ == null)
				cb_curPosFromJS_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CurPosFromJS_Ljava_lang_String_);
			return cb_curPosFromJS_Ljava_lang_String_;
		}

		static void n_CurPosFromJS_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Web.Security.SecureJsInterface __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Web.Security.SecureJsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurPosFromJS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_curPosFromJS_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/method[@name='curPosFromJS' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("curPosFromJS", "(Ljava/lang/String;)V", "GetCurPosFromJS_Ljava_lang_String_Handler")]
		public virtual unsafe void CurPosFromJS (string p0)
		{
			if (id_curPosFromJS_Ljava_lang_String_ == IntPtr.Zero)
				id_curPosFromJS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "curPosFromJS", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_curPosFromJS_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "curPosFromJS", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isPasswordEdit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsPasswordEdit_Ljava_lang_String_Handler ()
		{
			if (cb_isPasswordEdit_Ljava_lang_String_ == null)
				cb_isPasswordEdit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IsPasswordEdit_Ljava_lang_String_);
			return cb_isPasswordEdit_Ljava_lang_String_;
		}

		static void n_IsPasswordEdit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Web.Security.SecureJsInterface __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Web.Security.SecureJsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsPasswordEdit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isPasswordEdit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.web.security']/class[@name='SecureJsInterface']/method[@name='isPasswordEdit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPasswordEdit", "(Ljava/lang/String;)V", "GetIsPasswordEdit_Ljava_lang_String_Handler")]
		public virtual unsafe void IsPasswordEdit (string p0)
		{
			if (id_isPasswordEdit_Ljava_lang_String_ == IntPtr.Zero)
				id_isPasswordEdit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isPasswordEdit", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_isPasswordEdit_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPasswordEdit", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
