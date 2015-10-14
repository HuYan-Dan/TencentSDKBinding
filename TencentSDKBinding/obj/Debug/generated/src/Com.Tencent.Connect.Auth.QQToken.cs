using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']"
	[global::Android.Runtime.Register ("com/tencent/connect/auth/QQToken", DoNotGenerateAcw=true)]
	public partial class QQToken : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/field[@name='AUTH_QQ']"
		[Register ("AUTH_QQ")]
		public const int AuthQq = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/field[@name='AUTH_QZONE']"
		[Register ("AUTH_QZONE")]
		public const int AuthQzone = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/field[@name='AUTH_WEB']"
		[Register ("AUTH_WEB")]
		public const int AuthWeb = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/auth/QQToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QQToken); }
		}

		protected QQToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/constructor[@name='QQToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe QQToken (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (QQToken)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		static IntPtr id_setAppId_Ljava_lang_String_;
		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAppId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthSource;
#pragma warning disable 0169
		static Delegate GetGetAuthSourceHandler ()
		{
			if (cb_getAuthSource == null)
				cb_getAuthSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAuthSource);
			return cb_getAuthSource;
		}

		static int n_GetAuthSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuthSource;
		}
#pragma warning restore 0169

		static Delegate cb_setAuthSource_I;
#pragma warning disable 0169
		static Delegate GetSetAuthSource_IHandler ()
		{
			if (cb_setAuthSource_I == null)
				cb_setAuthSource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAuthSource_I);
			return cb_setAuthSource_I;
		}

		static void n_SetAuthSource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AuthSource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthSource;
		static IntPtr id_setAuthSource_I;
		public virtual unsafe int AuthSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='getAuthSource' and count(parameter)=0]"
			[Register ("getAuthSource", "()I", "GetGetAuthSourceHandler")]
			get {
				if (id_getAuthSource == IntPtr.Zero)
					id_getAuthSource = JNIEnv.GetMethodID (class_ref, "getAuthSource", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getAuthSource);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthSource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='setAuthSource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAuthSource", "(I)V", "GetSetAuthSource_IHandler")]
			set {
				if (id_setAuthSource_I == IntPtr.Zero)
					id_setAuthSource_I = JNIEnv.GetMethodID (class_ref, "setAuthSource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAuthSource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthSource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpireTimeInSecond;
#pragma warning disable 0169
		static Delegate GetGetExpireTimeInSecondHandler ()
		{
			if (cb_getExpireTimeInSecond == null)
				cb_getExpireTimeInSecond = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpireTimeInSecond);
			return cb_getExpireTimeInSecond;
		}

		static long n_GetExpireTimeInSecond (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpireTimeInSecond;
		}
#pragma warning restore 0169

		static IntPtr id_getExpireTimeInSecond;
		public virtual unsafe long ExpireTimeInSecond {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='getExpireTimeInSecond' and count(parameter)=0]"
			[Register ("getExpireTimeInSecond", "()J", "GetGetExpireTimeInSecondHandler")]
			get {
				if (id_getExpireTimeInSecond == IntPtr.Zero)
					id_getExpireTimeInSecond = JNIEnv.GetMethodID (class_ref, "getExpireTimeInSecond", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getExpireTimeInSecond);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpireTimeInSecond", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isSessionValid;
#pragma warning disable 0169
		static Delegate GetIsSessionValidHandler ()
		{
			if (cb_isSessionValid == null)
				cb_isSessionValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSessionValid);
			return cb_isSessionValid;
		}

		static bool n_IsSessionValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionValid;
		}
#pragma warning restore 0169

		static IntPtr id_isSessionValid;
		public virtual unsafe bool IsSessionValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='isSessionValid' and count(parameter)=0]"
			[Register ("isSessionValid", "()Z", "GetIsSessionValidHandler")]
			get {
				if (id_isSessionValid == IntPtr.Zero)
					id_isSessionValid = JNIEnv.GetMethodID (class_ref, "isSessionValid", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSessionValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSessionValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpenId;
#pragma warning disable 0169
		static Delegate GetGetOpenIdHandler ()
		{
			if (cb_getOpenId == null)
				cb_getOpenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenId);
			return cb_getOpenId;
		}

		static IntPtr n_GetOpenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpenId);
		}
#pragma warning restore 0169

		static Delegate cb_setOpenId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpenId_Ljava_lang_String_Handler ()
		{
			if (cb_setOpenId_Ljava_lang_String_ == null)
				cb_setOpenId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOpenId_Ljava_lang_String_);
			return cb_setOpenId_Ljava_lang_String_;
		}

		static void n_SetOpenId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOpenId;
		static IntPtr id_setOpenId_Ljava_lang_String_;
		public virtual unsafe string OpenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='getOpenId' and count(parameter)=0]"
			[Register ("getOpenId", "()Ljava/lang/String;", "GetGetOpenIdHandler")]
			get {
				if (id_getOpenId == IntPtr.Zero)
					id_getOpenId = JNIEnv.GetMethodID (class_ref, "getOpenId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOpenId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='setOpenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOpenId", "(Ljava/lang/String;)V", "GetSetOpenId_Ljava_lang_String_Handler")]
			set {
				if (id_setOpenId_Ljava_lang_String_ == IntPtr.Zero)
					id_setOpenId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOpenId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOpenId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOpenId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Auth.QQToken __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQToken']/method[@name='setAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAccessToken (string p0, string p1)
		{
			if (id_setAccessToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAccessToken_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
