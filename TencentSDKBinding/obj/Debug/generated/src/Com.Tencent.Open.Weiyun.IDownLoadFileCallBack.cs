using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']"
	[Register ("com/tencent/open/weiyun/IDownLoadFileCallBack", "", "Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker")]
	public partial interface IDownLoadFileCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']/method[@name='onDownloadProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDownloadProgress", "(I)V", "GetOnDownloadProgress_IHandler:Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnDownloadProgress (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']/method[@name='onDownloadStart' and count(parameter)=0]"
		[Register ("onDownloadStart", "()V", "GetOnDownloadStartHandler:Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnDownloadStart ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']/method[@name='onDownloadSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDownloadSuccess", "(Ljava/lang/String;)V", "GetOnDownloadSuccess_Ljava_lang_String_Handler:Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnDownloadSuccess (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
		[Register ("onError", "(Lcom/tencent/tauth/UiError;)V", "GetOnError_Lcom_tencent_tauth_UiError_Handler:Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnError (global::Com.Tencent.Tauth.UiError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IDownLoadFileCallBack']/method[@name='onPrepareStart' and count(parameter)=0]"
		[Register ("onPrepareStart", "()V", "GetOnPrepareStartHandler:Com.Tencent.Open.Weiyun.IDownLoadFileCallBackInvoker, TencentSDKBinding_v2.9.3")]
		void OnPrepareStart ();

	}

	[global::Android.Runtime.Register ("com/tencent/open/weiyun/IDownLoadFileCallBack", DoNotGenerateAcw=true)]
	internal class IDownLoadFileCallBackInvoker : global::Java.Lang.Object, IDownLoadFileCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/open/weiyun/IDownLoadFileCallBack");
		IntPtr class_ref;

		public static IDownLoadFileCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDownLoadFileCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.open.weiyun.IDownLoadFileCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDownLoadFileCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDownLoadFileCallBackInvoker); }
		}

		static Delegate cb_onDownloadProgress_I;
#pragma warning disable 0169
		static Delegate GetOnDownloadProgress_IHandler ()
		{
			if (cb_onDownloadProgress_I == null)
				cb_onDownloadProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDownloadProgress_I);
			return cb_onDownloadProgress_I;
		}

		static void n_OnDownloadProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDownloadProgress_I;
		public unsafe void OnDownloadProgress (int p0)
		{
			if (id_onDownloadProgress_I == IntPtr.Zero)
				id_onDownloadProgress_I = JNIEnv.GetMethodID (class_ref, "onDownloadProgress", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onDownloadProgress_I, __args);
		}

		static Delegate cb_onDownloadStart;
#pragma warning disable 0169
		static Delegate GetOnDownloadStartHandler ()
		{
			if (cb_onDownloadStart == null)
				cb_onDownloadStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDownloadStart);
			return cb_onDownloadStart;
		}

		static void n_OnDownloadStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadStart ();
		}
#pragma warning restore 0169

		IntPtr id_onDownloadStart;
		public unsafe void OnDownloadStart ()
		{
			if (id_onDownloadStart == IntPtr.Zero)
				id_onDownloadStart = JNIEnv.GetMethodID (class_ref, "onDownloadStart", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onDownloadStart);
		}

		static Delegate cb_onDownloadSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDownloadSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onDownloadSuccess_Ljava_lang_String_ == null)
				cb_onDownloadSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDownloadSuccess_Ljava_lang_String_);
			return cb_onDownloadSuccess_Ljava_lang_String_;
		}

		static void n_OnDownloadSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDownloadSuccess_Ljava_lang_String_;
		public unsafe void OnDownloadSuccess (string p0)
		{
			if (id_onDownloadSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onDownloadSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDownloadSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onDownloadSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
