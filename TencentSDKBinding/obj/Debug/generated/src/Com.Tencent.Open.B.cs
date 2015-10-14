using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='b']"
	[global::Android.Runtime.Register ("com/tencent/open/b", DoNotGenerateAcw=true)]
	public abstract partial class B : global::Android.App.Dialog {


		static IntPtr jsBridge_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/field[@name='jsBridge']"
		[Register ("jsBridge")]
		protected global::Com.Tencent.Open.A JsBridge {
			get {
				if (jsBridge_jfieldId == IntPtr.Zero)
					jsBridge_jfieldId = JNIEnv.GetFieldID (class_ref, "jsBridge", "Lcom/tencent/open/a;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, jsBridge_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (jsBridge_jfieldId == IntPtr.Zero)
					jsBridge_jfieldId = JNIEnv.GetFieldID (class_ref, "jsBridge", "Lcom/tencent/open/a;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, jsBridge_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mChromeClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/field[@name='mChromeClient']"
		[Register ("mChromeClient")]
		protected global::Android.Webkit.WebChromeClient MChromeClient {
			get {
				if (mChromeClient_jfieldId == IntPtr.Zero)
					mChromeClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mChromeClient", "Landroid/webkit/WebChromeClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mChromeClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebChromeClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mChromeClient_jfieldId == IntPtr.Zero)
					mChromeClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mChromeClient", "Landroid/webkit/WebChromeClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mChromeClient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/b", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (B); }
		}

		protected B (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/constructor[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe B (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (B)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/constructor[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe B (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (B)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
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
			global::Com.Tencent.Open.B __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConsoleMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConsoleMessage", "(Ljava/lang/String;)V", "GetOnConsoleMessage_Ljava_lang_String_Handler")]
		protected abstract void OnConsoleMessage (string p0);

	}

	[global::Android.Runtime.Register ("com/tencent/open/b", DoNotGenerateAcw=true)]
	internal partial class BInvoker : B {

		public BInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BInvoker); }
		}

		static IntPtr id_onConsoleMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='b']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConsoleMessage", "(Ljava/lang/String;)V", "GetOnConsoleMessage_Ljava_lang_String_Handler")]
		protected override unsafe void OnConsoleMessage (string p0)
		{
			if (id_onConsoleMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onConsoleMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConsoleMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_onConsoleMessage_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
