using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IGetFileListListener']"
	[Register ("com/tencent/open/weiyun/IGetFileListListener", "", "Com.Tencent.Open.Weiyun.IGetFileListListenerInvoker")]
	public partial interface IGetFileListListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IGetFileListListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.tencent.open.weiyun.WeiyunFile&gt;']]"
		[Register ("onComplete", "(Ljava/util/List;)V", "GetOnComplete_Ljava_util_List_Handler:Com.Tencent.Open.Weiyun.IGetFileListListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnComplete (global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/interface[@name='IGetFileListListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
		[Register ("onError", "(Lcom/tencent/tauth/UiError;)V", "GetOnError_Lcom_tencent_tauth_UiError_Handler:Com.Tencent.Open.Weiyun.IGetFileListListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnError (global::Com.Tencent.Tauth.UiError p0);

	}

	[global::Android.Runtime.Register ("com/tencent/open/weiyun/IGetFileListListener", DoNotGenerateAcw=true)]
	internal class IGetFileListListenerInvoker : global::Java.Lang.Object, IGetFileListListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/open/weiyun/IGetFileListListener");
		IntPtr class_ref;

		public static IGetFileListListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetFileListListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.open.weiyun.IGetFileListListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetFileListListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGetFileListListenerInvoker); }
		}

		static Delegate cb_onComplete_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Ljava_util_List_Handler ()
		{
			if (cb_onComplete_Ljava_util_List_ == null)
				cb_onComplete_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_util_List_);
			return cb_onComplete_Ljava_util_List_;
		}

		static void n_OnComplete_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.IGetFileListListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IGetFileListListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Tencent.Open.Weiyun.WeiyunFile>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Ljava_util_List_;
		public unsafe void OnComplete (global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> p0)
		{
			if (id_onComplete_Ljava_util_List_ == IntPtr.Zero)
				id_onComplete_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Tencent.Open.Weiyun.WeiyunFile>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_util_List_, __args);
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
			global::Com.Tencent.Open.Weiyun.IGetFileListListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IGetFileListListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> p0;
		public global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> P0 {
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

	[global::Android.Runtime.Register ("mono/com/tencent/open/weiyun/IGetFileListListenerImplementor")]
	internal sealed partial class IGetFileListListenerImplementor : global::Java.Lang.Object, IGetFileListListener {

		object sender;

		public IGetFileListListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/open/weiyun/IGetFileListListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::System.Collections.Generic.IList<global::Com.Tencent.Open.Weiyun.WeiyunFile> p0)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0));
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

		internal static bool __IsEmpty (IGetFileListListenerImplementor value)
		{
			return value.OnCompleteHandler == null && value.OnErrorHandler == null;
		}
	}

}
