using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']"
	[global::Android.Runtime.Register ("com/tencent/stat/StatConfig", DoNotGenerateAcw=true)]
	public partial class StatConfig : global::Java.Lang.Object {


		static IntPtr isAutoExceptionCaught_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/field[@name='isAutoExceptionCaught']"
		[Register ("isAutoExceptionCaught")]
		public static bool IsAutoExceptionCaught {
			get {
				if (isAutoExceptionCaught_jfieldId == IntPtr.Zero)
					isAutoExceptionCaught_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isAutoExceptionCaught", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isAutoExceptionCaught_jfieldId);
			}
			set {
				if (isAutoExceptionCaught_jfieldId == IntPtr.Zero)
					isAutoExceptionCaught_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isAutoExceptionCaught", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isAutoExceptionCaught_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/StatConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatConfig); }
		}

		protected StatConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/constructor[@name='StatConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatConfig)) {
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

		static IntPtr id_isAutoExceptionCaught;
		static IntPtr id_setAutoExceptionCaught_Z;
		public static unsafe bool AutoExceptionCaught {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='isAutoExceptionCaught' and count(parameter)=0]"
			[Register ("isAutoExceptionCaught", "()Z", "GetIsAutoExceptionCaughtHandler")]
			get {
				if (id_isAutoExceptionCaught == IntPtr.Zero)
					id_isAutoExceptionCaught = JNIEnv.GetStaticMethodID (class_ref, "isAutoExceptionCaught", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAutoExceptionCaught);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setAutoExceptionCaught' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoExceptionCaught", "(Z)V", "GetSetAutoExceptionCaught_ZHandler")]
			set {
				if (id_setAutoExceptionCaught_Z == IntPtr.Zero)
					id_setAutoExceptionCaught_Z = JNIEnv.GetStaticMethodID (class_ref, "setAutoExceptionCaught", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoExceptionCaught_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCurSessionStatReportCount;
		public static unsafe int CurSessionStatReportCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getCurSessionStatReportCount' and count(parameter)=0]"
			[Register ("getCurSessionStatReportCount", "()I", "GetGetCurSessionStatReportCountHandler")]
			get {
				if (id_getCurSessionStatReportCount == IntPtr.Zero)
					id_getCurSessionStatReportCount = JNIEnv.GetStaticMethodID (class_ref, "getCurSessionStatReportCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurSessionStatReportCount);
				} finally {
				}
			}
		}

		static IntPtr id_isDebugEnable;
		static IntPtr id_setDebugEnable_Z;
		public static unsafe bool DebugEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='isDebugEnable' and count(parameter)=0]"
			[Register ("isDebugEnable", "()Z", "GetIsDebugEnableHandler")]
			get {
				if (id_isDebugEnable == IntPtr.Zero)
					id_isDebugEnable = JNIEnv.GetStaticMethodID (class_ref, "isDebugEnable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebugEnable);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setDebugEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugEnable", "(Z)V", "GetSetDebugEnable_ZHandler")]
			set {
				if (id_setDebugEnable_Z == IntPtr.Zero)
					id_setDebugEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugEnable_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isEnableConcurrentProcess;
		static IntPtr id_setEnableConcurrentProcess_Z;
		public static unsafe bool EnableConcurrentProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='isEnableConcurrentProcess' and count(parameter)=0]"
			[Register ("isEnableConcurrentProcess", "()Z", "GetIsEnableConcurrentProcessHandler")]
			get {
				if (id_isEnableConcurrentProcess == IntPtr.Zero)
					id_isEnableConcurrentProcess = JNIEnv.GetStaticMethodID (class_ref, "isEnableConcurrentProcess", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEnableConcurrentProcess);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setEnableConcurrentProcess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableConcurrentProcess", "(Z)V", "GetSetEnableConcurrentProcess_ZHandler")]
			set {
				if (id_setEnableConcurrentProcess_Z == IntPtr.Zero)
					id_setEnableConcurrentProcess_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableConcurrentProcess", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableConcurrentProcess_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isEnableSmartReporting;
		static IntPtr id_setEnableSmartReporting_Z;
		public static unsafe bool EnableSmartReporting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='isEnableSmartReporting' and count(parameter)=0]"
			[Register ("isEnableSmartReporting", "()Z", "GetIsEnableSmartReportingHandler")]
			get {
				if (id_isEnableSmartReporting == IntPtr.Zero)
					id_isEnableSmartReporting = JNIEnv.GetStaticMethodID (class_ref, "isEnableSmartReporting", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEnableSmartReporting);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setEnableSmartReporting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableSmartReporting", "(Z)V", "GetSetEnableSmartReporting_ZHandler")]
			set {
				if (id_setEnableSmartReporting_Z == IntPtr.Zero)
					id_setEnableSmartReporting_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableSmartReporting", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableSmartReporting_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isEnableStatService;
		static IntPtr id_setEnableStatService_Z;
		public static unsafe bool EnableStatService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='isEnableStatService' and count(parameter)=0]"
			[Register ("isEnableStatService", "()Z", "GetIsEnableStatServiceHandler")]
			get {
				if (id_isEnableStatService == IntPtr.Zero)
					id_isEnableStatService = JNIEnv.GetStaticMethodID (class_ref, "isEnableStatService", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEnableStatService);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setEnableStatService' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableStatService", "(Z)V", "GetSetEnableStatService_ZHandler")]
			set {
				if (id_setEnableStatService_Z == IntPtr.Zero)
					id_setEnableStatService_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableStatService", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableStatService_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxBatchReportCount;
		static IntPtr id_setMaxBatchReportCount_I;
		public static unsafe int MaxBatchReportCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxBatchReportCount' and count(parameter)=0]"
			[Register ("getMaxBatchReportCount", "()I", "GetGetMaxBatchReportCountHandler")]
			get {
				if (id_getMaxBatchReportCount == IntPtr.Zero)
					id_getMaxBatchReportCount = JNIEnv.GetStaticMethodID (class_ref, "getMaxBatchReportCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxBatchReportCount);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxBatchReportCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxBatchReportCount", "(I)V", "GetSetMaxBatchReportCount_IHandler")]
			set {
				if (id_setMaxBatchReportCount_I == IntPtr.Zero)
					id_setMaxBatchReportCount_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxBatchReportCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxBatchReportCount_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxDaySessionNumbers;
		static IntPtr id_setMaxDaySessionNumbers_I;
		public static unsafe int MaxDaySessionNumbers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxDaySessionNumbers' and count(parameter)=0]"
			[Register ("getMaxDaySessionNumbers", "()I", "GetGetMaxDaySessionNumbersHandler")]
			get {
				if (id_getMaxDaySessionNumbers == IntPtr.Zero)
					id_getMaxDaySessionNumbers = JNIEnv.GetStaticMethodID (class_ref, "getMaxDaySessionNumbers", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxDaySessionNumbers);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxDaySessionNumbers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxDaySessionNumbers", "(I)V", "GetSetMaxDaySessionNumbers_IHandler")]
			set {
				if (id_setMaxDaySessionNumbers_I == IntPtr.Zero)
					id_setMaxDaySessionNumbers_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxDaySessionNumbers", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxDaySessionNumbers_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxParallelTimmingEvents;
		static IntPtr id_setMaxParallelTimmingEvents_I;
		public static unsafe int MaxParallelTimmingEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxParallelTimmingEvents' and count(parameter)=0]"
			[Register ("getMaxParallelTimmingEvents", "()I", "GetGetMaxParallelTimmingEventsHandler")]
			get {
				if (id_getMaxParallelTimmingEvents == IntPtr.Zero)
					id_getMaxParallelTimmingEvents = JNIEnv.GetStaticMethodID (class_ref, "getMaxParallelTimmingEvents", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxParallelTimmingEvents);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxParallelTimmingEvents' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxParallelTimmingEvents", "(I)V", "GetSetMaxParallelTimmingEvents_IHandler")]
			set {
				if (id_setMaxParallelTimmingEvents_I == IntPtr.Zero)
					id_setMaxParallelTimmingEvents_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxParallelTimmingEvents", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxParallelTimmingEvents_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxReportEventLength;
		static IntPtr id_setMaxReportEventLength_I;
		public static unsafe int MaxReportEventLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxReportEventLength' and count(parameter)=0]"
			[Register ("getMaxReportEventLength", "()I", "GetGetMaxReportEventLengthHandler")]
			get {
				if (id_getMaxReportEventLength == IntPtr.Zero)
					id_getMaxReportEventLength = JNIEnv.GetStaticMethodID (class_ref, "getMaxReportEventLength", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxReportEventLength);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxReportEventLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxReportEventLength", "(I)V", "GetSetMaxReportEventLength_IHandler")]
			set {
				if (id_setMaxReportEventLength_I == IntPtr.Zero)
					id_setMaxReportEventLength_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxReportEventLength", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxReportEventLength_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxSendRetryCount;
		static IntPtr id_setMaxSendRetryCount_I;
		public static unsafe int MaxSendRetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxSendRetryCount' and count(parameter)=0]"
			[Register ("getMaxSendRetryCount", "()I", "GetGetMaxSendRetryCountHandler")]
			get {
				if (id_getMaxSendRetryCount == IntPtr.Zero)
					id_getMaxSendRetryCount = JNIEnv.GetStaticMethodID (class_ref, "getMaxSendRetryCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxSendRetryCount);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxSendRetryCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSendRetryCount", "(I)V", "GetSetMaxSendRetryCount_IHandler")]
			set {
				if (id_setMaxSendRetryCount_I == IntPtr.Zero)
					id_setMaxSendRetryCount_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxSendRetryCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxSendRetryCount_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxSessionStatReportCount;
		static IntPtr id_setMaxSessionStatReportCount_I;
		public static unsafe int MaxSessionStatReportCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxSessionStatReportCount' and count(parameter)=0]"
			[Register ("getMaxSessionStatReportCount", "()I", "GetGetMaxSessionStatReportCountHandler")]
			get {
				if (id_getMaxSessionStatReportCount == IntPtr.Zero)
					id_getMaxSessionStatReportCount = JNIEnv.GetStaticMethodID (class_ref, "getMaxSessionStatReportCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxSessionStatReportCount);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxSessionStatReportCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSessionStatReportCount", "(I)V", "GetSetMaxSessionStatReportCount_IHandler")]
			set {
				if (id_setMaxSessionStatReportCount_I == IntPtr.Zero)
					id_setMaxSessionStatReportCount_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxSessionStatReportCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxSessionStatReportCount_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxStoreEventCount;
		static IntPtr id_setMaxStoreEventCount_I;
		public static unsafe int MaxStoreEventCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMaxStoreEventCount' and count(parameter)=0]"
			[Register ("getMaxStoreEventCount", "()I", "GetGetMaxStoreEventCountHandler")]
			get {
				if (id_getMaxStoreEventCount == IntPtr.Zero)
					id_getMaxStoreEventCount = JNIEnv.GetStaticMethodID (class_ref, "getMaxStoreEventCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getMaxStoreEventCount);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setMaxStoreEventCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxStoreEventCount", "(I)V", "GetSetMaxStoreEventCount_IHandler")]
			set {
				if (id_setMaxStoreEventCount_I == IntPtr.Zero)
					id_setMaxStoreEventCount_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxStoreEventCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxStoreEventCount_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getQQ;
		public static unsafe string QQ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getQQ' and count(parameter)=0]"
			[Register ("getQQ", "()Ljava/lang/String;", "GetGetQQHandler")]
			get {
				if (id_getQQ == IntPtr.Zero)
					id_getQQ = JNIEnv.GetStaticMethodID (class_ref, "getQQ", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQQ), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSendPeriodMinutes;
		static IntPtr id_setSendPeriodMinutes_I;
		public static unsafe int SendPeriodMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getSendPeriodMinutes' and count(parameter)=0]"
			[Register ("getSendPeriodMinutes", "()I", "GetGetSendPeriodMinutesHandler")]
			get {
				if (id_getSendPeriodMinutes == IntPtr.Zero)
					id_getSendPeriodMinutes = JNIEnv.GetStaticMethodID (class_ref, "getSendPeriodMinutes", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getSendPeriodMinutes);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setSendPeriodMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSendPeriodMinutes", "(I)V", "GetSetSendPeriodMinutes_IHandler")]
			set {
				if (id_setSendPeriodMinutes_I == IntPtr.Zero)
					id_setSendPeriodMinutes_I = JNIEnv.GetStaticMethodID (class_ref, "setSendPeriodMinutes", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSendPeriodMinutes_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSessionTimoutMillis;
		static IntPtr id_setSessionTimoutMillis_I;
		public static unsafe int SessionTimoutMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getSessionTimoutMillis' and count(parameter)=0]"
			[Register ("getSessionTimoutMillis", "()I", "GetGetSessionTimoutMillisHandler")]
			get {
				if (id_getSessionTimoutMillis == IntPtr.Zero)
					id_getSessionTimoutMillis = JNIEnv.GetStaticMethodID (class_ref, "getSessionTimoutMillis", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getSessionTimoutMillis);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setSessionTimoutMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSessionTimoutMillis", "(I)V", "GetSetSessionTimoutMillis_IHandler")]
			set {
				if (id_setSessionTimoutMillis_I == IntPtr.Zero)
					id_setSessionTimoutMillis_I = JNIEnv.GetStaticMethodID (class_ref, "setSessionTimoutMillis", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSessionTimoutMillis_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getStatReportUrl;
		static IntPtr id_setStatReportUrl_Ljava_lang_String_;
		public static unsafe string StatReportUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getStatReportUrl' and count(parameter)=0]"
			[Register ("getStatReportUrl", "()Ljava/lang/String;", "GetGetStatReportUrlHandler")]
			get {
				if (id_getStatReportUrl == IntPtr.Zero)
					id_getStatReportUrl = JNIEnv.GetStaticMethodID (class_ref, "getStatReportUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatReportUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setStatReportUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatReportUrl", "(Ljava/lang/String;)V", "GetSetStatReportUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setStatReportUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatReportUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setStatReportUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatReportUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getStatSendStrategy;
		static IntPtr id_setStatSendStrategy_Lcom_tencent_stat_StatReportStrategy_;
		public static unsafe global::Com.Tencent.Stat.StatReportStrategy StatSendStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getStatSendStrategy' and count(parameter)=0]"
			[Register ("getStatSendStrategy", "()Lcom/tencent/stat/StatReportStrategy;", "GetGetStatSendStrategyHandler")]
			get {
				if (id_getStatSendStrategy == IntPtr.Zero)
					id_getStatSendStrategy = JNIEnv.GetStaticMethodID (class_ref, "getStatSendStrategy", "()Lcom/tencent/stat/StatReportStrategy;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.StatReportStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatSendStrategy), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setStatSendStrategy' and count(parameter)=1 and parameter[1][@type='com.tencent.stat.StatReportStrategy']]"
			[Register ("setStatSendStrategy", "(Lcom/tencent/stat/StatReportStrategy;)V", "GetSetStatSendStrategy_Lcom_tencent_stat_StatReportStrategy_Handler")]
			set {
				if (id_setStatSendStrategy_Lcom_tencent_stat_StatReportStrategy_ == IntPtr.Zero)
					id_setStatSendStrategy_Lcom_tencent_stat_StatReportStrategy_ = JNIEnv.GetStaticMethodID (class_ref, "setStatSendStrategy", "(Lcom/tencent/stat/StatReportStrategy;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatSendStrategy_Lcom_tencent_stat_StatReportStrategy_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getAppKey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getAppKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppKey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppKey (global::Android.Content.Context p0)
		{
			if (id_getAppKey_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppKey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppKey", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppKey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCustomProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getCustomProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCustomProperty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCustomProperty (string p0)
		{
			if (id_getCustomProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getCustomProperty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCustomProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCustomProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCustomProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getCustomProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getCustomProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCustomProperty (string p0, string p1)
		{
			if (id_getCustomProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCustomProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCustomProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCustomProperty_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getCustomUserId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getCustomUserId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCustomUserId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCustomUserId (global::Android.Content.Context p0)
		{
			if (id_getCustomUserId_Landroid_content_Context_ == IntPtr.Zero)
				id_getCustomUserId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCustomUserId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCustomUserId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeviceInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getDeviceInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceInfo", "(Landroid/content/Context;)Lcom/tencent/stat/DeviceInfo;", "")]
		public static unsafe global::Com.Tencent.Stat.DeviceInfo GetDeviceInfo (global::Android.Content.Context p0)
		{
			if (id_getDeviceInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceInfo", "(Landroid/content/Context;)Lcom/tencent/stat/DeviceInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Tencent.Stat.DeviceInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.DeviceInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstallChannel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getInstallChannel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstallChannel", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetInstallChannel (global::Android.Content.Context p0)
		{
			if (id_getInstallChannel_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstallChannel_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstallChannel", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstallChannel_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='getMid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMid (global::Android.Content.Context p0)
		{
			if (id_getMid_Landroid_content_Context_ == IntPtr.Zero)
				id_getMid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initNativeCrashReport_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='initNativeCrashReport' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("initNativeCrashReport", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void InitNativeCrashReport (global::Android.Content.Context p0, string p1)
		{
			if (id_initNativeCrashReport_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_initNativeCrashReport_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initNativeCrashReport", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initNativeCrashReport_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setAppKey_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setAppKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAppKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetAppKey (global::Android.Content.Context p0, string p1)
		{
			if (id_setAppKey_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppKey_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppKey", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppKey_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setAppKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAppKey (string p0)
		{
			if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCustomUserId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setCustomUserId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCustomUserId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetCustomUserId (global::Android.Content.Context p0, string p1)
		{
			if (id_setCustomUserId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomUserId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomUserId", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomUserId_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setInstallChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setInstallChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInstallChannel", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetInstallChannel (string p0)
		{
			if (id_setInstallChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setInstallChannel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setInstallChannel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstallChannel_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setQQ_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='StatConfig']/method[@name='setQQ' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setQQ", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetQQ (global::Android.Content.Context p0, string p1)
		{
			if (id_setQQ_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setQQ_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setQQ", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setQQ_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
