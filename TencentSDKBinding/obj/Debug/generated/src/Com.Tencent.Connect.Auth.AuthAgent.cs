using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']"
	[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent", DoNotGenerateAcw=true)]
	public partial class AuthAgent : global::Com.Tencent.Connect.Common.BaseApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/field[@name='SECURE_LIB_ARM_FILE_NAME']"
		[Register ("SECURE_LIB_ARM_FILE_NAME")]
		public const string SecureLibArmFileName = (string) "libwbsafeedit";

		static IntPtr SECURE_LIB_FILE_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/field[@name='SECURE_LIB_FILE_NAME']"
		[Register ("SECURE_LIB_FILE_NAME")]
		public static string SecureLibFileName {
			get {
				if (SECURE_LIB_FILE_NAME_jfieldId == IntPtr.Zero)
					SECURE_LIB_FILE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURE_LIB_FILE_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURE_LIB_FILE_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SECURE_LIB_FILE_NAME_jfieldId == IntPtr.Zero)
					SECURE_LIB_FILE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURE_LIB_FILE_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SECURE_LIB_FILE_NAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SECURE_LIB_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/field[@name='SECURE_LIB_NAME']"
		[Register ("SECURE_LIB_NAME")]
		public static string SecureLibName {
			get {
				if (SECURE_LIB_NAME_jfieldId == IntPtr.Zero)
					SECURE_LIB_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURE_LIB_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURE_LIB_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SECURE_LIB_NAME_jfieldId == IntPtr.Zero)
					SECURE_LIB_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURE_LIB_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SECURE_LIB_NAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/field[@name='SECURE_LIB_X86_FILE_NAME']"
		[Register ("SECURE_LIB_X86_FILE_NAME")]
		public const string SecureLibX86FileName = (string) "libwbsafeedit_x86";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.CheckLoginListener']"
		[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent$CheckLoginListener", DoNotGenerateAcw=true)]
		public partial class CheckLoginListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/auth/AuthAgent$CheckLoginListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CheckLoginListener); }
			}

			protected CheckLoginListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.CheckLoginListener']/constructor[@name='AuthAgent.CheckLoginListener' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.auth.AuthAgent'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
			[Register (".ctor", "(Lcom/tencent/connect/auth/AuthAgent;Lcom/tencent/tauth/IUiListener;)V", "")]
			public unsafe CheckLoginListener (global::Com.Tencent.Connect.Auth.AuthAgent __self, global::Com.Tencent.Tauth.IUiListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (CheckLoginListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/AuthAgent;Lcom/tencent/tauth/IUiListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_, __args);
				} finally {
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
				global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.CheckLoginListener']/method[@name='onCancel' and count(parameter)=0]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.CheckLoginListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.CheckLoginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.CheckLoginListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']"
		[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent$FeedConfirmListener", DoNotGenerateAcw=true)]
		public partial class FeedConfirmListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener.ButtonListener']"
			[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent$FeedConfirmListener$ButtonListener", DoNotGenerateAcw=true)]
			public abstract partial class ButtonListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

				protected ButtonListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
				static Delegate GetOnClick_Landroid_view_View_Handler ()
				{
					if (cb_onClick_Landroid_view_View_ == null)
						cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
					return cb_onClick_Landroid_view_View_;
				}

				static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
				{
					global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener.ButtonListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener.ButtonListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
					__this.OnClick (v);
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener.ButtonListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='Android.Views.View']]"
				[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
				public abstract void OnClick (global::Android.Views.View v);

			}

			[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent$FeedConfirmListener$ButtonListener", DoNotGenerateAcw=true)]
			internal partial class ButtonListenerInvoker : ButtonListener {

				public ButtonListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

				protected override global::System.Type ThresholdType {
					get { return typeof (ButtonListenerInvoker); }
				}

				static IntPtr id_onClick_Landroid_view_View_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener.ButtonListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='Android.Views.View']]"
				[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
				public override unsafe void OnClick (global::Android.Views.View v)
				{
					if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
						id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (v);
						JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, __args);
					} finally {
					}
				}

			}


			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/auth/AuthAgent$FeedConfirmListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FeedConfirmListener); }
			}

			protected FeedConfirmListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']/constructor[@name='AuthAgent.FeedConfirmListener' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.auth.AuthAgent'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
			[Register (".ctor", "(Lcom/tencent/connect/auth/AuthAgent;Lcom/tencent/tauth/IUiListener;)V", "")]
			public unsafe FeedConfirmListener (global::Com.Tencent.Connect.Auth.AuthAgent __self, global::Com.Tencent.Tauth.IUiListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FeedConfirmListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/AuthAgent;Lcom/tencent/tauth/IUiListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Lcom_tencent_tauth_IUiListener_, __args);
				} finally {
				}
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler")]
			protected virtual unsafe void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_a);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
				} finally {
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
				global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']/method[@name='onCancel' and count(parameter)=0]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.FeedConfirmListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.FeedConfirmListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.TokenListener']"
		[global::Android.Runtime.Register ("com/tencent/connect/auth/AuthAgent$TokenListener", DoNotGenerateAcw=true)]
		public partial class TokenListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/auth/AuthAgent$TokenListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TokenListener); }
			}

			protected TokenListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_auth_AuthAgent_Landroid_content_Context_Lcom_tencent_tauth_IUiListener_ZZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.TokenListener']/constructor[@name='AuthAgent.TokenListener' and count(parameter)=5 and parameter[1][@type='com.tencent.connect.auth.AuthAgent'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
			[Register (".ctor", "(Lcom/tencent/connect/auth/AuthAgent;Landroid/content/Context;Lcom/tencent/tauth/IUiListener;ZZ)V", "")]
			public unsafe TokenListener (global::Com.Tencent.Connect.Auth.AuthAgent __self, global::Android.Content.Context p1, global::Com.Tencent.Tauth.IUiListener p2, bool p3, bool p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (TokenListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/tauth/IUiListener;ZZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/tauth/IUiListener;ZZ)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_auth_AuthAgent_Landroid_content_Context_Lcom_tencent_tauth_IUiListener_ZZ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_auth_AuthAgent_Landroid_content_Context_Lcom_tencent_tauth_IUiListener_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/AuthAgent;Landroid/content/Context;Lcom/tencent/tauth/IUiListener;ZZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Landroid_content_Context_Lcom_tencent_tauth_IUiListener_ZZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_AuthAgent_Landroid_content_Context_Lcom_tencent_tauth_IUiListener_ZZ, __args);
				} finally {
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
				global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.TokenListener']/method[@name='onCancel' and count(parameter)=0]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.TokenListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
				global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent.TokenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent.TokenListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/auth/AuthAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthAgent); }
		}

		protected AuthAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/constructor[@name='AuthAgent' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe AuthAgent (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AuthAgent)) {
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

		static Delegate cb_a_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_a_Lcom_tencent_tauth_IUiListener_ == null)
				cb_a_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_tencent_tauth_IUiListener_);
			return cb_a_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_A_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.AuthAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("a", "(Lcom/tencent/tauth/IUiListener;)V", "GetA_Lcom_tencent_tauth_IUiListener_Handler")]
		protected virtual unsafe void A (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_a_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_a_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_b_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetB_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_b_Lcom_tencent_tauth_IUiListener_ == null)
				cb_b_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Lcom_tencent_tauth_IUiListener_);
			return cb_b_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_B_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Auth.AuthAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p0 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.IUiListener']]"
		[Register ("b", "(Lcom/tencent/tauth/IUiListener;)V", "GetB_Lcom_tencent_tauth_IUiListener_Handler")]
		protected virtual unsafe void B (global::Com.Tencent.Tauth.IUiListener p0)
		{
			if (id_b_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_b_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_b_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static int n_DoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Auth.AuthAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DoLogin (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/method[@name='doLogin' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I", "GetDoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe int DoLogin (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetDoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_Handler ()
		{
			if (cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_ == null)
				cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, int>) n_DoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_);
			return cb_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_;
		}

		static int n_DoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, IntPtr native_p4)
		{
			global::Com.Tencent.Connect.Auth.AuthAgent __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.AuthAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p4 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DoLogin (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.auth']/class[@name='AuthAgent']/method[@name='doLogin' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener'] and parameter[4][@type='boolean'] and parameter[5][@type='android.support.v4.app.Fragment']]"
		[Register ("doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;ZLandroid/support/v4/app/Fragment;)I", "GetDoLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_Handler")]
		public virtual unsafe int DoLogin (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2, bool p3, global::Android.Support.V4.App.Fragment p4)
		{
			if (id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;ZLandroid/support/v4/app/Fragment;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_doLogin_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ZLandroid_support_v4_app_Fragment_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doLogin", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;ZLandroid/support/v4/app/Fragment;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
