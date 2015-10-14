using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Yyb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']"
	[global::Android.Runtime.Register ("com/tencent/open/yyb/AppbarJsBridge", DoNotGenerateAcw=true)]
	public partial class AppbarJsBridge : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='AUTHORIZE_FAIL']"
		[Register ("AUTHORIZE_FAIL")]
		public const int AuthorizeFail = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='BUTTON_CLICK_CALLBACK_FUNCTION_NAME']"
		[Register ("BUTTON_CLICK_CALLBACK_FUNCTION_NAME")]
		public const string ButtonClickCallbackFunctionName = (string) "clickCallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='CALLBACK_LOGIN']"
		[Register ("CALLBACK_LOGIN")]
		public const string CallbackLogin = (string) "loginCallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='CALLBACK_SHARE']"
		[Register ("CALLBACK_SHARE")]
		public const string CallbackShare = (string) "shareCallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='Code_Java_Exception']"
		[Register ("Code_Java_Exception")]
		public const int CodeJavaException = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='Code_None']"
		[Register ("Code_None")]
		public const int CodeNone = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='JSBRIDGE_VERSION']"
		[Register ("JSBRIDGE_VERSION")]
		public const int JsbridgeVersion = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='JS_BRIDGE_SCHEME']"
		[Register ("JS_BRIDGE_SCHEME")]
		public const string JsBridgeScheme = (string) "jsb://";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='READY_CALLBACK_FUNCTION_NAME']"
		[Register ("READY_CALLBACK_FUNCTION_NAME")]
		public const string ReadyCallbackFunctionName = (string) "readyCallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='Result_Fail']"
		[Register ("Result_Fail")]
		public const int ResultFail = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='Result_OK']"
		[Register ("Result_OK")]
		public const int ResultOK = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='SHARE_QQ']"
		[Register ("SHARE_QQ")]
		public const int ShareQq = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='SHARE_QZ']"
		[Register ("SHARE_QZ")]
		public const int ShareQz = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='SHARE_TIMELINE']"
		[Register ("SHARE_TIMELINE")]
		public const int ShareTimeline = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/field[@name='SHARE_WX']"
		[Register ("SHARE_WX")]
		public const int ShareWx = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/yyb/AppbarJsBridge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppbarJsBridge); }
		}

		protected AppbarJsBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/constructor[@name='AppbarJsBridge' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.webkit.WebView']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/webkit/WebView;)V", "")]
		public unsafe AppbarJsBridge (global::Android.App.Activity p0, global::Android.Webkit.WebView p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AppbarJsBridge)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Landroid/webkit/WebView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Landroid/webkit/WebView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/webkit/WebView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_webkit_WebView_, __args);
			} finally {
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_callback_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallback_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_callback_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_callback_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Callback_Ljava_lang_String_Ljava_lang_String_);
			return cb_callback_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Callback_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Callback (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_callback_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='callback' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("callback", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCallback_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Callback (string p0, string p1)
		{
			if (id_callback_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_callback_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callback", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_callback_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callback", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_clickCallback;
#pragma warning disable 0169
		static Delegate GetClickCallbackHandler ()
		{
			if (cb_clickCallback == null)
				cb_clickCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClickCallback);
			return cb_clickCallback;
		}

		static void n_ClickCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClickCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_clickCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='clickCallback' and count(parameter)=0]"
		[Register ("clickCallback", "()V", "GetClickCallbackHandler")]
		public virtual unsafe void ClickCallback ()
		{
			if (id_clickCallback == IntPtr.Zero)
				id_clickCallback = JNIEnv.GetMethodID (class_ref, "clickCallback", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clickCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clickCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCloseWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CloseWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_CloseWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CloseWebView (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='closeWebView' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("closeWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetCloseWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CloseWebView (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "closeWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_closeWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_GetAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.GetAppInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='getAppInfo' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getAppInfo", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetGetAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void GetAppInfo (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAppInfo", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getAppInfo_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppInfo", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_invoke_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_String_Handler ()
		{
			if (cb_invoke_Ljava_lang_String_ == null)
				cb_invoke_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_String_);
			return cb_invoke_Ljava_lang_String_;
		}

		static void n_Invoke_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invoke (p0);
		}
#pragma warning restore 0169

		static IntPtr id_invoke_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invoke", "(Ljava/lang/String;)V", "GetInvoke_Ljava_lang_String_Handler")]
		public virtual unsafe void Invoke (string p0)
		{
			if (id_invoke_Ljava_lang_String_ == IntPtr.Zero)
				id_invoke_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invoke_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OpenLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_OpenLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OpenLoginActivity (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='openLoginActivity' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("openLoginActivity", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetOpenLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OpenLoginActivity (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openLoginActivity", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_openLoginActivity_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openLoginActivity", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OpenNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_OpenNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OpenNewWindow (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='openNewWindow' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("openNewWindow", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetOpenNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OpenNewWindow (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openNewWindow", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_openNewWindow_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openNewWindow", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_PageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_PageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PageControl (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='pageControl' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("pageControl", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetPageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PageControl (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "pageControl", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pageControl_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageControl", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_ready;
#pragma warning disable 0169
		static Delegate GetReadyHandler ()
		{
			if (cb_ready == null)
				cb_ready = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Ready);
			return cb_ready;
		}

		static void n_Ready (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ready ();
		}
#pragma warning restore 0169

		static IntPtr id_ready;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='ready' and count(parameter)=0]"
		[Register ("ready", "()V", "GetReadyHandler")]
		public virtual unsafe void Ready ()
		{
			if (id_ready == IntPtr.Zero)
				id_ready = JNIEnv.GetMethodID (class_ref, "ready", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ready);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ready", "()V"));
			} finally {
			}
		}

		static Delegate cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResponse_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Response (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='response' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "GetResponse_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Response (string p0, int p1, string p2, string p3)
		{
			if (id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetResponse_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_Response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Response (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='response' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetResponse_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void Response (string p0, int p1, string p2, string p3, global::System.Collections.Generic.IDictionary<string, string> p4)
		{
			if (id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_response_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "response", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_responseFail_Ljava_lang_String_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetResponseFail_Ljava_lang_String_ILjava_lang_String_IHandler ()
		{
			if (cb_responseFail_Ljava_lang_String_ILjava_lang_String_I == null)
				cb_responseFail_Ljava_lang_String_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_ResponseFail_Ljava_lang_String_ILjava_lang_String_I);
			return cb_responseFail_Ljava_lang_String_ILjava_lang_String_I;
		}

		static void n_ResponseFail_Ljava_lang_String_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ResponseFail (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_responseFail_Ljava_lang_String_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='responseFail' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("responseFail", "(Ljava/lang/String;ILjava/lang/String;I)V", "GetResponseFail_Ljava_lang_String_ILjava_lang_String_IHandler")]
		public virtual unsafe void ResponseFail (string p0, int p1, string p2, int p3)
		{
			if (id_responseFail_Ljava_lang_String_ILjava_lang_String_I == IntPtr.Zero)
				id_responseFail_Ljava_lang_String_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "responseFail", "(Ljava/lang/String;ILjava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_responseFail_Ljava_lang_String_ILjava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseFail", "(Ljava/lang/String;ILjava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_responseShare_I;
#pragma warning disable 0169
		static Delegate GetResponseShare_IHandler ()
		{
			if (cb_responseShare_I == null)
				cb_responseShare_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ResponseShare_I);
			return cb_responseShare_I;
		}

		static void n_ResponseShare_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResponseShare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_responseShare_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='responseShare' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("responseShare", "(I)V", "GetResponseShare_IHandler")]
		public virtual unsafe void ResponseShare (int p0)
		{
			if (id_responseShare_I == IntPtr.Zero)
				id_responseShare_I = JNIEnv.GetMethodID (class_ref, "responseShare", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_responseShare_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseShare", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_responseShareFail_I;
#pragma warning disable 0169
		static Delegate GetResponseShareFail_IHandler ()
		{
			if (cb_responseShareFail_I == null)
				cb_responseShareFail_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ResponseShareFail_I);
			return cb_responseShareFail_I;
		}

		static void n_ResponseShareFail_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResponseShareFail (p0);
		}
#pragma warning restore 0169

		static IntPtr id_responseShareFail_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='responseShareFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("responseShareFail", "(I)V", "GetResponseShareFail_IHandler")]
		public virtual unsafe void ResponseShareFail (int p0)
		{
			if (id_responseShareFail_I == IntPtr.Zero)
				id_responseShareFail_I = JNIEnv.GetMethodID (class_ref, "responseShareFail", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_responseShareFail_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseShareFail", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_SetWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetWebView (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='setWebView' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetSetWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetWebView (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWebView_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebView", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShare_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_);
			return cb_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Yyb.AppbarJsBridge __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.AppbarJsBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Share (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='AppbarJsBridge']/method[@name='share' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("share", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V", "GetShare_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Share (global::Android.Net.Uri p0, int p1, string p2, string p3)
		{
			if (id_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "share", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_share_Landroid_net_Uri_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "share", "(Landroid/net/Uri;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
