using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Weiyun {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']"
	[global::Android.Runtime.Register ("com/tencent/open/weiyun/WeiyunFile", DoNotGenerateAcw=true)]
	public partial class WeiyunFile : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/weiyun/WeiyunFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeiyunFile); }
		}

		protected WeiyunFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/constructor[@name='WeiyunFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe WeiyunFile (string p0, string p1, string p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (WeiyunFile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCreateTime;
#pragma warning disable 0169
		static Delegate GetGetCreateTimeHandler ()
		{
			if (cb_getCreateTime == null)
				cb_getCreateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateTime);
			return cb_getCreateTime;
		}

		static IntPtr n_GetCreateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreateTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreateTime_Ljava_lang_String_Handler ()
		{
			if (cb_setCreateTime_Ljava_lang_String_ == null)
				cb_setCreateTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreateTime_Ljava_lang_String_);
			return cb_setCreateTime_Ljava_lang_String_;
		}

		static void n_SetCreateTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreateTime;
		static IntPtr id_setCreateTime_Ljava_lang_String_;
		public virtual unsafe string CreateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='getCreateTime' and count(parameter)=0]"
			[Register ("getCreateTime", "()Ljava/lang/String;", "GetGetCreateTimeHandler")]
			get {
				if (id_getCreateTime == IntPtr.Zero)
					id_getCreateTime = JNIEnv.GetMethodID (class_ref, "getCreateTime", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCreateTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='setCreateTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreateTime", "(Ljava/lang/String;)V", "GetSetCreateTime_Ljava_lang_String_Handler")]
			set {
				if (id_setCreateTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreateTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreateTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCreateTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreateTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileId;
#pragma warning disable 0169
		static Delegate GetGetFileIdHandler ()
		{
			if (cb_getFileId == null)
				cb_getFileId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileId);
			return cb_getFileId;
		}

		static IntPtr n_GetFileId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileId);
		}
#pragma warning restore 0169

		static Delegate cb_setFileId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileId_Ljava_lang_String_Handler ()
		{
			if (cb_setFileId_Ljava_lang_String_ == null)
				cb_setFileId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileId_Ljava_lang_String_);
			return cb_setFileId_Ljava_lang_String_;
		}

		static void n_SetFileId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FileId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileId;
		static IntPtr id_setFileId_Ljava_lang_String_;
		public virtual unsafe string FileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='getFileId' and count(parameter)=0]"
			[Register ("getFileId", "()Ljava/lang/String;", "GetGetFileIdHandler")]
			get {
				if (id_getFileId == IntPtr.Zero)
					id_getFileId = JNIEnv.GetMethodID (class_ref, "getFileId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFileId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='setFileId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileId", "(Ljava/lang/String;)V", "GetSetFileId_Ljava_lang_String_Handler")]
			set {
				if (id_setFileId_Ljava_lang_String_ == IntPtr.Zero)
					id_setFileId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFileId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileName;
#pragma warning disable 0169
		static Delegate GetGetFileNameHandler ()
		{
			if (cb_getFileName == null)
				cb_getFileName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileName);
			return cb_getFileName;
		}

		static IntPtr n_GetFileName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileName);
		}
#pragma warning restore 0169

		static Delegate cb_setFileName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileName_Ljava_lang_String_Handler ()
		{
			if (cb_setFileName_Ljava_lang_String_ == null)
				cb_setFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileName_Ljava_lang_String_);
			return cb_setFileName_Ljava_lang_String_;
		}

		static void n_SetFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FileName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileName;
		static IntPtr id_setFileName_Ljava_lang_String_;
		public virtual unsafe string FileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='getFileName' and count(parameter)=0]"
			[Register ("getFileName", "()Ljava/lang/String;", "GetGetFileNameHandler")]
			get {
				if (id_getFileName == IntPtr.Zero)
					id_getFileName = JNIEnv.GetMethodID (class_ref, "getFileName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFileName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='setFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileName", "(Ljava/lang/String;)V", "GetSetFileName_Ljava_lang_String_Handler")]
			set {
				if (id_setFileName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFileName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFileName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileSize;
#pragma warning disable 0169
		static Delegate GetGetFileSizeHandler ()
		{
			if (cb_getFileSize == null)
				cb_getFileSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileSize);
			return cb_getFileSize;
		}

		static long n_GetFileSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFileSize_J;
#pragma warning disable 0169
		static Delegate GetSetFileSize_JHandler ()
		{
			if (cb_setFileSize_J == null)
				cb_setFileSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetFileSize_J);
			return cb_setFileSize_J;
		}

		static void n_SetFileSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Open.Weiyun.WeiyunFile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Weiyun.WeiyunFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FileSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileSize;
		static IntPtr id_setFileSize_J;
		public virtual unsafe long FileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='getFileSize' and count(parameter)=0]"
			[Register ("getFileSize", "()J", "GetGetFileSizeHandler")]
			get {
				if (id_getFileSize == IntPtr.Zero)
					id_getFileSize = JNIEnv.GetMethodID (class_ref, "getFileSize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getFileSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.weiyun']/class[@name='WeiyunFile']/method[@name='setFileSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setFileSize", "(J)V", "GetSetFileSize_JHandler")]
			set {
				if (id_setFileSize_J == IntPtr.Zero)
					id_setFileSize_J = JNIEnv.GetMethodID (class_ref, "setFileSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFileSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileSize", "(J)V"), __args);
				} finally {
				}
			}
		}

	}
}
