using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tauth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IUiListener']"
	[Register ("com/tencent/tauth/IUiListener", "", "Com.Tencent.Tauth.IUiListenerInvoker")]
	public partial interface IUiListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IUiListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Tencent.Tauth.IUiListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IUiListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onComplete", "(Ljava/lang/Object;)V", "GetOnComplete_Ljava_lang_Object_Handler:Com.Tencent.Tauth.IUiListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnComplete (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IUiListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
		[Register ("onError", "(Lcom/tencent/tauth/UiError;)V", "GetOnError_Lcom_tencent_tauth_UiError_Handler:Com.Tencent.Tauth.IUiListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnError (global::Com.Tencent.Tauth.UiError p0);

	}

	[global::Android.Runtime.Register ("com/tencent/tauth/IUiListener", DoNotGenerateAcw=true)]
	internal class IUiListenerInvoker : global::Java.Lang.Object, IUiListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tauth/IUiListener");
		IntPtr class_ref;

		public static IUiListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUiListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tauth.IUiListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUiListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUiListenerInvoker); }
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
			global::Com.Tencent.Tauth.IUiListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCancel);
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
			global::Com.Tencent.Tauth.IUiListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Ljava_lang_Object_;
		public unsafe void OnComplete (global::Java.Lang.Object p0)
		{
			if (id_onComplete_Ljava_lang_Object_ == IntPtr.Zero)
				id_onComplete_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_lang_Object_, __args);
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
			global::Com.Tencent.Tauth.IUiListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_tencent_tauth_UiError_;
		public unsafe void OnError (global::Com.Tencent.Tauth.UiError p0)
		{
			if (id_onError_Lcom_tencent_tauth_UiError_ == IntPtr.Zero)
				id_onError_Lcom_tencent_tauth_UiError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/tencent/tauth/UiError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_tencent_tauth_UiError_, __args);
		}

	}

	public partial class UiCompleteEventArgs : global::System.EventArgs {

		public UiCompleteEventArgs (global::Java.Lang.Object p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Object p0;
		public global::Java.Lang.Object P0 {
			get { return p0; }
		}
	}

	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Tencent.Tauth.UiError p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Tauth.UiError p0;
		public global::Com.Tencent.Tauth.UiError P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/tauth/IUiListenerImplementor")]
	internal sealed partial class IUiListenerImplementor : global::Java.Lang.Object, IUiListener {

		object sender;

		public IUiListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tauth/IUiListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnCancelHandler;
#pragma warning restore 0649

		public void OnCancel ()
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<UiCompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::Java.Lang.Object p0)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new UiCompleteEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Tencent.Tauth.UiError p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IUiListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnErrorHandler == null;
		}
	}

}
