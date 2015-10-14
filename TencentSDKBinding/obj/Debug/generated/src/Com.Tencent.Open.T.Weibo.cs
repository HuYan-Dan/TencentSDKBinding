using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.T {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']"
	[global::Android.Runtime.Register ("com/tencent/open/t/Weibo", DoNotGenerateAcw=true)]
	public partial class Weibo : global::Com.Tencent.Connect.Common.BaseApi {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/t/Weibo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Weibo); }
		}

		protected Weibo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/constructor[@name='Weibo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe Weibo (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Weibo)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/constructor[@name='Weibo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe Weibo (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Weibo)) {
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

		static Delegate cb_atFriends_ILcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetAtFriends_ILcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_atFriends_ILcom_tencent_tauth_IUiListener_ == null)
				cb_atFriends_ILcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AtFriends_ILcom_tencent_tauth_IUiListener_);
			return cb_atFriends_ILcom_tencent_tauth_IUiListener_;
		}

		static void n_AtFriends_ILcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AtFriends (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_atFriends_ILcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='atFriends' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("atFriends", "(ILcom/tencent/tauth/IUiListener;)V", "GetAtFriends_ILcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void AtFriends (int p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_atFriends_ILcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_atFriends_ILcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "atFriends", "(ILcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_atFriends_ILcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "atFriends", "(ILcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_DeleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='deleteText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("deleteText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetDeleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void DeleteText (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "deleteText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getWeiboInfo_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetGetWeiboInfo_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_getWeiboInfo_Lcom_tencent_tauth_IUiListener_ == null)
				cb_getWeiboInfo_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetWeiboInfo_Lcom_tencent_tauth_IUiListener_);
			return cb_getWeiboInfo_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_GetWeiboInfo_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetWeiboInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getWeiboInfo_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='getWeiboInfo' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("getWeiboInfo", "(Lcom/tencent/tauth/IUiListener;)V", "GetGetWeiboInfo_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void GetWeiboInfo (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_getWeiboInfo_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_getWeiboInfo_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "getWeiboInfo", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getWeiboInfo_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeiboInfo", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetNickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_ == null)
				cb_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_NickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_);
			return cb_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_;
		}

		static void n_NickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.NickTips (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='nickTips' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("nickTips", "(Ljava/lang/String;ILcom/tencent/tauth/IUiListener;)V", "GetNickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void NickTips (string p0, int p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "nickTips", "(Ljava/lang/String;ILcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_nickTips_Ljava_lang_String_ILcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nickTips", "(Ljava/lang/String;ILcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendPicText (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='sendPicText' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sendPicText", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetSendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SendPicText (string p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sendPicText", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendPicText_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPicText", "(Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.T.Weibo __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.T.Weibo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p1 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.t']/class[@name='Weibo']/method[@name='sendText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sendText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetSendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SendText (string p0, global::Com.Tencent.Tauth.IUiListener p1)
		{
			if (id_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sendText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendText_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendText", "(Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
