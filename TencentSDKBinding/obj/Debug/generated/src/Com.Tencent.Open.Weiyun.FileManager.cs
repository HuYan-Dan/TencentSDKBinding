using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']"
	[global::Android.Runtime.Register ("com/tencent/open/weiyun/FileManager", DoNotGenerateAcw=true)]
	public partial class FileManager : global::Com.Tencent.Connect.Common.BaseApi {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.DownLoadImp']"
		[global::Android.Runtime.Register ("com/tencent/open/weiyun/FileManager$DownLoadImp", DoNotGenerateAcw=true)]
		public partial class DownLoadImp : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/weiyun/FileManager$DownLoadImp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DownLoadImp); }
			}

			protected DownLoadImp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.DownLoadImp']/constructor[@name='FileManager.DownLoadImp' and count(parameter)=6 and parameter[1][@type='com.tencent.open.weiyun.FileManager'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[4][@type='com.tencent.open.weiyun.WeiyunFile'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.open.weiyun.IDownLoadFileCallBack']]"
			[Register (".ctor", "(Lcom/tencent/open/weiyun/FileManager;Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V", "")]
			public unsafe DownLoadImp (global::Com.Tencent.Open.Weiyun.FileManager __self, global::Android.Content.Context p1, global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p2, global::Com.Tencent.Open.Weiyun.WeiyunFile p3, string p4, global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p4 = JNIEnv.NewString (p4);
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (native_p4);
					__args [5] = new JValue (p5);
					if (GetType () != typeof (DownLoadImp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/open/weiyun/FileManager;Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			static Delegate cb_setThumbSize_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetThumbSize_Ljava_lang_String_Handler ()
			{
				if (cb_setThumbSize_Ljava_lang_String_ == null)
					cb_setThumbSize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetThumbSize_Ljava_lang_String_);
				return cb_setThumbSize_Ljava_lang_String_;
			}

			static void n_SetThumbSize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.Weiyun.FileManager.DownLoadImp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.DownLoadImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetThumbSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setThumbSize_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.DownLoadImp']/method[@name='setThumbSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setThumbSize", "(Ljava/lang/String;)V", "GetSetThumbSize_Ljava_lang_String_Handler")]
			public virtual unsafe void SetThumbSize (string p0)
			{
				if (id_setThumbSize_Ljava_lang_String_ == IntPtr.Zero)
					id_setThumbSize_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setThumbSize", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setThumbSize_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbSize", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_start;
#pragma warning disable 0169
			static Delegate GetStartHandler ()
			{
				if (cb_start == null)
					cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
				return cb_start;
			}

			static void n_Start (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.Weiyun.FileManager.DownLoadImp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.DownLoadImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Start ();
			}
#pragma warning restore 0169

			static IntPtr id_start;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.DownLoadImp']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()V", "GetStartHandler")]
			public virtual unsafe void Start ()
			{
				if (id_start == IntPtr.Zero)
					id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_start);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.GetFileListListener']"
		[global::Android.Runtime.Register ("com/tencent/open/weiyun/FileManager$GetFileListListener", DoNotGenerateAcw=true)]
		public partial class GetFileListListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IUiListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/weiyun/FileManager$GetFileListListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetFileListListener); }
			}

			protected GetFileListListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_open_weiyun_FileManager_Lcom_tencent_open_weiyun_IGetFileListListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.GetFileListListener']/constructor[@name='FileManager.GetFileListListener' and count(parameter)=2 and parameter[1][@type='com.tencent.open.weiyun.FileManager'] and parameter[2][@type='com.tencent.open.weiyun.IGetFileListListener']]"
			[Register (".ctor", "(Lcom/tencent/open/weiyun/FileManager;Lcom/tencent/open/weiyun/IGetFileListListener;)V", "")]
			public unsafe GetFileListListener (global::Com.Tencent.Open.Weiyun.FileManager __self, global::Com.Tencent.Open.Weiyun.IGetFileListListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (GetFileListListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/weiyun/IGetFileListListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/open/weiyun/IGetFileListListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_open_weiyun_FileManager_Lcom_tencent_open_weiyun_IGetFileListListener_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_open_weiyun_FileManager_Lcom_tencent_open_weiyun_IGetFileListListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/open/weiyun/FileManager;Lcom/tencent/open/weiyun/IGetFileListListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Lcom_tencent_open_weiyun_IGetFileListListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Lcom_tencent_open_weiyun_IGetFileListListener_, __args);
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
				global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			static IntPtr id_onCancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.GetFileListListener']/method[@name='onCancel' and count(parameter)=0]"
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
				global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.GetFileListListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
				global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.GetFileListListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tauth.UiError p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.UiError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_tencent_tauth_UiError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.GetFileListListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.tencent.tauth.UiError']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.UploadFileImp']"
		[global::Android.Runtime.Register ("com/tencent/open/weiyun/FileManager$UploadFileImp", DoNotGenerateAcw=true)]
		public partial class UploadFileImp : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/weiyun/FileManager$UploadFileImp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UploadFileImp); }
			}

			protected UploadFileImp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.UploadFileImp']/constructor[@name='FileManager.UploadFileImp' and count(parameter)=5 and parameter[1][@type='com.tencent.open.weiyun.FileManager'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.tencent.open.weiyun.IUploadFileCallBack']]"
			[Register (".ctor", "(Lcom/tencent/open/weiyun/FileManager;Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V", "")]
			public unsafe UploadFileImp (global::Com.Tencent.Open.Weiyun.FileManager __self, global::Android.Content.Context p1, global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p2, string p3, global::Com.Tencent.Open.Weiyun.IUploadFileCallBack p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (UploadFileImp)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/open/weiyun/FileManager;Landroid/content/Context;Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_open_weiyun_FileManager_Landroid_content_Context_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static Delegate cb_start;
#pragma warning disable 0169
			static Delegate GetStartHandler ()
			{
				if (cb_start == null)
					cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
				return cb_start;
			}

			static void n_Start (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.Weiyun.FileManager.UploadFileImp __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.UploadFileImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Start ();
			}
#pragma warning restore 0169

			static IntPtr id_start;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.UploadFileImp']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()V", "GetStartHandler")]
			public virtual unsafe void Start ()
			{
				if (id_start == IntPtr.Zero)
					id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_start);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']"
		[global::Android.Runtime.Register ("com/tencent/open/weiyun/FileManager$WeiyunFileType", DoNotGenerateAcw=true)]
		public sealed partial class WeiyunFileType : global::Java.Lang.Enum {


			static IntPtr ImageFile_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/field[@name='ImageFile']"
			[Register ("ImageFile")]
			public static global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType ImageFile {
				get {
					if (ImageFile_jfieldId == IntPtr.Zero)
						ImageFile_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ImageFile", "Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ImageFile_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MusicFile_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/field[@name='MusicFile']"
			[Register ("MusicFile")]
			public static global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType MusicFile {
				get {
					if (MusicFile_jfieldId == IntPtr.Zero)
						MusicFile_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MusicFile", "Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MusicFile_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VideoFile_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/field[@name='VideoFile']"
			[Register ("VideoFile")]
			public static global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType VideoFile {
				get {
					if (VideoFile_jfieldId == IntPtr.Zero)
						VideoFile_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VideoFile", "Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VideoFile_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/weiyun/FileManager$WeiyunFileType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WeiyunFileType); }
			}

			internal WeiyunFileType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_value;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/method[@name='value' and count(parameter)=0]"
			[Register ("value", "()I", "")]
			public unsafe int Value ()
			{
				if (id_value == IntPtr.Zero)
					id_value = JNIEnv.GetMethodID (class_ref, "value", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_value);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;", "")]
			public static unsafe global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager.WeiyunFileType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;", "")]
			public static unsafe global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;");
				try {
					return (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/weiyun/FileManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileManager); }
		}

		protected FileManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/constructor[@name='FileManager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQAuth'] and parameter[3][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe FileManager (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQAuth p1, global::Com.Tencent.Connect.Auth.QQToken p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (FileManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/constructor[@name='FileManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe FileManager (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FileManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_DeleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.Weiyun.FileManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/method[@name='deleteFile' and count(parameter)=3 and parameter[1][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("deleteFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetDeleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void DeleteFile (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "deleteFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
#pragma warning disable 0169
		static Delegate GetDownLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_Handler ()
		{
			if (cb_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ == null)
				cb_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_);
			return cb_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
		}

		static void n_DownLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Weiyun.FileManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.WeiyunFile p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack p3 = (global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DownLoadFile (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/method[@name='downLoadFile' and count(parameter)=4 and parameter[1][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[2][@type='com.tencent.open.weiyun.WeiyunFile'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.open.weiyun.IDownLoadFileCallBack']]"
		[Register ("downLoadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V", "GetDownLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_Handler")]
		public virtual unsafe void DownLoadFile (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0, global::Com.Tencent.Open.Weiyun.WeiyunFile p1, string p2, global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack p3)
		{
			if (id_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ == IntPtr.Zero)
				id_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ = JNIEnv.GetMethodID (class_ref, "downLoadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_downLoadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downLoadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
#pragma warning disable 0169
		static Delegate GetDownLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_Handler ()
		{
			if (cb_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ == null)
				cb_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_);
			return cb_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
		}

		static void n_DownLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.Weiyun.FileManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.WeiyunFile p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack p3 = (global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DownLoadThumb (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/method[@name='downLoadThumb' and count(parameter)=4 and parameter[1][@type='com.tencent.open.weiyun.WeiyunFile'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.tencent.open.weiyun.IDownLoadFileCallBack']]"
		[Register ("downLoadThumb", "(Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V", "GetDownLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_Handler")]
		public virtual unsafe void DownLoadThumb (global::Com.Tencent.Open.Weiyun.WeiyunFile p0, string p1, string p2, global::Com.Tencent.Open.Weiyun.IDownLoadFileCallBack p3)
		{
			if (id_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ == IntPtr.Zero)
				id_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_ = JNIEnv.GetMethodID (class_ref, "downLoadThumb", "(Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_downLoadThumb_Lcom_tencent_open_weiyun_WeiyunFile_Ljava_lang_String_Ljava_lang_String_Lcom_tencent_open_weiyun_IDownLoadFileCallBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downLoadThumb", "(Lcom/tencent/open/weiyun/WeiyunFile;Ljava/lang/String;Ljava/lang/String;Lcom/tencent/open/weiyun/IDownLoadFileCallBack;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_;
#pragma warning disable 0169
		static Delegate GetGetFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_Handler ()
		{
			if (cb_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_ == null)
				cb_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_);
			return cb_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_;
		}

		static void n_GetFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Weiyun.FileManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.IGetFileListListener p1 = (global::Com.Tencent.Open.Weiyun.IGetFileListListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IGetFileListListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetFileList (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/method[@name='getFileList' and count(parameter)=2 and parameter[1][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[2][@type='com.tencent.open.weiyun.IGetFileListListener']]"
		[Register ("getFileList", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/IGetFileListListener;)V", "GetGetFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_Handler")]
		public virtual unsafe void GetFileList (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0, global::Com.Tencent.Open.Weiyun.IGetFileListListener p1)
		{
			if (id_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_ == IntPtr.Zero)
				id_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_ = JNIEnv.GetMethodID (class_ref, "getFileList", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/IGetFileListListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getFileList_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Lcom_tencent_open_weiyun_IGetFileListListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileList", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Lcom/tencent/open/weiyun/IGetFileListListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_;
#pragma warning disable 0169
		static Delegate GetUploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_Handler ()
		{
			if (cb_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ == null)
				cb_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_);
			return cb_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_;
		}

		static void n_UploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.Weiyun.FileManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Weiyun.IUploadFileCallBack p2 = (global::Com.Tencent.Open.Weiyun.IUploadFileCallBack)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.IUploadFileCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UploadFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='FileManager']/method[@name='uploadFile' and count(parameter)=3 and parameter[1][@type='com.tencent.open.weiyun.FileManager.WeiyunFileType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.open.weiyun.IUploadFileCallBack']]"
		[Register ("uploadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V", "GetUploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_Handler")]
		public virtual unsafe void UploadFile (global::Com.Tencent.Open.Weiyun.FileManager.WeiyunFileType p0, string p1, global::Com.Tencent.Open.Weiyun.IUploadFileCallBack p2)
		{
			if (id_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ == IntPtr.Zero)
				id_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_ = JNIEnv.GetMethodID (class_ref, "uploadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_uploadFile_Lcom_tencent_open_weiyun_FileManager_WeiyunFileType_Ljava_lang_String_Lcom_tencent_open_weiyun_IUploadFileCallBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadFile", "(Lcom/tencent/open/weiyun/FileManager$WeiyunFileType;Ljava/lang/String;Lcom/tencent/open/weiyun/IUploadFileCallBack;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
