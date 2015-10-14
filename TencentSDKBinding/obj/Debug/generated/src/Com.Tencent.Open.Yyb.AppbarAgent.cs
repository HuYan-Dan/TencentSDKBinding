using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Yyb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']"
	[global::Android.Runtime.Register ("com/tencent/open/yyb/AppbarAgent", DoNotGenerateAcw=true)]
	public partial class AppbarAgent : global::Com.Tencent.Connect.Common.BaseApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/field[@name='TO_APPBAR_DETAIL']"
		[Register ("TO_APPBAR_DETAIL")]
		public const string ToAppbarDetail = (string) "siteIndex";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/field[@name='TO_APPBAR_NEWS']"
		[Register ("TO_APPBAR_NEWS")]
		public const string ToAppbarNews = (string) "myMessage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/field[@name='TO_APPBAR_SEND_BLOG']"
		[Register ("TO_APPBAR_SEND_BLOG")]
		public const string ToAppbarSendBlog = (string) "newThread";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/field[@name='wx_appid']"
		[Register ("wx_appid")]
		public const string WxAppid = (string) "wx8e8dc60535c9cd93";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/yyb/AppbarAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppbarAgent); }
		}

		protected AppbarAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/constructor[@name='AppbarAgent' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe AppbarAgent (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AppbarAgent)) {
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
			global::Com.Tencent.Open.Yyb.AppbarAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbar (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbar_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/method[@name='startAppbar' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Tencent.Open.Yyb.AppbarAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbarLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbarLabel_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/method[@name='startAppbarLabel' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Tencent.Open.Yyb.AppbarAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAppbarThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startAppbarThread_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarAgent']/method[@name='startAppbarThread' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
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

	}
}
