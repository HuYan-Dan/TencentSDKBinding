using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']"
	[global::Android.Runtime.Register ("com/tencent/connect/UserInfo", DoNotGenerateAcw=true)]
	public partial class UserInfo : global::Com.Tencent.Connect.Common.BaseApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/field[@name='GRAPH_OPEN_ID']"
		[Register ("GRAPH_OPEN_ID")]
		public const string GraphOpenId = (string) "oauth2.0/m_me";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/UserInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserInfo); }
		}

		protected UserInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/constructor[@name='UserInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe UserInfo (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UserInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/constructor[@name='UserInfo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe UserInfo (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UserInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_getOpenId_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetOpenId_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getOpenId_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getOpenId_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetOpenId_Lcom_tencent_tauth_IUiListener_);
			return cb_getOpenId_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetOpenId_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetOpenId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenId_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/method[@name='getOpenId' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getOpenId", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetOpenId_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetOpenId (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getOpenId_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getOpenId_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getOpenId", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getOpenId_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenId", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTenPayAddr_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetTenPayAddr_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getTenPayAddr_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getTenPayAddr_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetTenPayAddr_Lcom_tencent_tauth_IUiListener_);
			return cb_getTenPayAddr_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetTenPayAddr_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetTenPayAddr (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getTenPayAddr_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/method[@name='getTenPayAddr' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getTenPayAddr", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetTenPayAddr_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetTenPayAddr (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getTenPayAddr_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getTenPayAddr_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getTenPayAddr", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getTenPayAddr_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTenPayAddr", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getUserInfo_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetUserInfo_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getUserInfo_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getUserInfo_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetUserInfo_Lcom_tencent_tauth_IUiListener_);
			return cb_getUserInfo_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetUserInfo_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetUserInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/method[@name='getUserInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getUserInfo", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetUserInfo_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetUserInfo (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getUserInfo_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getUserInfo_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getUserInfo", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getUserInfo_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getVipUserInfo_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetVipUserInfo_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getVipUserInfo_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getVipUserInfo_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetVipUserInfo_Lcom_tencent_tauth_IUiListener_);
			return cb_getVipUserInfo_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetVipUserInfo_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetVipUserInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getVipUserInfo_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/method[@name='getVipUserInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getVipUserInfo", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetVipUserInfo_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetVipUserInfo (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getVipUserInfo_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getVipUserInfo_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getVipUserInfo", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getVipUserInfo_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVipUserInfo", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetVipUserRichInfo_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetVipUserRichInfo_Lcom_tencent_tauth_IUiListener_);
			return cb_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetVipUserRichInfo_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetVipUserRichInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect']/class[@name='UserInfo']/method[@name='getVipUserRichInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getVipUserRichInfo", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetVipUserRichInfo_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetVipUserRichInfo (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getVipUserRichInfo", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getVipUserRichInfo_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVipUserRichInfo", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
