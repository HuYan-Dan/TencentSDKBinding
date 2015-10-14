using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']"
	[global::Android.Runtime.Register ("com/tencent/connect/auth/QQAuth", DoNotGenerateAcw=true)]
	public partial class QQAuth : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/auth/QQAuth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QQAuth); }
		}

		protected QQAuth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionValid;
		}
#pragma warning restore 0169

		static IntPtr id_isSessionValid;
		public virtual unsafe bool IsSessionValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='isSessionValid' and count(parameter)=0]"
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

		static Delegate cb_getQQToken;
#pragma warning disable 0169
		static Delegate GetGetQQTokenHandler ()
		{
			if (cb_getQQToken == null)
				cb_getQQToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQQToken);
			return cb_getQQToken;
		}

		static IntPtr n_GetQQToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QQToken);
		}
#pragma warning restore 0169

		static IntPtr id_getQQToken;
		public virtual unsafe global::Com.Tencent.Connect.Auth.QQToken QQToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='getQQToken' and count(parameter)=0]"
			[Register ("getQQToken", "()Lcom/tencent/connect/auth/QQToken;", "GetGetQQTokenHandler")]
			get {
				if (id_getQQToken == IntPtr.Zero)
					id_getQQToken = JNIEnv.GetMethodID (class_ref, "getQQToken", "()Lcom/tencent/connect/auth/QQToken;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (JNIEnv.CallObjectMethod  (Handle, id_getQQToken), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQQToken", "()Lcom/tencent/connect/auth/QQToken;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkLogin_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetCheckLogin_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_checkLogin_Lcom_tencent_tauth_IUiListener_ == null)
				cb_checkLogin_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckLogin_Lcom_tencent_tauth_IUiListener_);
			return cb_checkLogin_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_CheckLogin_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckLogin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkLogin_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='checkLogin' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("checkLogin", "(Lcom/tencent/tauth/IUiListener;)V", "GetCheckLogin_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void CheckLogin (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_checkLogin_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_checkLogin_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "checkLogin", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkLogin_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkLogin", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_createInstance_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='createInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/tencent/connect/auth/QQAuth;", "")]
		public static unsafe global::Com.Tencent.Connect.Auth.QQAuth CreateInstance (string p0, global::Android.Content.Context p1)
		{
			if (id_createInstance_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/tencent/connect/auth/QQAuth;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Tencent.Connect.Auth.QQAuth __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInstance_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Login (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='login' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Login (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Handler ()
		{
			if (cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ == null)
				cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_);
			return cb_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
		}

		static int n_Login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Login (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='login' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='java.lang.String']]"
		[Register ("login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I", "GetLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Handler")]
		public virtual unsafe int Login (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2, string p3)
		{
			if (id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Handler ()
		{
			if (cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ == null)
				cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_);
			return cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
		}

		static int n_Login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Login (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='login' and count(parameter)=4 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='java.lang.String']]"
		[Register ("login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I", "GetLogin_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Handler")]
		public virtual unsafe int Login (global::Android.Support.V4.App.Fragment p0, string p1, global::Com.Tencent.Tauth.IUiListener p2, string p3)
		{
			if (id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_LoginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoginWithOEM (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='loginWithOEM' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("loginWithOEM", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetLoginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int LoginWithOEM (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2, string p3, string p4, string p5)
		{
			if (id_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loginWithOEM", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_loginWithOEM_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loginWithOEM", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_logout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Handler ()
		{
			if (cb_logout_Landroid_content_Context_ == null)
				cb_logout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_);
			return cb_logout_Landroid_content_Context_;
		}

		static void n_Logout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("logout", "(Landroid/content/Context;)V", "GetLogout_Landroid_content_Context_Handler")]
		public virtual unsafe void Logout (global::Android.Content.Context p0)
		{
			if (id_logout_Landroid_content_Context_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logout_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, bool>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static bool n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)Z", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe bool OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetReAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_ReAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReAuth (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='reAuth' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("reAuth", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetReAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int ReAuth (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "reAuth", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reAuth", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reportDAU;
#pragma warning disable 0169
		static Delegate GetReportDAUHandler ()
		{
			if (cb_reportDAU == null)
				cb_reportDAU = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReportDAU);
			return cb_reportDAU;
		}

		static void n_ReportDAU (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportDAU ();
		}
#pragma warning restore 0169

		static IntPtr id_reportDAU;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='reportDAU' and count(parameter)=0]"
		[Register ("reportDAU", "()V", "GetReportDAUHandler")]
		public virtual unsafe void ReportDAU ()
		{
			if (id_reportDAU == IntPtr.Zero)
				id_reportDAU = JNIEnv.GetMethodID (class_ref, "reportDAU", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reportDAU);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportDAU", "()V"));
			} finally {
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
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='setAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_setOpenId_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpenId_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_setOpenId_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_setOpenId_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOpenId_Landroid_content_Context_Ljava_lang_String_);
			return cb_setOpenId_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_SetOpenId_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Connect.Auth.QQAuth __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOpenId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOpenId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='QQAuth']/method[@name='setOpenId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setOpenId", "(Landroid/content/Context;Ljava/lang/String;)V", "GetSetOpenId_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOpenId (global::Android.Content.Context p0, string p1)
		{
			if (id_setOpenId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setOpenId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOpenId", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOpenId_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOpenId", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
