using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatAppMonitor", DoNotGenerateAcw=true)]
	public partial class StatAppMonitor : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/field[@name='FAILURE_RESULT_TYPE']"
		[Register ("FAILURE_RESULT_TYPE")]
		public const int FailureResultType = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/field[@name='LOGIC_FAILURE_RESULT_TYPE']"
		[Register ("LOGIC_FAILURE_RESULT_TYPE")]
		public const int LogicFailureResultType = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/field[@name='SUCCESS_RESULT_TYPE']"
		[Register ("SUCCESS_RESULT_TYPE")]
		public const int SuccessResultType = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatAppMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatAppMonitor); }
		}

		protected StatAppMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/constructor[@name='StatAppMonitor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StatAppMonitor (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (StatAppMonitor)) {
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

		static IntPtr id_ctor_Ljava_lang_String_IIJJJI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/constructor[@name='StatAppMonitor' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;IIJJJI)V", "")]
		public unsafe StatAppMonitor (string p0, int p1, int p2, long p3, long p4, long p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (StatAppMonitor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IIJJJI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;IIJJJI)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IIJJJI == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IIJJJI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IIJJJI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IIJJJI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_IIJJJI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInterfaceName;
#pragma warning disable 0169
		static Delegate GetGetInterfaceNameHandler ()
		{
			if (cb_getInterfaceName == null)
				cb_getInterfaceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceName);
			return cb_getInterfaceName;
		}

		static IntPtr n_GetInterfaceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InterfaceName);
		}
#pragma warning restore 0169

		static Delegate cb_setInterfaceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInterfaceName_Ljava_lang_String_Handler ()
		{
			if (cb_setInterfaceName_Ljava_lang_String_ == null)
				cb_setInterfaceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterfaceName_Ljava_lang_String_);
			return cb_setInterfaceName_Ljava_lang_String_;
		}

		static void n_SetInterfaceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InterfaceName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInterfaceName;
		static IntPtr id_setInterfaceName_Ljava_lang_String_;
		public virtual unsafe string InterfaceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getInterfaceName' and count(parameter)=0]"
			[Register ("getInterfaceName", "()Ljava/lang/String;", "GetGetInterfaceNameHandler")]
			get {
				if (id_getInterfaceName == IntPtr.Zero)
					id_getInterfaceName = JNIEnv.GetMethodID (class_ref, "getInterfaceName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInterfaceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setInterfaceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInterfaceName", "(Ljava/lang/String;)V", "GetSetInterfaceName_Ljava_lang_String_Handler")]
			set {
				if (id_setInterfaceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setInterfaceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInterfaceName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInterfaceName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterfaceName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMillisecondsConsume;
#pragma warning disable 0169
		static Delegate GetGetMillisecondsConsumeHandler ()
		{
			if (cb_getMillisecondsConsume == null)
				cb_getMillisecondsConsume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMillisecondsConsume);
			return cb_getMillisecondsConsume;
		}

		static long n_GetMillisecondsConsume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MillisecondsConsume;
		}
#pragma warning restore 0169

		static Delegate cb_setMillisecondsConsume_J;
#pragma warning disable 0169
		static Delegate GetSetMillisecondsConsume_JHandler ()
		{
			if (cb_setMillisecondsConsume_J == null)
				cb_setMillisecondsConsume_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMillisecondsConsume_J);
			return cb_setMillisecondsConsume_J;
		}

		static void n_SetMillisecondsConsume_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MillisecondsConsume = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMillisecondsConsume;
		static IntPtr id_setMillisecondsConsume_J;
		public virtual unsafe long MillisecondsConsume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getMillisecondsConsume' and count(parameter)=0]"
			[Register ("getMillisecondsConsume", "()J", "GetGetMillisecondsConsumeHandler")]
			get {
				if (id_getMillisecondsConsume == IntPtr.Zero)
					id_getMillisecondsConsume = JNIEnv.GetMethodID (class_ref, "getMillisecondsConsume", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMillisecondsConsume);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMillisecondsConsume", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setMillisecondsConsume' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMillisecondsConsume", "(J)V", "GetSetMillisecondsConsume_JHandler")]
			set {
				if (id_setMillisecondsConsume_J == IntPtr.Zero)
					id_setMillisecondsConsume_J = JNIEnv.GetMethodID (class_ref, "setMillisecondsConsume", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMillisecondsConsume_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMillisecondsConsume", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReqSize;
#pragma warning disable 0169
		static Delegate GetGetReqSizeHandler ()
		{
			if (cb_getReqSize == null)
				cb_getReqSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetReqSize);
			return cb_getReqSize;
		}

		static long n_GetReqSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReqSize;
		}
#pragma warning restore 0169

		static Delegate cb_setReqSize_J;
#pragma warning disable 0169
		static Delegate GetSetReqSize_JHandler ()
		{
			if (cb_setReqSize_J == null)
				cb_setReqSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetReqSize_J);
			return cb_setReqSize_J;
		}

		static void n_SetReqSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReqSize;
		static IntPtr id_setReqSize_J;
		public virtual unsafe long ReqSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getReqSize' and count(parameter)=0]"
			[Register ("getReqSize", "()J", "GetGetReqSizeHandler")]
			get {
				if (id_getReqSize == IntPtr.Zero)
					id_getReqSize = JNIEnv.GetMethodID (class_ref, "getReqSize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getReqSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReqSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setReqSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setReqSize", "(J)V", "GetSetReqSize_JHandler")]
			set {
				if (id_setReqSize_J == IntPtr.Zero)
					id_setReqSize_J = JNIEnv.GetMethodID (class_ref, "setReqSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReqSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReqSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRespSize;
#pragma warning disable 0169
		static Delegate GetGetRespSizeHandler ()
		{
			if (cb_getRespSize == null)
				cb_getRespSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRespSize);
			return cb_getRespSize;
		}

		static long n_GetRespSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RespSize;
		}
