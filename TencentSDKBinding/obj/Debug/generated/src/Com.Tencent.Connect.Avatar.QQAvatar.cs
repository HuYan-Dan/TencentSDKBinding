using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Avatar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='QQAvatar']"
	[global::Android.Runtime.Register ("com/tencent/connect/avatar/QQAvatar", DoNotGenerateAcw=true)]
	public partial class QQAvatar : global::Com.Tencent.Connect.Common.BaseApi {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/avatar/QQAvatar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QQAvatar); }
		}

		protected QQAvatar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='QQAvatar']/constructor[@name='QQAvatar' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe QQAvatar (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (QQAvatar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I;
#pragma warning disable 0169
		static Delegate GetSetAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_IHandler ()
		{
			if (cb_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I == null)
				cb_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I);
			return cb_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I;
		}

		static void n_SetAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Tencent.Connect.Avatar.QQAvatar __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Avatar.QQAvatar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAvatar (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.avatar']/class[@name='QQAvatar']/method[@name='setAvatar' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='int']]"
		[Register ("setAvatar", "(Landroid/app/Activity;Landroid/net/Uri;Lcom/tencent/tauth/IUiListener;I)V", "GetSetAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_IHandler")]
		public virtual unsafe void SetAvatar (global::Android.App.Activity p0, global::Android.Net.Uri p1, global::Com.Tencent.Tauth.IUiListener p2, int p3)
		{
			if (id_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I == IntPtr.Zero)
				id_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I = JNIEnv.GetMethodID (class_ref, "setAvatar", "(Landroid/app/Activity;Landroid/net/Uri;Lcom/tencent/tauth/IUiListener;I)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAvatar_Landroid_app_Activity_Landroid_net_Uri_Lcom_tencent_tauth_IUiListener_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatar", "(Landroid/app/Activity;Landroid/net/Uri;Lcom/tencent/tauth/IUiListener;I)V"), __args);
			} finally {
			}
		}

	}
}
