using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog']"
	[global::Android.Runtime.Register ("com/tencent/open/TDialog", DoNotGenerateAcw=true)]
	public partial class TDialog : global::Com.Tencent.Open.B {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.FbWebViewClient']"
		[global::Android.Runtime.Register ("com/tencent/open/TDialog$FbWebViewClient", DoNotGenerateAcw=true)]
		public partial class FbWebViewClient : global::Android.Webkit.WebViewClient {

			protected FbWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']"
		[global::Android.Runtime.Register ("com/tencent/open/TDialog$JsListener", DoNotGenerateAcw=true)]
		public partial class JsListener : global::Com.Tencent.Open.A.B {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/TDialog$JsListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JsListener); }
			}

			protected JsListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onAddShare_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnAddShare_Ljava_lang_String_Handler ()
			{
				if (cb_onAddShare_Ljava_lang_String_ == null)
					cb_onAddShare_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAddShare_Ljava_lang_String_);
				return cb_onAddShare_Ljava_lang_String_;
			}

			static void n_OnAddShare_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAddShare (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAddShare_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onAddShare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onAddShare", "(Ljava/lang/String;)V", "GetOnAddShare_Ljava_lang_String_Handler")]
			public virtual unsafe void OnAddShare (string p0)
			{
				if (id_onAddShare_Ljava_lang_String_ == IntPtr.Zero)
					id_onAddShare_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAddShare", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAddShare_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAddShare", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

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
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCancel_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_onCancelAddShare_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCancelAddShare_Ljava_lang_String_Handler ()
			{
				if (cb_onCancelAddShare_Ljava_lang_String_ == null)
					cb_onCancelAddShare_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelAddShare_Ljava_lang_String_);
				return cb_onCancelAddShare_Ljava_lang_String_;
			}

			static void n_OnCancelAddShare_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCancelAddShare (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCancelAddShare_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onCancelAddShare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onCancelAddShare", "(Ljava/lang/String;)V", "GetOnCancelAddShare_Ljava_lang_String_Handler")]
			public virtual unsafe void OnCancelAddShare (string p0)
			{
				if (id_onCancelAddShare_Ljava_lang_String_ == IntPtr.Zero)
					id_onCancelAddShare_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCancelAddShare", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCancelAddShare_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelAddShare", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onCancelInvite;
#pragma warning disable 0169
			static Delegate GetOnCancelInviteHandler ()
			{
				if (cb_onCancelInvite == null)
					cb_onCancelInvite = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelInvite);
				return cb_onCancelInvite;
			}

			static void n_OnCancelInvite (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancelInvite ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancelInvite;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onCancelInvite' and count(parameter)=0]"
			[Register ("onCancelInvite", "()V", "GetOnCancelInviteHandler")]
			public virtual unsafe void OnCancelInvite ()
			{
				if (id_onCancelInvite == IntPtr.Zero)
					id_onCancelInvite = JNIEnv.GetMethodID (class_ref, "onCancelInvite", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCancelInvite);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelInvite", "()V"));
				} finally {
				}
			}

			static Delegate cb_onCancelLogin;
#pragma warning disable 0169
			static Delegate GetOnCancelLoginHandler ()
			{
				if (cb_onCancelLogin == null)
					cb_onCancelLogin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelLogin);
				return cb_onCancelLogin;
			}

			static void n_OnCancelLogin (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancelLogin ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancelLogin;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onCancelLogin' and count(parameter)=0]"
			[Register ("onCancelLogin", "()V", "GetOnCancelLoginHandler")]
			public virtual unsafe void OnCancelLogin ()
			{
				if (id_onCancelLogin == IntPtr.Zero)
					id_onCancelLogin = JNIEnv.GetMethodID (class_ref, "onCancelLogin", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCancelLogin);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelLogin", "()V"));
				} finally {
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
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_onInvite_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnInvite_Ljava_lang_String_Handler ()
			{
				if (cb_onInvite_Ljava_lang_String_ == null)
					cb_onInvite_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInvite_Ljava_lang_String_);
				return cb_onInvite_Ljava_lang_String_;
			}

			static void n_OnInvite_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInvite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onInvite_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onInvite' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onInvite", "(Ljava/lang/String;)V", "GetOnInvite_Ljava_lang_String_Handler")]
			public virtual unsafe void OnInvite (string p0)
			{
				if (id_onInvite_Ljava_lang_String_ == IntPtr.Zero)
					id_onInvite_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInvite", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInvite_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInvite", "(Ljava/lang/String;)V"), __args);
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
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoad (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLoad_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				global::Com.Tencent.Open.TDialog.JsListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.JsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowMsg (p0);
			}
#pragma warning restore 0169

			static IntPtr id_showMsg_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.JsListener']/method[@name='showMsg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.OnTimeListener']"
		[global::Android.Runtime.Register ("com/tencent/open/TDialog$OnTimeListener", DoNotGenerateAcw=true)]
		public partial class OnTimeListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/TDialog$OnTimeListener", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.OnTimeListener']/constructor[@name='TDialog.OnTimeListener' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.tencent.tauth.IUiListener']]"
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
				global::Com.Tencent.Open.TDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.OnTimeListener']/method[@name='onCancel' and count(parameter)=0]"
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
				global::Com.Tencent.Open.TDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.OnTimeListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
				global::Com.Tencent.Open.TDialog.OnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog.OnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.OnTimeListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.THandler']"
		[global::Android.Runtime.Register ("com/tencent/open/TDialog$THandler", DoNotGenerateAcw=true)]
		public partial class THandler : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/TDialog$THandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (THandler); }
			}

			protected THandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_open_TDialog_Lcom_tencent_open_TDialog_OnTimeListener_Landroid_os_Looper_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog.THandler']/constructor[@name='TDialog.THandler' and count(parameter)=3 and parameter[1][@type='com.tencent.open.TDialog'] and parameter[2][@type='com.tencent.open.TDialog.OnTimeListener'] and parameter[3][@type='android.os.Looper']]"
			[Register (".ctor", "(Lcom/tencent/open/TDialog;Lcom/tencent/open/TDialog$OnTimeListener;Landroid/os/Looper;)V", "")]
			public unsafe THandler (global::Com.Tencent.Open.TDialog __self, global::Com.Tencent.Open.TDialog.OnTimeListener p1, global::Android.OS.Looper p2)
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
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/TDialog$OnTimeListener;Landroid/os/Looper;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/TDialog$OnTimeListener;Landroid/os/Looper;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_open_TDialog_Lcom_tencent_open_TDialog_OnTimeListener_Landroid_os_Looper_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_open_TDialog_Lcom_tencent_open_TDialog_OnTimeListener_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/open/TDialog;Lcom/tencent/open/TDialog$OnTimeListener;Landroid/os/Looper;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_open_TDialog_Lcom_tencent_open_TDialog_OnTimeListener_Landroid_os_Looper_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_open_TDialog_Lcom_tencent_open_TDialog_OnTimeListener_Landroid_os_Looper_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/TDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TDialog); }
		}

		protected TDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog']/constructor[@name='TDialog' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.tauth.IUiListener'] and parameter[5][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe TDialog (global::Android.Content.Context p0, string p1, string p2, global::Com.Tencent.Tauth.IUiListener p3, global::Com.Tencent.Connect.Auth.QQToken p4)
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
				if (GetType () != typeof (TDialog)) {
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
			global::Com.Tencent.Open.TDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.TDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConsoleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConsoleMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='TDialog']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
