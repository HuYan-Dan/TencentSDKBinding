using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']"
	[global::Android.Runtime.Register ("com/tencent/open/PKDialog", DoNotGenerateAcw=true)]
	public partial class PKDialog : global::Com.Tencent.Open.B {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.FbWebViewClient']"
		[global::Android.Runtime.Register ("com/tencent/open/PKDialog$FbWebViewClient", DoNotGenerateAcw=true)]
		public partial class FbWebViewClient : global::Android.Webkit.WebViewClient {

			protected FbWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.JsListener']"
		[global::Android.Runtime.Register ("com/tencent/open/PKDialog$JsListener", DoNotGenerateAcw=true)]
		public partial class JsListener : global::Com.Tencent.Open.A.B {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/PKDialog$JsListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JsListener); }
			}

			protected JsListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCancel_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCancel_Ljava_lang_String_Handler ()
			{
				if (cb_onCancel_Ljava_lang_String_ == null)
					cb_onCancel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Ljava_lang_String_);
				return cb_onCancel_Ljava_lang_String_;
			}

			static void n_OnCancel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCancel_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.JsListener']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onCancel", "(Ljava/lang/String;)V", "GetOnCancel_Ljava_lang_String_Handler")]
			public virtual unsafe void OnCancel (string p0)
			{
				if (id_onCancel_Ljava_lang_String_ == IntPtr.Zero)
					id_onCancel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCancel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onComplete_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_ == null)
					cb_onComplete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_);
				return cb_onComplete_Ljava_lang_String_;
			}

			static void n_OnComplete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.JsListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onComplete", "(Ljava/lang/String;)V", "GetOnComplete_Ljava_lang_String_Handler")]
			public virtual unsafe void OnComplete (string p0)
			{
				if (id_onComplete_Ljava_lang_String_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onComplete_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onComplete", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onLoad_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLoad_Ljava_lang_String_Handler ()
			{
				if (cb_onLoad_Ljava_lang_String_ == null)
					cb_onLoad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoad_Ljava_lang_String_);
				return cb_onLoad_Ljava_lang_String_;
			}

			static void n_OnLoad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoad (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLoad_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.JsListener']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onLoad", "(Ljava/lang/String;)V", "GetOnLoad_Ljava_lang_String_Handler")]
			public virtual unsafe void OnLoad (string p0)
			{
				if (id_onLoad_Ljava_lang_String_ == IntPtr.Zero)
					id_onLoad_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onLoad_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoad", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_showMsg_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetShowMsg_Ljava_lang_String_Handler ()
			{
				if (cb_showMsg_Ljava_lang_String_ == null)
					cb_showMsg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowMsg_Ljava_lang_String_);
				return cb_showMsg_Ljava_lang_String_;
			}

			static void n_ShowMsg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowMsg (p0);
			}
#pragma warning restore 0169

			static IntPtr id_showMsg_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.JsListener']/method[@name='showMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("showMsg", "(Ljava/lang/String;)V", "GetShowMsg_Ljava_lang_String_Handler")]
			public virtual unsafe void ShowMsg (string p0)
			{
				if (id_showMsg_Ljava_lang_String_ == IntPtr.Zero)
					id_showMsg_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showMsg", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_showMsg_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showMsg", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.OnTimeListener']"
		[global::Android.Runtime.Register ("com/tencent/open/PKDialog$OnTimeListener", DoNotGenerateAcw=true)]
		public partial class OnTimeListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/PKDialog$OnTimeListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnTimeListener); }
			}

			protected OnTimeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.OnTimeListener']/constructor[@name='PKDialog.OnTimeListener' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.tencent.tauth.IUiListener']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "")]
			public unsafe OnTimeListener (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Tencent.Tauth.IUiListener p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (OnTimeListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static Delegate cb_onCancel;
#pragma warning disable 0169
			static Delegate GetOnCancelHandler ()
			{
				if (cb_onCancel == null)
					cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
				return cb_onCancel;
			}

			static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.PKDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.OnTimeListener']/method[@name='onCancel' and count(parameter)=0]"
			[Register ("onCancel", "()V", "GetOnCancelHandler")]
			public virtual unsafe void OnCancel ()
			{
				if (id_onCancel == IntPtr.Zero)
					id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCancel);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancel", "()V"));
				} finally {
				}
			}

			static Delegate cb_onComplete_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_Object_Handler ()
			{
				if (cb_onComplete_Ljava_lang_Object_ == null)
					cb_onComplete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_Object_);
				return cb_onComplete_Ljava_lang_Object_;
			}

			static void n_OnComplete_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.OnTimeListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("onComplete", "(Ljava/lang/Object;)V", "GetOnComplete_Ljava_lang_Object_Handler")]
			public virtual unsafe void OnComplete (global::Java.Lang.Object p0)
			{
				if (id_onComplete_Ljava_lang_Object_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onComplete_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onComplete", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onError_Lcom_tencent_tauth_UiError_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_tencent_tauth_UiError_Handler ()
			{
				if (cb_onError_Lcom_tencent_tauth_UiError_ == null)
					cb_onError_Lcom_tencent_tauth_UiError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_tencent_tauth_UiError_);
				return cb_onError_Lcom_tencent_tauth_UiError_;
			}

			static void n_OnError_Lcom_tencent_tauth_UiError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.PKDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.OnTimeListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
			[Register ("onError", "(Lcom/tencent/tauth/UiError;)V", "GetOnError_Lcom_tencent_tauth_UiError_Handler")]
			public virtual unsafe void OnError (global::Com.Tencent.Tauth.UiError p0)
			{
				if (id_onError_Lcom_tencent_tauth_UiError_ == IntPtr.Zero)
					id_onError_Lcom_tencent_tauth_UiError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/tencent/tauth/UiError;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onError_Lcom_tencent_tauth_UiError_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Lcom/tencent/tauth/UiError;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.THandler']"
		[global::Android.Runtime.Register ("com/tencent/open/PKDialog$THandler", DoNotGenerateAcw=true)]
		public partial class THandler : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/PKDialog$THandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (THandler); }
			}

			protected THandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_open_PKDialog_Lcom_tencent_open_PKDialog_OnTimeListener_Landroid_os_Looper_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog.THandler']/constructor[@name='PKDialog.THandler' and count(parameter)=3 and parameter[1][@type='com.tencent.open.PKDialog'] and parameter[2][@type='com.tencent.open.PKDialog.OnTimeListener'] and parameter[3][@type='android.os.Looper']]"
			[Register (".ctor", "(Lcom/tencent/open/PKDialog;Lcom/tencent/open/PKDialog$OnTimeListener;Landroid/os/Looper;)V", "")]
			public unsafe THandler (global::Com.Tencent.Open.PKDialog __self, global::Com.Tencent.Open.PKDialog.OnTimeListener p1, global::Android.OS.Looper p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (THandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/PKDialog$OnTimeListener;Landroid/os/Looper;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/PKDialog$OnTimeListener;Landroid/os/Looper;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_open_PKDialog_Lcom_tencent_open_PKDialog_OnTimeListener_Landroid_os_Looper_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_open_PKDialog_Lcom_tencent_open_PKDialog_OnTimeListener_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/open/PKDialog;Lcom/tencent/open/PKDialog$OnTimeListener;Landroid/os/Looper;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_open_PKDialog_Lcom_tencent_open_PKDialog_OnTimeListener_Landroid_os_Looper_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_open_PKDialog_Lcom_tencent_open_PKDialog_OnTimeListener_Landroid_os_Looper_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/PKDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKDialog); }
		}

		protected PKDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']/constructor[@name='PKDialog' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.tauth.IUiListener'] and parameter[5][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe PKDialog (global::Android.Content.Context p0, string p1, string p2, global::Com.Tencent.Tauth.IUiListener p3, global::Com.Tencent.Connect.Auth.QQToken p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (PKDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_callJs_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCallJs_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_callJs_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_callJs_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CallJs_Ljava_lang_String_Ljava_lang_String_);
			return cb_callJs_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CallJs_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.PKDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CallJs (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_callJs_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']/method[@name='callJs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("callJs", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCallJs_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CallJs (string p0, string p1)
		{
			if (id_callJs_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_callJs_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callJs", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_callJs_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callJs", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onConsoleMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConsoleMessage_Ljava_lang_String_Handler ()
		{
			if (cb_onConsoleMessage_Ljava_lang_String_ == null)
				cb_onConsoleMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConsoleMessage_Ljava_lang_String_);
			return cb_onConsoleMessage_Ljava_lang_String_;
		}

		static void n_OnConsoleMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.PKDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConsoleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConsoleMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConsoleMessage", "(Ljava/lang/String;)V", "GetOnConsoleMessage_Ljava_lang_String_Handler")]
		protected override unsafe void OnConsoleMessage (string p0)
		{
			if (id_onConsoleMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onConsoleMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConsoleMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConsoleMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConsoleMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onKeyboardHidden;
#pragma warning disable 0169
		static Delegate GetOnKeyboardHiddenHandler ()
		{
			if (cb_onKeyboardHidden == null)
				cb_onKeyboardHidden = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnKeyboardHidden);
			return cb_onKeyboardHidden;
		}

		static void n_OnKeyboardHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.PKDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyboardHidden ();
		}
#pragma warning restore 0169

		static IntPtr id_onKeyboardHidden;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']/method[@name='onKeyboardHidden' and count(parameter)=0]"
		[Register ("onKeyboardHidden", "()V", "GetOnKeyboardHiddenHandler")]
		public virtual unsafe void OnKeyboardHidden ()
		{
			if (id_onKeyboardHidden == IntPtr.Zero)
				id_onKeyboardHidden = JNIEnv.GetMethodID (class_ref, "onKeyboardHidden", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onKeyboardHidden);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyboardHidden", "()V"));
			} finally {
			}
		}

		static Delegate cb_onKeyboardShown_I;
#pragma warning disable 0169
		static Delegate GetOnKeyboardShown_IHandler ()
		{
			if (cb_onKeyboardShown_I == null)
				cb_onKeyboardShown_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnKeyboardShown_I);
			return cb_onKeyboardShown_I;
		}

		static void n_OnKeyboardShown_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Open.PKDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.PKDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyboardShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onKeyboardShown_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='PKDialog']/method[@name='onKeyboardShown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onKeyboardShown", "(I)V", "GetOnKeyboardShown_IHandler")]
		public virtual unsafe void OnKeyboardShown (int p0)
		{
			if (id_onKeyboardShown_I == IntPtr.Zero)
				id_onKeyboardShown_I = JNIEnv.GetMethodID (class_ref, "onKeyboardShown", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onKeyboardShown_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyboardShown", "(I)V"), __args);
			} finally {
			}
		}

	}
}
