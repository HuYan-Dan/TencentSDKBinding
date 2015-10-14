using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']"
	[global::Android.Runtime.Register ("com/tencent/tauth/Tencent", DoNotGenerateAcw=true)]
	public partial class Tencent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/field[@name='REQUEST_LOGIN']"
		[Register ("REQUEST_LOGIN")]
		public const int RequestLogin = (int) 10001;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tauth/Tencent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tencent); }
		}

		protected Tencent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getAccessToken' and count(parameter)=0]"
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getAppId' and count(parameter)=0]"
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
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static long n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresIn;
		public virtual unsafe long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()J", "GetGetExpiresInHandler")]
			get {
				if (id_getExpiresIn == IntPtr.Zero)
					id_getExpiresIn = JNIEnv.GetMethodID (class_ref, "getExpiresIn", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getExpiresIn);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiresIn", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionValid;
		}
#pragma warning restore 0169

		static IntPtr id_isSessionValid;
		public virtual unsafe bool IsSessionValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='isSessionValid' and count(parameter)=0]"
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOpenId;
		static IntPtr id_setOpenId_Ljava_lang_String_;
		public virtual unsafe string OpenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getOpenId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='setOpenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QQToken);
		}
#pragma warning restore 0169

		static IntPtr id_getQQToken;
		public virtual unsafe global::Com.Tencent.Connect.Auth.QQToken QQToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getQQToken' and count(parameter)=0]"
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

		static Delegate cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetAddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_AddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddToQQFavorites (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='addToQQFavorites' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetAddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void AddToQQFavorites (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetAsk_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Ask (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='ask' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("ask", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetAsk_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Ask (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "ask", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_ask_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ask", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetBindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_BindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindQQGroup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='bindQQGroup' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetBindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void BindQQGroup (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetBrag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Brag (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='brag' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("brag", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetBrag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Brag (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "brag", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_brag_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "brag", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetChallenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Challenge (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='challenge' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("challenge", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetChallenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Challenge (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "challenge", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_challenge_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "challenge", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetCheckActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_CheckActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CheckActivityAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='checkActivityAvailable' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("checkActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetCheckActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void CheckActivityAvailable (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "checkActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckLogin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkLogin_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='checkLogin' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
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

		static Delegate cb_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetCheckPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_Handler ()
		{
			if (cb_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_ == null)
				cb_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_);
			return cb_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_;
		}

		static bool n_CheckPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckPrizeByIntent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='checkPrizeByIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.content.Intent']]"
		[Register ("checkPrizeByIntent", "(Landroid/app/Activity;Landroid/content/Intent;)Z", "GetCheckPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_Handler")]
		public virtual unsafe bool CheckPrizeByIntent (global::Android.App.Activity p0, global::Android.Content.Intent p1)
		{
			if (id_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_ == IntPtr.Zero)
				id_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "checkPrizeByIntent", "(Landroid/app/Activity;Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_checkPrizeByIntent_Landroid_app_Activity_Landroid_content_Intent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkPrizeByIntent", "(Landroid/app/Activity;Landroid/content/Intent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createInstance_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='createInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/tencent/tauth/Tencent;", "")]
		public static unsafe global::Com.Tencent.Tauth.Tencent CreateInstance (string p0, global::Android.Content.Context p1)
		{
			if (id_createInstance_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createInstance", "(Ljava/lang/String;Landroid/content/Context;)Lcom/tencent/tauth/Tencent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Tencent.Tauth.Tencent __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInstance_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_DeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteLocation (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='deleteLocation' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetDeleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int DeleteLocation (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_deleteLocation_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteLocation", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetExchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ExchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ExchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ExchangePrize (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='exchangePrize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("exchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetExchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ExchangePrize (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "exchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_exchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetWPAUserOnlineState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='getWPAUserOnlineState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getWPAUserOnlineState", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetGetWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetWPAUserOnlineState (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getWPAUserOnlineState", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getWPAUserOnlineState_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWPAUserOnlineState", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Gift (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='gift' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("gift", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetGift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Gift (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "gift", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_gift_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gift", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGrade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_Grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Grade (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='grade' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("grade", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetGrade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void Grade (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "grade", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_grade_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grade", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetHandleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == null)
				cb_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_);
			return cb_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_HandleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleLoginData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='handleLoginData' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Obsolete (@"deprecated")]
		[Register ("handleLoginData", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V", "GetHandleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void HandleLoginData (global::Android.Content.Intent p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "handleLoginData", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleLoginData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleLoginData", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_handleResultData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='handleResultData' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("handleResultData", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V", "")]
		public static unsafe void HandleResultData (global::Android.Content.Intent p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_handleResultData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_handleResultData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetStaticMethodID (class_ref, "handleResultData", "(Landroid/content/Intent;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleResultData_Landroid_content_Intent_Lcom_tencent_tauth_IUiListener_, __args);
			} finally {
			}
		}

		static Delegate cb_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetInvite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Invite (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='invite' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("invite", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetInvite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Invite (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "invite", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_invite_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invite", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isSupportSSOLogin_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetIsSupportSSOLogin_Landroid_app_Activity_Handler ()
		{
			if (cb_isSupportSSOLogin_Landroid_app_Activity_ == null)
				cb_isSupportSSOLogin_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupportSSOLogin_Landroid_app_Activity_);
			return cb_isSupportSSOLogin_Landroid_app_Activity_;
		}

		static bool n_IsSupportSSOLogin_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupportSSOLogin (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSupportSSOLogin_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='isSupportSSOLogin' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isSupportSSOLogin", "(Landroid/app/Activity;)Z", "GetIsSupportSSOLogin_Landroid_app_Activity_Handler")]
		public virtual unsafe bool IsSupportSSOLogin (global::Android.App.Activity p0)
		{
			if (id_isSupportSSOLogin_Landroid_app_Activity_ == IntPtr.Zero)
				id_isSupportSSOLogin_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "isSupportSSOLogin", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isSupportSSOLogin_Landroid_app_Activity_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupportSSOLogin", "(Landroid/app/Activity;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJoinQQGroup_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_JoinQQGroup_Landroid_app_Activity_Ljava_lang_String_);
			return cb_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_;
		}

		static bool n_JoinQQGroup_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.JoinQQGroup (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='joinQQGroup' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("joinQQGroup", "(Landroid/app/Activity;Ljava/lang/String;)Z", "GetJoinQQGroup_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe bool JoinQQGroup (global::Android.App.Activity p0, string p1)
		{
			if (id_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "joinQQGroup", "(Landroid/app/Activity;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_joinQQGroup_Landroid_app_Activity_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "joinQQGroup", "(Landroid/app/Activity;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Login (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='login' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
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

		static Delegate cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetLogin_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Login (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='login' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetLogin_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Login (global::Android.Support.V4.App.Fragment p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_login_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetLoginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_LoginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoginServerSide (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='loginServerSide' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("loginServerSide", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetLoginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int LoginServerSide (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "loginServerSide", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_loginServerSide_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loginServerSide", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetLoginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_LoginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoginServerSide (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='loginServerSide' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("loginServerSide", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetLoginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int LoginServerSide (global::Android.Support.V4.App.Fragment p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "loginServerSide", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_loginServerSide_Landroid_support_v4_app_Fragment_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loginServerSide", "(Landroid/support/v4/app/Fragment;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='loginWithOEM' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetMakeFriend_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeFriend_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_MakeFriend_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MakeFriend (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='makeFriend' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetMakeFriend_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void MakeFriend (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
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

		static IntPtr id_onActivityResultData_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='onActivityResultData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent'] and parameter[4][@type='com.tencent.tauth.IUiListener']]"
		[Register ("onActivityResultData", "(IILandroid/content/Intent;Lcom/tencent/tauth/IUiListener;)Z", "")]
		public static unsafe bool OnActivityResultData (int p0, int p1, global::Android.Content.Intent p2, global::Com.Tencent.Tauth.IUiListener p3)
		{
			if (id_onActivityResultData_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_onActivityResultData_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetStaticMethodID (class_ref, "onActivityResultData", "(IILandroid/content/Intent;Lcom/tencent/tauth/IUiListener;)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_onActivityResultData_IILandroid_content_Intent_Lcom_tencent_tauth_IUiListener_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetQueryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_QueryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.QueryUnexchangePrize (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='queryUnexchangePrize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("queryUnexchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetQueryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void QueryUnexchangePrize (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "queryUnexchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_queryUnexchangePrize_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryUnexchangePrize", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReAuth (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reAuth_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='reAuth' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
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

		static Delegate cb_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetReactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Reactive (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='reactive' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("reactive", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetReactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Reactive (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "reactive", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_reactive_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reactive", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_releaseResource;
#pragma warning disable 0169
		static Delegate GetReleaseResourceHandler ()
		{
			if (cb_releaseResource == null)
				cb_releaseResource = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseResource);
			return cb_releaseResource;
		}

		static void n_ReleaseResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseResource ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseResource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='releaseResource' and count(parameter)=0]"
		[Register ("releaseResource", "()V", "GetReleaseResourceHandler")]
		public virtual unsafe void ReleaseResource ()
		{
			if (id_releaseResource == IntPtr.Zero)
				id_releaseResource = JNIEnv.GetMethodID (class_ref, "releaseResource", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_releaseResource);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseResource", "()V"));
			} finally {
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportDAU ();
		}
#pragma warning restore 0169

		static IntPtr id_reportDAU;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='reportDAU' and count(parameter)=0]"
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

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Request (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='request' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Lorg/json/JSONObject;", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Json.JSONObject Request (string p0, global::Android.OS.Bundle p1, string p2)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRequestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_ == null)
				cb_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_);
			return cb_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_;
		}

		static void n_RequestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IRequestListener p3 = (global::Com.Tencent.Tauth.IRequestListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.RequestAsync (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='requestAsync' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.tauth.IRequestListener'] and parameter[5][@type='java.lang.Object']]"
		[Register ("requestAsync", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/tencent/tauth/IRequestListener;Ljava/lang/Object;)V", "GetRequestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_Handler")]
		public virtual unsafe void RequestAsync (string p0, global::Android.OS.Bundle p1, string p2, global::Com.Tencent.Tauth.IRequestListener p3, global::Java.Lang.Object p4)
		{
			if (id_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "requestAsync", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/tencent/tauth/IRequestListener;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestAsync_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestAsync", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/tencent/tauth/IRequestListener;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_SearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SearchNearby (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='searchNearby' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetSearchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int SearchNearby (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_searchNearby_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchNearby", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendToMyComputer (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='sendToMyComputer' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SendToMyComputer (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
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
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='setAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAvatar (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='setAvatar' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SetAvatar (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II;
#pragma warning disable 0169
		static Delegate GetSetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_IIHandler ()
		{
			if (cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II == null)
				cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_SetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II);
			return cb_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II;
		}

		static void n_SetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAvatar (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='setAvatar' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;II)V", "GetSetAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_IIHandler")]
		public virtual unsafe void SetAvatar (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2, int p3, int p4)
		{
			if (id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II == IntPtr.Zero)
				id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II = JNIEnv.GetMethodID (class_ref, "setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;II)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAvatar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SharePrizeToQQ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='sharePrizeToQQ' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SharePrizeToQQ (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShareToQQ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='shareToQQ' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShareToQQ (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShareToQzone (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='shareToQzone' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("shareToQzone", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShareToQzone (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "shareToQzone", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToQzone_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToQzone", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShareToTroopBar (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='shareToTroopBar' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShareToTroopBar (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShowTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShowTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowTaskGuideWindow (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='showTaskGuideWindow' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("showTaskGuideWindow", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShowTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShowTaskGuideWindow (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "showTaskGuideWindow", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTaskGuideWindow", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startAppbar_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartAppbar_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_startAppbar_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_startAppbar_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartAppbar_Landroid_app_Activity_Ljava_lang_String_);
			return cb_startAppbar_Landroid_app_Activity_Ljava_lang_String_;
		}

		static void n_StartAppbar_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbar (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbar_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='startAppbar' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("startAppbar", "(Landroid/app/Activity;Ljava/lang/String;)V", "GetStartAppbar_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe void StartAppbar (global::Android.App.Activity p0, string p1)
		{
			if (id_startAppbar_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_startAppbar_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startAppbar", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAppbar_Landroid_app_Activity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAppbar", "(Landroid/app/Activity;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartAppbarLabel_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartAppbarLabel_Landroid_app_Activity_Ljava_lang_String_);
			return cb_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_;
		}

		static void n_StartAppbarLabel_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbarLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='startAppbarLabel' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("startAppbarLabel", "(Landroid/app/Activity;Ljava/lang/String;)V", "GetStartAppbarLabel_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe void StartAppbarLabel (global::Android.App.Activity p0, string p1)
		{
			if (id_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startAppbarLabel", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAppbarLabel", "(Landroid/app/Activity;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartAppbarThread_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartAppbarThread_Landroid_app_Activity_Ljava_lang_String_);
			return cb_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_;
		}

		static void n_StartAppbarThread_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbarThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='startAppbarThread' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("startAppbarThread", "(Landroid/app/Activity;Ljava/lang/String;)V", "GetStartAppbarThread_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe void StartAppbarThread (global::Android.App.Activity p0, string p1)
		{
			if (id_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startAppbarThread", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAppbarThread", "(Landroid/app/Activity;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_StartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_);
			return cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_StartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartWPAConversation (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='startWPAConversation' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)I", "GetStartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int StartWPAConversation (global::Android.App.Activity p0, string p1, string p2)
		{
			if (id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_StartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_StartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.StartWPAConversation (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='startWPAConversation' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetStartWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int StartWPAConversation (global::Android.App.Activity p0, string p1, string p2, string p3)
		{
			if (id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_startWPAConversation_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startWPAConversation", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetStory_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_Story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Story (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='story' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("story", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I", "GetStory_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int Story (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "story", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_story_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "story", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetVoice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_Voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tauth.Tencent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.Tencent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Voice (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/class[@name='Tencent']/method[@name='voice' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("voice", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetVoice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void Voice (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "voice", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_voice_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "voice", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
