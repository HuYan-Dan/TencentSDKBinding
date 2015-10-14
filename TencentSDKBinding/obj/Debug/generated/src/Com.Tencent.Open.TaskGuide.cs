using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']"
	[global::Android.Runtime.Register ("com/tencent/open/TaskGuide", DoNotGenerateAcw=true)]
	public partial class TaskGuide : global::Com.Tencent.Connect.Common.BaseApi {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/TaskGuide", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskGuide); }
		}

		protected TaskGuide (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']/constructor[@name='TaskGuide' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe TaskGuide (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TaskGuide)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']/constructor[@name='TaskGuide' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe TaskGuide (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TaskGuide)) {
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

		static Delegate cb_removeWindow;
#pragma warning disable 0169
		static Delegate GetRemoveWindowHandler ()
		{
			if (cb_removeWindow == null)
				cb_removeWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveWindow);
			return cb_removeWindow;
		}

		static void n_RemoveWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.TaskGuide __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TaskGuide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_removeWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']/method[@name='removeWindow' and count(parameter)=0]"
		[Register ("removeWindow", "()V", "GetRemoveWindowHandler")]
		public virtual unsafe void RemoveWindow ()
		{
			if (id_removeWindow == IntPtr.Zero)
				id_removeWindow = JNIEnv.GetMethodID (class_ref, "removeWindow", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeWindow", "()V"));
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
			global::Com.Tencent.Open.TaskGuide __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TaskGuide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowTaskGuideWindow (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showTaskGuideWindow_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']/method[@name='showTaskGuideWindow' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
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

		static Delegate cb_showWindow;
#pragma warning disable 0169
		static Delegate GetShowWindowHandler ()
		{
			if (cb_showWindow == null)
				cb_showWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowWindow);
			return cb_showWindow;
		}

		static void n_ShowWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.TaskGuide __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TaskGuide> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_showWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TaskGuide']/method[@name='showWindow' and count(parameter)=0]"
		[Register ("showWindow", "()V", "GetShowWindowHandler")]
		public virtual unsafe void ShowWindow ()
		{
			if (id_showWindow == IntPtr.Zero)
				id_showWindow = JNIEnv.GetMethodID (class_ref, "showWindow", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showWindow", "()V"));
			} finally {
			}
		}

	}
}
