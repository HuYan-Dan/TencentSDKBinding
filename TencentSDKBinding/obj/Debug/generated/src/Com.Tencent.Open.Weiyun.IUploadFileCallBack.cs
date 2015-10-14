using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']"
	[Register ("com/tencent/open/weiyun/IUploadFileCallBack", "", "Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker")]
	public partial interface IUploadFileCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
		[Register ("onError", "(Lcom/tencent/tauth/UiError;)V", "GetOnError_Lcom_tencent_tauth_UiError_Handler:Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnError (global::Com.Tencent.Tauth.UiError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']/method[@name='onPrepareStart' and count(parameter)=0]"
		[Register ("onPrepareStart", "()V", "GetOnPrepareStartHandler:Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnPrepareStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']/method[@name='onUploadProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUploadProgress", "(I)V", "GetOnUploadProgress_IHandler:Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnUploadProgress (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']/method[@name='onUploadStart' and count(parameter)=0]"
		[Register ("onUploadStart", "()V", "GetOnUploadStartHandler:Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnUploadStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IUploadFileCallBack']/method[@name='onUploadSuccess' and count(parameter)=0]"
		[Register ("onUploadSuccess", "()V", "GetOnUploadSuccessHandler:Com.Tencent.Open.Weiyun.IUploadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnUploadSuccess ();

	}

	[global::Android.Runtime.Register ("com/tencent/open/weiyun/IUploadFileCallBack", DoNotGenerateAcw=true)]
	internal class IUploadFileCallBackInvoker : global::Java.Lang.Object, IUploadFileCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/open/weiyun/IUploadFileCallBack");
		IntPtr class_ref;

		public static IUploadFileCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUploadFileCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.open.weiyun.IUploadFileCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUploadFileCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUploadFileCallBackInvoker); }
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
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onPrepareStart;
#pragma warning disable 0169
		static Delegate GetOnPrepareStartHandler ()
		{
			if (cb_onPrepareStart == null)
				cb_onPrepareStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrepareStart);
			return cb_onPrepareStart;
		}

		static void n_OnPrepareStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepareStart ();
		}
#pragma warning restore 0169

		IntPtr id_onPrepareStart;
		public unsafe void OnPrepareStart ()
		{
			if (id_onPrepareStart == IntPtr.Zero)
				id_onPrepareStart = JNIEnv.GetMethodID (class_ref, "onPrepareStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPrepareStart);
		}

		static Delegate cb_onUploadProgress_I;
#pragma warning disable 0169
		static Delegate GetOnUploadProgress_IHandler ()
		{
			if (cb_onUploadProgress_I == null)
				cb_onUploadProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnUploadProgress_I);
			return cb_onUploadProgress_I;
		}

		static void n_OnUploadProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUploadProgress_I;
		public unsafe void OnUploadProgress (int p0)
		{
			if (id_onUploadProgress_I == IntPtr.Zero)
				id_onUploadProgress_I = JNIEnv.GetMethodID (class_ref, "onUploadProgress", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onUploadProgress_I, __args);
		}

		static Delegate cb_onUploadStart;
#pragma warning disable 0169
		static Delegate GetOnUploadStartHandler ()
		{
			if (cb_onUploadStart == null)
				cb_onUploadStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUploadStart);
			return cb_onUploadStart;
		}

		static void n_OnUploadStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadStart ();
		}
#pragma warning restore 0169

		IntPtr id_onUploadStart;
		public unsafe void OnUploadStart ()
		{
			if (id_onUploadStart == IntPtr.Zero)
				id_onUploadStart = JNIEnv.GetMethodID (class_ref, "onUploadStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onUploadStart);
		}

		static Delegate cb_onUploadSuccess;
#pragma warning disable 0169
		static Delegate GetOnUploadSuccessHandler ()
		{
			if (cb_onUploadSuccess == null)
				cb_onUploadSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUploadSuccess);
			return cb_onUploadSuccess;
		}

		static void n_OnUploadSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onUploadSuccess;
		public unsafe void OnUploadSuccess ()
		{
			if (id_onUploadSuccess == IntPtr.Zero)
				id_onUploadSuccess = JNIEnv.GetMethodID (class_ref, "onUploadSuccess", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onUploadSuccess);
		}

	}

}
