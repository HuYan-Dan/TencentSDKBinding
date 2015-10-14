using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']"
	[global::Android.Runtime.Register ("com/tencent/stat/common/StatLogger", DoNotGenerateAcw=true)]
	public sealed partial class StatLogger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/common/StatLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatLogger); }
		}

		internal StatLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/constructor[@name='StatLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StatLogger (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (StatLogger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/constructor[@name='StatLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatLogger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isDebugEnable;
		static IntPtr id_setDebugEnable_Z;
		public unsafe bool DebugEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='isDebugEnable' and count(parameter)=0]"
			[Register ("isDebugEnable", "()Z", "GetIsDebugEnableHandler")]
			get {
				if (id_isDebugEnable == IntPtr.Zero)
					id_isDebugEnable = JNIEnv.GetMethodID (class_ref, "isDebugEnable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isDebugEnable);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='setDebugEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugEnable", "(Z)V", "GetSetDebugEnable_ZHandler")]
			set {
				if (id_setDebugEnable_Z == IntPtr.Zero)
					id_setDebugEnable_Z = JNIEnv.GetMethodID (class_ref, "setDebugEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setDebugEnable_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLogLevel;
		static IntPtr id_setLogLevel_I;
		public unsafe int LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()I", "GetGetLogLevelHandler")]
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetMethodID (class_ref, "getLogLevel", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getLogLevel);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogLevel", "(I)V", "GetSetLogLevel_IHandler")]
			set {
				if (id_setLogLevel_I == IntPtr.Zero)
					id_setLogLevel_I = JNIEnv.GetMethodID (class_ref, "setLogLevel", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLogLevel_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_d_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("d", "(Ljava/lang/Object;)V", "")]
		public unsafe void D (global::Java.Lang.Object p0)
		{
			if (id_d_Ljava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_debug_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/Object;)V", "")]
		public unsafe void Debug (global::Java.Lang.Object p0)
		{
			if (id_debug_Ljava_lang_Object_ == IntPtr.Zero)
				id_debug_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_debug_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/Exception;)V", "")]
		public unsafe void E (global::Java.Lang.Exception p0)
		{
			if (id_e_Ljava_lang_Exception_ == IntPtr.Zero)
				id_e_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("e", "(Ljava/lang/Object;)V", "")]
		public unsafe void E (global::Java.Lang.Object p0)
		{
			if (id_e_Ljava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("error", "(Ljava/lang/Exception;)V", "")]
		public unsafe void Error (global::Java.Lang.Exception p0)
		{
			if (id_error_Ljava_lang_Exception_ == IntPtr.Zero)
				id_error_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_error_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/Object;)V", "")]
		public unsafe void Error (global::Java.Lang.Object p0)
		{
			if (id_error_Ljava_lang_Object_ == IntPtr.Zero)
				id_error_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_error_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("i", "(Ljava/lang/Object;)V", "")]
		public unsafe void I (global::Java.Lang.Object p0)
		{
			if (id_i_Ljava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_info_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/Object;)V", "")]
		public unsafe void Info (global::Java.Lang.Object p0)
		{
			if (id_info_Ljava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_info_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_setTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTag", "(Ljava/lang/String;)V", "")]
		public unsafe void SetTag (string p0)
		{
			if (id_setTag_Ljava_lang_String_ == IntPtr.Zero)
				id_setTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setTag_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_v_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("v", "(Ljava/lang/Object;)V", "")]
		public unsafe void V (global::Java.Lang.Object p0)
		{
			if (id_v_Ljava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_v_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_verbose_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='verbose' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("verbose", "(Ljava/lang/Object;)V", "")]
		public unsafe void Verbose (global::Java.Lang.Object p0)
		{
			if (id_verbose_Ljava_lang_Object_ == IntPtr.Zero)
				id_verbose_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "verbose", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_verbose_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_w_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("w", "(Ljava/lang/Object;)V", "")]
		public unsafe void W (global::Java.Lang.Object p0)
		{
			if (id_w_Ljava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_warn_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat.common']/class[@name='StatLogger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/Object;)V", "")]
		public unsafe void Warn (global::Java.Lang.Object p0)
		{
			if (id_warn_Ljava_lang_Object_ == IntPtr.Zero)
				id_warn_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_warn_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