#pragma warning restore 0169

		static Delegate cb_setRespSize_J;
#pragma warning disable 0169
		static Delegate GetSetRespSize_JHandler ()
		{
			if (cb_setRespSize_J == null)
				cb_setRespSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRespSize_J);
			return cb_setRespSize_J;
		}

		static void n_SetRespSize_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RespSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRespSize;
		static IntPtr id_setRespSize_J;
		public virtual unsafe long RespSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getRespSize' and count(parameter)=0]"
			[Register ("getRespSize", "()J", "GetGetRespSizeHandler")]
			get {
				if (id_getRespSize == IntPtr.Zero)
					id_getRespSize = JNIEnv.GetMethodID (class_ref, "getRespSize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getRespSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRespSize", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setRespSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRespSize", "(J)V", "GetSetRespSize_JHandler")]
			set {
				if (id_setRespSize_J == IntPtr.Zero)
					id_setRespSize_J = JNIEnv.GetMethodID (class_ref, "setRespSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRespSize_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRespSize", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResultType;
#pragma warning disable 0169
		static Delegate GetGetResultTypeHandler ()
		{
			if (cb_getResultType == null)
				cb_getResultType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResultType);
			return cb_getResultType;
		}

		static int n_GetResultType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultType;
		}
#pragma warning restore 0169

		static Delegate cb_setResultType_I;
#pragma warning disable 0169
		static Delegate GetSetResultType_IHandler ()
		{
			if (cb_setResultType_I == null)
				cb_setResultType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResultType_I);
			return cb_setResultType_I;
		}

		static void n_SetResultType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResultType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultType;
		static IntPtr id_setResultType_I;
		public virtual unsafe int ResultType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getResultType' and count(parameter)=0]"
			[Register ("getResultType", "()I", "GetGetResultTypeHandler")]
			get {
				if (id_getResultType == IntPtr.Zero)
					id_getResultType = JNIEnv.GetMethodID (class_ref, "getResultType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getResultType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setResultType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResultType", "(I)V", "GetSetResultType_IHandler")]
			set {
				if (id_setResultType_I == IntPtr.Zero)
					id_setResultType_I = JNIEnv.GetMethodID (class_ref, "setResultType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setResultType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReturnCode;
#pragma warning disable 0169
		static Delegate GetGetReturnCodeHandler ()
		{
			if (cb_getReturnCode == null)
				cb_getReturnCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReturnCode);
			return cb_getReturnCode;
		}

		static int n_GetReturnCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReturnCode;
		}
#pragma warning restore 0169

		static Delegate cb_setReturnCode_I;
#pragma warning disable 0169
		static Delegate GetSetReturnCode_IHandler ()
		{
			if (cb_setReturnCode_I == null)
				cb_setReturnCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReturnCode_I);
			return cb_setReturnCode_I;
		}

		static void n_SetReturnCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReturnCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReturnCode;
		static IntPtr id_setReturnCode_I;
		public virtual unsafe int ReturnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getReturnCode' and count(parameter)=0]"
			[Register ("getReturnCode", "()I", "GetGetReturnCodeHandler")]
			get {
				if (id_getReturnCode == IntPtr.Zero)
					id_getReturnCode = JNIEnv.GetMethodID (class_ref, "getReturnCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getReturnCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReturnCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setReturnCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReturnCode", "(I)V", "GetSetReturnCode_IHandler")]
			set {
				if (id_setReturnCode_I == IntPtr.Zero)
					id_setReturnCode_I = JNIEnv.GetMethodID (class_ref, "setReturnCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReturnCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReturnCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSampling;
#pragma warning disable 0169
		static Delegate GetGetSamplingHandler ()
		{
			if (cb_getSampling == null)
				cb_getSampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampling);
			return cb_getSampling;
		}

		static int n_GetSampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sampling;
		}
#pragma warning restore 0169

		static Delegate cb_setSampling_I;
#pragma warning disable 0169
		static Delegate GetSetSampling_IHandler ()
		{
			if (cb_setSampling_I == null)
				cb_setSampling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSampling_I);
			return cb_setSampling_I;
		}

		static void n_SetSampling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sampling = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSampling;
		static IntPtr id_setSampling_I;
		public virtual unsafe int Sampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='getSampling' and count(parameter)=0]"
			[Register ("getSampling", "()I", "GetGetSamplingHandler")]
			get {
				if (id_getSampling == IntPtr.Zero)
					id_getSampling = JNIEnv.GetMethodID (class_ref, "getSampling", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSampling);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampling", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='setSampling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampling", "(I)V", "GetSetSampling_IHandler")]
			set {
				if (id_setSampling_I == IntPtr.Zero)
					id_setSampling_I = JNIEnv.GetMethodID (class_ref, "setSampling", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSampling_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSampling", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.StatAppMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatAppMonitor']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/tencent/stat/StatAppMonitor;", "GetCloneHandler")]
		public virtual unsafe global::Com.Tencent.Stat.StatAppMonitor Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/tencent/stat/StatAppMonitor;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatAppMonitor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/tencent/stat/StatAppMonitor;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
